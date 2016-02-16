Imports MySql.Data.MySqlClient

Public Class frmCambiarClave
    Private Sub frmCambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = gloUsuario

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New MySqlCommand("select * from usuarios where user='" + txtUsuario.Text + "' and pwd='" + getSHA1Hash(txtContraseña.Text) + "';", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                cmd.CommandText = "update usuarios set pwd='" + getSHA1Hash(txtNuevaContraseña.Text) + "' where user='" + txtUsuario.Text + "';"
                cmd.ExecuteNonQuery()
                MsgBox("Contraseña Cambiada", vbInformation)
            Else
                MsgBox("Combinación de usuario y contraseña errónea", vbCritical)
                txtContraseña.ResetText()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=login", vbCritical)
        End Try

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub
End Class