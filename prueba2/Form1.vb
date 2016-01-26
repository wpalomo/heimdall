Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ws As New facturaE.WebServiceSRI.WebService
            ws.SendClaveAcceso("0112201501176817399000120012100000002861234567813", "C:\test-sri\test.xml")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
