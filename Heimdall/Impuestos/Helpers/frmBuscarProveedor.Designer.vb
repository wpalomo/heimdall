<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Spr = New System.Windows.Forms.DataGridView()
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUC, Cédula o Nombre:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(15, 25)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(422, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'Spr
        '
        Me.Spr.AllowUserToAddRows = False
        Me.Spr.AllowUserToDeleteRows = False
        Me.Spr.AllowUserToOrderColumns = True
        Me.Spr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Spr.Location = New System.Drawing.Point(15, 51)
        Me.Spr.Name = "Spr"
        Me.Spr.ReadOnly = True
        Me.Spr.Size = New System.Drawing.Size(422, 317)
        Me.Spr.TabIndex = 2
        '
        'frmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.Spr)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBuscarProveedor"
        Me.Text = "Buscar Proveedor"
        CType(Me.Spr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Spr As DataGridView
End Class
