<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrosDeExportacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusSucursal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerarATSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ReportesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParámetrosToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ParámetrosToolStripMenuItem.Text = "Parámetros"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusMes, Me.ToolStripStatusLabel1, Me.statusSucursal, Me.ToolStripStatusLabel2, Me.statusUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(740, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.VentasToolStripMenuItem1, Me.ExportacionesToolStripMenuItem, Me.ToolStripMenuItem4, Me.ProveedoresToolStripMenuItem1, Me.ClientesToolStripMenuItem1})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'ExportacionesToolStripMenuItem
        '
        Me.ExportacionesToolStripMenuItem.Name = "ExportacionesToolStripMenuItem"
        Me.ExportacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportacionesToolStripMenuItem.Text = "Exportaciones"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CierreDeMesToolStripMenuItem, Me.ToolStripMenuItem1, Me.GenerarATSToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeProveedoresToolStripMenuItem1, Me.RegistrosDeCompraToolStripMenuItem, Me.ToolStripMenuItem2, Me.ListadoDeClientesToolStripMenuItem, Me.RegistrosDeVentasToolStripMenuItem, Me.ToolStripMenuItem3, Me.RegistrosDeExportacionesToolStripMenuItem})
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'ListadoDeProveedoresToolStripMenuItem1
        '
        Me.ListadoDeProveedoresToolStripMenuItem1.Name = "ListadoDeProveedoresToolStripMenuItem1"
        Me.ListadoDeProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.ListadoDeProveedoresToolStripMenuItem1.Text = "Listado de Proveedores"
        '
        'RegistrosDeCompraToolStripMenuItem
        '
        Me.RegistrosDeCompraToolStripMenuItem.Name = "RegistrosDeCompraToolStripMenuItem"
        Me.RegistrosDeCompraToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RegistrosDeCompraToolStripMenuItem.Text = "Registros de Compra"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(211, 6)
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'RegistrosDeVentasToolStripMenuItem
        '
        Me.RegistrosDeVentasToolStripMenuItem.Name = "RegistrosDeVentasToolStripMenuItem"
        Me.RegistrosDeVentasToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RegistrosDeVentasToolStripMenuItem.Text = "Registros de Ventas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(211, 6)
        '
        'RegistrosDeExportacionesToolStripMenuItem
        '
        Me.RegistrosDeExportacionesToolStripMenuItem.Name = "RegistrosDeExportacionesToolStripMenuItem"
        Me.RegistrosDeExportacionesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RegistrosDeExportacionesToolStripMenuItem.Text = "Registros de Exportaciones"
        '
        'CierreDeMesToolStripMenuItem
        '
        Me.CierreDeMesToolStripMenuItem.Name = "CierreDeMesToolStripMenuItem"
        Me.CierreDeMesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CierreDeMesToolStripMenuItem.Text = "Cierre de Mes"
        '
        'statusMes
        '
        Me.statusMes.Name = "statusMes"
        Me.statusMes.Size = New System.Drawing.Size(44, 17)
        Me.statusMes.Text = "ENERO"
        '
        'statusSucursal
        '
        Me.statusSucursal.Name = "statusSucursal"
        Me.statusSucursal.Size = New System.Drawing.Size(40, 17)
        Me.statusSucursal.Text = "Matriz"
        '
        'statusUsuario
        '
        Me.statusUsuario.Name = "statusUsuario"
        Me.statusUsuario.Size = New System.Drawing.Size(52, 17)
        Me.statusUsuario.Text = "evillegas"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel1.Text = "     "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel2.Text = "     "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'GenerarATSToolStripMenuItem
        '
        Me.GenerarATSToolStripMenuItem.Name = "GenerarATSToolStripMenuItem"
        Me.GenerarATSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerarATSToolStripMenuItem.Text = "Generar ATS"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 416)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "HEIMDALL :: Impuestos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParámetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExportacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreDeMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistrosDeCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents RegistrosDeExportacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusMes As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents statusSucursal As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents statusUsuario As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarATSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
End Class
