<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cboCodigoRetencion.Items.AddRange(New Object() {"303 - HONORARIOS PROFESIONALES Y DEMAS PAGOS POR SERVICIOS RELACIONADOS CON EL TI" &
                "TULO PROFESIONAL - 10%", "304 - SERVICIOS PREDOMINA EL INTELECTO NO RELACIONADOS CON EL TITULO PROFESIONAL " &
                "- 8%", "304A - COMISIONES Y DEMAS PAGOS POR SERVICIOS PREDOMINA INTELECTO NO RELACIONADOS" &
                " CON EL TITULO PROFESIONAL - 8%", "304B - PAGOS A NOTARIOS Y REGISTRADORES DE LA PROPIEDAD Y MERCANTIL POR SUS ACTIV" &
                "IDADES EJERCIDAS COMO TALES - 8%", "304C - PAGOS A DEPORTISTAS, ENTRENADORES, ARBITROS,  MIEMBROS DEL CUERPO TECNICO " &
                "POR SUS ACTIVIDADES EJERCIDAS COMO TALES - 8%", "304D - PAGOS A ARTISTAS POR SUS ACTIVIDADES EJERCIDAS COMO TALES - 8%", "304E - HONORARIOS Y DEMAS PAGOS POR SERVICIOS DE DOCENCIA - 8%", "307 - SERVICIOS PREDOMINA LA MANO DE OBRA - 2%", "308 - UTILIZACION O APROVECHAMIENTO DE LA IMAGEN O RENOMBRE - 10%", "309 - SERVICIOS PRESTADOS POR MEDIOS DE COMUNICACION Y AGENCIAS DE PUBLICIDAD - 1" &
                "%", "310 - SERVICIO DE TRANSPORTE PRIVADO DE PASAJEROS O TRANSPORTE PUBLICO O PRIVADO " &
                "DE CARGA - 1%", "311 - POR PAGOS A TRAVES DE LIQUIDACION DE COMPRA (NIVEL CULTURAL O RUSTICIDAD) -" &
                " 2%", "312 - TRANSFERENCIA DE BIENES MUEBLES DE NATURALEZA CORPORAL - 1%", "312A - COMPRA DE BIENES DE ORIGEN AGRICOLA, AVICOLA, PECUARIO, APICOLA, CUNICULA," &
                " BIOACUATICO Y FORESTAL - 1%", "314A - REGALIAS POR CONCEPTO DE FRANQUICIAS DE ACUERDO A LEY DE PROPIEDAD INTELEC" &
                "TUAL  PAGO A PERSONAS NATURALES - 8%", "314B - CANONES,  DERECHOS DE AUTOR,  MARCAS,  PATENTES Y SIMILARES DE ACUERDO A L" &
                "EY DE PROPIEDAD INTELECTUAL  PAGO A PERSONAS NATURALES - 8%", "314C - REGALIAS POR CONCEPTO DE FRANQUICIAS DE ACUERDO A LEY DE PROPIEDAD INTELEC" &
                "TUAL  PAGO A SOCIEDADES - 8%", "314D - CANONES,  DERECHOS DE AUTOR, MARCAS,  PATENTES Y SIMILARES DE ACUERDO A LE" &
                "Y DE PROPIEDAD INTELECTUAL  PAGO A SOCIEDADES - 8%", "319 - CUOTAS DE ARRENDAMIENTO MERCANTIL,  INCLUSIVE LA DE OPCION DE COMPRA - 1%", "320 - POR ARRENDAMIENTO BIENES INMUEBLES - 8%", "322 - SEGUROS Y REASEGUROS (PRIMAS Y CESIONES) - 1%", "323 - POR RENDIMIENTOS FINANCIEROS PAGADOS A NATURALES Y SOCIEDADES  (NO A IFIS) " &
                "- 2%", "323A - POR RF: DEPOSITOS CTA. CORRIENTE - 2%", "323B1 - POR RF:  DEPOSITOS CTA. AHORROS SOCIEDADES - 2%", "323E - POR RF: DEPOSITO A PLAZO FIJO GRAVADOS - 2%", "323E2 - POR RF: DEPOSITO A PLAZO FIJO EXENTOS - 2%", "323F - POR RENDIMIENTOS FINANCIEROS: OPERACIONES DE REPORTO  REPOS - 2%", "323G - POR RF: INVERSIONES (CAPTACIONES) RENDIMIENTOS DISTINTOS DE AQUELLOS PAGAD" &
                "OS A IFIS - 2%", "323H - POR RF: OBLIGACIONES - 2%", "323I - POR RF: BONOS CONVERTIBLE EN ACCIONES - 2%", "323M - POR RF: INVERSIONES EN TITULOS VALORES EN RENTA FIJA GRAVADOS - 2%", "323N - POR RF: INVERSIONES EN TITULOS VALORES EN RENTA FIJA EXENTOS - 2%", "323O - POR RF: INTERESES PAGADOS A BANCOS Y OTRAS ENTIDADES SOMETIDAS AL CONTROL " &
                "DE LA SUPERINTENDENCIA DE BANCOS Y DE LA EPS - 2%", "323P - POR RF: INTERESES PAGADOS POR ENTIDADES DEL SECTOR PUBLICO A FAVOR DE SUJE" &
                "TOS PASIVOS - 2%", "323Q - POR RF: OTROS INTERESES Y RENDIMIENTOS FINANCIEROS GRAVADOS - 2%", "323R - POR RF: OTROS INTERESES Y RENDIMIENTOS FINANCIEROS EXENTOS - 2%", "324A - POR RF: INTERESES EN OPERACIONES DE CREDITO ENTRE INSTITUCIONES DEL SISTEM" &
                "A FINANCIERO Y ENTIDADES ECONOMIA POPULAR Y SOLIDARIA. - 1%", "324B - POR RF: POR INVERSIONES ENTRE INSTITUCIONES DEL SISTEMA FINANCIERO Y ENTID" &
                "ADES ECONOMIA POPULAR Y SOLIDARIA. - 1%", "325 - ANTICIPO DIVIDENDOS - 22%", "325A - DIVIDENDOS ANTICIPADOS PRESTAMOS ACCIONISTAS,  BENEFICIARIOS O PARTICIPES " &
                "- 22%", "326 - DIVIDENDOS DISTRIBUIDOS QUE CORRESPONDAN AL IMPUESTO A LA RENTA UNICO ESTAB" &
                "LECIDO EN EL ART. 27 DE LA LRTI - 0%", "327 - DIVIDENDOS DISTRIBUIDOS A PERSONAS NATURALES RESIDENTES - 0%", "328 - DIVIDENDOS DISTRIBUIDOS A SOCIEDADES RESIDENTES - 0%", "329 - DIVIDENDOS DISTRIBUIDOS A FIDEICOMISOS RESIDENTES - 0%", "330 - DIVIDENDOS GRAVADOS DISTRIBUIDOS EN ACCIONES (REINVERSION DE UTILIDADES SIN" &
                " DERECHO A REDUCCION TARIFA IR) - 0%", "331 - DIVIDENDOS EXENTOS DISTRIBUIDOS EN ACCIONES (REINVERSION DE UTILIDADES CON " &
                "DERECHO A REDUCCION TARIFA IR) - 0%", "332 - OTRAS COMPRAS DE BIENES Y SERVICIOS NO SUJETAS A RETENCION - 0%", "332A - POR LA ENAJENACION OCASIONAL DE ACCIONES O PARTICIPACIONES Y TITULOS VALOR" &
                "ES - 0%", "332B - COMPRA DE BIENES INMUEBLES - 0%", "332C - TRANSPORTE PUBLICO DE PASAJEROS - 0%", "332D - PAGOS EN EL PAIS POR TRANS. DE PASAJ O TRANS. INTERN. DE CARGA,  A CIAS NA" &
                "CIONALES O EXTRANJERAS DE AVIACION O MARITIMAS - 0%", "332E - VALORES ENTREGADOS POR LAS COOPERATIVAS DE TRANSPORTE A SUS SOCIOS - 0%", "332F - COMPRAVENTA DE DIVISAS DISTINTAS AL DOLAR DE LOS ESTADOS UNIDOS DE AMERICA" &
                " - 0%", "332G - PAGOS CON TARJETA DE CREDITO - 0%", "332H - PAGO AL EXTERIOR TARJETA DE CREDITO REPORTADA POR LA EMISORA DE TARJETA DE" &
                " CREDITO,  SOLO RECAP - 0%", "333 - ENAJENACION DE DERECHOS REPRESENTATIVOS DE CAPITAL Y OTROS DERECHOS COTIZAD" &
                "OS EN BOLSA ECUATORIANA - 0.2%", "334 - ENAJENACION DE DERECHOS REPRESENTATIVOS DE CAPITAL Y OTROS DERECHOS NO COTI" &
                "ZADOS EN BOLSA ECUATORIANA - 1%", "335 - POR LOTERIAS,  RIFAS,  APUESTAS Y SIMILARES - 15%", "336 - POR VENTA DE COMBUSTIBLES A COMERCIALIZADORAS - 0.2%", "337 - POR VENTA DE COMBUSTIBLES A DISTRIBUIDORES - 0.3%", "338 - COMPRA LOCAL DE BANANO A PRODUCTOR - 0%", "339 - LIQUIDACION IMPUESTO UNICO A LA VENTA LOCAL DE BANANO DE PRODUCCION PROPIA " &
                "- 0%", "340 - IMPUESTO UNICO A LA EXPORTACION DE BANANO DE PRODUCCION PROPIA  COMPONENTE " &
                "1 - 0%", "341 - IMPUESTO UNICO A LA EXPORTACION DE BANANO DE PRODUCCION PROPIA  COMPONENTE " &
                "2 - 0%", "342 - IMPUESTO UNICO A LA EXPORTACION DE BANANO PRODUCIDO POR TERCEROS - 0%", "343A - POR ENERGIA ELECTRICA - 1%", "343B - POR ACTIVIDADES DE CONSTRUCCION DE OBRA MATERIAL INMUEBLE,  URBANIZACION, " &
                " LOTIZACION O ACTIVIDADES SIMILARES - 1%", "344 - OTRAS RETENCIONES APLICABLES EL 2% - 2%", "344A - PAGO LOCAL TARJETA DE CREDITO REPORTADA POR LA EMISORA DE TARJETA DE CREDI" &
                "TO,  SOLO RECAP - 2%", "346A - GANANCIAS DE CAPITAL - 0%", "500 - PAGO AL EXTERIOR  RENTAS INMOBILIARIAS - 0%", "501 - PAGO AL EXTERIOR  BENEFICIOS EMPRESARIALES - 0%", "502 - PAGO AL EXTERIOR  SERVICIOS EMPRESARIALES - 0%", "503 - PAGO AL EXTERIOR  NAVEGACION MARITIMA Y/O AEREA - 0%", "504 - PAGO AL EXTERIOR DIVIDENDOS DISTRIBUIDOS A PERSONAS NATURALES - 0%", "504A - PAGO AL EXTERIOR  DIVIDENDOS A SOCIEDADES - 0%", "504B - PAGO AL EXTERIOR  ANTICIPO DIVIDENDOS - 22%", "504C - PAGO AL EXTERIOR  DIVIDENDOS ANTICIPADOS PRESTAMOS ACCIONISTAS,  BENEFICIA" &
                "RIOS O PARTICIPES - 22%", "504D - PAGO AL EXTERIOR  DIVIDENDOS A FIDEICOMISOS - 0%", "504E - PAGO AL EXTERIOR DIVIDENDOS DISTRIBUIDOS A PERSONAS NATURALES (PARAISOS FI" &
                "SCALES) - 0%", "504F - PAGO AL EXTERIOR  DIVIDENDOS A SOCIEDADES  (PARAISOS FISCALES) - 13%", "504G - PAGO AL EXTERIOR  ANTICIPO DIVIDENDOS  (PARAISOS FISCALES) - 25%", "504H - PAGO AL EXTERIOR  DIVIDENDOS A FIDEICOMISOS  (PARAISOS FISCALES) - 13%", "505 - PAGO AL EXTERIOR  RENDIMIENTOS FINANCIEROS - 0%", "505A - PAGO AL EXTERIOR: INTERESES DE CREDITOS DE INSTITUCIONES FINANCIERAS DEL E" &
                "XTERIOR - 0%", "505B - PAGO AL EXTERIOR:INTERESES DE CREDITOS DE GOBIERNO A GOBIERNO - 0%", "505C - PAGO AL EXTERIOR:INTERESES DE CREDITOS DE ORGANISMOS MULTILATERALES - 0%", "505D - PAGO AL EXTERIOR  INTERESES POR FINANCIAMIENTO DE PROVEEDORES EXTERNOS - 0" &
                "%", "505E - PAGO AL EXTERIOR  INTERESES DE OTROS CREDITOS EXTERNOS - 0%", "505F - PAGO AL EXTERIOR  OTROS INTERESES Y RENDIMIENTOS FINANCIEROS - 0%", "509 - PAGO AL EXTERIOR  CANONES,  DERECHOS DE AUTOR, MARCA, PATENTES Y SIMILARES " &
                "- 0%", "509A - PAGO AL EXTERIOR  REGALIAS POR CONCEPTO DE FRANQUICIAS - 0%", "510 - PAGO AL EXTERIOR  GANANCIAS DE CAPITAL - 0%", "511 - PAGO AL EXTERIOR  SERVICIOS PROFESIONALES INDEPENDIENTES - 0%", "512 - PAGO AL EXTERIOR  SERVICIOS PROFESIONALES DEPENDIENTES - 0%", "513 - PAGO AL EXTERIOR  ARTISTAS - 0%", "513A - PAGO AL EXTERIOR  DEPORTISTAS - 0%", "514 - PAGO AL EXTERIOR  PARTICIPACION DE CONSEJEROS - 0%", "515 - PAGO AL EXTERIOR  ENTRETENIMIENTO PUBLICO - 0%", "516 - PAGO AL EXTERIOR  PENSIONES - 0%", "517 - PAGO AL EXTERIOR  REEMBOLSO DE GASTOS - 0%", "518 - PAGO AL EXTERIOR  FUNCIONES PUBLICAS - 0%", "519 - PAGO AL EXTERIOR  ESTUDIANTES - 0%", "520 - PAGO AL EXTERIOR  OTROS CONCEPTOS DE INGRESOS GRAVADOS - 0%", "520A - PAGO AL EXTERIOR  OTROS CONCEPTOS DE INGRESOS GRAVADOS - 0%", "520B - PAGO AL EXTERIOR  ARRENDAMIENTOS MERCANTIL INTERNACIONAL - 0%", "520D - PAGO AL EXTERIOR  COMISIONES POR EXPORTACIONES Y POR PROMOCION DE TURISMO " &
                "RECEPTIVO - 0%", "520E - PAGO AL EXTERIOR  POR LAS EMPRESAS DE TRANSPORTE MARITIMO O AEREO Y POR EM" &
                "PRESAS PESQUERAS DE ALTA MAR, POR SU ACTIVIDAD - 0%", "520F - PAGO AL EXTERIOR  POR LAS AGENCIAS INTERNACIONALES DE PRENSA - 0%", "520G - PAGO AL EXTERIOR  CONTRATOS DE FLETAMENTO DE NAVES PARA EMPRESAS DE TRANSP" &
                "ORTE AEREO O MARITIMO INTERNACIONAL - 0%", "521 - PAGO AL EXTERIOR  ENAJENACION DE DERECHOS REPRESENTATIVOS DE CAPITAL Y OTRO" &
                "S DERECHOS - 5%", "522A - PAGO AL EXTERIOR  SERVICIOS TECNICOS,  ADMINISTRATIVOS O DE CONSULTORIA Y " &
                "REGALIAS CON CONVENIO DE DOBLE TRIBUTACION - 0%", "522B - PAGO AL EXTERIOR  SERVICIOS TECNICOS,  ADMINISTRATIVOS O DE CONSULTORIA Y " &
                "REGALIAS SIN CONVENIO DE DOBLE TRIBUTACION - 22%", "522C - PAGO AL EXTERIOR  SERVICIOS TECNICOS,  ADMINISTRATIVOS O DE CONSULTORIA Y " &
                "REGALIAS EN PARAISOS FISCALES - 35%", "523A - PAGO AL EXTERIOR  SEGUROS Y REASEGUROS (PRIMAS Y CESIONES)  CON CONVENIO D" &
                "E DOBLE TRIBUTACION - 0%", "523B - PAGO AL EXTERIOR  SEGUROS Y REASEGUROS (PRIMAS Y CESIONES) SIN CONVENIO DE" &
                " DOBLE TRIBUTACION - 22%", "523C - PAGO AL EXTERIOR  SEGUROS Y REASEGUROS (PRIMAS Y CESIONES) EN PARAISOS FIS" &
                "CALES - 35%", "524 - PAGO AL EXTERIOR  OTROS PAGOS AL EXTERIOR NO SUJETOS A RETENCION - 0%"})
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
        Me.txtPorcentaje.ReadOnly = True
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
