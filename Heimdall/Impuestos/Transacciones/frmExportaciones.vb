Public Class frmExportaciones
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtRegistro.Text = ""
        txtIdentificacion.Text = ""
        txtCliente.Text = ""
        txtTipoIdentificacion.Text = ""
        cboParteRelacionada.SelectedIndex = 1
        cboPais.SelectedIndex = -1

        cboTipoExportacion.SelectedIndex = 0
        txtValorFOB.Text = ""
        txtFecha.Value = Now
        txtDocTpte.Text = ""
        cboDistrito.SelectedIndex = 5
        txtAño.Text = ""
        cboRegimen.SelectedIndex = 0
        txtCorrelativo.Text = ""

        cboTipoComprobante.SelectedIndex = 0
        txtValorFOBComprobante.Text = ""
        txtEstablecimiento.Text = ""
        txtPuntoEmision.Text = ""
        txtSecuencial.Text = ""
        txtNumeroAutorizacion.Text = ""
        txtFechaComprobante.Value = Now
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim f As New frmBuscarCliente
        f.ShowDialog()
    End Sub

    Private Sub frmExportaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)
    End Sub
End Class