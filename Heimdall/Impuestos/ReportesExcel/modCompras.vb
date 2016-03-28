Imports SpreadsheetLight
Imports SpreadsheetLight.Drawing
Imports MySql.Data.MySqlClient
Imports System.Data
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.IO

Module modCompras
    Private ds As New DataTable

    Public Sub rptListadoCompras(dt As DataTable)
        Dim wb As New SLDocument()
        Dim pic As SLPicture = New SLPicture(BmpToBytes_MemStream(My.Resources.ResourceManager.GetObject("unaep")), DocumentFormat.OpenXml.Packaging.ImagePartType.Png)
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

        wb.SetCellValue("L7", "TIPO DOC. MODIFICADO")
        wb.SetCellValue("M7", "NUMERO DOC. MODIFICADO")
        wb.SetCellValue("N7", "NUM. AUTOR. DOC. MODIFICADO")
        wb.SetCellValue("O7", "BASE 0%")
        wb.SetCellValue("P7", "BASE DIFERENTE AL 0%")
        wb.SetCellValue("Q7", "BASE NO OBJETO")
        wb.SetCellValue("R7", "BASE EXENTA")
        wb.SetCellValue("S7", "MONTO IVA")
        wb.SetCellValue("T7", "MONTO ICE")
        wb.SetCellValue("U7", "RETENCION DEL IVA DEL 10%")
        wb.SetCellValue("V7", "RETENCION DEL IVA DEL 20%")
        wb.SetCellValue("W7", "RETENCION DEL IVA DEL 30%")
        wb.SetCellValue("X7", "RETENCION DEL IVA DEL 70%")
        wb.SetCellValue("Y7", "RETENCION DEL IVA DEL 100%")
        wb.SetCellValue("Z7", "PAGO LOCAL O EXTERIOR")
        wb.SetCellValue("AA7", "PAIS DEL PAGO")
        wb.SetCellValue("AB7", "REGIMEN FISCAL MENOR")
        wb.SetCellValue("AC7", "CONVENIO DOBLE TRIBUTACIÓN")
        wb.SetCellValue("AD7", "RETENCION NORMA LEGAL")
        wb.SetCellValue("AE7", "NUM. DE LA RETENCIÓN")
        wb.SetCellValue("AF7", "NUM. AUTORIZACIÓN DE LA RETENCIÓN")
        wb.SetCellValue("AG7", "FECHA DE LA RETENCIÓN")
        wb.SetCellValue("AH7", "BASE RET 1%")
        wb.SetCellValue("AI7", "VALOR RET 1%")
        wb.SetCellValue("AJ7", "BASE RET 2%")
        wb.SetCellValue("AK7", "VALOR RET 2%")
        wb.SetCellValue("AL7", "BASE RET 8%")
        wb.SetCellValue("AM7", "VALOR RET 8%")
        wb.SetCellValue("AN7", "USUARIO")
        wb.SetCellValue("AO7", "FECHA REGISTRO")
        wb.ApplyNamedCellStyleToRow("7", SLNamedCellStyleValues.Heading3)

        Dim style As SLStyle = wb.CreateStyle()
        style.FormatCode = "dd-MM-yyyy"


        'Detalle
        For Each row As DataRow In dt.Rows
            wb.SetCellValue("A" & i, row("id").ToString)
            wb.SetCellValue("B" & i, row("tipo_identificacion").ToString)
            wb.SetCellValue("C" & i, row("identificacion").ToString)
            wb.SetCellValue("D" & i, row("proveedor").ToString)
            wb.SetCellValue("E" & i, row("parte_relacionada").ToString)
            wb.SetCellValue("F" & i, row("sustento_tributario").ToString)
            wb.SetCellValue("G" & i, row("tipo_comprobante").ToString)
            wb.SetCellValue("H" & i, CDate(row("fecha_emision")))
            wb.SetCellValue("I" & i, CDate(row("fecha_comprobante")))
            wb.SetCellValue("J" & i, row("establecimiento").ToString + "-" + row("punto_emision").ToString + "-" + row("secuencial").ToString)
            wb.SetCellValue("K" & i, row("numero_autorizacion").ToString)
            wb.SetCellValue("L" & i, row("documento_modificado").ToString)
            wb.SetCellValue("M" & i, row("doc_establecimiento").ToString + "-" + row("doc_punto_emision").ToString + "-" + row("doc_secuencial").ToString)
            wb.SetCellValue("N" & i, row("doc_numero_autorizacion").ToString)
            wb.SetCellValue("O" & i, row("base_0"))
            wb.SetCellValue("P" & i, row("base_diferente_0"))
            wb.SetCellValue("Q" & i, row("base_no_objeto"))
            wb.SetCellValue("R" & i, row("base_exenta"))
            wb.SetCellValue("S" & i, row("monto_iva"))
            wb.SetCellValue("T" & i, row("monto_ice"))
            wb.SetCellValue("U" & i, row("retencion_iva_10"))
            wb.SetCellValue("V" & i, row("retencion_iva_20"))
            wb.SetCellValue("W" & i, row("retencion_iva_30"))
            wb.SetCellValue("X" & i, row("retencion_iva_70"))
            wb.SetCellValue("Y" & i, row("retencion_iva_100"))
            wb.SetCellValue("Z" & i, row("pago_a_residente").ToString)
            wb.SetCellValue("AA" & i, row("pais_pago").ToString)
            wb.SetCellValue("AB" & i, row("regimen_fiscal_menor").ToString)
            wb.SetCellValue("AC" & i, row("convenio_doble_tributacion").ToString)
            wb.SetCellValue("AD" & i, row("retencion_norma_legal").ToString)
            wb.SetCellValue("AE" & i, row("ret_establecimiento").ToString + "-" + row("ret_punto_emision").ToString + "-" + row("ret_secuencial").ToString)
            wb.SetCellValue("AF" & i, row("ret_numero_autorizacion").ToString)
            wb.SetCellValue("AG" & i, CDate(row("ret_fecha_emision")))

            consultarRetenciones(row("id").ToString)
            For Each fila As DataRow In ds.Rows
                If fila("porcentaje").ToString = "1.00" Then
                    wb.SetCellValue("AH" & i, fila("bi"))
                    wb.SetCellValue("AI" & i, fila("vr"))
                ElseIf fila("porcentaje").ToString = "2.00" Then
                    wb.SetCellValue("AJ" & i, fila("bi"))
                    wb.SetCellValue("AK" & i, fila("vr"))
                ElseIf fila("porcentaje").ToString = "8.00" Then
                    wb.SetCellValue("AL" & i, fila("bi"))
                    wb.SetCellValue("AM" & i, fila("vr"))
                End If
            Next

            wb.SetCellValue("AN" & i, row("creado_por"))
            wb.SetCellValue("AO" & i, row("creado_el").ToString)

            wb.SetCellStyle("H" & i, style)
            wb.SetCellStyle("I" & i, style)
            wb.SetCellStyle("AG" & i, style)
            i += 1
        Next

        'Estilos
        wb.ApplyNamedCellStyleToColumn(15, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(16, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(17, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(18, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(19, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(20, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(21, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(22, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(23, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(24, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(25, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(34, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(35, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(36, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(37, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(38, SLNamedCellStyleValues.Currency)
        wb.ApplyNamedCellStyleToColumn(39, SLNamedCellStyleValues.Currency)

        'Guardar el Reporte
        wb.AutoFitColumn(1, 45)
        Dim archivoGenerado As String = Path.GetTempPath + "\" + GenerarNombre() + ".xlsx"
        wb.SaveAs(archivoGenerado)
        Process.Start(archivoGenerado)
    End Sub

    Private Sub consultarRetenciones(IdCompra As String)
        Try
            Dim cmd As New MySqlCommand("select porcentaje, sum(baseimponible) as bi, sum(valorretenido) as vr from compras_retenciones where compra_id=" + IdCompra, gloConexion)
            ds.Clear()
            ds.Load(cmd.ExecuteReader)
        Catch ex As Exception
            ds.Clear()
        End Try

    End Sub
End Module
