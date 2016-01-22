Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private isLogin As Integer = 0

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim cmd As New MySqlCommand("select * from usuarios where user='" + txtUsuario.Text + "' and pwd='" + getSHA1Hash(txtContraseña.Text) + "';", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                gloUsuario = txtUsuario.Text
                isLogin = 1
                Me.Close()
            Else
                MsgBox("Combinación de usuario y contraseña errónea", vbCritical)
                txtContraseña.ResetText()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=login", vbCritical)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If isLogin = 0 Then
            Application.Exit()
        End If
    End Sub
End Class