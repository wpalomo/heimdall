Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modExportaciones
    Public Sub rptListadoExportaciones(dt As DataTable, del As String, al As String, usuario As String)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture(BmpToBytes_MemStream(My.Resources.ResourceManager.GetObject("unaep")), DocumentFormat.OpenXml.Packaging.ImagePartType.Png)
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "REGISTRO DE EXPORTACIONES")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "# REGISTRO")
        wb.SetCellValue("B7", "TIPO DE IDENTIFICACION")
        wb.SetCellValue("C7", "IDENTIFICACION")
        wb.SetCellValue("D7", "CLIENTE")
        wb.SetCellValue("E7", "PARTE RELACIONADA")
        wb.SetCellValue("F7", "PAIS AL QUE EXPORTA")
        wb.SetCellValue("G7", "TIPO DE EXPORTACIÓN")
        wb.SetCellValue("H7", "VALOR FOB")
        wb.SetCellValue("I7", "FECHA DE LA TRANSACCIÓN")
        wb.SetCellValue("J7", "DOC. TRANSPORTE")
        wb.SetCellValue("K7", "DISTRITO")
        wb.SetCellValue("L7", "AÑO")
        wb.SetCellValue("M7", "REGIMEN")
        wb.SetCellValue("N7", "CORRELATIVO")
        wb.SetCellValue("O7", "TIPO DE COMPROBANTE")
        wb.SetCellValue("P7", "VALOR FOB COMPROBANTE")
        wb.SetCellValue("Q7", "NUMERO COMPROBANTE")
        wb.SetCellValue("R7", "NUMERO DE AUTORIZACIÓN")
        wb.SetCellValue("S7", "FECHA DEL COMPROBANTE")
        wb.SetCellValue("T7", "USUARIO")
        wb.SetCellValue("U7", "FECHA REGISTRO")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id").ToString)
            wb.SetCellValue("B" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("C" & i, row("identificacion"))
            wb.SetCellValue("D" & i, row("cliente"))
            wb.SetCellValue("E" & i, row("parte_relacionada").ToString)
            wb.SetCellValue("F" & i, row("pais_exporta").ToString)
            wb.SetCellValue("G" & i, row("tipo_exportacion").ToString)
            wb.SetCellValue("H" & i, row("valor_fob"))
            wb.SetCellValue("I" & i, CDate(row("fecha_transaccion")).ToShortDateString)
            wb.SetCellValue("J" & i, row("doc_transporte").ToString)
            wb.SetCellValue("K" & i, row("distrito").ToString)
            wb.SetCellValue("L" & i, row("año").ToString)
            wb.SetCellValue("M" & i, row("regimen").ToString)
            wb.SetCellValue("N" & i, row("correlativo").ToString)
            wb.SetCellValue("O" & i, row("tipo_comprobante").ToString)
            wb.SetCellValue("P" & i, row("valor_fob_comprobante"))
            wb.SetCellValue("Q" & i, row("establecimiento").ToString + row("punto_emision").ToString + row("secuencial").ToString)
            wb.SetCellValue("R" & i, row("numero_autorizacion").ToString)
            wb.SetCellValue("S" & i, CDate(row("fecha_comprobante")).ToShortDateString)
            wb.SetCellValue("T" & i, row("creado_por").ToString)
            wb.SetCellValue("U" & i, CDate(row("creado_el")).ToString)
            i += 1
        Next

        'Estilos
        wb.ApplyNamedCellStyleToColumn(8, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(16, SLNamedCellStyleValues.Currency)

        'Guardar el Reporte
        wb.AutoFitColumn(1, 22)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub
End Module
