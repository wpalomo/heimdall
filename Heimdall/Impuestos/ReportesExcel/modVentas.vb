Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modVentas
    Public Sub rptListadoVentas(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture(BmpToBytes_MemStream(My.Resources.ResourceManager.GetObject("logo")), DocumentFormat.OpenXml.Packaging.ImagePartType.Png)
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE PROVEEDORES")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "# DE REGISTRO")
        wb.SetCellValue("B7", "TIPO DE IDENTIFICACION")
        wb.SetCellValue("C7", "IDENTIFICACION")
        wb.SetCellValue("D7", "PROVEEDOR")
        wb.SetCellValue("E7", "CIUDAD")
        wb.SetCellValue("F7", "DIRECCION")
        wb.SetCellValue("G7", "TELEFONO")
        wb.SetCellValue("H7", "USUARIO")
        wb.SetCellValue("I7", "FECHA REGISTRO")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id").ToString)
            wb.SetCellValue("B" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("C" & i, row("identificacion").ToString)
            wb.SetCellValue("D" & i, row("nombres").ToString)
            wb.SetCellValue("E" & i, row("ciudad").ToString)
            wb.SetCellValue("F" & i, row("direccion").ToString)
            wb.SetCellValue("G" & i, row("telefono").ToString)
            wb.SetCellValue("H" & i, row("creado_por").ToString)
            wb.SetCellValue("I" & i, CDate(row("creado_el")).ToString)
            i += 1
        Next
        'Guardar el Reporte
        wb.AutoFitColumn(1, 7)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub

End Module
