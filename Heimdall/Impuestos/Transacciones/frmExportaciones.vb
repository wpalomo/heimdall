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
        TabControl1.SelectTab(0)
        txtRegistro.Text = InputBox("Ingrese el # de Registro a consultar")

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

            End If
            TabControl1.SelectTab(0)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=guardar_exportacion()", vbCritical)
        End Try
    End Sub

End Class