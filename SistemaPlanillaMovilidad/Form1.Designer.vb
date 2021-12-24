<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.NumericUpDown()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminarViaje = New System.Windows.Forms.Button()
        Me.btnAgregarViaje = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtnVuelta = New System.Windows.Forms.RadioButton()
        Me.rbtnIda = New System.Windows.Forms.RadioButton()
        Me.cboxDestino = New System.Windows.Forms.ComboBox()
        Me.cboxFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboxOrigen = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnCrearRegistro = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxNombre = New System.Windows.Forms.ComboBox()
        Me.TablaViajes = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboxMeses = New System.Windows.Forms.ComboBox()
        Me.btnGenerarExcel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TablaViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminarViaje)
        Me.GroupBox1.Controls.Add(Me.btnAgregarViaje)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMotivo)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cboxDestino)
        Me.GroupBox1.Controls.Add(Me.cboxFecha)
        Me.GroupBox1.Controls.Add(Me.cboxOrigen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 515)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de viaje"
        '
        'txtMonto
        '
        Me.txtMonto.DecimalPlaces = 2
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtMonto.Location = New System.Drawing.Point(95, 283)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(93, 30)
        Me.txtMonto.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLimpiar.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.limpiar_40px
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(142, 450)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(46, 46)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminarViaje
        '
        Me.btnEliminarViaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEliminarViaje.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.tacho_basura_40px
        Me.btnEliminarViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarViaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEliminarViaje.Location = New System.Drawing.Point(77, 450)
        Me.btnEliminarViaje.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminarViaje.Name = "btnEliminarViaje"
        Me.btnEliminarViaje.Size = New System.Drawing.Size(46, 46)
        Me.btnEliminarViaje.TabIndex = 12
        Me.btnEliminarViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarViaje.UseVisualStyleBackColor = False
        '
        'btnAgregarViaje
        '
        Me.btnAgregarViaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAgregarViaje.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.guardar_40px
        Me.btnAgregarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarViaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAgregarViaje.Location = New System.Drawing.Point(15, 450)
        Me.btnAgregarViaje.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarViaje.Name = "btnAgregarViaje"
        Me.btnAgregarViaje.Size = New System.Drawing.Size(46, 46)
        Me.btnAgregarViaje.TabIndex = 11
        Me.btnAgregarViaje.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = " Motivo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Destino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Origen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha"
        '
        'txtMotivo
        '
        Me.txtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMotivo.Location = New System.Drawing.Point(25, 350)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(163, 80)
        Me.txtMotivo.TabIndex = 5
        Me.txtMotivo.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtnVuelta)
        Me.GroupBox3.Controls.Add(Me.rbtnIda)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(185, 68)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de viaje"
        '
        'rbtnVuelta
        '
        Me.rbtnVuelta.AutoSize = True
        Me.rbtnVuelta.Location = New System.Drawing.Point(74, 29)
        Me.rbtnVuelta.Name = "rbtnVuelta"
        Me.rbtnVuelta.Size = New System.Drawing.Size(109, 29)
        Me.rbtnVuelta.TabIndex = 1
        Me.rbtnVuelta.TabStop = True
        Me.rbtnVuelta.Text = "VUELTA"
        Me.rbtnVuelta.UseVisualStyleBackColor = True
        '
        'rbtnIda
        '
        Me.rbtnIda.AutoSize = True
        Me.rbtnIda.Location = New System.Drawing.Point(5, 29)
        Me.rbtnIda.Name = "rbtnIda"
        Me.rbtnIda.Size = New System.Drawing.Size(63, 29)
        Me.rbtnIda.TabIndex = 0
        Me.rbtnIda.TabStop = True
        Me.rbtnIda.Text = "IDA"
        Me.rbtnIda.UseVisualStyleBackColor = True
        '
        'cboxDestino
        '
        Me.cboxDestino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboxDestino.FormattingEnabled = True
        Me.cboxDestino.Location = New System.Drawing.Point(25, 172)
        Me.cboxDestino.Name = "cboxDestino"
        Me.cboxDestino.Size = New System.Drawing.Size(163, 28)
        Me.cboxDestino.TabIndex = 2
        '
        'cboxFecha
        '
        Me.cboxFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cboxFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboxFecha.Location = New System.Drawing.Point(25, 49)
        Me.cboxFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.cboxFecha.Name = "cboxFecha"
        Me.cboxFecha.Size = New System.Drawing.Size(163, 23)
        Me.cboxFecha.TabIndex = 1
        '
        'cboxOrigen
        '
        Me.cboxOrigen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxOrigen.DisplayMember = "MODULO_ID"
        Me.cboxOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboxOrigen.FormattingEnabled = True
        Me.cboxOrigen.Location = New System.Drawing.Point(25, 104)
        Me.cboxOrigen.Name = "cboxOrigen"
        Me.cboxOrigen.Size = New System.Drawing.Size(163, 28)
        Me.cboxOrigen.TabIndex = 0
        Me.cboxOrigen.ValueMember = "MODULO_ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.btnNuevoUsuario)
        Me.GroupBox2.Controls.Add(Me.btnCrearRegistro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDNI)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboxNombre)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.GroupBox2.Location = New System.Drawing.Point(250, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(113, 70)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(202, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "No estas en la lista? clickeame"
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnNuevoUsuario.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.nuevo_usuario_40px
        Me.btnNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevoUsuario.Enabled = False
        Me.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(635, 27)
        Me.btnNuevoUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(46, 46)
        Me.btnNuevoUsuario.TabIndex = 5
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'btnCrearRegistro
        '
        Me.btnCrearRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearRegistro.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.guardar_40px
        Me.btnCrearRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearRegistro.Location = New System.Drawing.Point(557, 27)
        Me.btnCrearRegistro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCrearRegistro.Name = "btnCrearRegistro"
        Me.btnCrearRegistro.Size = New System.Drawing.Size(46, 46)
        Me.btnCrearRegistro.TabIndex = 4
        Me.btnCrearRegistro.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(337, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtDNI.Location = New System.Drawing.Point(397, 36)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(121, 30)
        Me.txtDNI.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombres"
        '
        'cboxNombre
        '
        Me.cboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cboxNombre.FormattingEnabled = True
        Me.cboxNombre.Location = New System.Drawing.Point(117, 33)
        Me.cboxNombre.Name = "cboxNombre"
        Me.cboxNombre.Size = New System.Drawing.Size(214, 33)
        Me.cboxNombre.TabIndex = 0
        '
        'TablaViajes
        '
        Me.TablaViajes.AccessibleDescription = "LOCAL"
        Me.TablaViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaViajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TablaViajes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaViajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablaViajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaViajes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.TablaViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaViajes.DefaultCellStyle = DataGridViewCellStyle11
        Me.TablaViajes.GridColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TablaViajes.Location = New System.Drawing.Point(250, 124)
        Me.TablaViajes.MultiSelect = False
        Me.TablaViajes.Name = "TablaViajes"
        Me.TablaViajes.ReadOnly = True
        Me.TablaViajes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaViajes.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.TablaViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaViajes.Size = New System.Drawing.Size(700, 351)
        Me.TablaViajes.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(574, 502)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtTotal.Location = New System.Drawing.Point(665, 497)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 30)
        Me.txtTotal.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(268, 502)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Mes"
        '
        'cboxMeses
        '
        Me.cboxMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cboxMeses.FormattingEnabled = True
        Me.cboxMeses.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboxMeses.Location = New System.Drawing.Point(324, 497)
        Me.cboxMeses.Name = "cboxMeses"
        Me.cboxMeses.Size = New System.Drawing.Size(199, 33)
        Me.cboxMeses.TabIndex = 15
        Me.cboxMeses.Text = "Selecciona un mes"
        '
        'btnGenerarExcel
        '
        Me.btnGenerarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGenerarExcel.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.excel_40px
        Me.btnGenerarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGenerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGenerarExcel.Location = New System.Drawing.Point(883, 488)
        Me.btnGenerarExcel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenerarExcel.Name = "btnGenerarExcel"
        Me.btnGenerarExcel.Size = New System.Drawing.Size(46, 46)
        Me.btnGenerarExcel.TabIndex = 12
        Me.btnGenerarExcel.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(962, 539)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TablaViajes)
        Me.Controls.Add(Me.cboxMeses)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGenerarExcel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(982, 582)
        Me.MinimumSize = New System.Drawing.Size(982, 582)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Planilla de movilidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TablaViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TablaViajes As DataGridView
    Friend WithEvents cboxFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotivo As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtnVuelta As RadioButton
    Friend WithEvents rbtnIda As RadioButton
    Friend WithEvents cboxNombre As ComboBox
    Friend WithEvents btnEliminarViaje As Button
    Friend WithEvents btnAgregarViaje As Button
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents btnCrearRegistro As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnGenerarExcel As Button
    Friend WithEvents txtMonto As NumericUpDown
    Private WithEvents cboxDestino As ComboBox
    Private WithEvents cboxOrigen As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboxMeses As ComboBox
End Class
