<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanilladeSaltoenLargoyTriple
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEditarLista = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbResultados = New System.Windows.Forms.GroupBox()
        Me.txtMetros = New System.Windows.Forms.TextBox()
        Me.btnRehuso = New System.Windows.Forms.Button()
        Me.btnNulo = New System.Windows.Forms.Button()
        Me.btnVálido = New System.Windows.Forms.Button()
        Me.dgvSaltoyTriple = New System.Windows.Forms.DataGridView()
        Me.Número = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Federación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TercerLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MejordelosPrimerosTres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuartoLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuintoLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SextoLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MejorSegundosTres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpfechainicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox254 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grbResultados.SuspendLayout()
        CType(Me.dgvSaltoyTriple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditarLista)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.grbResultados)
        Me.GroupBox1.Controls.Add(Me.dgvSaltoyTriple)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1036, 450)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        '
        'btnEditarLista
        '
        Me.btnEditarLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarLista.Location = New System.Drawing.Point(780, 14)
        Me.btnEditarLista.Name = "btnEditarLista"
        Me.btnEditarLista.Size = New System.Drawing.Size(132, 23)
        Me.btnEditarLista.TabIndex = 541
        Me.btnEditarLista.Text = "Editar Lista de Atletas"
        Me.btnEditarLista.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(918, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 540
        Me.Button1.Text = "Quitar Atleta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 539
        Me.Button2.Text = "Agregar Atleta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grbResultados
        '
        Me.grbResultados.Controls.Add(Me.txtMetros)
        Me.grbResultados.Controls.Add(Me.btnRehuso)
        Me.grbResultados.Controls.Add(Me.btnNulo)
        Me.grbResultados.Controls.Add(Me.btnVálido)
        Me.grbResultados.Location = New System.Drawing.Point(6, 369)
        Me.grbResultados.Name = "grbResultados"
        Me.grbResultados.Size = New System.Drawing.Size(471, 66)
        Me.grbResultados.TabIndex = 535
        Me.grbResultados.TabStop = False
        Me.grbResultados.Text = "Opciones de resultado"
        '
        'txtMetros
        '
        Me.txtMetros.Location = New System.Drawing.Point(103, 22)
        Me.txtMetros.Multiline = True
        Me.txtMetros.Name = "txtMetros"
        Me.txtMetros.Size = New System.Drawing.Size(91, 26)
        Me.txtMetros.TabIndex = 533
        '
        'btnRehuso
        '
        Me.btnRehuso.Location = New System.Drawing.Point(364, 19)
        Me.btnRehuso.Name = "btnRehuso"
        Me.btnRehuso.Size = New System.Drawing.Size(91, 32)
        Me.btnRehuso.TabIndex = 533
        Me.btnRehuso.Text = "Rehuso (=)"
        Me.btnRehuso.UseVisualStyleBackColor = True
        '
        'btnNulo
        '
        Me.btnNulo.Location = New System.Drawing.Point(232, 19)
        Me.btnNulo.Name = "btnNulo"
        Me.btnNulo.Size = New System.Drawing.Size(91, 32)
        Me.btnNulo.TabIndex = 533
        Me.btnNulo.Text = "Nulo (X)"
        Me.btnNulo.UseVisualStyleBackColor = True
        '
        'btnVálido
        '
        Me.btnVálido.Location = New System.Drawing.Point(6, 20)
        Me.btnVálido.Name = "btnVálido"
        Me.btnVálido.Size = New System.Drawing.Size(91, 31)
        Me.btnVálido.TabIndex = 533
        Me.btnVálido.Text = "Válido"
        Me.btnVálido.UseVisualStyleBackColor = True
        '
        'dgvSaltoyTriple
        '
        Me.dgvSaltoyTriple.AllowUserToAddRows = False
        Me.dgvSaltoyTriple.AllowUserToDeleteRows = False
        Me.dgvSaltoyTriple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSaltoyTriple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaltoyTriple.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Número, Me.Nombre, Me.Apellido, Me.Federación, Me.PrimerLanzamiento, Me.SegundoLanzamiento, Me.TercerLanzamiento, Me.MejordelosPrimerosTres, Me.Orden, Me.CuartoLanzamiento, Me.QuintoLanzamiento, Me.SextoLanzamiento, Me.MejorSegundosTres, Me.Clasificación})
        Me.dgvSaltoyTriple.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSaltoyTriple.Location = New System.Drawing.Point(6, 48)
        Me.dgvSaltoyTriple.MultiSelect = False
        Me.dgvSaltoyTriple.Name = "dgvSaltoyTriple"
        Me.dgvSaltoyTriple.ReadOnly = True
        Me.dgvSaltoyTriple.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaltoyTriple.Size = New System.Drawing.Size(1024, 305)
        Me.dgvSaltoyTriple.TabIndex = 530
        '
        'Número
        '
        Me.Número.HeaderText = "Nro."
        Me.Número.Name = "Número"
        Me.Número.ReadOnly = True
        Me.Número.Width = 40
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Federación
        '
        Me.Federación.HeaderText = "Federación"
        Me.Federación.Name = "Federación"
        Me.Federación.ReadOnly = True
        '
        'PrimerLanzamiento
        '
        Me.PrimerLanzamiento.HeaderText = "1°"
        Me.PrimerLanzamiento.Name = "PrimerLanzamiento"
        Me.PrimerLanzamiento.ReadOnly = True
        Me.PrimerLanzamiento.Width = 60
        '
        'SegundoLanzamiento
        '
        Me.SegundoLanzamiento.HeaderText = "2°"
        Me.SegundoLanzamiento.Name = "SegundoLanzamiento"
        Me.SegundoLanzamiento.ReadOnly = True
        Me.SegundoLanzamiento.Width = 60
        '
        'TercerLanzamiento
        '
        Me.TercerLanzamiento.HeaderText = "3°"
        Me.TercerLanzamiento.Name = "TercerLanzamiento"
        Me.TercerLanzamiento.ReadOnly = True
        Me.TercerLanzamiento.Width = 60
        '
        'MejordelosPrimerosTres
        '
        Me.MejordelosPrimerosTres.HeaderText = "Mejor"
        Me.MejordelosPrimerosTres.Name = "MejordelosPrimerosTres"
        Me.MejordelosPrimerosTres.ReadOnly = True
        Me.MejordelosPrimerosTres.Width = 60
        '
        'Orden
        '
        Me.Orden.HeaderText = "Orden"
        Me.Orden.Name = "Orden"
        Me.Orden.ReadOnly = True
        Me.Orden.Width = 60
        '
        'CuartoLanzamiento
        '
        Me.CuartoLanzamiento.HeaderText = "4°"
        Me.CuartoLanzamiento.Name = "CuartoLanzamiento"
        Me.CuartoLanzamiento.ReadOnly = True
        Me.CuartoLanzamiento.Width = 60
        '
        'QuintoLanzamiento
        '
        Me.QuintoLanzamiento.HeaderText = "5°"
        Me.QuintoLanzamiento.Name = "QuintoLanzamiento"
        Me.QuintoLanzamiento.ReadOnly = True
        Me.QuintoLanzamiento.Width = 60
        '
        'SextoLanzamiento
        '
        Me.SextoLanzamiento.HeaderText = "6°"
        Me.SextoLanzamiento.Name = "SextoLanzamiento"
        Me.SextoLanzamiento.ReadOnly = True
        Me.SextoLanzamiento.Width = 60
        '
        'MejorSegundosTres
        '
        Me.MejorSegundosTres.HeaderText = "Mejor"
        Me.MejorSegundosTres.Name = "MejorSegundosTres"
        Me.MejorSegundosTres.ReadOnly = True
        Me.MejorSegundosTres.Width = 60
        '
        'Clasificación
        '
        Me.Clasificación.HeaderText = "Clasificación"
        Me.Clasificación.Name = "Clasificación"
        Me.Clasificación.ReadOnly = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(444, 117)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(140, 20)
        Me.txtCategoria.TabIndex = 536
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(62, 115)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox3.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Categoría"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(242, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Prueba"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 116
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(18, 623)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 143
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCategoria)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpfechainicio)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.lblLocalidad)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.txtHora)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox254)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 149)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(673, 118)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox2.TabIndex = 538
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(595, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 537
        Me.Label8.Text = "Juez Principal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Hora"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(298, 52)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 187
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(213, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 183
        Me.Label10.Text = "Fecha de Inicio"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(65, 55)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox5.TabIndex = 182
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(6, 58)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 181
        Me.lblLocalidad.Text = "Localidad"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(461, 20)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox4.TabIndex = 180
        '
        'txtHora
        '
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(466, 56)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(94, 20)
        Me.txtHora.TabIndex = 179
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(240, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 179
        '
        'TextBox254
        '
        Me.TextBox254.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox254.Location = New System.Drawing.Point(61, 19)
        Me.TextBox254.Name = "TextBox254"
        Me.TextBox254.Size = New System.Drawing.Size(127, 20)
        Me.TextBox254.TabIndex = 178
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Provincia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Lugar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 175
        Me.Label7.Text = "Nombre"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox2.Location = New System.Drawing.Point(832, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 174
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(776, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 48)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(973, 623)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 544
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(892, 623)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 543
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(649, 623)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(75, 23)
        Me.btnComenzar.TabIndex = 542
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(730, 623)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 546
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(811, 623)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 543
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'PlanilladeSaltoenLargoyTriple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 658)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label5)
        Me.Name = "PlanilladeSaltoenLargoyTriple"
        Me.Text = "Planilla de Salto en Largo y Triple"
        Me.GroupBox1.ResumeLayout(False)
        Me.grbResultados.ResumeLayout(False)
        Me.grbResultados.PerformLayout()
        CType(Me.dgvSaltoyTriple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox254 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents dtpfechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvSaltoyTriple As System.Windows.Forms.DataGridView
    Friend WithEvents Número As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Federación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TercerLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MejordelosPrimerosTres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Orden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuartoLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuintoLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SextoLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MejorSegundosTres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clasificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grbResultados As System.Windows.Forms.GroupBox
    Friend WithEvents txtMetros As System.Windows.Forms.TextBox
    Friend WithEvents btnRehuso As System.Windows.Forms.Button
    Friend WithEvents btnNulo As System.Windows.Forms.Button
    Friend WithEvents btnVálido As System.Windows.Forms.Button
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEditarLista As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
