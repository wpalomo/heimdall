﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprasRetenciones
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
        Me.cboCodigoRetencion = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtBaseImponible = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCodigoRetencion
        '
        Me.cboCodigoRetencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodigoRetencion.FormattingEnabled = True
        Me.cboCodigoRetencion.Items.AddRange(New Object() {"01-PAGO A RESIDENTE", "02-PAGO A NO RESIDENTE"})
        Me.cboCodigoRetencion.Location = New System.Drawing.Point(153, 16)
        Me.cboCodigoRetencion.Name = "cboCodigoRetencion"
        Me.cboCodigoRetencion.Size = New System.Drawing.Size(375, 21)
        Me.cboCodigoRetencion.TabIndex = 84
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(24, 19)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(123, 13)
        Me.Label37.TabIndex = 83
        Me.Label37.Text = "Concepto de Retención:"
        '
        'txtBaseImponible
        '
        Me.txtBaseImponible.Location = New System.Drawing.Point(153, 43)
        Me.txtBaseImponible.Name = "txtBaseImponible"
        Me.txtBaseImponible.Size = New System.Drawing.Size(100, 20)
        Me.txtBaseImponible.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Base Imponible Renta:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(153, 69)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentaje.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Porcentaje Retención:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(153, 95)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Monto de Retención:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(393, 91)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(73, 26)
        Me.cmdCancelar.TabIndex = 95
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(299, 91)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(73, 26)
        Me.cmdAceptar.TabIndex = 94
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'frmComprasRetenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBaseImponible)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCodigoRetencion)
        Me.Controls.Add(Me.Label37)
        Me.Name = "frmComprasRetenciones"
        Me.Text = "Agregar Retención en la Fuente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCodigoRetencion As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtBaseImponible As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdAceptar As Button
End Class
