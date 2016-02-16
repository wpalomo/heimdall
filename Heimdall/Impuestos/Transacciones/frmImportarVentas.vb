Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmImportarVentas
    Private Sub frmImportarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarSpr()

    End Sub

    Private Sub llenarSpr()
        Try
            Dim cmd As New MySqlCommand("select id, clave_acceso from comprobantes where procesada=0", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                Spr.DataSource = dt
                If dt.Rows.Count = 1 Then
                    lblMensaje.Text = dt.Rows.Count.ToString + " registro para importar"
                Else
                    lblMensaje.Text = dt.Rows.Count.ToString + " registros para importar"
                End If
                Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Spr.Columns(0).HeaderText = "ID"
                Spr.Columns(1).HeaderText = "Clave de Acceso"
            Else
                MsgBox("No existen registros para importar", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=login", vbCritical)
        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdImportar_Click(sender As Object, e As EventArgs) Handles cmdImportar.Click
        If MsgBox("Desea importar estos comprobantes al Sistema?", vbQuestion + vbYesNo) = vbYes Then
            Dim ws As New facturaE.eFactura.WebService
            Dim archivo = "c:\unaep\temporal.xml"
            If ws.SendClaveAcceso("0112201501176817399000120012080000003281234567819", archivo) = facturaE.RespuestaSRYType.AUTORIZADO Then
                MsgBox("importado")
            End If
            Exit Sub

            Try
                Dim i As Integer
                Spr.Enabled = False
                cmdImportar.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                pgBar.Minimum = 0
                pgBar.Maximum = Spr.Rows.Count
                pgBar.Visible = True
                For i = 1 To Spr.Rows.Count
                    'Spr(i,1).Value 
                    i = i + 1
                    pgBar.Value = i
                Next
                MsgBox("Proceso de Importación Finalizado", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=batchImportarVentas", vbCritical)
            Finally
                Me.Cursor = Cursors.Default
                pgBar.Visible = False
                Spr.Enabled = True
                cmdImportar.Enabled = True
                llenarSpr()
            End Try

        End If

    End Sub
End Class