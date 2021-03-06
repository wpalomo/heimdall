﻿Imports MySql.Data.MySqlClient

Public Class frmRpCompras
    Dim dt As New DataTable

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub llenarUsuarios()
        Try
            cboUsuarios.Items.Clear()
            If gloTienePermisos Then
                Dim cmd As New MySqlCommand("select user from usuarios", gloConexion)
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                cboUsuarios.Items.Add("Todos")
                For Each row As DataRow In dt.Rows
                    cboUsuarios.Items.Add(row("user").ToString)
                Next
            Else
                cboUsuarios.Items.Add(gloUsuario)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtDesde.ResetText()
        txtHasta.ResetText()
        cboUsuarios.SelectedIndex = 0
        txtRuc.ResetText()
        txtProveedor.ResetText()
        Spr.DataSource = ""
        Spr.Refresh()
        cmdExportar.Visible = False
        dt.Clear()
    End Sub

    Private Sub frmRpExportaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarUsuarios()
        cmdNuevo_Click(sender, e)
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        Try
            Spr.DataSource = Nothing
            Spr.Refresh()
            Dim cmd As New MySqlCommand()
            cmd.Connection = gloConexion

            Dim usuario As String = ""
            Dim ruc As String = ""
            If cboUsuarios.Text = "Todos" Then
                usuario = "1"
            Else
                usuario = "creado_por='" + usuario + "'"
            End If
            If txtRuc.Text = "" Then
                ruc = "1"
            Else
                ruc = "identificacion='" + txtRuc.Text + "'"
            End If
            cmd.CommandText = "select * from compras where " + usuario + " and " + ruc + " and fecha_comprobante between '" + txtDesde.Text + "' and '" + txtHasta.Text + "';"

            dt.Clear()
            dt.Load(cmd.ExecuteReader)
            Spr.DataSource = dt
            Spr.Refresh()
            Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'Spr.Columns(1).HeaderText = "Usuario"
            'Spr.Columns(2).HeaderText = "Contraseña"
            lblMensajeCompras.Text = Spr.Rows.Count.ToString + " registros recuperados"
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
        Spr.Height = Me.Height - 170
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        gloSelectedSupplierID = ""
        gloSelectedSupplierName = ""
        gloSelectedSupplierType = ""
        Dim f As New frmBuscarProveedor
        f.ShowDialog()
        txtRuc.Text = gloSelectedSupplierID
        txtProveedor.Text = gloSelectedSupplierName
    End Sub
End Class