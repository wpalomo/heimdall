Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modCompras
    Public Sub rptListadoCompras(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture("C:\UNAEP\images\logo.png")
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE COMPRAS")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "# DE REGISTRO")
        wb.SetCellValue("B7", "TIPO DE IDENTIFICACION")
        wb.SetCellValue("C7", "IDENTIFICACION")
        wb.SetCellValue("D7", "PROVEEDOR")
        wb.SetCellValue("E7", "PARTE RELACIONADA")
        wb.SetCellValue("F7", "SUSTENTO TRIBUTARIO")
        wb.SetCellValue("G7", "TIPO DE COMPROBANTE")
        wb.SetCellValue("H7", "FECHA DE EMISION")
        wb.SetCellValue("I7", "FECHA DEL COMPROBANTE")
        wb.SetCellValue("J7", "NUMERO DEL COMPROBANTE")
        wb.SetCellValue("K7", "NUMERO DE AUTORIZACION")

        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id").ToString)
            wb.SetCellValue("B" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("C" & i, row("identificacion").ToString)
            wb.SetCellValue("D" & i, row("proveedor").ToString)
            wb.SetCellValue("E" & i, row("parte_relacionada").ToString)
            wb.SetCellValue("F" & i, row("sustento_tributario").ToString)
            wb.SetCellValue("G" & i, row("tipo_comprobante").ToString)
            wb.SetCellValue("H" & i, CDate(row("fecha_emision")).ToString)
            wb.SetCellValue("I" & i, CDate(row("fecha_comprobante")).ToString)
            wb.SetCellValue("J" & i, row("establecimiento").ToString + "-" + row("punto_emision").ToString + "-" + row("secuencial").ToString)
            wb.SetCellValue("K" & i, row("numero_autorizacion").ToString)
            i += 1
        Next
        'Guardar el Reporte
        wb.AutoFitColumn(1, 20)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub
End Module
