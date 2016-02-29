Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class frmCompras
    Private modo As Integer = 0 '0=>Nuevo, 1=>Edicion

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub LimpiarSpr()
        While Spr.Rows.Count <> 0
            Spr.Rows.RemoveAt(0)
        End While
    End Sub

    Private Sub chkSiTieneCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkSiTieneRet.CheckedChanged
        If chkSiTieneRet.Checked = True Then
            cmdAñadirRetencion.Enabled = True
            cmdQuitarRetencion.Enabled = True
            txtEstablecimientoRet.Enabled = True
            txtPuntoEmisionRet.Enabled = True
            txtSecuencialRet.Enabled = True
            txtNumeroAutorizacionRet.Enabled = True
            txtFechaEmisionRet.Enabled = True
            cmdImportarRetencion.Enabled = True
            Spr.Enabled = True
        Else
            cmdAñadirRetencion.Enabled = False
            cmdQuitarRetencion.Enabled = False
            txtEstablecimientoRet.Enabled = False
            txtPuntoEmisionRet.Enabled = False
            txtSecuencialRet.Enabled = False
            txtNumeroAutorizacionRet.Enabled = False
            txtFechaEmisionRet.Enabled = False
            cmdImportarRetencion.Enabled = False
            Spr.Enabled = False
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        gloSelectedSupplierID = ""
        gloSelectedSupplierName = ""
        gloSelectedSupplierType = ""
        Dim f As New frmBuscarProveedor
        f.ShowDialog()
        txtIdentificacion.Text = gloSelectedSupplierID
        txtProveedor.Text = gloSelectedSupplierName
        txtTipoIdentificacion.Text = gloSelectedSupplierType
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        TabControl1.SelectTab(0)
        txtIdentificacion.Text = ""
        txtProveedor.Text = ""
        txtTipoIdentificacion.Text = ""
        cboParteRelacionada.SelectedIndex = 1

        cboSustentoTributario.SelectedIndex = -1
        cboTipoComprobante.SelectedIndex = -1
        txtFechaEmision.ResetText()
        txtEstablecimiento.Text = ""
        txtPuntoEmision.Text = ""
        txtSecuencial.Text = ""
        txtNumeroAutorizacion.Text = ""
        cboDocModificado.SelectedIndex = -1
        txtEstablecimientoModificado.Text = ""
        txtPuntoEmisionModificado.Text = ""
        txtSecuencialModificado.Text = ""
        txtNumeroAutorizacionModificado.Text = ""

        txtBase0.Text = ""
        txtBaseDiferente0.Text = ""
        txtBaseNoObjeto.Text = ""
        txtBaseExenta.Text = ""
        txtMontoIVA.Text = ""
        txtMontoICE.Text = ""
        txtRetIVA10.Text = ""
        txtRetIVA20.Text = ""
        txtRetIVA30.Text = ""
        txtRetIVA70.Text = ""
        txtRetIVA100.Text = ""

        cboPagoResidente.SelectedIndex = 0
        cboPaisPago.SelectedIndex = -1
        cboPagoRegimenMenor.SelectedIndex = -1
        cboConvenioDobleTributacion.SelectedIndex = -1
        cboRetencionNormaLegal.SelectedIndex = -1

        chkSiTieneRet.Checked = False
        txtEstablecimientoRet.Text = ""
        txtPuntoEmisionRet.Text = ""
        txtSecuencialRet.Text = ""
        txtNumeroAutorizacionRet.Text = ""
        txtFechaEmisionRet.ResetText()
        lblUsuario.Text = ""
        txtRegistro.Text = ""
        LimpiarSpr()
        modo = 0

    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)

    End Sub

    Private Sub cboPagoResidente_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboPagoResidente.Text = "01-PAGO A RESIDENTE" Then
            cboPaisPago.SelectedIndex = -1
            cboPagoRegimenMenor.SelectedIndex = -1
            cboConvenioDobleTributacion.SelectedIndex = -1
            cboRetencionNormaLegal.SelectedIndex = -1
            cboPaisPago.Enabled = False
            cboPagoRegimenMenor.Enabled = False
            cboConvenioDobleTributacion.Enabled = False
            cboRetencionNormaLegal.Enabled = False
        Else
            cboPaisPago.Enabled = True
            cboPagoRegimenMenor.Enabled = True
            cboConvenioDobleTributacion.Enabled = True
            cboRetencionNormaLegal.Enabled = True
        End If
    End Sub

    Private Sub cboTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoComprobante.SelectedIndexChanged
        If cboTipoComprobante.Text = "04-Nota de crédito" Or cboTipoComprobante.Text = "05-Nota de débito" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub cmdImportarRetencion_Click(sender As Object, e As EventArgs) Handles cmdImportarRetencion.Click
        Dim ca As String = InputBox("Ingrese la Clave de Acceso")
        If ca <> "" Then
            Dim ws As New facturaE.eFactura.WebService
            Dim archivo = Path.GetTempPath + "\temporal.xml"
            If ws.SendClaveAcceso(ca, archivo) = facturaE.RespuestaSRYType.AUTORIZADO Then
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText(archivo).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
                My.Computer.FileSystem.WriteAllText(archivo, fileReader, False)
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(archivo)
                Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/autorizacion/comprobante/comprobanteRetencion/impuestos/impuesto")
                Dim retencion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/estab").FirstChild.Value.ToString + xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/ptoEmi").FirstChild.Value.ToString + xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/secuencial").FirstChild.Value.ToString
                Dim autorizacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/numeroAutorizacion").FirstChild.Value.ToString
                Dim identificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoCompRetencion/identificacionSujetoRetenido").FirstChild.Value.ToString
                Dim tipoIdenticacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoCompRetencion/tipoIdentificacionSujetoRetenido").FirstChild.Value.ToString
                Dim proveedor As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoCompRetencion/razonSocialSujetoRetenido").FirstChild.Value.ToString
                Dim fechaEmision As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoCompRetencion/fechaEmision").FirstChild.Value.ToString
                txtIdentificacion.Text = identificacion
                txtTipoIdentificacion.Text = tipoIdenticacion
                txtProveedor.Text = proveedor

                txtEstablecimientoRet.Text = Strings.Left(retencion, 3)
                txtPuntoEmisionRet.Text = Strings.Right(Strings.Left(retencion, 6), 3)
                txtSecuencialRet.Text = Strings.Right(retencion, 9)
                txtNumeroAutorizacionRet.Text = autorizacion
                txtFechaEmisionRet.Value = CDate(fechaEmision)

                Dim codigoImpuesto As String = ""
                Dim codigoRetencion As String = ""
                Dim base As String = ""
                Dim porcentaje As String = ""
                Dim valor As String = ""
                Dim numDoc As String = ""
                Dim fechaDoc As String = ""
                For Each node As XmlNode In nodes
                    codigoImpuesto = node.SelectSingleNode("codigo").InnerText
                    codigoRetencion = node.SelectSingleNode("codigoRetencion").InnerText
                    base = node.SelectSingleNode("baseImponible").InnerText
                    porcentaje = node.SelectSingleNode("porcentajeRetener").InnerText
                    valor = node.SelectSingleNode("valorRetenido").InnerText
                    numDoc = node.SelectSingleNode("numDocSustento").InnerText
                    fechaDoc = node.SelectSingleNode("fechaEmisionDocSustento").InnerText

                    If codigoImpuesto = "1" Then
                        Spr.Rows.Add(codigoRetencion, "", base, porcentaje, valor)
                    End If

                    txtFechaEmision.Value = CDate(fechaDoc)
                    txtEstablecimiento.Text = Strings.Left(numDoc, 3)
                    txtPuntoEmision.Text = Strings.Right(Strings.Left(numDoc, 6), 3)
                    txtSecuencial.Text = Strings.Right(numDoc, 9)

                Next
            End If
        End If


    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        '----------------------------------------------------------------------------------
        '   Guardar
        '----------------------------------------------------------------------------------
        Try
            If modo = 0 Then 'NUEVO 

                ' ---. VALIDACIONES .----

                If txtEstablecimiento.Text.Length < 3 Then
                    MsgBox("El número del ESTABLECIMIENTO debe ser igual a 3", vbExclamation)
                    Exit Sub
                End If

                If txtPuntoEmision.Text.Length < 3 Then
                    MsgBox("El número del PUNTO DE EMISIÓN debe ser igual a 3", vbExclamation)
                    Exit Sub
                End If

                If txtSecuencial.Text.Length < 9 Then
                    MsgBox("El número del SECUENCIAL debe ser igual a 9", vbExclamation)
                    Exit Sub
                End If

                If txtBase0.Text = "" Then
                    txtBase0.Text = "0.00"
                End If
                If txtBaseDiferente0.Text = "" Then
                    txtBaseDiferente0.Text = "0.00"
                End If
                If txtBaseNoObjeto.Text = "" Then
                    txtBaseNoObjeto.Text = "0.00"
                End If
                If txtBaseExenta.Text = "" Then
                    txtBaseExenta.Text = "0.00"
                End If
                If txtMontoIVA.Text = "" Then
                    txtMontoIVA.Text = "0.00"
                End If
                If txtMontoICE.Text = "" Then
                    txtMontoICE.Text = "0.00"
                End If
                If txtRetIVA10.Text = "" Then
                    txtRetIVA10.Text = "0.00"
                End If
                If txtRetIVA20.Text = "" Then
                    txtRetIVA20.Text = "0.00"
                End If
                If txtRetIVA30.Text = "" Then
                    txtRetIVA30.Text = "0.00"
                End If
                If txtRetIVA70.Text = "" Then
                    txtRetIVA70.Text = "0.00"
                End If
                If txtRetIVA100.Text = "" Then
                    txtRetIVA100.Text = "0.00"
                End If

                '   ***  COMPRA  ***
                Dim cmd As New MySqlCommand("INSERT INTO compras(identificacion,proveedor,tipo_identificacion,parte_relacionada,sustento_tributario,tipo_comprobante,fecha_emision,fecha_comprobante,establecimiento,punto_emision,secuencial,numero_autorizacion,documento_modificado,doc_establecimiento,doc_punto_emision,doc_secuencial,doc_numero_autorizacion,base_0,base_diferente_0,base_no_objeto,base_exenta,monto_iva,monto_ice,retencion_iva_10,retencion_iva_20,retencion_iva_30,retencion_iva_70,retencion_iva_100,pago_a_residente,pais_pago,regimen_fiscal_menor,convenio_doble_tributacion,retencion_norma_legal,tiene_retencion,ret_establecimiento,ret_punto_emision,ret_secuencial,ret_numero_autorizacion,ret_fecha_emision,creado_por,creado_el) VALUES(@identificacion,@proveedor,@tipo_identificacion,@parte_relacionada,@sustento_tributario,@tipo_comprobante,@fecha_emision,@fecha_comprobante,@establecimiento,@punto_emision,@secuencial,@numero_autorizacion,@documento_modificado,@doc_establecimiento,@doc_punto_emision,@doc_secuencial,@doc_numero_autorizacion,@base_0,@base_diferente_0,@base_no_objeto,@base_exenta,@monto_iva,@monto_ice,@retencion_iva_10,@retencion_iva_20,@retencion_iva_30,@retencion_iva_70,@retencion_iva_100,@pago_a_residente,@pais_pago,@regimen_fiscal_menor,@convenio_doble_tributacion,@retencion_norma_legal,@tiene_retencion,@ret_establecimiento,@ret_punto_emision,@ret_secuencial,@ret_numero_autorizacion,@ret_fecha_emision,@creado_por,@creado_el);", gloConexion)
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = txtProveedor.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = txtTipoIdentificacion.Text
                cmd.Parameters.Add("@parte_relacionada", MySqlDbType.VarChar).Value = cboParteRelacionada.Text


                cmd.Parameters.Add("@sustento_tributario", MySqlDbType.VarChar).Value = cboSustentoTributario.Text
                cmd.Parameters.Add("@tipo_comprobante", MySqlDbType.VarChar).Value = cboTipoComprobante.Text
                cmd.Parameters.Add("@fecha_emision", MySqlDbType.Date).Value = txtFechaEmision.Value
                cmd.Parameters.Add("@fecha_comprobante", MySqlDbType.Date).Value = txtFechaEmision.Value
                cmd.Parameters.Add("@establecimiento", MySqlDbType.VarChar).Value = txtEstablecimiento.Text
                cmd.Parameters.Add("@punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmision.Text
                cmd.Parameters.Add("@secuencial", MySqlDbType.VarChar).Value = txtSecuencial.Text
                cmd.Parameters.Add("@numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacion.Text
                cmd.Parameters.Add("@documento_modificado", MySqlDbType.VarChar).Value = cboDocModificado.Text
                cmd.Parameters.Add("@doc_establecimiento", MySqlDbType.VarChar).Value = txtEstablecimientoModificado.Text
                cmd.Parameters.Add("@doc_punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmisionModificado.Text
                cmd.Parameters.Add("@doc_secuencial", MySqlDbType.VarChar).Value = txtSecuencialModificado.Text
                cmd.Parameters.Add("@doc_numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacionModificado.Text

                cmd.Parameters.Add("@base_0", MySqlDbType.Decimal).Value = CDec(txtBase0.Text)
                cmd.Parameters.Add("@base_diferente_0", MySqlDbType.Decimal).Value = CDec(txtBaseDiferente0.Text)
                cmd.Parameters.Add("@base_no_objeto", MySqlDbType.Decimal).Value = CDec(txtBaseNoObjeto.Text)
                cmd.Parameters.Add("@base_exenta", MySqlDbType.Decimal).Value = CDec(txtBaseExenta.Text)
                cmd.Parameters.Add("@monto_iva", MySqlDbType.Decimal).Value = CDec(txtMontoIVA.Text)
                cmd.Parameters.Add("@monto_ice", MySqlDbType.Decimal).Value = CDec(txtMontoICE.Text)
                cmd.Parameters.Add("@retencion_iva_10", MySqlDbType.Decimal).Value = CDec(txtRetIVA10.Text)
                cmd.Parameters.Add("@retencion_iva_20", MySqlDbType.Decimal).Value = CDec(txtRetIVA20.Text)
                cmd.Parameters.Add("@retencion_iva_30", MySqlDbType.Decimal).Value = CDec(txtRetIVA30.Text)
                cmd.Parameters.Add("@retencion_iva_70", MySqlDbType.Decimal).Value = CDec(txtRetIVA70.Text)
                cmd.Parameters.Add("@retencion_iva_100", MySqlDbType.Decimal).Value = CDec(txtRetIVA100.Text)

                cmd.Parameters.Add("@pago_a_residente", MySqlDbType.VarChar).Value = cboPagoResidente.Text
                cmd.Parameters.Add("@pais_pago", MySqlDbType.VarChar).Value = cboPaisPago.Text
                cmd.Parameters.Add("@regimen_fiscal_menor", MySqlDbType.VarChar).Value = cboPagoRegimenMenor.Text
                cmd.Parameters.Add("@convenio_doble_tributacion", MySqlDbType.VarChar).Value = cboConvenioDobleTributacion.Text
                cmd.Parameters.Add("@retencion_norma_legal", MySqlDbType.VarChar).Value = cboRetencionNormaLegal.Text

                cmd.Parameters.Add("@tiene_retencion", MySqlDbType.Int16).Value = CInt(chkSiTieneRet.Checked)
                cmd.Parameters.Add("@ret_establecimiento", MySqlDbType.VarChar).Value = txtEstablecimientoRet.Text
                cmd.Parameters.Add("@ret_punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmisionRet.Text
                cmd.Parameters.Add("@ret_secuencial", MySqlDbType.VarChar).Value = txtSecuencialRet.Text
                cmd.Parameters.Add("@ret_numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacionRet.Text
                cmd.Parameters.Add("@ret_fecha_emision", MySqlDbType.Date).Value = txtFechaEmisionRet.Value

                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now

                cmd.ExecuteNonQuery()

                'Recuperamos el ID de la Compra
                Dim compraId As Integer = 0
                Dim cmx As New MySqlCommand("Select LAST_INSERT_ID() As t;", gloConexion)
                Dim dt As New DataTable
                dt.Load(cmx.ExecuteReader)
                If dt.Rows.Count > 0 Then
                    compraId = CInt(dt.Rows(0)("t").ToString)
                End If
                txtRegistro.Text = compraId.ToString

                '   ***  RETENCIONES DE COMPRA  ***
                If chkSiTieneRet.Checked = True Then
                    For i = 0 To Spr.Rows.Count - 1
                        InsertarRetenciones(compraId, Spr(0, i).Value.ToString(), Spr(1, i).Value.ToString(), Spr(2, i).Value, Spr(3, i).Value, Spr(4, i).Value)
                    Next
                End If
                MsgBox("Compra Creada!", vbInformation)
                modo = 1
            ElseIf modo = 1 Then 'ACTUALIZA

                'actualizar compras
                Dim cmd As New MySqlCommand("UPDATE compras SET identificacion=@identificacion, proveedor=@proveedor, tipo_identificacion=@tipo_identificacion, parte_relacionada=@parte_relacionada, sustento_tributario=@sustento_tributario, tipo_comprobante=@tipo_comprobante, fecha_emision=@fecha_emision, fecha_comprobante=@fecha_comprobante, establecimiento=@establecimiento, punto_emision=@punto_emision, secuencial=@secuencial, numero_autorizacion=@numero_autorizacion, documento_modificado=@documento_modificado, doc_establecimiento=@doc_establecimiento, doc_punto_emision=@doc_punto_emision, doc_secuencial=@doc_secuencial, doc_numero_autorizacion=@doc_numero_autorizacion, base_0=@base_0, base_diferente_0=@base_diferente_0, base_no_objeto=@base_no_objeto, base_exenta=@base_exenta, monto_iva=@monto_iva, monto_ice=@monto_ice, retencion_iva_10=@retencion_iva_10, retencion_iva_20=@retencion_iva_20, retencion_iva_30=@retencion_iva_30, retencion_iva_70=@retencion_iva_70, retencion_iva_100=@retencion_iva_100, pago_a_residente=@pago_a_residente, pais_pago=@pais_pago, regimen_fiscal_menor=@regimen_fiscal_menor, convenio_doble_tributacion=@convenio_doble_tributacion, retencion_norma_legal=@retencion_norma_legal, tiene_retencion=@tiene_retencion, ret_establecimiento=@ret_establecimiento, ret_punto_emision=@ret_punto_emision, ret_secuencial=@ret_secuencial, ret_numero_autorizacion=@ret_numero_autorizacion, ret_fecha_emision=@ret_fecha_emision, creado_por=@creado_por, creado_el=@creado_el WHERE id=@id;", gloConexion)
                cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = txtIdentificacion.Text
                cmd.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = txtProveedor.Text
                cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = txtTipoIdentificacion.Text
                cmd.Parameters.Add("@parte_relacionada", MySqlDbType.VarChar).Value = cboParteRelacionada.Text

                cmd.Parameters.Add("@sustento_tributario", MySqlDbType.VarChar).Value = cboSustentoTributario.Text
                cmd.Parameters.Add("@tipo_comprobante", MySqlDbType.VarChar).Value = cboTipoComprobante.Text
                cmd.Parameters.Add("@fecha_emision", MySqlDbType.Date).Value = txtFechaEmision.Value
                cmd.Parameters.Add("@fecha_comprobante", MySqlDbType.Date).Value = txtFechaEmision.Value
                cmd.Parameters.Add("@establecimiento", MySqlDbType.VarChar).Value = txtEstablecimiento.Text
                cmd.Parameters.Add("@punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmision.Text
                cmd.Parameters.Add("@secuencial", MySqlDbType.VarChar).Value = txtSecuencial.Text
                cmd.Parameters.Add("@numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacion.Text
                cmd.Parameters.Add("@documento_modificado", MySqlDbType.VarChar).Value = cboDocModificado.Text
                cmd.Parameters.Add("@doc_establecimiento", MySqlDbType.VarChar).Value = txtEstablecimientoModificado.Text
                cmd.Parameters.Add("@doc_punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmisionModificado.Text
                cmd.Parameters.Add("@doc_secuencial", MySqlDbType.VarChar).Value = txtSecuencialModificado.Text
                cmd.Parameters.Add("@doc_numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacionModificado.Text

                cmd.Parameters.Add("@base_0", MySqlDbType.Decimal).Value = CDec(txtBase0.Text)
                cmd.Parameters.Add("@base_diferente_0", MySqlDbType.Decimal).Value = CDec(txtBaseDiferente0.Text)
                cmd.Parameters.Add("@base_no_objeto", MySqlDbType.Decimal).Value = CDec(txtBaseNoObjeto.Text)
                cmd.Parameters.Add("@base_exenta", MySqlDbType.Decimal).Value = CDec(txtBaseExenta.Text)
                cmd.Parameters.Add("@monto_iva", MySqlDbType.Decimal).Value = CDec(txtMontoIVA.Text)
                cmd.Parameters.Add("@monto_ice", MySqlDbType.Decimal).Value = CDec(txtMontoICE.Text)
                cmd.Parameters.Add("@retencion_iva_10", MySqlDbType.Decimal).Value = CDec(txtRetIVA10.Text)
                cmd.Parameters.Add("@retencion_iva_20", MySqlDbType.Decimal).Value = CDec(txtRetIVA20.Text)
                cmd.Parameters.Add("@retencion_iva_30", MySqlDbType.Decimal).Value = CDec(txtRetIVA30.Text)
                cmd.Parameters.Add("@retencion_iva_70", MySqlDbType.Decimal).Value = CDec(txtRetIVA70.Text)
                cmd.Parameters.Add("@retencion_iva_100", MySqlDbType.Decimal).Value = CDec(txtRetIVA100.Text)

                cmd.Parameters.Add("@pago_a_residente", MySqlDbType.VarChar).Value = cboPagoResidente.Text
                cmd.Parameters.Add("@pais_pago", MySqlDbType.VarChar).Value = cboPaisPago.Text
                cmd.Parameters.Add("@regimen_fiscal_menor", MySqlDbType.VarChar).Value = cboPagoRegimenMenor.Text
                cmd.Parameters.Add("@convenio_doble_tributacion", MySqlDbType.VarChar).Value = cboConvenioDobleTributacion.Text
                cmd.Parameters.Add("@retencion_norma_legal", MySqlDbType.VarChar).Value = cboRetencionNormaLegal.Text

                cmd.Parameters.Add("@tiene_retencion", MySqlDbType.Int16).Value = CInt(chkSiTieneRet.Checked)
                cmd.Parameters.Add("@ret_establecimiento", MySqlDbType.VarChar).Value = txtEstablecimientoRet.Text
                cmd.Parameters.Add("@ret_punto_emision", MySqlDbType.VarChar).Value = txtPuntoEmisionRet.Text
                cmd.Parameters.Add("@ret_secuencial", MySqlDbType.VarChar).Value = txtSecuencialRet.Text
                cmd.Parameters.Add("@ret_numero_autorizacion", MySqlDbType.VarChar).Value = txtNumeroAutorizacionRet.Text
                cmd.Parameters.Add("@ret_fecha_emision", MySqlDbType.Date).Value = txtFechaEmisionRet.Value

                cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = gloUsuario
                cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = CInt(txtRegistro.Text)
                cmd.ExecuteNonQuery()

                Dim compraId As Integer = CInt(txtRegistro.Text)

                'eliminar retenciones
                EliminarRetenciones(compraId)

                'volver a agregar
                If chkSiTieneRet.Checked = True Then
                    For i = 0 To Spr.Rows.Count - 1
                        InsertarRetenciones(compraId, Spr(0, i).Value.ToString(), Spr(1, i).Value.ToString(), Spr(2, i).Value, Spr(3, i).Value, Spr(4, i).Value)
                    Next
                End If
                MsgBox("Compra Actualizada!", vbInformation)
            End If
            TabControl1.SelectTab(0)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=guardar_exportacion()", vbCritical)
        End Try
    End Sub

    Private Sub InsertarRetenciones(compraId As Integer, codRet As String, Concep As String, Base As Decimal, Porc As Decimal, Valor As Decimal)
        Dim cmd As New MySqlCommand("INSERT INTO compras_retenciones(compra_id,codigoRetencion,concepto,BaseImponible,porcentaje,valorRetenido) VALUES(@compra_id,@codigoRetencion,@concepto,@BaseImponible,@porcentaje,@valorRetenido);", gloConexion)
        cmd.Parameters.Add("@compra_id", MySqlDbType.Int32).Value = compraId
        cmd.Parameters.Add("@codigoRetencion", MySqlDbType.VarChar).Value = codRet
        cmd.Parameters.Add("@concepto", MySqlDbType.VarChar).Value = Concep
        cmd.Parameters.Add("@BaseImponible", MySqlDbType.Decimal).Value = Base
        cmd.Parameters.Add("@porcentaje", MySqlDbType.Decimal).Value = Porc
        cmd.Parameters.Add("@valorRetenido", MySqlDbType.Decimal).Value = Valor
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub CargarSpr(compraId As Integer)
        Dim cmd As New MySqlCommand("select codigoRetencion, concepto, baseimponible, porcentaje, valorretenido from compras_retenciones where compra_id=" + compraId.ToString + ";", gloConexion)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        If dt.Rows.Count > 0 Then
            LimpiarSpr()
            For i = 1 To dt.Rows.Count
                Spr.Rows.Add(dt.Rows(i - 1)("codigoRetencion").ToString, dt.Rows(i - 1)("concepto").ToString, dt.Rows(i - 1)("baseimponible").ToString, dt.Rows(i - 1)("porcentaje").ToString, dt.Rows(i - 1)("valorretenido").ToString)
            Next
        End If
    End Sub
    Private Sub EliminarRetenciones(compraId As Integer)
        Dim cmd As New MySqlCommand("DELETE FROM compras_retenciones WHERE compra_id = @compra_id;", gloConexion)
        cmd.Parameters.Add("@compra_id", MySqlDbType.Int32).Value = compraId
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub cmdMostrar_Click(sender As Object, e As EventArgs) Handles cmdMostrar.Click
        Dim registro As String = InputBox("Ingrese el número de registro")
        If Not IsNumeric(registro) Then
            Exit Sub
        End If
        Dim cmd As New MySqlCommand("Select * FROM compras where id=" + registro, gloConexion)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        If dt.Rows.Count > 0 Then
            txtIdentificacion.Text = dt.Rows(0)("identificacion").ToString
            txtProveedor.Text = dt.Rows(0)("proveedor").ToString
            txtTipoIdentificacion.Text = dt.Rows(0)("tipo_identificacion").ToString
            cboParteRelacionada.Text = dt.Rows(0)("parte_relacionada").ToString

            cboSustentoTributario.Text = dt.Rows(0)("sustento_tributario").ToString
            cboTipoComprobante.Text = dt.Rows(0)("tipo_comprobante").ToString
            txtFechaEmision.Value = dt.Rows(0)("fecha_emision").ToString
            txtEstablecimiento.Text = dt.Rows(0)("establecimiento").ToString
            txtPuntoEmision.Text = dt.Rows(0)("punto_emision").ToString
            txtSecuencial.Text = dt.Rows(0)("secuencial").ToString
            txtNumeroAutorizacion.Text = dt.Rows(0)("numero_autorizacion").ToString
            cboDocModificado.Text = dt.Rows(0)("documento_modificado").ToString
            txtEstablecimientoModificado.Text = dt.Rows(0)("doc_establecimiento").ToString
            txtPuntoEmisionModificado.Text = dt.Rows(0)("doc_punto_emision").ToString
            txtSecuencialModificado.Text = dt.Rows(0)("doc_secuencial").ToString
            txtNumeroAutorizacionModificado.Text = dt.Rows(0)("doc_numero_autorizacion").ToString

            txtBase0.Text = dt.Rows(0)("base_0").ToString
            txtBaseDiferente0.Text = dt.Rows(0)("base_diferente_0").ToString
            txtBaseNoObjeto.Text = dt.Rows(0)("base_no_objeto").ToString
            txtBaseExenta.Text = dt.Rows(0)("base_exenta").ToString
            txtMontoIVA.Text = dt.Rows(0)("monto_iva").ToString
            txtMontoICE.Text = dt.Rows(0)("monto_ice").ToString
            txtRetIVA10.Text = dt.Rows(0)("retencion_iva_10").ToString
            txtRetIVA20.Text = dt.Rows(0)("retencion_iva_20").ToString
            txtRetIVA30.Text = dt.Rows(0)("retencion_iva_30").ToString
            txtRetIVA70.Text = dt.Rows(0)("retencion_iva_70").ToString
            txtRetIVA100.Text = dt.Rows(0)("retencion_iva_100").ToString

            cboPagoResidente.Text = dt.Rows(0)("pago_a_residente").ToString
            cboPaisPago.Text = dt.Rows(0)("pais_pago").ToString
            cboPagoRegimenMenor.Text = dt.Rows(0)("regimen_fiscal_menor").ToString
            cboConvenioDobleTributacion.Text = dt.Rows(0)("convenio_doble_tributacion").ToString
            cboRetencionNormaLegal.Text = dt.Rows(0)("retencion_norma_legal").ToString

            chkSiTieneRet.Checked = dt.Rows(0)("tiene_retencion").ToString
            txtEstablecimientoRet.Text = dt.Rows(0)("ret_establecimiento").ToString
            txtPuntoEmisionRet.Text = dt.Rows(0)("ret_punto_emision").ToString
            txtSecuencialRet.Text = dt.Rows(0)("ret_secuencial").ToString
            txtNumeroAutorizacionRet.Text = dt.Rows(0)("ret_numero_autorizacion").ToString
            txtFechaEmisionRet.Text = dt.Rows(0)("ret_fecha_emision").ToString

            lblUsuario.Text = "Creado por: " + dt.Rows(0)("creado_por").ToString.ToUpper + " el " + dt.Rows(0)("creado_el").ToString
            txtRegistro.Text = registro

            CargarSpr(txtRegistro.Text)
            modo = 1
        Else
            MsgBox("No se encontró el Registro # " + registro, vbExclamation)
            cmdNuevo_Click(sender, e)
        End If

    End Sub

    Private Sub cmdQuitarRetencion_Click(sender As Object, e As EventArgs) Handles cmdQuitarRetencion.Click
        If MsgBox("Esta seguro de eliminar esa fila?", vbQuestion + vbYesNo) = vbYes Then
            Spr.Rows.RemoveAt(Spr.CurrentRow.Index)
            Spr.Refresh()
        End If
    End Sub

    Private Sub cmdAñadirRetencion_Click(sender As Object, e As EventArgs) Handles cmdAñadirRetencion.Click
        Dim f As New frmComprasRetenciones
        f.Spr = Me.Spr
        f.ShowDialog()
        Spr.Refresh()
    End Sub

    Private Sub cmdCalcularIVA10_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA10.Click
        If IsNumeric(txtMontoIVA.text) Then
            txtRetIVA10.Text = Math.Round(CDec(txtMontoIVA.Text) * 0.1, 2).ToString
        Else
            txtRetIVA10.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCalcularIVA20_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA20.Click
        If IsNumeric(txtMontoIVA.Text) Then
            txtRetIVA20.Text = Math.Round(CDec(txtMontoIVA.Text) * 0.2, 2).ToString
        Else
            txtRetIVA20.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCalcularIVA30_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA30.Click
        If IsNumeric(txtMontoIVA.Text) Then
            txtRetIVA30.Text = Math.Round(CDec(txtMontoIVA.Text) * 0.3, 2).ToString
        Else
            txtRetIVA30.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCalcularIVA70_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA70.Click
        If IsNumeric(txtMontoIVA.Text) Then
            txtRetIVA70.Text = Math.Round(CDec(txtMontoIVA.Text) * 0.7, 2).ToString
        Else
            txtRetIVA70.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCalcularIVA100_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA100.Click
        If IsNumeric(txtMontoIVA.Text) Then
            txtRetIVA100.Text = Math.Round(CDec(txtMontoIVA.Text) * 1, 2).ToString
        Else
            txtRetIVA100.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCalcularIVA_Click(sender As Object, e As EventArgs) Handles cmdCalcularIVA.Click
        If IsNumeric(txtMontoIVA.Text) Then
            txtBaseDiferente0.Text = Math.Round(CDec(txtMontoIVA.Text) * 0.12, 2).ToString
        Else
            txtBaseDiferente0.Text = "0.00"
        End If
    End Sub
End Class