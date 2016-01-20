Imports MySql.Data.MySqlClient

Public Class frmBuscarCliente
    Private Sub txtBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            Try
                Dim cmd As New MySqlCommand("select identificacion, nombres, tipo_identificacion from clientes where nombres LIKE '%" + txtBusqueda.Text + "%' or identificacion LIKE '%" + txtBusqueda.Text + "%';", gloConexion)
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                Spr.DataSource = dt
                Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=buscarCliente", vbCritical)
            End Try
        End If
    End Sub


    Private Sub Spr_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Spr.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        Else
            gloSelectedClientID = Spr(0, e.RowIndex).Value.ToString()
            gloSelectedClientName = Spr(1, e.RowIndex).Value.ToString()
            gloSelectedClientType = Spr(2, e.RowIndex).Value.ToString()
            Me.Close()
        End If

    End Sub

    Private Sub Spr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Spr.CellContentClick

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

    End Sub
End Class