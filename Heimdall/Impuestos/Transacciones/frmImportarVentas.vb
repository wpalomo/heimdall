Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class frmImportarVentas
    Private Sub frmImportarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarSpr()

    End Sub

    Private Sub llenarSpr()
        Try
            Dim cmd As New MySqlCommand("select id, case MID(clave_acceso,9,2) when '01' THEN 'Factura' when '04' THEN 'Nota de Crédito' when '05' THEN 'Nota de Débito' when '06' THEN 'Guía de Remisión' when '07' THEN 'Retención' end as tipo, clave_acceso from comprobantes where procesada=0", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                Spr.DataSource = dt
                If dt.Rows.Count = 1 Then
                    lblMensaje.Text = dt.Rows.Count.ToString + " registro para importar"
                Else
                    lblMensaje.Text = dt.Rows.Count.ToString + " registros para importar"
                End If
                Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Spr.Columns(0).HeaderText = "ID"
                Spr.Columns(1).HeaderText = "Tipo de Documento"
                Spr.Columns(2).HeaderText = "Clave de Acceso"
            Else
                MsgBox("No existen registros para importar", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=login", vbCritical)
        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub
    Private Function extraeFC(ca As String, f As String) As Boolean
        Try
            Dim xmlDoc As New XmlDocument()
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)

            Dim fechaEmision As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/fechaEmision").FirstChild.Value.ToString
            Dim estab As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/estab").FirstChild.Value.ToString
            Dim pto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/ptoEmi").FirstChild.Value.ToString()
            Dim sec As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/secuencial").FirstChild.Value.ToString()
            Dim tipoIdentificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/tipoIdentificacionComprador").FirstChild.Value.ToString
            Dim identificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/identificacionComprador").FirstChild.Value.ToString
            Dim cliente As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/razonSocialComprador").FirstChild.Value.ToString
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalSinImpuestos").FirstChild.Value.ToString
            Dim totalDescuentos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalDescuento").FirstChild.Value.ToString
            Dim codigoImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalConImpuestos/totalImpuesto/codigo").FirstChild.Value.ToString
            Dim codigoPorcentaje As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalConImpuestos/totalImpuesto/codigoPorcentaje").FirstChild.Value.ToString
            Dim baseImponible As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalConImpuestos/totalImpuesto/baseImponible").FirstChild.Value.ToString
            Dim valorImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalConImpuestos/totalImpuesto/valor").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/importeTotal").FirstChild.Value.ToString

            If existeCliente(identificacion) = False Then
                crearCliente(cliente, tipoIdentificacion, identificacion)
            End If

            If crearRegistroVenta("FC", CDate(fechaEmision), estab, pto, sec, "", "", tipoIdentificacion, identificacion, cliente, CDec(totalSinImpuestos), CDec(totalDescuentos), codigoImpuesto, codigoPorcentaje, CDec(baseImponible), CDec(valorImpuesto), CDec(importeTotal)) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=extraeFC", vbCritical)
            Return False
        End Try

    End Function

    Private Function extraeNC(ca As String, f As String) As Boolean
        Try
            Dim xmlDoc As New XmlDocument()
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)

            Dim fechaEmision As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/fechaEmision").FirstChild.Value.ToString
            Dim estab As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/estab").FirstChild.Value.ToString
            Dim pto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/ptoEmi").FirstChild.Value.ToString()
            Dim sec As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/secuencial").FirstChild.Value.ToString()
            Dim codDM As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/codDocModificado").FirstChild.Value.ToString()
            Dim numDM As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/numDocModificado").FirstChild.Value.ToString()
            Dim tipoIdentificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/tipoIdentificacionComprador").FirstChild.Value.ToString
            Dim identificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/identificacionComprador").FirstChild.Value.ToString
            Dim cliente As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/razonSocialComprador").FirstChild.Value.ToString
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalSinImpuestos").FirstChild.Value.ToString
            Dim codigoImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalConImpuestos/totalImpuesto/codigo").FirstChild.Value.ToString
            Dim codigoPorcentaje As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalConImpuestos/totalImpuesto/codigoPorcentaje").FirstChild.Value.ToString
            Dim baseImponible As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalConImpuestos/totalImpuesto/baseImponible").FirstChild.Value.ToString
            Dim valorImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalConImpuestos/totalImpuesto/valor").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/valorModificacion").FirstChild.Value.ToString

            If existeCliente(identificacion) = False Then
                crearCliente(cliente, tipoIdentificacion, identificacion)
            End If

            If crearRegistroVenta("NC", CDate(fechaEmision), estab, pto, sec, codDM, numDM, tipoIdentificacion, identificacion, cliente, CDec(totalSinImpuestos), 0, codigoImpuesto, codigoPorcentaje, CDec(baseImponible), CDec(valorImpuesto), CDec(importeTotal)) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=extraeNC", vbCritical)
            Return False
        End Try
    End Function

    Private Function extraeND(ca As String, f As String) As Boolean
        Try
            Dim xmlDoc As New XmlDocument()
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)

            Dim fechaEmision As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/fechaEmision").FirstChild.Value.ToString
            Dim estab As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoTributaria/estab").FirstChild.Value.ToString
            Dim pto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoTributaria/ptoEmi").FirstChild.Value.ToString()
            Dim sec As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoTributaria/secuencial").FirstChild.Value.ToString()
            Dim codDM As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/codDocModificado").FirstChild.Value.ToString()
            Dim numDM As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/numDocModificado").FirstChild.Value.ToString()
            Dim tipoIdentificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/tipoIdentificacionComprador").FirstChild.Value.ToString
            Dim identificacion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/identificacionComprador").FirstChild.Value.ToString
            Dim cliente As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/razonSocialComprador").FirstChild.Value.ToString
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/totalSinImpuestos").FirstChild.Value.ToString
            Dim codigoImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/impuestos/impuesto/codigo").FirstChild.Value.ToString
            Dim codigoPorcentaje As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/impuestos/impuesto/codigoPorcentaje").FirstChild.Value.ToString
            Dim baseImponible As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/impuestos/impuesto/baseImponible").FirstChild.Value.ToString
            Dim valorImpuesto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/impuestos/impuesto/valor").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/valorTotal").FirstChild.Value.ToString

            If existeCliente(identificacion) = False Then
                crearCliente(cliente, tipoIdentificacion, identificacion)
            End If

            If crearRegistroVenta("ND", CDate(fechaEmision), estab, pto, sec, codDM, numDM, tipoIdentificacion, identificacion, cliente, CDec(totalSinImpuestos), 0, codigoImpuesto, codigoPorcentaje, CDec(baseImponible), CDec(valorImpuesto), CDec(importeTotal)) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=extraeND", vbCritical)
        Return False
        End Try
    End Function

    Private Function crearRegistroVenta(tipoDoc As String, fecEmi As Date, estab As String, pto As String, sec As String, codDocMod As String, numDocMod As String, tipIde As String, ide As String, cli As String, totSin As Decimal, totDcto As Decimal, codImp As String, codPor As String, base As Decimal, valor As Decimal, importe As Decimal) As Boolean
        Try
            Dim cmd As New MySqlCommand("INSERT INTO ventas(tipo_documento, fecha_emision, establecimiento, punto_emision, secuencial, codigo_documento_modificado, numero_documento_modificado, tipo_identificacion, identificacion, cliente, total_sin_impuestos, total_descuentos, codigo_impuesto, codigo_porcentaje, base_imponible, valor_impuesto, importe_total, creado_por, creado_el) VALUE (@tipo_documento,@fecha_emision,@establecimiento,@punto_emision,@secuencial,@codigo_documento_modificado,@numero_documento_modificado,@tipo_identificacion,@identificacion,@cliente,@total_sin_impuestos,@total_descuentos,@codigo_impuesto,@codigo_porcentaje,@base_imponible,@valor_impuesto,@importe_total,@creado_por,@creado_el);", gloConexion)
            cmd.Parameters.Add("@tipo_documento", MySqlDbType.VarChar).Value = tipoDoc
            cmd.Parameters.Add("@fecha_emision", MySqlDbType.Date).Value = fecEmi
            cmd.Parameters.Add("@establecimiento", MySqlDbType.VarChar).Value = estab
            cmd.Parameters.Add("@punto_emision", MySqlDbType.VarChar).Value = pto
            cmd.Parameters.Add("@secuencial", MySqlDbType.VarChar).Value = sec
            cmd.Parameters.Add("@codigo_documento_modificado", MySqlDbType.VarChar).Value = codDocMod
            cmd.Parameters.Add("@numero_documento_modificado", MySqlDbType.VarChar).Value = numDocMod
            cmd.Parameters.Add("@tipo_identificacion", MySqlDbType.VarChar).Value = tipIde
            cmd.Parameters.Add("@identificacion", MySqlDbType.VarChar).Value = ide
            cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = cli
            cmd.Parameters.Add("@total_sin_impuestos", MySqlDbType.Decimal).Value = totSin
            cmd.Parameters.Add("@total_descuentos", MySqlDbType.Decimal).Value = totDcto
            cmd.Parameters.Add("@codigo_impuesto", MySqlDbType.VarChar).Value = codImp
            cmd.Parameters.Add("@codigo_porcentaje", MySqlDbType.VarChar).Value = codPor
            cmd.Parameters.Add("@base_imponible", MySqlDbType.Decimal).Value = base
            cmd.Parameters.Add("@valor_impuesto", MySqlDbType.Decimal).Value = valor
            cmd.Parameters.Add("@importe_total", MySqlDbType.Decimal).Value = importe
            cmd.Parameters.Add("@creado_por", MySqlDbType.VarChar).Value = "Sit"
            cmd.Parameters.Add("@creado_el", MySqlDbType.DateTime).Value = DateTime.Now
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=crearRegistroVenta", vbCritical)
            Return False
        End Try

    End Function

    Private Function existeCliente(ident As String) As Boolean
        Try
            Dim cmd As New MySqlCommand("Select id from clientes where identificacion='" + ident + "'", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=existeCliente", vbCritical)
            Return False
        End Try

    End Function

    Private Function crearCliente(nom As String, tip As String, ide As String) As Boolean
        Try
            Dim cmd As New MySqlCommand("insert into clientes(nombres,tipo_identificacion,identificacion,creado_por,creado_el) values(@nom,@tip,@ide,@cpo,@cel);", gloConexion)
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom
            cmd.Parameters.Add("@tip", MySqlDbType.VarChar).Value = tip
            cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = ide
            cmd.Parameters.Add("@cpo", MySqlDbType.VarChar).Value = "Sit"
            cmd.Parameters.Add("@cel", MySqlDbType.DateTime).Value = DateTime.Now
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=crearCliente", vbCritical)
            Return False
        End Try

    End Function

    Private Function ProcesarXML(ws As facturaE.eFactura.WebService, id As String) As Boolean
        Try
            Dim comprobante As facturaE.Comprobante = ws.Comprobante
            Dim ca As String = comprobante.ClaveAcceso
            Dim na As String = comprobante.NumeroAutorizacion
            Dim fa As String = comprobante.FechaAutorizacion
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(comprobante.Comprobante)
            If IsNothing(xmlDoc.DocumentElement.SelectSingleNode("/comprobante/factura/infoTributaria/CodDoc").FirstChild.Value.ToString) = False Then
                MsgBox("Es Factura")
            End If
            'If Strings.Mid(ca, 9, 2) = "01" Then
            '    If extraeFC(ca, archivo) = True Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'ElseIf Strings.Mid(ca, 9, 2) = "04" Then
            '    If extraeNC(ca, archivo) = True Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'ElseIf Strings.Mid(ca, 9, 2) = "05" Then
            '    If extraeND(ca, archivo) = True Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'ElseIf Strings.Mid(ca, 9, 2) = "06" Then
            '    SetComprobanteNoAplica(id)
            '    Return False
            'ElseIf Strings.Mid(ca, 9, 2) = "07" Then
            '    SetComprobanteNoAplica(id)
            '    Return False
            'Else
            '    Return False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=ProcesarXML", vbCritical)
            Return False
        End Try

    End Function

    Private Sub SetComprobanteNoAplica(id As String)
        Try
            Dim cmd As New MySqlCommand("update comprobantes set procesada=-1 where id=" + id, gloConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=SetComprobanteProcesado", vbCritical)
        End Try
    End Sub

    Private Sub SetComprobanteProcesado(id As String)
        Try
            Dim cmd As New MySqlCommand("update comprobantes set procesada=1 where id=" + id, gloConexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=SetComprobanteProcesado", vbCritical)
        End Try
    End Sub

    Private Sub cmdImportar_Click(sender As Object, e As EventArgs) Handles cmdImportar.Click
        If MsgBox("Desea importar estos comprobantes al Sistema?", vbQuestion + vbYesNo) = vbYes Then
            Try
                Dim ws As New facturaE.eFactura.WebService
                Dim archivo As String = ""
                Dim id As String = ""
                Dim ca As String = ""
                Dim i As Integer
                Spr.Enabled = False
                cmdImportar.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                pgBar.Minimum = 0
                pgBar.Maximum = Spr.Rows.Count
                pgBar.Visible = True
                For i = 0 To Spr.Rows.Count - 1
                    archivo = Path.GetTempPath + Spr(2, i).Value.ToString.Trim + ".xml"
                    ca = Spr(2, i).Value.ToString
                    id = Spr(0, i).Value.ToString
                    If ws.SendClaveAcceso(ca, archivo) = facturaE.RespuestaSRYType.AUTORIZADO Then
                        If ProcesarXML(ws, id) = True Then
                            SetComprobanteProcesado(id)
                        End If
                    End If
                    i = i + 1
                    pgBar.Value = i
                Next
                MsgBox("Proceso de Importación Finalizado", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=batchImportarVentas", vbCritical)
            Finally
                Me.Cursor = Cursors.Default
                pgBar.Visible = False
                Spr.Enabled = True
                cmdImportar.Enabled = True
                llenarSpr()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ws As New facturaE.eFactura.WebService
        ws.SendClaveAcceso("2001201601176817399000120052030000000301234567815", "C:\test\fc-2.xml")
        MsgBox("ok")

    End Sub
End Class