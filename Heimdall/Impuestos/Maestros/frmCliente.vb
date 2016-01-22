Imports MySql.Data.MySqlClient

Public Class frmCliente
    Private modo As Integer = 0 '0=>Nuevo, 1=>Edicion

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim f As New frmBuscarCliente
        f.ShowDialog()
        Dim registro As String = gloSelectedClientID
        If Not IsNumeric(registro) Then
            Exit Sub
        End If
        Dim cmd As New MySqlCommand("SELECT * FROM clientes where identificacion='" + registro + "';", gloConexion)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        If dt.Rows.Count > 0 Then
            txtNombre.Text = dt.Rows(0)("nombres").ToString
            txtIdentificacion.Text = dt.Rows(0)("identificacion").ToString
            cboTipoIdentificacion.Text = dt.Rows(0)("tipo_identificacion").ToString
            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            txtTelefono.Text = dt.Rows(0)("telefono").ToString
            txtRegistro.Text = dt.Rows(0)("id").ToString
            lblUsuario.Text = "Creado por: " + dt.Rows(0)("creado_por").ToString.ToUpper + " el " + dt.Rows(0)("creado_el").ToString
            modo = 1
        Else
            MsgBox("No se encontró el Registro # " + registro, vbExclamation)
            cmdNuevo_Click(sender, e)
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If txtNombre.Text = "" Then
            MsgBox("El nombre es obligatorio", vbExclamation)
            Exit Sub
        End If
        If cboTipoIdentificacion.Text = "" Then
            MsgBox("El tipo de identificación es obligatorio", vbExclamation)
            Exit Sub
        End If
        If txtIdentificacion.Text = "" Then
            MsgBox("La identificación es obligatorio", vbExclamation)
            Exit Sub
        End If

        Try
            If modo = 0 Then
                Dim cmd As New MySqlCommand("INSERT INTO clientes(nombres,tipo_identificacion,identificacion,direccion,telefono,creado_por,creado_el) VALUES(@nombres,@tipo_identificacion,@identificacion,@direccion,@telefono,@creado_por,@creado_el);", gloConexion)
                cmd.Parameters.Add("@nombres", MySqlDbType.VarChar).Value = txtNombre.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = cboTipoIdentificacion.Text
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = txtDireccion.Text
                cmd.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = txtTelefono.Text
                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now
                cmd.ExecuteNonQuery()

                'Recuperamos el ID del Cliente
                Dim clienteId As Integer = 0
                Dim cmx As New MySqlCommand("SELECT LAST_INSERT_ID() as t;", gloConexion)
                Dim dt As New DataTable
                dt.Load(cmx.ExecuteReader)
                If dt.Rows.Count > 0 Then
                    clienteId = CInt(dt.Rows(0)("t").ToString)
                End If
                txtRegistro.Text = clienteId.ToString

                MsgBox("Cliente Creado!", vbInformation)
            Else
                Dim cmd As New MySqlCommand("UPDATE clientes SET nombres=@nombres, tipo_identificacion=@tipo_identificacion, identificacion=@identificacion, direccion=@direccion, telefono=@telefono, creado_por=@creado_por, creado_el=@creado_el WHERE id=@id;", gloConexion)
                cmd.Parameters.Add("@nombres", MySqlDbType.VarChar).Value = txtNombre.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = cboTipoIdentificacion.Text
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = txtDireccion.Text
                cmd.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = txtTelefono.Text
                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = CInt(txtRegistro.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Cliente Actualizado!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=guardar_cliente()", vbCritical)
        End Try
    End Sub

    Private Sub cmdMostrar_Click(sender As Object, e As EventArgs) Handles cmdMostrar.Click
        Dim registro As String = InputBox("Ingrese el número de registro")
        If Not IsNumeric(registro) Then
            Exit Sub
        End If
        Dim cmd As New MySqlCommand("SELECT * FROM clientes where id=" + registro, gloConexion)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        If dt.Rows.Count > 0 Then
            txtNombre.Text = dt.Rows(0)("nombres").ToString
            txtIdentificacion.Text = dt.Rows(0)("identificacion").ToString
            cboTipoIdentificacion.Text = dt.Rows(0)("tipo_identificacion").ToString
            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            txtTelefono.Text = dt.Rows(0)("telefono").ToString

            lblUsuario.Text = "Creado por: " + dt.Rows(0)("creado_por").ToString.ToUpper + " el " + dt.Rows(0)("creado_el").ToString
            txtRegistro.Text = registro
            modo = 1
        Else
            MsgBox("No se encontró el Registro # " + registro, vbExclamation)
            cmdNuevo_Click(sender, e)
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtRegistro.Text = ""
        txtNombre.Text = ""
        cboTipoIdentificacion.SelectedIndex = -1
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        modo = 0
        lblUsuario.Text = ""
    End Sub
End Class