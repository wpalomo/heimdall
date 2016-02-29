Imports MySql.Data.MySqlClient

Public Class frmRpVentas
    Dim dt As New DataTable

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtDesde.ResetText()
        txtHasta.ResetText()
        cboEstablecimiento.SelectedIndex = -1
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
            If cboEstablecimiento.Text = "Todos" Then
                cmd.CommandText = "select * from ventas where fecha_emision between '" + txtDesde.Text + "' and '" + txtHasta.Text + "';"
            Else
                cmd.CommandText = "select * from ventas where establecimiento='" + cboEstablecimiento.Text.Split(" - ")(0) + "' and fecha_emision between '" + txtDesde.Text + "' and '" + txtHasta.Text + "';"
            End If
            dt.Clear()
            dt.Load(cmd.ExecuteReader)
            Spr.DataSource = dt
            Spr.Refresh()
            Spr.Columns(0).HeaderText = "# Registro"
            Spr.Columns(1).HeaderText = "Tipo Documento"
            Spr.Columns(2).HeaderText = "Fecha de Emisión"
            Spr.Columns(3).HeaderText = "Establecimiento"
            Spr.Columns(4).HeaderText = "Punto de Emisión"
            Spr.Columns(5).HeaderText = "Secuencial"
            Spr.Columns(6).HeaderText = "Código Doc. Modificado"
            Spr.Columns(7).HeaderText = "Número Doc. Modificado"
            Spr.Columns(8).HeaderText = "Tipo Identificación"
            Spr.Columns(9).HeaderText = "Identificación"
            Spr.Columns(10).HeaderText = "Cliente"
            Spr.Columns(11).HeaderText = "Total sin Impuestos"
            Spr.Columns(12).HeaderText = "Total de Descuentos"
            Spr.Columns(13).HeaderText = "Código de Impuesto"
            Spr.Columns(14).HeaderText = "Código de Porcentaje"
            Spr.Columns(15).HeaderText = "Base Imponible"
            Spr.Columns(16).HeaderText = "Valor Impuesto"
            Spr.Columns(17).HeaderText = "Total"
            Spr.Columns(18).HeaderText = "Creado por"
            Spr.Columns(19).HeaderText = "Creado el"
            Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            lblMensajeVentas.Text = Spr.Rows.Count.ToString + " registros recuperados"
            cmdExportar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteVentas", vbCritical)
        End Try


    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptListadoVentas(dt)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=exportarVentas", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmRpVentas_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Spr.Width = Me.Width - 40
        Spr.Height = Me.Height - 170
    End Sub
End Class