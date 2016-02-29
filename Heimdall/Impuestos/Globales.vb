Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging

Module Globales
    Public gloConexion As MySqlConnection
    Public gloUsuario As String
    Public gloTienePermisos As Integer
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

    Public Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("f1")
        Next
        Return strResult

    End Function

    Public Function GenerarNombre() As String
        Dim xCharArray() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray
        Dim xNoArray() As Char = "0123456789".ToCharArray
        Dim xGenerator As System.Random = New System.Random()
        Dim xStr As String = String.Empty
        While xStr.Length < 6
            If xGenerator.Next(0, 2) = 0 Then
                xStr &= xCharArray(xGenerator.Next(0, xCharArray.Length))
            Else
                xStr &= xNoArray(xGenerator.Next(0, xNoArray.Length))
            End If
        End While
        Return xStr
    End Function

    Public Function BmpToBytes_MemStream(bmp As Bitmap) As Byte()
        Dim MS As MemoryStream = New MemoryStream()
        bmp.Save(MS, ImageFormat.Jpeg)
        Dim bmpBytes As Byte() = MS.GetBuffer()
        bmp.Dispose()
        MS.Close()
        Return bmpBytes
    End Function


End Module
