Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet

Module modProveedores
    Public Sub rptListadoProveedores()
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture("C:\UNAEP\images\logo.png")
        wb.InsertPicture(pic)
        wb.SetCellValue("A5", "LISTADO DE PROVEEDORES")
        wb.MergeWorksheetCells("A5", "D5")
        'Guardar el Reporte
        Dim archivoGenerado As String = "C:\test\listado_proveedores.xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub

End Module
