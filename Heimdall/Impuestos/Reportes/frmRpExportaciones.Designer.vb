﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpExportaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpExportaciones))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAyuda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.Spr = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblMensajeExportaciones = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.toolStripSeparator, Me.cmdAyuda, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(630, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(23, 22)
        Me.cmdNuevo.Text = "Nuevo"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'cmdAyuda
        '
        Me.cmdAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(23, 22)
        Me.cmdAyuda.Text = "Ayuda"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(23, 22)
        Me.cmdSalir.Text = "Salir"
        '
        'Spr
        '
        Me.Spr.AllowUserToAddRows = False
        Me.Spr.AllowUserToDeleteRows = False
        Me.Spr.AllowUserToOrderColumns = True
        Me.Spr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Spr.Location = New System.Drawing.Point(12, 106)
        Me.Spr.Name = "Spr"
        Me.Spr.ReadOnly = True
        Me.Spr.Size = New System.Drawing.Size(606, 261)
        Me.Spr.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Desde:"
        '
        'txtDesde
        '
        Me.txtDesde.CustomFormat = "yyyy-MM-dd"
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDesde.Location = New System.Drawing.Point(63, 37)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(101, 20)
        Me.txtDesde.TabIndex = 31
        '
        'txtHasta
        '
        Me.txtHasta.CustomFormat = "yyyy-MM-dd"
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtHasta.Location = New System.Drawing.Point(63, 63)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(101, 20)
        Me.txtHasta.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Hasta:"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(414, 46)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(75, 37)
        Me.cmdGenerar.TabIndex = 36
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(543, 46)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(75, 37)
        Me.cmdExportar.TabIndex = 37
        Me.cmdExportar.Text = "Exportar Excel"
        Me.cmdExportar.UseVisualStyleBackColor = True
        Me.cmdExportar.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMensajeExportaciones})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 372)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(630, 22)
        Me.StatusStrip1.TabIndex = 38
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMensajeExportaciones
        '
        Me.lblMensajeExportaciones.Name = "lblMensajeExportaciones"
        Me.lblMensajeExportaciones.Size = New System.Drawing.Size(0, 17)
        '
        'frmRpExportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 394)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Spr)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "frmRpExportaciones"
        Me.Text = "Reporte de Exportaciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents cmdAyuda As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents Spr As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesde As DateTimePicker
    Friend WithEvents txtHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdGenerar As Button
    Friend WithEvents cmdExportar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblMensajeExportaciones As ToolStripStatusLabel
End Class
