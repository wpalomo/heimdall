Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet

Module modClientes

    Public Sub rptListadoClientes(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture("C:\UNAEP\images\logo.png")
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE CLIENTES")
        wb.MergeWorksheetCells("A5", "D5")
        Dim i As Integer = 8

        'Encabezados
        wb.SetCellValue("A7", "TIPO DE IDENTIFICACION")
        wb.SetCellValue("B7", "IDENTIFICACION")
        wb.SetCellValue("C7", "CLIENTE")
        wb.SetCellValue("D7", "DIRECCION")
        wb.SetCellValue("E7", "TELEFONO")
        wb.SetCellValue("F7", "USUARIO")
        wb.SetCellValue("G7", "FECHA REGISTRO")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("B" & i, row("identificacion").ToString)
            wb.SetCellValue("C" & i, row("nombres").ToString)
            wb.SetCellValue("D" & i, row("direccion").ToString)
            wb.SetCellValue("E" & i, row("telefono").ToString)
            wb.SetCellValue("F" & i, row("creado_por").ToString)
            wb.SetCellValue("G" & i, CDate(row("creado_el")).ToString)
            i += 1
        Next
        'Guardar el Reporte
        wb.AutoFitColumn(1, 7)
        Dim archivoGenerado As String = "C:\UNAEP\impuestos\listado_clientes.xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub
End Module
