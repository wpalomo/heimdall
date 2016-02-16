<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExportaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportaciones))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAyuda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtTipoIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPais = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboParteRelacionada = New System.Windows.Forms.ComboBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.groRefrendo = New System.Windows.Forms.GroupBox()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDocTpte = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboRegimen = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtValorFOB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboTipoExportacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtFechaComprobante = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNumeroAutorizacion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSecuencial = New System.Windows.Forms.TextBox()
        Me.txtPuntoEmision = New System.Windows.Forms.TextBox()
        Me.txtEstablecimiento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValorFOBComprobante = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdMostrar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdImportarRetencion = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.groRefrendo.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.cmdGuardar, Me.toolStripSeparator, Me.cmdAyuda, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 25)
        Me.ToolStrip1.TabIndex = 13
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
        'txtRegistro
        '
        Me.txtRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistro.Location = New System.Drawing.Point(91, 35)
        Me.txtRegistro.MaxLength = 6
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.ReadOnly = True
        Me.txtRegistro.Size = New System.Drawing.Size(59, 20)
        Me.txtRegistro.TabIndex = 15
        Me.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "No. Registro:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 313)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdBuscar)
        Me.TabPage1.Controls.Add(Me.txtTipoIdentificacion)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboPais)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cboParteRelacionada)
        Me.TabPage1.Controls.Add(Me.txtIdentificacion)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(565, 287)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(255, 20)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(52, 20)
        Me.cmdBuscar.TabIndex = 47
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtTipoIdentificacion
        '
        Me.txtTipoIdentificacion.Location = New System.Drawing.Point(149, 72)
        Me.txtTipoIdentificacion.Name = "txtTipoIdentificacion"
        Me.txtTipoIdentificacion.ReadOnly = True
        Me.txtTipoIdentificacion.Size = New System.Drawing.Size(220, 20)
        Me.txtTipoIdentificacion.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "País al que se exporta:"
        '
        'cboPais
        '
        Me.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Items.AddRange(New Object() {"301-AFGANISTAN", "594-AGUAS INTERNACIONALES", "428-ÅLAND ISLANDS", "201-ALBANIA", "207-ALBORAN Y PEREJIL", "202-ALEMANIA", "595-ALTO VOLTA", "016-AMERICAN SAMOA", "233-ANDORRA", "454-ANGOLA", "109-ANGUILA", "134-ANTIGUA Y BARBUDA", "140-ANTILLAS HOLANDESAS", "302-ARABIA SAUDITA", "403-ARGELIA", "101-ARGENTINA", "356-ARMENIA", "141-ARUBA", "501-AUSTRALIA", "203-AUSTRIA", "347-AZERBAIJAN", "129-BAHAMAS", "327-BAHREIN", "328-BANGLADESH", "130-BARBADOS", "241-BELARUS", "204-BELGICA", "135-BELICE", "429-BENIN", "142-BERMUDA", "596-BIELORRUSIA", "102-BOLIVIA", "242-BOSNIA Y HERZEGOVINA", "430-BOTSWANA", "074-BOUVET ISLAND", "103-BRASIL", "344-BRUNEI DARUSSALAM", "205-BULGARIA", "402-BURKINA FASO", "404-BURUNDI", "329-BUTAN", "456-CABO VERDE", "304-CAMBOYA", "405-CAMERUN", "104-CANADA", "228-CANARIAS  ISLAS", "433-CHAD", "108-CHILE", "331-CHINA POPULAR", "332-CHIPRE", "105-COLOMBIA", "458-COMORAS", "406-CONGO", "330-COREA DEL SUR", "306-COREA NORTE", "432-COSTA DE MARFIL", "106-COSTA RICA", "597-COTE DÍVOIRE", "243-CROACIA", "107-CUBA", "127-CURAZAO", "598-CYPRUS", "208-DINAMARCA", "459-DJIBOUTI", "136-DOMINICA", "593-ECUADOR", "434-EGIPTO", "123-EL SALVADOR", "333-EMIRATOS ARABES UNIDOS", "463-ERITREA", "252-ESLOVAQUIA", "244-ESLOVENIA", "209-ESPAÑA", "110-ESTADOS UNIDOS", "245-ESTONIA", "407-ETIOPIA", "600-FALKLAND ISLANDS", "506-FIJI", "308-FILIPINAS", "212-FINLANDIA", "211-FRANCIA", "260-FRENCH SOUTHERN TERRITORIES", "435-GABON", "408-GAMBIA", "246-GEORGIA", "436-GHANA", "239-GIBRALTAR", "131-GRANADA", "214-GRECIA", "247-GROENLANDIA", "143-GUADALUPE", "517-GUAM", "111-GUATEMALA", "831-GUERNSEY", "409-GUINEA", "438-GUINEA ECUATORIAL", "437-GUINEA-BISSAU", "132-GUYANA", "144-GUYANA FRANCESA", "112-HAITI", "113-HONDURAS", "354-HONG KONG", "216-HUNGRIA", "309-INDIA", "310-INDONESIA", "311-IRAK", "312-IRAN (REPUBLICA ISLAMICA)", "217-IRLANDA", "218-ISLANDIA", "145-ISLAS CAIMAN", "518-ISLAS COCOS (KEELING)", "519-ISLAS COOK", "253-ISLAS FAROE", "343-ISLAS HEARD Y MCDONALD", "520-ISLAS NAVIDAD", "146-ISLAS VIRGENES (BRITANICAS)", "833-ISLE OF MAN", "313-ISRAEL", "219-ITALIA", "114-JAMAICA", "314-JAPON", "499-JERSEY", "147-JOHNSTON ISLA", "315-JORDANIA", "348-KAZAJSTAN", "439-KENIA", "349-KIRGUIZISTAN", "510-KIRIBATI", "316-KUWAIT", "317-LAOS, REP. POP. DEMOC.", "601-LATVIA", "440-LESOTHO", "248-LETONIA", "318-LIBANO", "410-LIBERIA", "602-LIBIA", "234-LIECHTENSTEIN", "249-LITUANIA", "220-LUXEMBURGO", "355-MACAO", "251-MACEDONIA", "412-MADAGASCAR", "319-MALASIA", "413-MALAWI", "335-MALDIVAS", "414-MALI", "221-MALTA", "115-MALVINAS  ISLAS", "415-MARRUECOS", "511-MARSHALL ISLAS", "148-MARTINICA", "441-MAURICIO", "416-MAURITANIA", "443-MAYOTTE", "116-MEXICO", "512-MICRONESIA", "521-MIDWAY ISLAS", "250-MOLDOVA", "235-MONACO", "321-MONGOLIA (MANCHURIA)", "382-MONTENEGRO", "149-MONTSERRAT ISLA", "464-MOROCCO", "442-MOZAMBIQUE", "303-MYANMAR (BURMA)", "460-NAMIBIA", "513-NAURU", "336-NEPAL", "117-NICARAGUA", "444-NIGER", "417-NIGERIA", "522-NIUE ISLA", "523-NORFOLK ISLA", "603-NORTHERN MARIANA ISL", "222-NORUEGA", "524-NUEVA  CALEDONIA", "503-NUEVA ZELANDA", "337-OMAN", "215-PAISES BAJOS (HOLANDA)", "322-PAKISTAN", "509-PALAO  (BELAU)  ISLAS", "353-PALESTINA", "118-PANAMA", "507-PAPUA NUEVA GUINEA", "119-PARAGUAY", "120-PERU", "525-PITCAIRN, ISLA", "526-POLINESIA FRANCESA", "223-POLONIA", "224-PORTUGAL", "121-PUERTO RICO", "334-QATAR", "213-REINO UNIDO", "431-REPUBLICA CENTROAFRICANA", "599-REPUBLICA CHECA", "122-REPUBLICA DOMINICANA", "465-REUNION", "225-RUMANIA", "230-RUSIA", "445-RWANDA", "447-SAHARA OCCIDENTAL", "590-SAINT BARTHELEMY", "514-SALOMON  ISLAS", "504-SAMOA OCCIDENTAL", "137-SAN CRISTOBAL Y NEVIS", "237-SAN MARINO", "139-SAN VICENTE Y LAS GRANAD.", "466-SANTA ELENA", "138-SANTA LUCIA", "449-SANTO TOME Y PRINCIPE", "420-SENEGAL", "688-SERBIA", "446-SEYCHELLES", "423-SIERRA LEONA", "338-SINGAPUR", "323-SIRIA", "448-SOMALIA", "339-SRI LANKA (CEILAN)", "604-ST. PIERRE AND MIQUE", "422-SUDAFRICA  (CISKEI)", "421-SUDAN", "226-SUECIA", "227-SUIZA", "133-SURINAM", "450-SWAZILANDIA", "605-SYRIAN ARAB REPUBLIC", "325-TAILANDIA", "307-TAIWAN (CHINA)", "350-TAJIKISTAN", "425-TANZANIA", "606-TERRITORIO ANTARTICO BRITANICO", "607-TERRITORIO BRITANICO OCEANO IN", "529-TIMOR DEL ESTE", "451-TOGO", "530-TOKELAI", "508-TONGA", "124-TRINIDAD Y TOBAGO", "452-TUNEZ", "151-TURCAS  Y CAICOS ISLAS", "351-TURKMENISTAN", "346-TURQUIA", "515-TUVALU", "229-UCRANIA", "426-UGANDA", "125-URUGUAY", "352-UZBEKISTAN", "516-VANUATU", "238-VATICANO (SANTA SEDE)", "126-VENEZUELA", "341-VIETNAM", "152-VIRGENES,ISLAS(NORT.AMER.)", "531-WAKE ISLA", "532-WALLIS Y FUTUNA, ISLAS", "342-YEMEN", "231-YUGOSLAVIA", "453-ZAIRE", "427-ZAMBIA", "419-ZIMBABWE (RHODESIA)"})
        Me.cboPais.Location = New System.Drawing.Point(149, 127)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(220, 21)
        Me.cboPais.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Parte Relacionada:"
        '
        'cboParteRelacionada
        '
        Me.cboParteRelacionada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParteRelacionada.FormattingEnabled = True
        Me.cboParteRelacionada.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboParteRelacionada.Location = New System.Drawing.Point(149, 100)
        Me.cboParteRelacionada.Name = "cboParteRelacionada"
        Me.cboParteRelacionada.Size = New System.Drawing.Size(100, 21)
        Me.cboParteRelacionada.TabIndex = 42
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(149, 20)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.ReadOnly = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Identificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tipo Identificación:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(149, 46)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(309, 20)
        Me.txtCliente.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cliente:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.groRefrendo)
        Me.TabPage2.Controls.Add(Me.txtFecha)
        Me.TabPage2.Controls.Add(Me.txtValorFOB)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cboTipoExportacion)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(565, 287)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle de Exportación"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'groRefrendo
        '
        Me.groRefrendo.Controls.Add(Me.txtCorrelativo)
        Me.groRefrendo.Controls.Add(Me.Label14)
        Me.groRefrendo.Controls.Add(Me.txtAño)
        Me.groRefrendo.Controls.Add(Me.Label11)
        Me.groRefrendo.Controls.Add(Me.txtDocTpte)
        Me.groRefrendo.Controls.Add(Me.Label13)
        Me.groRefrendo.Controls.Add(Me.Label7)
        Me.groRefrendo.Controls.Add(Me.cboRegimen)
        Me.groRefrendo.Controls.Add(Me.Label8)
        Me.groRefrendo.Controls.Add(Me.cboDistrito)
        Me.groRefrendo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groRefrendo.Location = New System.Drawing.Point(32, 115)
        Me.groRefrendo.Name = "groRefrendo"
        Me.groRefrendo.Size = New System.Drawing.Size(492, 166)
        Me.groRefrendo.TabIndex = 55
        Me.groRefrendo.TabStop = False
        Me.groRefrendo.Text = "Refrendo"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrelativo.Location = New System.Drawing.Point(139, 135)
        Me.txtCorrelativo.MaxLength = 8
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrelativo.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Correlativo:"
        '
        'txtAño
        '
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(139, 82)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Año:"
        '
        'txtDocTpte
        '
        Me.txtDocTpte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocTpte.Location = New System.Drawing.Point(139, 29)
        Me.txtDocTpte.MaxLength = 13
        Me.txtDocTpte.Name = "txtDocTpte"
        Me.txtDocTpte.Size = New System.Drawing.Size(100, 20)
        Me.txtDocTpte.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "N. Doc. Transporte:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Régimen:"
        '
        'cboRegimen
        '
        Me.cboRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegimen.FormattingEnabled = True
        Me.cboRegimen.Items.AddRange(New Object() {"40-Exportación definitive", "50-Exportación temporal para reimportación en el mismo estado", "51-Exportación temporal para perfeccionamiento pasivo", "60-Reexp. de mercancías en el mismo estado", "61-Reexportación de mercancías que fueron importadas para perfeccionamiento activ" &
                "o", "79-Exportación a consumo desde Zona Franca", "83-Reembarque", "94-Courier exportación", "95-Exportaciones Correos del Ecuador"})
        Me.cboRegimen.Location = New System.Drawing.Point(139, 108)
        Me.cboRegimen.Name = "cboRegimen"
        Me.cboRegimen.Size = New System.Drawing.Size(337, 21)
        Me.cboRegimen.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Distrito:"
        '
        'cboDistrito
        '
        Me.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Items.AddRange(New Object() {"019-GuayaquilAéreo", "028-Guayaquil Marítimo", "037-Manta", "046-Esmeraldas", "055-Quito", "064-Puerto Bolívar", "073-Tulcán", "082-Huaquillas", "091-Cuenca", "109-Loja Macara", "118-Sta Elena", "127-Latacunga", "136-Gerencia General", "145-CEBAF San Miguel "})
        Me.cboDistrito.Location = New System.Drawing.Point(139, 55)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(220, 21)
        Me.cboDistrito.TabIndex = 55
        '
        'txtFecha
        '
        Me.txtFecha.CustomFormat = "dd/MM/yyyy"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(171, 69)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 48
        '
        'txtValorFOB
        '
        Me.txtValorFOB.Location = New System.Drawing.Point(171, 43)
        Me.txtValorFOB.Name = "txtValorFOB"
        Me.txtValorFOB.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFOB.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Valor FOB:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha de la transacción:"
        '
        'cboTipoExportacion
        '
        Me.cboTipoExportacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoExportacion.FormattingEnabled = True
        Me.cboTipoExportacion.Items.AddRange(New Object() {"01-Con Refrendo", "02-Sin Refrendo"})
        Me.cboTipoExportacion.Location = New System.Drawing.Point(171, 16)
        Me.cboTipoExportacion.Name = "cboTipoExportacion"
        Me.cboTipoExportacion.Size = New System.Drawing.Size(220, 21)
        Me.cboTipoExportacion.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Tipo de Exportación:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmdImportarRetencion)
        Me.TabPage3.Controls.Add(Me.txtFechaComprobante)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.txtNumeroAutorizacion)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.txtSecuencial)
        Me.TabPage3.Controls.Add(Me.txtPuntoEmision)
        Me.TabPage3.Controls.Add(Me.txtEstablecimiento)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.txtValorFOBComprobante)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.cboTipoComprobante)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(548, 287)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Comprobante de Exportación"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtFechaComprobante
        '
        Me.txtFechaComprobante.CustomFormat = "dd/MM/yyyy"
        Me.txtFechaComprobante.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaComprobante.Location = New System.Drawing.Point(151, 197)
        Me.txtFechaComprobante.Name = "txtFechaComprobante"
        Me.txtFechaComprobante.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaComprobante.TabIndex = 62
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(28, 200)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 13)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Fecha de Emisión:"
        '
        'txtNumeroAutorizacion
        '
        Me.txtNumeroAutorizacion.Location = New System.Drawing.Point(151, 171)
        Me.txtNumeroAutorizacion.MaxLength = 49
        Me.txtNumeroAutorizacion.Name = "txtNumeroAutorizacion"
        Me.txtNumeroAutorizacion.Size = New System.Drawing.Size(284, 20)
        Me.txtNumeroAutorizacion.TabIndex = 60
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "N° de Autorización:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(335, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Secuencial"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(240, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Punto de Emisión"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(150, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Establecimiento"
        '
        'txtSecuencial
        '
        Me.txtSecuencial.Location = New System.Drawing.Point(335, 145)
        Me.txtSecuencial.MaxLength = 9
        Me.txtSecuencial.Name = "txtSecuencial"
        Me.txtSecuencial.Size = New System.Drawing.Size(100, 20)
        Me.txtSecuencial.TabIndex = 55
        '
        'txtPuntoEmision
        '
        Me.txtPuntoEmision.Location = New System.Drawing.Point(243, 145)
        Me.txtPuntoEmision.MaxLength = 3
        Me.txtPuntoEmision.Name = "txtPuntoEmision"
        Me.txtPuntoEmision.Size = New System.Drawing.Size(86, 20)
        Me.txtPuntoEmision.TabIndex = 54
        '
        'txtEstablecimiento
        '
        Me.txtEstablecimiento.Location = New System.Drawing.Point(151, 145)
        Me.txtEstablecimiento.MaxLength = 3
        Me.txtEstablecimiento.Name = "txtEstablecimiento"
        Me.txtEstablecimiento.Size = New System.Drawing.Size(86, 20)
        Me.txtEstablecimiento.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(30, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Factura de Exportación"
        '
        'txtValorFOBComprobante
        '
        Me.txtValorFOBComprobante.Location = New System.Drawing.Point(206, 51)
        Me.txtValorFOBComprobante.Name = "txtValorFOBComprobante"
        Me.txtValorFOBComprobante.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFOBComprobante.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Valor FOB del Comprobante Local:"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Items.AddRange(New Object() {"01-Factura ", "04-Nota de crédito", "05-Nota de débito", "16-Formulario Único de Exportación (FUE) o Declaración Aduanera Única (DAU) o Dec" &
                "laración Andina de Valor (DAV)", "41-Comprobante de venta emitido por reembolso", "47-Nota de Crédito por Reembolso Emitida por Intermediario", "48-Nota de Débito por Reembolso Emitida por Intermediario"})
        Me.cboTipoComprobante.Location = New System.Drawing.Point(206, 24)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(220, 21)
        Me.cboTipoComprobante.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Tipo de Comprobante:"
        '
        'cmdMostrar
        '
        Me.cmdMostrar.Image = Global.Impuestos.My.Resources.Resources.find_icon
        Me.cmdMostrar.Location = New System.Drawing.Point(156, 33)
        Me.cmdMostrar.Name = "cmdMostrar"
        Me.cmdMostrar.Size = New System.Drawing.Size(31, 23)
        Me.cmdMostrar.TabIndex = 32
        Me.cmdMostrar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(580, 22)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 17)
        Me.lblUsuario.Text = "Usuario"
        '
        'cmdImportarRetencion
        '
        Me.cmdImportarRetencion.Location = New System.Drawing.Point(444, 145)
        Me.cmdImportarRetencion.Name = "cmdImportarRetencion"
        Me.cmdImportarRetencion.Size = New System.Drawing.Size(92, 46)
        Me.cmdImportarRetencion.TabIndex = 96
        Me.cmdImportarRetencion.Text = "Importar Factura Electrónica"
        Me.cmdImportarRetencion.UseVisualStyleBackColor = True
        '
        'frmExportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 404)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdMostrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmExportaciones"
        Me.Text = "Exportaciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.groRefrendo.ResumeLayout(False)
        Me.groRefrendo.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents cmdGuardar As ToolStripButton
    Friend WithEvents cmdAyuda As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtRegistro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents cboTipoExportacion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents cboParteRelacionada As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPais As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTipoIdentificacion As TextBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtValorFOB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents groRefrendo As GroupBox
    Friend WithEvents cboDistrito As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboRegimen As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDocTpte As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCorrelativo As TextBox
    Friend WithEvents txtValorFOBComprobante As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboTipoComprobante As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEstablecimiento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSecuencial As TextBox
    Friend WithEvents txtPuntoEmision As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNumeroAutorizacion As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtFechaComprobante As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdMostrar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents cmdImportarRetencion As Button
End Class
