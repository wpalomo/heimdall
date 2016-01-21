Public Class frmComprasRetenciones
    Public Spr As DataGridView

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cboCodigoRetencion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoRetencion.SelectedIndexChanged
        Dim lista As String() = cboCodigoRetencion.Text.Split("-")
        txtPorcentaje.Text = lista(lista.Length - 1).Trim

    End Sub

    Private Sub txtBaseImponible_TextChanged(sender As Object, e As EventArgs) Handles txtBaseImponible.TextChanged
        If IsNumeric(txtBaseImponible.Text) Then
            txtMonto.Text = Decimal.Round(CDec(txtBaseImponible.Text) * CDec(txtPorcentaje.Text.Replace("%", "") / 100), 2).ToString
        Else
            txtMonto.Text = 0.00
        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim lista As String() = cboCodigoRetencion.Text.Split("-")
        Spr.Rows.Add(lista(0).Trim, lista(1).Trim, txtBaseImponible.Text, lista(2).Replace("%", "").Trim, txtMonto.Text)
        Me.Close()

    End Sub
End Class