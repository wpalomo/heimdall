<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAyuda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(124, 121)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(220, 20)
        Me.txtCiudad.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Ciudad:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(124, 147)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(220, 50)
        Me.txtDireccion.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Dirección:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(124, 95)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Identificación:"
        '
        'cboTipoIdentificacion
        '
        Me.cboTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoIdentificacion.FormattingEnabled = True
        Me.cboTipoIdentificacion.Items.AddRange(New Object() {"01-RUC", "02-CEDULA", "03-PASAPORTE / IDENTIFICACIÓN TRIBUTARIA DEL EXTERIOR"})
        Me.cboTipoIdentificacion.Location = New System.Drawing.Point(124, 69)
        Me.cboTipoIdentificacion.Name = "cboTipoIdentificacion"
        Me.cboTipoIdentificacion.Size = New System.Drawing.Size(220, 21)
        Me.cboTipoIdentificacion.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo Identificación:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(124, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(309, 20)
        Me.txtNombre.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.cmdBuscar, Me.cmdGuardar, Me.toolStripSeparator, Me.cmdAyuda, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(469, 25)
        Me.ToolStrip1.TabIndex = 34
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
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(23, 22)
        Me.cmdBuscar.Text = "ToolStripButton1"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(23, 22)
        Me.cmdGuardar.Text = "Guardar"
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
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(124, 203)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Teléfono:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(285, 203)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 35
        Me.txtID.Visible = False
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 250)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboTipoIdentificacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmProveedor"
        Me.Text = "Proveedores"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTipoIdentificacion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents cmdGuardar As ToolStripButton
    Friend WithEvents cmdAyuda As ToolStripButton
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmdBuscar As ToolStripButton
End Class
