<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreMensual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCerrarMes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Spr = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtIdMesActual = New System.Windows.Forms.TextBox()
        Me.txtNombreMesActual = New System.Windows.Forms.TextBox()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mes a Cerrar:"
        '
        'cmdCerrarMes
        '
        Me.cmdCerrarMes.Location = New System.Drawing.Point(322, 220)
        Me.cmdCerrarMes.Name = "cmdCerrarMes"
        Me.cmdCerrarMes.Size = New System.Drawing.Size(75, 31)
        Me.cmdCerrarMes.TabIndex = 4
        Me.cmdCerrarMes.Text = "Cerrar Mes"
        Me.cmdCerrarMes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Meses Cerrados:"
        '
        'Spr
        '
        Me.Spr.AllowUserToAddRows = False
        Me.Spr.AllowUserToDeleteRows = False
        Me.Spr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Spr.Location = New System.Drawing.Point(104, 37)
        Me.Spr.Name = "Spr"
        Me.Spr.ReadOnly = True
        Me.Spr.Size = New System.Drawing.Size(293, 164)
        Me.Spr.TabIndex = 32
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripButton, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(420, 25)
        Me.ToolStrip1.TabIndex = 33
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Ayuda"
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
        'txtIdMesActual
        '
        Me.txtIdMesActual.Location = New System.Drawing.Point(104, 226)
        Me.txtIdMesActual.Name = "txtIdMesActual"
        Me.txtIdMesActual.ReadOnly = True
        Me.txtIdMesActual.Size = New System.Drawing.Size(49, 20)
        Me.txtIdMesActual.TabIndex = 34
        '
        'txtNombreMesActual
        '
        Me.txtNombreMesActual.Location = New System.Drawing.Point(159, 226)
        Me.txtNombreMesActual.Name = "txtNombreMesActual"
        Me.txtNombreMesActual.ReadOnly = True
        Me.txtNombreMesActual.Size = New System.Drawing.Size(145, 20)
        Me.txtNombreMesActual.TabIndex = 35
        '
        'frmCierreMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNombreMesActual)
        Me.Controls.Add(Me.txtIdMesActual)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Spr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCerrarMes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCierreMensual"
        Me.Text = "Cierre de Mes"
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCerrarMes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Spr As DataGridView
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtIdMesActual As TextBox
    Friend WithEvents txtNombreMesActual As TextBox
End Class
