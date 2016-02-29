<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRpCompras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpCompras))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAyuda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.cboUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Spr = New System.Windows.Forms.DataGridView()
        Me.stComBar = New System.Windows.Forms.StatusStrip()
        Me.lblMensajeCompras = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stComBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.toolStripSeparator, Me.cmdAyuda, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(727, 25)
        Me.ToolStrip1.TabIndex = 38
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
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(640, 49)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(75, 37)
        Me.cmdExportar.TabIndex = 47
        Me.cmdExportar.Text = "Exportar Excel"
        Me.cmdExportar.UseVisualStyleBackColor = True
        Me.cmdExportar.Visible = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(380, 49)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(75, 37)
        Me.cmdGenerar.TabIndex = 46
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'cboUsuarios
        '
        Me.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuarios.FormattingEnabled = True
        Me.cboUsuarios.Items.AddRange(New Object() {"Todos"})
        Me.cboUsuarios.Location = New System.Drawing.Point(256, 39)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Size = New System.Drawing.Size(92, 21)
        Me.cboUsuarios.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Usuario:"
        '
        'txtHasta
        '
        Me.txtHasta.CustomFormat = "yyyy-MM-dd"
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtHasta.Location = New System.Drawing.Point(64, 66)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(101, 20)
        Me.txtHasta.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.CustomFormat = "yyyy-MM-dd"
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDesde.Location = New System.Drawing.Point(64, 40)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(101, 20)
        Me.txtDesde.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Desde:"
        '
        'Spr
        '
        Me.Spr.AllowUserToAddRows = False
        Me.Spr.AllowUserToDeleteRows = False
        Me.Spr.AllowUserToOrderColumns = True
        Me.Spr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Spr.Location = New System.Drawing.Point(12, 103)
        Me.Spr.Name = "Spr"
        Me.Spr.ReadOnly = True
        Me.Spr.Size = New System.Drawing.Size(703, 304)
        Me.Spr.TabIndex = 39
        '
        'stComBar
        '
        Me.stComBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMensajeCompras})
        Me.stComBar.Location = New System.Drawing.Point(0, 414)
        Me.stComBar.Name = "stComBar"
        Me.stComBar.Size = New System.Drawing.Size(727, 22)
        Me.stComBar.TabIndex = 48
        Me.stComBar.Text = "StatusStrip1"
        '
        'lblMensajeCompras
        '
        Me.lblMensajeCompras.Name = "lblMensajeCompras"
        Me.lblMensajeCompras.Size = New System.Drawing.Size(0, 17)
        '
        'frmRpCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 436)
        Me.Controls.Add(Me.stComBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.cboUsuarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Spr)
        Me.MaximizeBox = False
        Me.Name = "frmRpCompras"
        Me.Text = "Reporte de Compras"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stComBar.ResumeLayout(False)
        Me.stComBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdExportar As Button
    Friend WithEvents cmdGenerar As Button
    Friend WithEvents cboUsuarios As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Spr As DataGridView
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdAyuda As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents stComBar As StatusStrip
    Friend WithEvents lblMensajeCompras As ToolStripStatusLabel
End Class
