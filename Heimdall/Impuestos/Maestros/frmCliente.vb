Imports MySql.Data.MySqlClient

Public Class frmCliente
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim f As New frmBuscarCliente
        f.ShowDialog()

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            Dim cmd As New MySqlCommand("INSERT INTO clientes(nombres,tipo_identificacion,identificacion,direccion,telefono,creado_por,creado_el) VALUES(@nombres,@tipo_identificacion,@identificacion,@direccion,@telefono,@creado_por,@creado_el);", gloConexion)
            cmd.Parameters.Add("@nombres", MySqlDbType.VarChar).Value = txtNombre.Text
            cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = cboTipoIdentificacion.Text
            cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
            cmd.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = txtDireccion.Text
            cmd.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = txtTelefono.Text

            cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
            cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now

            cmd.ExecuteNonQuery()
            MsgBox("Cliente Creado!", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=guardar_cliente()", vbCritical)
        End Try
    End Sub
End Class