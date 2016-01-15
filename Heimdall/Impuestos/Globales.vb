Imports MySql.Data.MySqlClient
Module Globales
    Public gloConexion As MySqlConnection
    Public gloConexionImport As MySqlConnection
    Public gloUsuario As String

    Public Sub AbrirConexion()
        Try
            gloConexion = New MySqlConnection("Server=181.198.55.114;Database=heimdall;Uid=root;Pwd=Kristina20*;")
            gloConexion.Open()

            gloConexionImport = New MySqlConnection("Server=181.198.55.114;Database=impuestos;Uid=root;Pwd=Kristina20*;")
            gloConexionImport.Open()

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=AbrirConexion", vbCritical)
        End Try


    End Sub

End Module
