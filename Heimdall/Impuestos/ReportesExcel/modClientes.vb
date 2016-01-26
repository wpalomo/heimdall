Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modClientes

    Public Sub rptListadoClientes(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture("C:\UNAEP\images\logo.png")
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE CLIENTES")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "# DE REGISTRO")
        wb.SetCellValue("B7", "TIPO DE IDENTIFICACION")
        wb.SetCellValue("C7", "IDENTIFICACION")
        wb.SetCellValue("D7", "CLIENTE")
        wb.SetCellValue("E7", "DIRECCION")
        wb.SetCellValue("F7", "TELEFONO")
        wb.SetCellValue("G7", "USUARIO")
        wb.SetCellValue("H7", "FECHA REGISTRO")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id").ToString)
            wb.SetCellValue("B" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("C" & i, row("identificacion").ToString)
            wb.SetCellValue("D" & i, row("nombres").ToString)
            wb.SetCellValue("E" & i, row("direccion").ToString)
            wb.SetCellValue("F" & i, row("telefono").ToString)
            wb.SetCellValue("G" & i, row("creado_por").ToString)
            wb.SetCellValue("H" & i, CDate(row("creado_el")).ToString)
            i += 1
        Next
        'Guardar el Reporte
        wb.AutoFitColumn(1, 7)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub
End Module
