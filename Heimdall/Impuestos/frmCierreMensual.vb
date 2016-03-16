Imports MySql.Data.MySqlClient

Public Class frmCierreMensual
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCierreMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarSpr()
    End Sub

    Private Sub llenarSpr()
        Try
            Dim cmd As New MySqlCommand("select mes, fecha_cierre from cierre_mes where estado=2", gloConexion)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                Spr.DataSource = dt
                Spr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Spr.Columns(0).HeaderText = "Mes"
                Spr.Columns(1).HeaderText = "Fecha de Cierre"
            End If

            cmd.CommandText = "select id, mes from cierre_mes where estado=1"
            Dim dt2 As New DataTable
            dt2.Load(cmd.ExecuteReader)
            If dt2.Rows.Count > 0 Then
                txtIdMesActual.Text = dt2.Rows(0)("id").ToString
                txtNombreMesActual.Text = dt2.Rows(0)("mes").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + vbCrLf + "funcion=llenarSpr", vbCritical)
        End Try
    End Sub

    Private Sub cmdCerrarMes_Click(sender As Object, e As EventArgs) Handles cmdCerrarMes.Click
        If MsgBox("¿ Desea cerrar " + txtNombreMesActual.Text.ToUpper + " ?", vbYesNo + vbQuestion) = vbYes Then
            Try
                'Poner el mes actual como cerrado
                Dim cmd As New MySqlCommand("update cierre_mes set estado=2, fecha_cierre=@fecha where id=@id", gloConexion)
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = CInt(txtIdMesActual.Text)
                cmd.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = DateTime.Now
                cmd.ExecuteNonQuery()

                'Poner el mes siguiente como actual
                Dim cmx As New MySqlCommand("update cierre_mes set estado=1 where id=@id", gloConexion)
                cmx.Parameters.Add("@id", MySqlDbType.Int32).Value = CInt(txtIdMesActual.Text) + 1
                cmx.ExecuteNonQuery()
                MsgBox("Se ha cerrado " + txtNombreMesActual.Text.ToUpper, vbInformation)

                llenarSpr()
                CargarMesActual()
                frmPrincipal.statusMes.Text = gloMesActualNombre
                cmdCerrarMes.Enabled = False

            Catch ex As Exception
                MsgBox("" + vbCrLf + ex.Message, vbExclamation)
            End Try





        End If
    End Sub
End Class