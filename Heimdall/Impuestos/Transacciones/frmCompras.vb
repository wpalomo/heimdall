Public Class frmCompras
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdAñadirRetencion.Click
        frmComprasRetenciones.ShowDialog()
        Spr.Rows.Add()

    End Sub

    Private Sub chkSiTieneCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkSiTieneCR.CheckedChanged
        If chkSiTieneCR.Checked = True Then
            cmdAñadirRetencion.Enabled = True
            cmdQuitarRetencion.Enabled = True
            txtEstablecimientoCR.Enabled = True
            txtPuntoEmisionCR.Enabled = True
            txtSecuencialCR.Enabled = True
            txtAutorizacionCR.Enabled = True
            txtFechaEmisionCR.Enabled = True
        Else
            cmdAñadirRetencion.Enabled = False
            cmdQuitarRetencion.Enabled = False
            txtEstablecimientoCR.Enabled = False
            txtPuntoEmisionCR.Enabled = False
            txtSecuencialCR.Enabled = False
            txtAutorizacionCR.Enabled = False
            txtFechaEmisionCR.Enabled = False
            Spr.Rows.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New frmBuscarProveedor
        f.ShowDialog()
    End Sub
End Class