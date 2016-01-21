Public Class frmCompras
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdAñadirRetencion.Click
        Dim f As New frmComprasRetenciones
        f.Spr = Me.Spr
        f.ShowDialog()
        Spr.Refresh()

    End Sub

    Private Sub chkSiTieneCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkSiTieneRet.CheckedChanged
        If chkSiTieneRet.Checked = True Then
            cmdAñadirRetencion.Enabled = True
            cmdQuitarRetencion.Enabled = True
            txtEstablecimientoRet.Enabled = True
            txtPuntoEmisionRet.Enabled = True
            txtSecuencialRet.Enabled = True
            txtAutorizacionRet.Enabled = True
            txtFechaEmisionRet.Enabled = True
            cmdImportarRetencion.Enabled = True
        Else
            cmdAñadirRetencion.Enabled = False
            cmdQuitarRetencion.Enabled = False
            txtEstablecimientoRet.Enabled = False
            txtPuntoEmisionRet.Enabled = False
            txtSecuencialRet.Enabled = False
            txtAutorizacionRet.Enabled = False
            txtFechaEmisionRet.Enabled = False
            cmdImportarRetencion.Enabled = False
            Spr.Rows.Clear()
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        gloSelectedSupplierID = ""
        gloSelectedSupplierName = ""
        gloSelectedSupplierType = ""
        Dim f As New frmBuscarProveedor
        f.ShowDialog()
        txtIdentificacion.Text = gloSelectedSupplierID
        txtProveedor.Text = gloSelectedSupplierName
        txtTipoIdentificacion.Text = gloSelectedSupplierType
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cboParteRelacionada.SelectedIndex = 1
        cboPagoResidente.SelectedIndex = 0

    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNuevo_Click(sender, e)

    End Sub

    Private Sub cboPagoResidente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPagoResidente.SelectedIndexChanged
        If cboPagoResidente.Text = "01-PAGO A RESIDENTE" Then
            cboPaisPago.SelectedIndex = -1
            cboPagoRegimenMenor.SelectedIndex = -1
            cboConvenioDobleTributacion.SelectedIndex = -1
            cboRetencionNormaLegal.SelectedIndex = -1
            cboPaisPago.Enabled = False
            cboPagoRegimenMenor.Enabled = False
            cboConvenioDobleTributacion.Enabled = False
            cboRetencionNormaLegal.Enabled = False
        Else
            cboPaisPago.Enabled = True
            cboPagoRegimenMenor.Enabled = True
            cboConvenioDobleTributacion.Enabled = True
            cboRetencionNormaLegal.Enabled = True
        End If
    End Sub

    Private Sub cboTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoComprobante.SelectedIndexChanged
        If cboTipoComprobante.Text = "04-Nota de crédito" Or cboTipoComprobante.Text = "05-Nota de débito" Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub cmdImportarRetencion_Click(sender As Object, e As EventArgs) Handles cmdImportarRetencion.Click
        InputBox("Ingrese la Clave de Acceso")
    End Sub
End Class