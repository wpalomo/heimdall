Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVariablesGlobales()
        Dim f As New frmLogin
        f.ShowDialog()
        statusUsuario.Text = gloUsuario
        statusSucursal.Text = "Matriz"
        statusMes.Text = gloMesActualNombre
    End Sub

    Private Sub CierreDeMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeMesToolStripMenuItem.Click
        Dim f As New frmCierreMensual
        f.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿ Desea salir del sistema ?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ParámetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParámetrosToolStripMenuItem.Click
        If gloTienePermisos Then
            Dim f As New frmParametros
            f.ShowDialog()
        Else
            MsgBox("No tiene permiso para esta opción", vbExclamation)
        End If

    End Sub

    Private Sub ExportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportacionesToolStripMenuItem.Click
        Dim f As New frmExportaciones
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub ATSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATSToolStripMenuItem.Click
        InputBox("Ingrese Mes [1-12] para generar ATS", "Generar ATS")
        GenerarATS()
    End Sub

    Private Sub ImportarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarVentasToolStripMenuItem.Click
        If gloTienePermisos Then
            Dim f As New frmImportarVentas
            f.MdiParent = Me
            f.Show()
        Else
            MsgBox("No tiene permiso para esta opción", vbExclamation)
        End If

    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim f As New frmCompras
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim f As New frmProveedor
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim f As New frmCliente
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoDeProveedoresToolStripMenuItem1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim cmd As New MySqlCommand("select * from proveedores", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            rptListadoProveedores(dt)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteProveedores", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim cmd As New MySqlCommand("select * from clientes", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            rptListadoClientes(dt)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=reporteClientes", vbCritical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RegistrosDeExportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeExportacionesToolStripMenuItem.Click
        Dim f As New frmRpExportaciones
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub RegistrosDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeCompraToolStripMenuItem.Click
        Dim f As New frmRpCompras
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click
        MsgBox("Si tiene algun inconveniente, envíe un correo a dvinces@gmail.com" + vbCrLf + "con la Captura de Pantall", vbInformation)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub RegistrosDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeVentasToolStripMenuItem.Click
        Dim f As New frmRpVentas
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub DescargarXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)


        Try
            Dim objReader As New StreamReader("C:\UNAEP\claves.txt")

            Dim ws As New facturaE.eFactura.WebService
            Dim ca As String = ""
            stProBar.Visible = True
            stProBar.Minimum = 0
            Dim contador As Integer = 0
            Do
                ca = objReader.ReadLine()
                contador += 1
            Loop Until ca Is Nothing
            objReader.Close()
            stProBar.Maximum = contador
            contador = 0

            objReader = New StreamReader("C:\UNAEP\claves.txt")
            Dim objWriter As New StreamWriter("C:\Users\David\Desktop\SUSANITA\" + "\procesadas.txt")
            Do
                ca = objReader.ReadLine()
                If Not ca Is Nothing Then
                    Dim k As New facturaE.RespuestaSRYType
                    k = ws.SendClaveAcceso(ca, "C:\Users\David\Desktop\SUSANITA\" + "\xml\" + ca + ".xml")
                    If k = facturaE.RespuestaSRYType.AUTORIZADO Then
                        objWriter.WriteLine()
                    End If
                    contador += 1
                    stProBar.Value = contador
                End If
            Loop Until ca Is Nothing
            objWriter.Close()
            objReader.Close()

            MsgBox("finalizado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AdministrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarUsuariosToolStripMenuItem.Click
        If gloTienePermisos Then
            Dim f As New frmAdministrarUsuarios
            f.ShowDialog()
        Else
            MsgBox("No tiene permiso para esta opción", vbExclamation)
        End If
    End Sub

    Private Sub CambiarMiClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarMiClaveToolStripMenuItem.Click
        Dim f As New frmCambiarClave
        f.ShowDialog()

    End Sub

    Private Sub Formulario101ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario101ToolStripMenuItem.Click

    End Sub

    Private Sub Formulario103ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario103ToolStripMenuItem.Click

    End Sub

    Private Sub Formulario104ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario104ToolStripMenuItem.Click

    End Sub
End Class