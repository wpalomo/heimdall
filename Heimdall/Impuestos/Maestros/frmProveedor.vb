Public Class frmProveedor
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim f As New frmBuscarProveedor
        f.ShowDialog()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtNombre.Text = ""
        cboTipoIdentificacion.SelectedIndex = -1
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        txtCorreoElectronico.Text = ""
        txtTelefono.Text = ""

    End Sub
End Class