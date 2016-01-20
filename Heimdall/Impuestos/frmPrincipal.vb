Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVariablesGlobales()
        Dim f As New frmLogin
        f.ShowDialog()
        statusUsuario.Text = gloUsuario
        statusMes.Text = gloMesActualNombre
    End Sub

    Private Sub CierreDeMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeMesToolStripMenuItem.Click
        Dim f As New frmCierreMensual
        f.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿ Desea salir del sistema ?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ParámetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosToolStripMenuItem.Click
        Dim f As New frmParametros
        f.ShowDialog()

    End Sub

    Private Sub ExportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportacionesToolStripMenuItem.Click
        Dim f As New frmExportaciones
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub ATSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATSToolStripMenuItem.Click
        InputBox("Ingrese Mes [1-12] para generar ATS", "Generar ATS")
        GenerarATS()
    End Sub

    Private Sub ImportarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarVentasToolStripMenuItem.Click
        Dim f As New frmImportarVentas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim f As New frmCompras
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim f As New frmProveedor
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim f As New frmCliente
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoDeProveedoresToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        rptListadoProveedores()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim cmd As New MySqlCommand("select * from clientes", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            rptListadoClientes(dt)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteClientes", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RegistrosDeExportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeExportacionesToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim cmd As New MySqlCommand("select * from exportaciones", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            rptListadoExportaciones(dt, "", "", "")
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteExportaciones", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class