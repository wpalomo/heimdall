Imports MySql.Data.MySqlClient

Public Class frmImportarVentas
    Private Sub frmImportarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarSpr()

    End Sub

    Private Sub llenarSpr()
        Try
            Dim cmd As New MySqlCommand("select id, clave_acceso from comprobantes where procesada=0", gloConexionImport)
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
        MsgBox("Desea importar estos comprobantes al Sistema?", vbQuestion + vbYesNo)
    End Sub
End Class