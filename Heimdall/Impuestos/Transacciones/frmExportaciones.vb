Imports MySql.Data.MySqlClient

Public Class frmExportaciones
    Private modo As Integer = 0 '0=>Nuevo, 1=>Edicion

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        modo = 0
        txtRegistro.Text = ""
        txtIdentificacion.Text = ""
        txtCliente.Text = ""
        txtTipoIdentificacion.Text = ""
        cboParteRelacionada.SelectedIndex = 1
        cboPais.SelectedIndex = -1

        cboTipoExportacion.SelectedIndex = 0
        txtValorFOB.Text = ""
        txtFecha.Value = Now
        txtDocTpte.Text = ""
        cboDistrito.SelectedIndex = 5
        txtAño.Text = "2016"
        cboRegimen.SelectedIndex = 0
        txtCorrelativo.Text = ""

        cboTipoComprobante.SelectedIndex = 0
        txtValorFOBComprobante.Text = ""
        txtEstablecimiento.Text = ""
        txtPuntoEmision.Text = ""
        txtSecuencial.Text = ""
        txtNumeroAutorizacion.Text = ""
        txtFechaComprobante.Value = Now

        lblUsuario.Text = ""

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        gloSelectedClientID = ""
        gloSelectedClientName = ""
        gloSelectedClientType = ""
        Dim f As New frmBuscarCliente
        f.ShowDialog()
        txtIdentificacion.Text = gloSelectedClientID
        txtCliente.Text = gloSelectedClientName
        txtTipoIdentificacion.Text = gloSelectedClientType

    End Sub

    Private Sub frmExportaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)

    End Sub

    Private Sub cboTipoExportacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoExportacion.SelectedIndexChanged
        If cboTipoExportacion.Text = "02-Sin Refrendo" Then
            groRefrendo.Visible = False
        Else
            groRefrendo.Visible = True
        End If
    End Sub

    Private Sub cmdMostrar_Click(sender As Object, e As EventArgs) Handles cmdMostrar.Click
        Dim registro As String = InputBox("Ingrese el número de registro")
        If Not IsNumeric(registro) Then
            Exit Sub
        End If
        Dim cmd As New MySqlCommand("SELECT * FROM exportaciones where id=" + registro, gloConexion)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        If dt.Rows.Count > 0 Then
            txtIdentificacion.Text = dt.Rows(0)("identificacion").ToString
            txtCliente.Text = dt.Rows(0)("cliente").ToString
            txtTipoIdentificacion.Text = dt.Rows(0)("tipo_identificacion").ToString
            cboParteRelacionada.Text = dt.Rows(0)("parte_relacionada").ToString
            cboPais.Text = dt.Rows(0)("pais_exporta").ToString

            cboTipoExportacion.Text = dt.Rows(0)("tipo_exportacion").ToString
            txtValorFOB.Text = dt.Rows(0)("valor_fob").ToString
            txtFecha.Text = dt.Rows(0)("fecha_transaccion").ToString
            txtDocTpte.Text = dt.Rows(0)("doc_transporte").ToString
            cboDistrito.Text = dt.Rows(0)("distrito").ToString
            txtAño.Text = dt.Rows(0)("año").ToString
            cboRegimen.Text = dt.Rows(0)("regimen").ToString
            txtCorrelativo.Text = dt.Rows(0)("correlativo").ToString

            cboTipoComprobante.Text = dt.Rows(0)("tipo_comprobante").ToString
            txtValorFOBComprobante.Text = dt.Rows(0)("valor_fob_comprobante").ToString
            txtEstablecimiento.Text = dt.Rows(0)("establecimiento").ToString
            txtPuntoEmision.Text = dt.Rows(0)("punto_emision").ToString
            txtSecuencial.Text = dt.Rows(0)("secuencial").ToString
            txtNumeroAutorizacion.Text = dt.Rows(0)("numero_autorizacion").ToString
            txtFechaComprobante.Text = dt.Rows(0)("fecha_comprobante").ToString

            lblUsuario.Text = "Creado por: " + dt.Rows(0)("creado_por").ToString.ToUpper + " el " + dt.Rows(0)("creado_el").ToString
            txtRegistro.Text = registro
            modo = 1
        Else
            MsgBox("No se encontró el Registro # " + registro, vbExclamation)
            cmdNuevo_Click(sender, e)
        End If
        TabControl1.SelectTab(0)

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        '----------------------------------------------------------------------------------
        '   Validaciones
        '----------------------------------------------------------------------------------
        If txtIdentificacion.Text = "" Then
            MsgBox("Debe elegir un cliente", vbExclamation)
            Exit Sub
        End If

        If cboPais.Text = "" Then
            MsgBox("Debe elegir un pais", vbExclamation)
            Exit Sub
        End If

        If cboTipoExportacion.Text = "" Then
            MsgBox("Debe elegir un pais", vbExclamation)
            Exit Sub
        ElseIf cboTipoExportacion.Text = "01-Con Refrendo" Then
            If txtDocTpte.Text = "" Then
                MsgBox("El Documento de Transporte es obligatorio", vbExclamation)
                Exit Sub
            End If
            If txtDocTpte.Text.Length < 3 Then
                MsgBox("El Documento de Transporte debe tener al menos 3 caracteres", vbExclamation)
                Exit Sub
            End If
            If cboDistrito.Text = "" Then
                MsgBox("Debe elegir un Distrito", vbExclamation)
                Exit Sub
            End If
            If txtAño.Text = "" Then
                MsgBox("El año es obligatorio", vbExclamation)
                Exit Sub
            End If
            If cboRegimen.Text = "" Then
                MsgBox("Debe elegir un Régimen", vbExclamation)
                Exit Sub
            End If
            If txtCorrelativo.Text = "" Or txtCorrelativo.Text.Length <> 8 Then
                MsgBox("El Correlativo es obligatorio y debetener 8 digitos", vbExclamation)
                Exit Sub
            End If
        End If

        If txtFecha.Value.Month <> gloMesActual Then
            MsgBox("La fecha de la transacción debe pertenecer a " + gloMesActualNombre, vbExclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtValorFOB.Text) Then
            MsgBox("El campo Valor FOB debe ser un número", vbExclamation)
            Exit Sub
        Else
            If CDec(txtValorFOB.Text) <= 0 Then
                MsgBox("El campo Valor FOB debe ser mayor que cero", vbExclamation)
                Exit Sub
            End If
        End If

        If cboTipoComprobante.Text = "" Then
            MsgBox("Debe elegir un Tipo de Comprobante", vbExclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtValorFOBComprobante.Text) Then
            MsgBox("El campo Valor FOB del Comprobante debe ser un número", vbExclamation)
            Exit Sub
        Else
            If CDec(txtValorFOBComprobante.Text) <= 0 Then
                MsgBox("El campo Valor FOB del Comprobante debe ser mayor que cero", vbExclamation)
                Exit Sub
            End If
        End If

        If txtEstablecimiento.Text = "" Or txtEstablecimiento.Text.Length < 3 Or IsNumeric(txtEstablecimiento.Text) = False Then
            MsgBox("El campo Establecimiento es obligatorio y debe tener 3 digitos", vbExclamation)
            Exit Sub
        End If
        If txtPuntoEmision.Text = "" Or txtPuntoEmision.Text.Length < 3 Or IsNumeric(txtPuntoEmision.Text) = False Then
            MsgBox("El campo Punto de Emision es obligatorio y debe tener 3 digitos", vbExclamation)
            Exit Sub
        End If
        If txtSecuencial.Text = "" Or txtSecuencial.Text.Length < 1 Or IsNumeric(txtSecuencial.Text) = False Then
            MsgBox("El campo Secuencial es obligatorio y debe tener al menos 1 digitos", vbExclamation)
            Exit Sub
        End If
        If txtNumeroAutorizacion.Text = "" Or txtNumeroAutorizacion.Text.Length < 3 Or IsNumeric(txtNumeroAutorizacion.Text) = False Then
            MsgBox("El campo Número de Autorización es obligatorio y debe tener al menos 3 digitos", vbExclamation)
            Exit Sub
        End If
        If txtFechaComprobante.Value.Month <> gloMesActual Then
            MsgBox("La fecha del Comprobante debe pertenecer a " + gloMesActualNombre, vbExclamation)
            Exit Sub
        End If
        '----------------------------------------------------------------------------------
        '   Guardar
        '----------------------------------------------------------------------------------
        Try
            If modo = 0 Then 'NUEVO 
                Dim cmd As New MySqlCommand("INSERT INTO exportaciones(identificacion,cliente,tipo_identificacion,parte_relacionada,pais_exporta,tipo_exportacion,valor_fob,fecha_transaccion,doc_transporte,distrito,año,regimen,correlativo,tipo_comprobante,valor_fob_comprobante,establecimiento,punto_emision,secuencial,numero_autorizacion,fecha_comprobante,creado_por,creado_el) VALUES(@identificacion,@cliente,@tipo_identificacion,@parte_relacionada,@pais_exporta,@tipo_exportacion,@valor_fob,@fecha_transaccion,@doc_transporte,@distrito,@año,@regimen,@correlativo,@tipo_comprobante,@valor_fob_comprobante,@establecimiento,@punto_emision,@secuencial,@numero_autorizacion,@fecha_comprobante,@creado_por,@creado_el);", gloConexion)
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = txtCliente.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = txtTipoIdentificacion.Text
                cmd.Parameters.Add("@parte_relacionada", MySqlDbType.VarChar).Value = cboParteRelacionada.Text
                cmd.Parameters.Add("@pais_exporta", MySqlDbType.VarChar).Value = cboPais.Text

                cmd.Parameters.Add("@tipo_exportacion", MySqlDbType.VarChar).Value = cboTipoExportacion.Text
                cmd.Parameters.Add("@valor_fob", MySqlDbType.Decimal).Value = CDec(txtValorFOB.Text)
                cmd.Parameters.Add("@fecha_transaccion", MySqlDbType.Date).Value = txtFecha.Value
                cmd.Parameters.Add("@doc_transporte", MySqlDbType.VarChar).Value = txtDocTpte.Text
                cmd.Parameters.Add("@distrito", MySqlDbType.VarChar).Value = cboDistrito.Text
                cmd.Parameters.Add("@año", MySqlDbType.VarChar).Value = txtAño.Text
                cmd.Parameters.Add("@regimen", MySqlDbType.VarChar).Value = cboRegimen.Text
                cmd.Parameters.Add("@correlativo", MySqlDbType.VarChar).Value = txtCorrelativo.Text

                cmd.Parameters.Add("@tipo_comprobante", MySqlDbType.VarChar).Value = cboTipoComprobante.Text
                cmd.Parameters.Add("@valor_fob_comprobante", MySqlDbType.Decimal).Value = CDec(txtValorFOBComprobante.Text)
                cmd.Parameters.Add("@establecimiento", MySqlDbType.VarChar).Value = txtEstablecimiento.Text
                cmd.Parameters.Add("@punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmision.Text
                cmd.Parameters.Add("@secuencial", MySqlDbType.VarChar).Value = txtSecuencial.Text
                cmd.Parameters.Add("@numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacion.Text
                cmd.Parameters.Add("@fecha_comprobante", MySqlDbType.Date).Value = txtFechaComprobante.Value

                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now

                cmd.ExecuteNonQuery()
                MsgBox("Exportación Creada!", vbInformation)

            ElseIf modo = 1 Then 'ACTUALIZA
                Dim cmd As New MySqlCommand("UPDATE exportaciones SET identificacion=@identificacion, cliente=@cliente, tipo_identificacion=@tipo_identificacion, parte_relacionada=@parte_relacionada, pais_exporta=@pais_exporta, tipo_exportacion=@tipo_exportacion, valor_fob=@valor_fob, fecha_transaccion=@fecha_transaccion,doc_transporte = @doc_transporte,  distrito = @distrito,año = @año,regimen = @regimen,correlativo = @correlativo,tipo_comprobante = @tipo_comprobante,valor_fob_comprobante = @valor_fob_comprobante,  establecimiento = @establecimiento,punto_emision = @punto_emision,secuencial = @secuencial,numero_autorizacion = @numero_autorizacion,  fecha_comprobante=@fecha_comprobante,  creado_por=@creado_por, creado_el=@creado_el WHERE id=@id;", gloConexion)
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = txtCliente.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = txtTipoIdentificacion.Text
                cmd.Parameters.Add("@parte_relacionada", MySqlDbType.VarChar).Value = cboParteRelacionada.Text
                cmd.Parameters.Add("@pais_exporta", MySqlDbType.VarChar).Value = cboPais.Text

                cmd.Parameters.Add("@tipo_exportacion", MySqlDbType.VarChar).Value = cboTipoExportacion.Text
                cmd.Parameters.Add("@valor_fob", MySqlDbType.Decimal).Value = CDec(txtValorFOB.Text)
                cmd.Parameters.Add("@fecha_transaccion", MySqlDbType.Date).Value = txtFecha.Value
                cmd.Parameters.Add("@doc_transporte", MySqlDbType.VarChar).Value = txtDocTpte.Text
                cmd.Parameters.Add("@distrito", MySqlDbType.VarChar).Value = cboDistrito.Text
                cmd.Parameters.Add("@año", MySqlDbType.VarChar).Value = txtAño.Text
                cmd.Parameters.Add("@regimen", MySqlDbType.VarChar).Value = cboRegimen.Text
                cmd.Parameters.Add("@correlativo", MySqlDbType.VarChar).Value = txtCorrelativo.Text

                cmd.Parameters.Add("@tipo_comprobante", MySqlDbType.VarChar).Value = cboTipoComprobante.Text
                cmd.Parameters.Add("@valor_fob_comprobante", MySqlDbType.Decimal).Value = CDec(txtValorFOBComprobante.Text)
                cmd.Parameters.Add("@establecimiento", MySqlDbType.VarChar).Value = txtEstablecimiento.Text
                cmd.Parameters.Add("@punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmision.Text
                cmd.Parameters.Add("@secuencial", MySqlDbType.VarChar).Value = txtSecuencial.Text
                cmd.Parameters.Add("@numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacion.Text
                cmd.Parameters.Add("@fecha_comprobante", MySqlDbType.Date).Value = txtFechaComprobante.Value

                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = CInt(txtRegistro.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Exportación Actualizada!", vbInformation)
            End If
            TabControl1.SelectTab(0)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=guardar_exportacion()", vbCritical)
        End Try
    End Sub

End Class