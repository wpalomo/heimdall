Imports MySql.Data.MySqlClient
Module Globales
    Public gloConexion As MySqlConnection
    Public gloRuta As String
    Public gloUsuario As String
    Public gloMesActual As Integer
    Public gloMesActualNombre As String

    ' Transaccionales
    Public gloSelectedClientID As String
    Public gloSelectedClientName As String
    Public gloSelectedClientType As String
    Public gloSelectedSupplierID As String
    Public gloSelectedSupplierName As String
    Public gloSelectedSupplierType As String

    Public Sub CargarVariablesGlobales()
        Try
            Dim vCon = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\UNAEP\Impuestos\", "Conexion", Nothing)
            gloRuta = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\UNAEP\Impuestos\", "Ruta", Nothing)

            If IsNothing(vCon) Then
                MsgBox("No ha definido las claves en el registro", vbExclamation)
                Application.Exit()
            Else
                AbrirConexion(vCon)
                CargarMesActual()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=CargarVariablesGlobales", vbCritical)
        End Try

    End Sub
    Private Sub CargarMesActual()
        Try
            Dim cmd As New MySqlCommand("select id, mes from cierre_mes where estado=1;", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            gloMesActual = dt.Rows(0)("id").ToString
            gloMesActualNombre = dt.Rows(0)("mes").ToString
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=CargarMesActual", vbCritical)
        End Try
    End Sub
    Public Sub AbrirConexion(conexion As String)
        Try
            gloConexion = New MySqlConnection(conexion)
            gloConexion.Open()

            gloMesActual = 1
            gloMesActualNombre = "ENERO"

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=AbrirConexion", vbCritical)
        End Try

    End Sub

End Module
