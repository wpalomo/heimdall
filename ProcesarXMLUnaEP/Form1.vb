Imports System.IO
Imports System.Xml

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strFile As String = "C:\Users\David\Desktop\SUSANITA\all\retenciones-procesadas.txt"
        Dim fileEntries As String() = Directory.GetFiles(txtRuta.Text)
        Dim xmlDoc As New XmlDocument()

        For Each f In fileEntries
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            xmlDoc.Load(f)
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/autorizacion/comprobante/comprobanteRetencion/impuestos/impuesto")
            Dim retencion As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/estab").FirstChild.Value.ToString + xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/ptoEmi").FirstChild.Value.ToString + xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/comprobanteRetencion/infoTributaria/secuencial").FirstChild.Value.ToString
            Dim codigoImpuesto As String = ""
            Dim codigoRetencion As String = ""
            Dim base As String = ""
            Dim porcentaje As String = ""
            Dim valor As String = ""
            Dim numDoc As String = ""
            Dim fecDoc As String = ""
            For Each node As XmlNode In nodes
                codigoImpuesto = node.SelectSingleNode("codigo").InnerText
                codigoRetencion = node.SelectSingleNode("codigoRetencion").InnerText
                base = node.SelectSingleNode("baseImponible").InnerText
                porcentaje = node.SelectSingleNode("porcentajeRetener").InnerText
                valor = node.SelectSingleNode("valorRetenido").InnerText
                numDoc = node.SelectSingleNode("numDocSustento").InnerText
                fecDoc = node.SelectSingleNode("fechaEmisionDocSustento").InnerText
                File.AppendAllText(strFile, retencion + vbTab + codigoImpuesto + vbTab + codigoRetencion + vbTab + base + vbTab + porcentaje + vbTab + valor + vbTab + numDoc + vbTab + fecDoc + vbCrLf)
            Next
        Next
        MsgBox("Listo", vbInformation)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strFile As String = "C:\Users\David\Desktop\SUSANITA\all\facturas-procesadas.txt"
        Dim fileEntries As String() = Directory.GetFiles(txtRuta.Text)
        Dim xmlDoc As New XmlDocument()

        For Each f In fileEntries
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/totalSinImpuestos").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/importeTotal").FirstChild.Value.ToString
            Dim estab As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/estab").FirstChild.Value.ToString
            Dim pto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/ptoEmi").FirstChild.Value.ToString()
            Dim sec As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoTributaria/secuencial").FirstChild.Value.ToString()
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/autorizacion/comprobante/factura/infoFactura/totalConImpuestos/totalImpuesto")
            Dim tipoRuc As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/tipoIdentificacionComprador").FirstChild.Value.ToString
            Dim Ruc As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/factura/infoFactura/identificacionComprador").FirstChild.Value.ToString
            Dim codigoImpuesto As String = ""
            Dim porcentaje As String = ""
            Dim base As String = ""
            Dim valor As String = ""
            For Each node As XmlNode In nodes
                codigoImpuesto = node.SelectSingleNode("codigo").InnerText
                porcentaje = node.SelectSingleNode("codigoPorcentaje").InnerText
                base = node.SelectSingleNode("baseImponible").InnerText
                valor = node.SelectSingleNode("valor").InnerText
                File.AppendAllText(strFile, tipoRuc + vbTab + Ruc + vbTab + estab + vbTab + pto + vbTab + sec + vbTab + totalSinImpuestos + vbTab + codigoImpuesto + vbTab + porcentaje + vbTab + base + vbTab + valor + vbTab + importeTotal + vbCrLf)
            Next
        Next
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strFile As String = "C:\Users\David\Desktop\SUSANITA\all\NC-procesadas.txt"
        Dim fileEntries As String() = Directory.GetFiles(txtRuta.Text)
        Dim xmlDoc As New XmlDocument()

        For Each f In fileEntries
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalSinImpuestos").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/valorModificacion").FirstChild.Value.ToString
            Dim estab As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/estab").FirstChild.Value.ToString
            Dim pto As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/ptoEmi").FirstChild.Value.ToString()
            Dim sec As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoTributaria/secuencial").FirstChild.Value.ToString()
            Dim tipoRuc As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/tipoIdentificacionComprador").FirstChild.Value.ToString
            Dim Ruc As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaCredito/infoNotaCredito/identificacionComprador").FirstChild.Value.ToString
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/autorizacion/comprobante/notaCredito/infoNotaCredito/totalConImpuestos/totalImpuesto")
            Dim codigoImpuesto As String = ""
            Dim porcentaje As String = ""
            Dim base As String = ""
            Dim valor As String = ""
            For Each node As XmlNode In nodes
                codigoImpuesto = node.SelectSingleNode("codigo").InnerText
                porcentaje = node.SelectSingleNode("codigoPorcentaje").InnerText
                base = node.SelectSingleNode("baseImponible").InnerText
                valor = node.SelectSingleNode("valor").InnerText
                File.AppendAllText(strFile, tipoRuc + vbTab + Ruc + vbTab + estab + vbTab + pto + vbTab + sec + vbTab + totalSinImpuestos + vbTab + codigoImpuesto + vbTab + porcentaje + vbTab + base + vbTab + valor + vbTab + importeTotal + vbCrLf)
            Next
        Next
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strFile As String = "C:\Users\David\Desktop\SUSANITA\all\ND-procesadas.txt"
        Dim fileEntries As String() = Directory.GetFiles(txtRuta.Text)
        Dim xmlDoc As New XmlDocument()

        For Each f In fileEntries
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader, False)
            Dim fileReader2 As String = My.Computer.FileSystem.ReadAllText(f).Replace("<![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>", "").Replace("]]>", "")
            My.Computer.FileSystem.WriteAllText(f, fileReader2, False)
            xmlDoc.Load(f)
            Dim totalSinImpuestos As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/totalSinImpuestos").FirstChild.Value.ToString
            Dim importeTotal As String = xmlDoc.DocumentElement.SelectSingleNode("/autorizacion/comprobante/notaDebito/infoNotaDebito/valorTotal").FirstChild.Value.ToString
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/autorizacion/comprobante/notaDebito/infoNotaDebito/impuestos/impuesto")
            Dim codigoImpuesto As String = ""
            Dim porcentaje As String = ""
            Dim tarifa As String = ""
            Dim base As String = ""
            Dim valor As String = ""
            For Each node As XmlNode In nodes
                codigoImpuesto = node.SelectSingleNode("codigo").InnerText
                porcentaje = node.SelectSingleNode("codigoPorcentaje").InnerText
                tarifa = node.SelectSingleNode("tarifa").InnerText
                base = node.SelectSingleNode("baseImponible").InnerText
                valor = node.SelectSingleNode("valor").InnerText
                File.AppendAllText(strFile, totalSinImpuestos + vbTab + codigoImpuesto + vbTab + porcentaje + vbTab + tarifa + vbTab + base + vbTab + valor + vbTab + importeTotal + vbCrLf)
            Next
        Next
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fileEntries As String() = Directory.GetFiles("C:\Users\David\Desktop\SUSANITA\all\xml")
        Dim resultados As String()
        Dim cadena As String

        For Each f In fileEntries
            resultados = f.Split("\")
            cadena = resultados.Last
            If Strings.Mid(cadena, 5, 4) = "2015" Then
                If Strings.Mid(cadena, 9, 2) = "01" Then
                    System.IO.File.Move(f, "C:\Users\David\Desktop\SUSANITA\all\fc\" + cadena)
                ElseIf Strings.Mid(cadena, 9, 2) = "04" Then
                    System.IO.File.Move(f, "C:\Users\David\Desktop\SUSANITA\all\nc\" + cadena)
                ElseIf Strings.Mid(cadena, 9, 2) = "05" Then
                    System.IO.File.Move(f, "C:\Users\David\Desktop\SUSANITA\all\nd\" + cadena)
                ElseIf Strings.Mid(cadena, 9, 2) = "06" Then
                    System.IO.File.Move(f, "C:\Users\David\Desktop\SUSANITA\all\gr\" + cadena)
                ElseIf Strings.Mid(cadena, 9, 2) = "07" Then
                    System.IO.File.Move(f, "C:\Users\David\Desktop\SUSANITA\all\rt\" + cadena)
                End If
            End If
        Next
        MsgBox("listo")
    End Sub
End Class
