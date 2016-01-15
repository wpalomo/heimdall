Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim f As New frmLogin
        f.ShowDialog()
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
        GenerarATS()
    End Sub

    Private Sub ImportarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarVentasToolStripMenuItem.Click
        Dim f As New frmImportarVentas
        f.MdiParent = Me
        f.Show()
    End Sub
End Class