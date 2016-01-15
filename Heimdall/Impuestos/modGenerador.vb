Imports System.Xml

Module modGenerador
    Public Sub GenerarATS()
        Using writer As XmlWriter = XmlWriter.Create("C:\test\ats.xml")
            ' Begin writing.
            writer.WriteStartDocument()
            writer.WriteStartElement("iva") ' iva

            ' ----------------- CABECERA  -----------------------------
            writer.WriteElementString("TipoIDInformante", "R")
            writer.WriteElementString("IdInformante", "1768173990001")
            writer.WriteElementString("razonSocial", "EMPRESA PUBLICA UNIDAD NACIONAL DE ALMACENAMIENTO UNA EP")
            writer.WriteElementString("Anio", "2015")
            writer.WriteElementString("Mes", "11")
            writer.WriteElementString("totalVentas", "2000")
            writer.WriteElementString("codigoOperativo", "IVA")


            ' ----------------- VENTAS -----------------------------
            'tipoComprobante: 18=>FC, 04=>NC, 05=>ND
            writer.WriteStartElement("ventas")
            writer.WriteStartElement("detalleVentas")
            writer.WriteElementString("tpIdCliente", "05")
            writer.WriteElementString("idCliente", "0926803396")
            writer.WriteElementString("parteRelVtas", "NO")
            writer.WriteElementString("tipoComprobante", "18")
            writer.WriteElementString("numeroComprobantes", "2")
            writer.WriteElementString("baseNoGraIva", "0.00")
            writer.WriteElementString("baseImponible", "0.00")
            writer.WriteElementString("baseImpGrav", "2000")
            writer.WriteElementString("montoIva", "240")
            writer.WriteElementString("montoIce", "0.00")
            writer.WriteElementString("valorRetIva", "0.00")
            writer.WriteElementString("valorRetRenta", "0.00")
            writer.WriteEndElement()
            writer.WriteEndElement()


            ' ----------------- VENTAS POR ESTABLECIMIENTO -----------------------------
            writer.WriteStartElement("ventasEstablecimiento")
            writer.WriteStartElement("ventaEst")
            writer.WriteElementString("codEstab", "001")
            writer.WriteElementString("ventasEstab", "2000")
            writer.WriteEndElement()
            writer.WriteEndElement()


            ' ----------------- EXPORTACIONES -----------------------------
            writer.WriteStartElement("exportaciones")
            writer.WriteStartElement("detalleExportaciones")
            writer.WriteElementString("tpIdClienteEx", "20")
            writer.WriteElementString("idClienteEx", "1310086226001")
            writer.WriteElementString("parteRelExp", "NO")
            writer.WriteElementString("paisEfecExp", "202")
            writer.WriteElementString("exportacionDe", "01")
            writer.WriteElementString("tipoComprobante", "01")
            writer.WriteElementString("distAduanero", "064")
            writer.WriteElementString("anio", "2015")
            writer.WriteElementString("regimen", "40")
            writer.WriteElementString("correlativo", "84984948")
            writer.WriteElementString("docTransp", "9832983298328")
            writer.WriteElementString("fechaEmbarque", "01/11/2015")
            writer.WriteElementString("valorFOB", "15000")
            writer.WriteElementString("valorFOBComprobante", "12000")
            writer.WriteElementString("establecimiento", "001")
            writer.WriteElementString("puntoEmision", "001")
            writer.WriteElementString("secuencial", "000154086")
            writer.WriteElementString("autorizacion", "151516500")
            writer.WriteElementString("fechaEmision", "05/11/2015")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndDocument()
        End Using
        MsgBox("Listo", vbInformation)
    End Sub
End Module
