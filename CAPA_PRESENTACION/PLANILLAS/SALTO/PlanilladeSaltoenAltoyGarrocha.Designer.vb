<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanilladeSaltoenAltoyGarrocha
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
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grbResultados = New System.Windows.Forms.GroupBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnNulo = New System.Windows.Forms.Button()
        Me.btnRehuso = New System.Windows.Forms.Button()
        Me.btnAltura = New System.Windows.Forms.Button()
        Me.btnVálido = New System.Windows.Forms.Button()
        Me.btnAgregarAtleta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvAltoyGarrocha = New System.Windows.Forms.DataGridView()
        Me.Número = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MejorAltura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarAtleta = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfechainicio = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.TextBox277 = New System.Windows.Forms.TextBox()
        Me.TextBox278 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbResultados.SuspendLayout()
        CType(Me.dgvAltoyGarrocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnQuitarAtleta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(58, 551)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 171
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(610, 550)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(75, 23)
        Me.btnComenzar.TabIndex = 168
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(772, 550)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 169
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(985, 670)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 170
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'grbResultados
        '
        Me.grbResultados.Controls.Add(Me.txtAltura)
        Me.grbResultados.Controls.Add(Me.btnNulo)
        Me.grbResultados.Controls.Add(Me.btnRehuso)
        Me.grbResultados.Controls.Add(Me.btnAltura)
        Me.grbResultados.Controls.Add(Me.btnVálido)
        Me.grbResultados.Location = New System.Drawing.Point(25, 290)
        Me.grbResultados.Name = "grbResultados"
        Me.grbResultados.Size = New System.Drawing.Size(527, 66)
        Me.grbResultados.TabIndex = 535
        Me.grbResultados.TabStop = False
        Me.grbResultados.Text = "Opciones de resultado"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(109, 25)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(110, 20)
        Me.txtAltura.TabIndex = 534
        '
        'btnNulo
        '
        Me.btnNulo.Location = New System.Drawing.Point(325, 18)
        Me.btnNulo.Name = "btnNulo"
        Me.btnNulo.Size = New System.Drawing.Size(91, 32)
        Me.btnNulo.TabIndex = 533
        Me.btnNulo.Text = "Nulo (X)"
        Me.btnNulo.UseVisualStyleBackColor = True
        '
        'btnRehuso
        '
        Me.btnRehuso.Location = New System.Drawing.Point(422, 19)
        Me.btnRehuso.Name = "btnRehuso"
        Me.btnRehuso.Size = New System.Drawing.Size(91, 32)
        Me.btnRehuso.TabIndex = 533
        Me.btnRehuso.Text = "Rehuso (=)"
        Me.btnRehuso.UseVisualStyleBackColor = True
        '
        'btnAltura
        '
        Me.btnAltura.Location = New System.Drawing.Point(12, 19)
        Me.btnAltura.Name = "btnAltura"
        Me.btnAltura.Size = New System.Drawing.Size(91, 31)
        Me.btnAltura.TabIndex = 533
        Me.btnAltura.Text = "Ingrese la altura"
        Me.btnAltura.UseVisualStyleBackColor = True
        '
        'btnVálido
        '
        Me.btnVálido.Location = New System.Drawing.Point(228, 19)
        Me.btnVálido.Name = "btnVálido"
        Me.btnVálido.Size = New System.Drawing.Size(91, 31)
        Me.btnVálido.TabIndex = 533
        Me.btnVálido.Text = "Válido (O)"
        Me.btnVálido.UseVisualStyleBackColor = True
        '
        'btnAgregarAtleta
        '
        Me.btnAgregarAtleta.Location = New System.Drawing.Point(624, 17)
        Me.btnAgregarAtleta.Name = "btnAgregarAtleta"
        Me.btnAgregarAtleta.Size = New System.Drawing.Size(109, 23)
        Me.btnAgregarAtleta.TabIndex = 536
        Me.btnAgregarAtleta.Text = "Agregar Atleta"
        Me.btnAgregarAtleta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(739, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 537
        Me.Button1.Text = "Quitar Atleta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(691, 551)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 538
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dgvAltoyGarrocha
        '
        Me.dgvAltoyGarrocha.AllowUserToAddRows = False
        Me.dgvAltoyGarrocha.AllowUserToDeleteRows = False
        Me.dgvAltoyGarrocha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAltoyGarrocha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Número, Me.Apellido, Me.Altura1, Me.Altura2, Me.Altura3, Me.Altura4, Me.Altura5, Me.Altura6, Me.Altura7, Me.Altura8, Me.Altura9, Me.Altura10, Me.MejorAltura, Me.Clasificación})
        Me.dgvAltoyGarrocha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAltoyGarrocha.Location = New System.Drawing.Point(25, 46)
        Me.dgvAltoyGarrocha.MultiSelect = False
        Me.dgvAltoyGarrocha.Name = "dgvAltoyGarrocha"
        Me.dgvAltoyGarrocha.ReadOnly = True
        Me.dgvAltoyGarrocha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAltoyGarrocha.Size = New System.Drawing.Size(823, 226)
        Me.dgvAltoyGarrocha.TabIndex = 539
        '
        'Número
        '
        Me.Número.HeaderText = "Nro."
        Me.Número.Name = "Número"
        Me.Número.ReadOnly = True
        Me.Número.Width = 50
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Altura1
        '
        Me.Altura1.HeaderText = "Alt.1"
        Me.Altura1.Name = "Altura1"
        Me.Altura1.ReadOnly = True
        Me.Altura1.Width = 50
        '
        'Altura2
        '
        Me.Altura2.HeaderText = "Alt.2"
        Me.Altura2.Name = "Altura2"
        Me.Altura2.ReadOnly = True
        Me.Altura2.Width = 50
        '
        'Altura3
        '
        Me.Altura3.HeaderText = "Alt.3"
        Me.Altura3.Name = "Altura3"
        Me.Altura3.ReadOnly = True
        Me.Altura3.Width = 50
        '
        'Altura4
        '
        Me.Altura4.HeaderText = "Alt.4"
        Me.Altura4.Name = "Altura4"
        Me.Altura4.ReadOnly = True
        Me.Altura4.Width = 50
        '
        'Altura5
        '
        Me.Altura5.HeaderText = "Alt.5"
        Me.Altura5.Name = "Altura5"
        Me.Altura5.ReadOnly = True
        Me.Altura5.Width = 50
        '
        'Altura6
        '
        Me.Altura6.HeaderText = "Alt.6"
        Me.Altura6.Name = "Altura6"
        Me.Altura6.ReadOnly = True
        Me.Altura6.Width = 50
        '
        'Altura7
        '
        Me.Altura7.HeaderText = "Alt.7"
        Me.Altura7.Name = "Altura7"
        Me.Altura7.ReadOnly = True
        Me.Altura7.Width = 50
        '
        'Altura8
        '
        Me.Altura8.HeaderText = "Alt.8"
        Me.Altura8.Name = "Altura8"
        Me.Altura8.ReadOnly = True
        Me.Altura8.Width = 50
        '
        'Altura9
        '
        Me.Altura9.HeaderText = "Alt.9"
        Me.Altura9.Name = "Altura9"
        Me.Altura9.ReadOnly = True
        Me.Altura9.Width = 50
        '
        'Altura10
        '
        Me.Altura10.HeaderText = "Alt.10"
        Me.Altura10.Name = "Altura10"
        Me.Altura10.ReadOnly = True
        Me.Altura10.Width = 50
        '
        'MejorAltura
        '
        Me.MejorAltura.HeaderText = "Mejor Altura"
        Me.MejorAltura.Name = "MejorAltura"
        Me.MejorAltura.ReadOnly = True
        Me.MejorAltura.Width = 50
        '
        'Clasificación
        '
        Me.Clasificación.HeaderText = "Clasif."
        Me.Clasificación.Name = "Clasificación"
        Me.Clasificación.ReadOnly = True
        Me.Clasificación.Width = 80
        '
        'btnQuitarAtleta
        '
        Me.btnQuitarAtleta.Controls.Add(Me.dgvAltoyGarrocha)
        Me.btnQuitarAtleta.Controls.Add(Me.btnAgregarAtleta)
        Me.btnQuitarAtleta.Controls.Add(Me.grbResultados)
        Me.btnQuitarAtleta.Controls.Add(Me.Button1)
        Me.btnQuitarAtleta.Location = New System.Drawing.Point(58, 163)
        Me.btnQuitarAtleta.Name = "btnQuitarAtleta"
        Me.btnQuitarAtleta.Size = New System.Drawing.Size(870, 370)
        Me.btnQuitarAtleta.TabIndex = 540
        Me.btnQuitarAtleta.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfechainicio)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.TextBox277)
        Me.GroupBox1.Controls.Add(Me.TextBox278)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 144)
        Me.GroupBox1.TabIndex = 541
        Me.GroupBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(282, 89)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox2.TabIndex = 565
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 564
        Me.Label1.Text = "Juez Principal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 548
        Me.Label6.Text = "Categoría"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(65, 88)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 550
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(598, 18)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox4.TabIndex = 563
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(616, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 549
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 546
        Me.Label3.Text = "Prueba"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(539, 21)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 562
        Me.lblLocalidad.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 561
        Me.Label10.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 547
        Me.Label4.Text = "Sexo"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(99, 53)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 560
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(426, 19)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox5.TabIndex = 559
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(254, 53)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(110, 20)
        Me.txtHora.TabIndex = 556
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(440, 52)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(110, 20)
        Me.txtCategoria.TabIndex = 555
        '
        'TextBox277
        '
        Me.TextBox277.Location = New System.Drawing.Point(233, 19)
        Me.TextBox277.Name = "TextBox277"
        Me.TextBox277.Size = New System.Drawing.Size(118, 20)
        Me.TextBox277.TabIndex = 558
        '
        'TextBox278
        '
        Me.TextBox278.Location = New System.Drawing.Point(67, 18)
        Me.TextBox278.Name = "TextBox278"
        Me.TextBox278.Size = New System.Drawing.Size(110, 20)
        Me.TextBox278.TabIndex = 557
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 554
        Me.Label2.Text = "Provincia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 553
        Me.Label8.Text = "Fecha de Inicio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(193, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 552
        Me.Label9.Text = "Lugar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 551
        Me.Label11.Text = "Nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox1.Location = New System.Drawing.Point(793, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 545
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(743, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 48)
        Me.Label5.TabIndex = 544
        Me.Label5.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(853, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 169
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PlanilladeSaltoenAltoyGarrocha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.btnQuitarAtleta)
        Me.Name = "PlanilladeSaltoenAltoyGarrocha"
        Me.Text = "Planilla de Salto en Alto y con Garrocha"
        Me.grbResultados.ResumeLayout(False)
        Me.grbResultados.PerformLayout()
        CType(Me.dgvAltoyGarrocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnQuitarAtleta.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents grbResultados As System.Windows.Forms.GroupBox
    Friend WithEvents btnRehuso As System.Windows.Forms.Button
    Friend WithEvents btnNulo As System.Windows.Forms.Button
    Friend WithEvents btnVálido As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAtleta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents dgvAltoyGarrocha As System.Windows.Forms.DataGridView
    Friend WithEvents btnAltura As System.Windows.Forms.Button
    Friend WithEvents btnQuitarAtleta As System.Windows.Forms.GroupBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpfechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TextBox277 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox278 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Número As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Altura10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MejorAltura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clasificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
