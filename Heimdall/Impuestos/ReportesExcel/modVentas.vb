Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modVentas
    Public Sub rptListadoVentas(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture(BmpToBytes_MemStream(My.Resources.ResourceManager.GetObject("unaep")), DocumentFormat.OpenXml.Packaging.ImagePartType.Png)
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE VENTAS")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "# DE REGISTRO")
        wb.SetCellValue("B7", "TIPO DE DOCUMENTO")
        wb.SetCellValue("C7", "FECHA DE EMISIÓN")
        wb.SetCellValue("D7", "ESTABLECIMIENTO")
        wb.SetCellValue("E7", "PUNTO DE EMISION")
        wb.SetCellValue("F7", "SECUENCIAL")
        wb.SetCellValue("G7", "CODIGO DOC. MODIFICADO")
        wb.SetCellValue("H7", "NUMERO DOC. MODIFICADO")
        wb.SetCellValue("I7", "TIPO DE IDENTIFICACIÓN")
        wb.SetCellValue("J7", "IDENTIFICACIÓN")
        wb.SetCellValue("K7", "CLIENTE")
        wb.SetCellValue("L7", "TOTAL SIN IMPUESTOS")
        wb.SetCellValue("M7", "TOTAL DESCUENTOS")
        wb.SetCellValue("N7", "CODIGO DEL IMPUESTO")
        wb.SetCellValue("O7", "CODIGO DEL PORCENTAJE")
        wb.SetCellValue("P7", "BASE IMPONIBLE")
        wb.SetCellValue("Q7", "VALOR DEL IMPUESTO")
        wb.SetCellValue("R7", "TOTAL")
        wb.SetCellValue("S7", "CREADO POR")
        wb.SetCellValue("T7", "CREADO EL")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id"))
            wb.SetCellValue("B" & i, row("tipo_documento").ToString)
            wb.SetCellValue("C" & i, CDate(row("fecha_emision")))
            wb.SetCellValue("D" & i, row("establecimiento").ToString)
            wb.SetCellValue("E" & i, row("punto_emision").ToString)
            wb.SetCellValue("F" & i, row("secuencial").ToString)
            wb.SetCellValue("G" & i, row("codigo_documento_modificado").ToString)
            wb.SetCellValue("H" & i, row("numero_documento_modificado").ToString)
            wb.SetCellValue("I" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("J" & i, row("identificacion").ToString)
            wb.SetCellValue("K" & i, row("cliente").ToString)
            wb.SetCellValue("L" & i, row("total_sin_impuestos"))
            wb.SetCellValue("M" & i, row("total_descuentos"))
            wb.SetCellValue("N" & i, row("codigo_impuesto").ToString)
            wb.SetCellValue("O" & i, row("codigo_porcentaje").ToString)
            wb.SetCellValue("P" & i, row("base_imponible"))
            wb.SetCellValue("Q" & i, row("valor_impuesto"))
            wb.SetCellValue("R" & i, row("importe_total"))
            wb.SetCellValue("S" & i, row("creado_por").ToString)
            wb.SetCellValue("T" & i, CDate(row("creado_el")).ToString)
            i += 1
        Next
        'Guardar el Reporte
        wb.AutoFitColumn(1, 20)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub

End Module
