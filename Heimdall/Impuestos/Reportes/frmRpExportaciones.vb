Imports MySql.Data.MySqlClient

Public Class frmRpExportaciones
    Dim dt As New DataTable

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtDesde.ResetText()
        txtHasta.ResetText()
        Spr.DataSource = ""
        Spr.Refresh()
        cmdExportar.Visible = False
        dt.Clear()

    End Sub

    Private Sub frmRpExportaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        Try
            Spr.DataSource = Nothing
            Spr.Refresh()
            Dim cmd As New MySqlCommand()
            cmd.Connection = gloConexion
            cmd.CommandText = "select * from exportaciones where fecha_comprobante between '" + txtDesde.Text + "' and '" + txtHasta.Text + "';"
            dt.Clear()
            dt.Load(cmd.ExecuteReader)
            Spr.DataSource = dt
            Spr.Refresh()
            Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'Spr.Columns(1).HeaderText = "Usuario"
            'Spr.Columns(2).HeaderText = "Contraseña"
            lblMensajeExportaciones.Text = Spr.Rows.Count.ToString + " registros recuperados"
            cmdExportar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteExportaciones", vbCritical)
        End Try


    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptListadoExportaciones(dt, txtDesde.Text, txtHasta.Text, "")
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=exportarExportaciones", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmRpExportaciones_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Spr.Width = Me.Width - 40
        Spr.Height = Me.Height - 170
    End Sub

End Class