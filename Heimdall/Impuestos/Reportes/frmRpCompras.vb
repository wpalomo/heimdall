Imports MySql.Data.MySqlClient

Public Class frmRpCompras
    Dim dt As New DataTable

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtDesde.ResetText()
        txtHasta.ResetText()
        cboEstablecimiento.SelectedIndex = 0
        Spr.DataSource = ""
        Spr.Refresh()
        cmdExportar.Visible = False

    End Sub

    Private Sub frmRpExportaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        Try
            Dim cmd As New MySqlCommand()
            cmd.Connection = gloConexion
            If cboEstablecimiento.Text = "Todos" Then
                cmd.CommandText = "select * from compras where fecha_comprobante between '" + txtDesde.Text + "' and '" + txtHasta.Text + "';"
            Else
                cmd.CommandText = "select * from compras where establecimiento='" + cboEstablecimiento.Text + "' and fecha_comprobante between '" + txtHasta.Text + "' and '" + txtDesde.Text + "';"
            End If
            dt.Load(cmd.ExecuteReader)
            Spr.DataSource = dt
            Spr.Refresh()
            Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'Spr.Columns(1).HeaderText = "Usuario"
            'Spr.Columns(2).HeaderText = "Contraseña"
            cmdExportar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteCompras", vbCritical)
        End Try


    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptListadoCompras(dt)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=exportarCompras", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmRpCompras_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Spr.Width = Me.Width - 40
        Spr.Height = Me.Height - 160
    End Sub
End Class