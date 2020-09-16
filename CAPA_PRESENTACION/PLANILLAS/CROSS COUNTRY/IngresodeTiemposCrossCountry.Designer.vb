<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresodeTiemposCrossCountry
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.btnInformeFinal = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtTiempo3 = New System.Windows.Forms.TextBox()
        Me.txtTiempo2 = New System.Windows.Forms.TextBox()
        Me.txtTiempo1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.btnAgregarTiempo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboPrueba = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboJuez3 = New System.Windows.Forms.ComboBox()
        Me.cboJuez2 = New System.Windows.Forms.ComboBox()
        Me.cboJuez1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpfechainicio = New System.Windows.Forms.DateTimePicker()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvTiempos = New System.Windows.Forms.DataGridView()
        Me.Dorsal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoJuez1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoJuez2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoJuez3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Atleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Resultado_Parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoPlanillaCrossCountry = New System.Windows.Forms.TextBox()
        Me.ckbEditarTiempo = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTiempos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 510)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 554
        Me.Label13.Text = "Usuario"
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(279, 507)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 553
        '
        'btnInformeFinal
        '
        Me.btnInformeFinal.Location = New System.Drawing.Point(622, 500)
        Me.btnInformeFinal.Name = "btnInformeFinal"
        Me.btnInformeFinal.Size = New System.Drawing.Size(119, 23)
        Me.btnInformeFinal.TabIndex = 557
        Me.btnInformeFinal.Text = "Ir a Informe Final"
        Me.btnInformeFinal.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(747, 500)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 556
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(828, 500)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 555
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.btnAceptar)
        Me.GroupBox4.Controls.Add(Me.txtTiempo3)
        Me.GroupBox4.Controls.Add(Me.txtTiempo2)
        Me.GroupBox4.Controls.Add(Me.txtTiempo1)
        Me.GroupBox4.Location = New System.Drawing.Point(665, 321)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 149)
        Me.GroupBox4.TabIndex = 550
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Editar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Tiempo de Juez 3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Tiempo de Juez 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Tiempo de Juez 1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(82, 118)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 106
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtTiempo3
        '
        Me.txtTiempo3.Location = New System.Drawing.Point(105, 92)
        Me.txtTiempo3.Name = "txtTiempo3"
        Me.txtTiempo3.Size = New System.Drawing.Size(123, 20)
        Me.txtTiempo3.TabIndex = 105
        '
        'txtTiempo2
        '
        Me.txtTiempo2.Location = New System.Drawing.Point(105, 56)
        Me.txtTiempo2.Name = "txtTiempo2"
        Me.txtTiempo2.Size = New System.Drawing.Size(123, 20)
        Me.txtTiempo2.TabIndex = 105
        '
        'txtTiempo1
        '
        Me.txtTiempo1.Location = New System.Drawing.Point(105, 20)
        Me.txtTiempo1.Name = "txtTiempo1"
        Me.txtTiempo1.Size = New System.Drawing.Size(123, 20)
        Me.txtTiempo1.TabIndex = 105
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTiempo)
        Me.GroupBox3.Controls.Add(Me.btnAgregarTiempo)
        Me.GroupBox3.Location = New System.Drawing.Point(665, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 69)
        Me.GroupBox3.TabIndex = 549
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese Tiempo"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(16, 19)
        Me.txtTiempo.Multiline = True
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(124, 39)
        Me.txtTiempo.TabIndex = 4
        '
        'btnAgregarTiempo
        '
        Me.btnAgregarTiempo.Location = New System.Drawing.Point(151, 19)
        Me.btnAgregarTiempo.Name = "btnAgregarTiempo"
        Me.btnAgregarTiempo.Size = New System.Drawing.Size(75, 39)
        Me.btnAgregarTiempo.TabIndex = 6
        Me.btnAgregarTiempo.Text = "Agregar"
        Me.btnAgregarTiempo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cboPrueba)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cboSexo)
        Me.GroupBox2.Controls.Add(Me.cboCategoria)
        Me.GroupBox2.Controls.Add(Me.cboJuez3)
        Me.GroupBox2.Controls.Add(Me.cboJuez2)
        Me.GroupBox2.Controls.Add(Me.cboJuez1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtHora)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboLocalidad)
        Me.GroupBox2.Controls.Add(Me.lblLocalidad)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpfechainicio)
        Me.GroupBox2.Controls.Add(Me.cboProvincia)
        Me.GroupBox2.Controls.Add(Me.txtLugar)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 160)
        Me.GroupBox2.TabIndex = 548
        Me.GroupBox2.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(499, 130)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(109, 20)
        Me.txtEstado.TabIndex = 684
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 683
        Me.Label1.Text = "Estado de Competencia"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 680
        Me.Label17.Text = "Prueba"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(373, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 678
        Me.Label18.Text = "Categoría"
        '
        'cboPrueba
        '
        Me.cboPrueba.FormattingEnabled = True
        Me.cboPrueba.Location = New System.Drawing.Point(55, 131)
        Me.cboPrueba.Name = "cboPrueba"
        Me.cboPrueba.Size = New System.Drawing.Size(121, 21)
        Me.cboPrueba.TabIndex = 679
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(191, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 677
        Me.Label19.Text = "Sexo"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(232, 131)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 21)
        Me.cboSexo.TabIndex = 675
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(433, 93)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 676
        '
        'cboJuez3
        '
        Me.cboJuez3.FormattingEnabled = True
        Me.cboJuez3.Location = New System.Drawing.Point(560, 66)
        Me.cboJuez3.Name = "cboJuez3"
        Me.cboJuez3.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez3.TabIndex = 228
        '
        'cboJuez2
        '
        Me.cboJuez2.FormattingEnabled = True
        Me.cboJuez2.Location = New System.Drawing.Point(560, 42)
        Me.cboJuez2.Name = "cboJuez2"
        Me.cboJuez2.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez2.TabIndex = 229
        '
        'cboJuez1
        '
        Me.cboJuez1.FormattingEnabled = True
        Me.cboJuez1.Location = New System.Drawing.Point(560, 16)
        Me.cboJuez1.Name = "cboJuez1"
        Me.cboJuez1.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez1.TabIndex = 230
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(516, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Juez 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(516, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 226
        Me.Label8.Text = "Juez 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(516, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 225
        Me.Label12.Text = "Juez 1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox1.Location = New System.Drawing.Point(749, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(244, 94)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(109, 20)
        Me.txtHora.TabIndex = 154
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(702, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 48)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboLocalidad
        '
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(295, 55)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(154, 21)
        Me.cboLocalidad.TabIndex = 115
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(236, 62)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 114
        Me.lblLocalidad.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Hora"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(95, 94)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 108
        Me.dtpfechainicio.Value = New Date(2016, 8, 5, 19, 21, 0, 0)
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(64, 59)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(154, 21)
        Me.cboProvincia.TabIndex = 107
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(276, 21)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.ReadOnly = True
        Me.txtLugar.Size = New System.Drawing.Size(134, 20)
        Me.txtLugar.TabIndex = 105
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(58, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Fecha de Inicio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(236, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Lugar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Nombre"
        '
        'dgvTiempos
        '
        Me.dgvTiempos.AllowUserToAddRows = False
        Me.dgvTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiempos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dorsal, Me.Apellido, Me.TiempoJuez1, Me.TiempoJuez2, Me.TiempoJuez3, Me.TiempoAsignado, Me.Id_Atleta, Me.Id_Resultado_Parcial})
        Me.dgvTiempos.Enabled = False
        Me.dgvTiempos.Location = New System.Drawing.Point(12, 189)
        Me.dgvTiempos.Name = "dgvTiempos"
        Me.dgvTiempos.ReadOnly = True
        Me.dgvTiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiempos.Size = New System.Drawing.Size(645, 279)
        Me.dgvTiempos.TabIndex = 547
        '
        'Dorsal
        '
        Me.Dorsal.HeaderText = "Dorsal"
        Me.Dorsal.Name = "Dorsal"
        Me.Dorsal.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'TiempoJuez1
        '
        Me.TiempoJuez1.HeaderText = "Tiempo Juez 1"
        Me.TiempoJuez1.Name = "TiempoJuez1"
        Me.TiempoJuez1.ReadOnly = True
        '
        'TiempoJuez2
        '
        Me.TiempoJuez2.HeaderText = "Tiempo Juez 2"
        Me.TiempoJuez2.Name = "TiempoJuez2"
        Me.TiempoJuez2.ReadOnly = True
        '
        'TiempoJuez3
        '
        Me.TiempoJuez3.HeaderText = "Tiempo Juez 3"
        Me.TiempoJuez3.Name = "TiempoJuez3"
        Me.TiempoJuez3.ReadOnly = True
        '
        'TiempoAsignado
        '
        Me.TiempoAsignado.HeaderText = "Tiempo Asignado"
        Me.TiempoAsignado.Name = "TiempoAsignado"
        Me.TiempoAsignado.ReadOnly = True
        '
        'Id_Atleta
        '
        Me.Id_Atleta.HeaderText = "Id_Atleta"
        Me.Id_Atleta.Name = "Id_Atleta"
        Me.Id_Atleta.ReadOnly = True
        '
        'Id_Resultado_Parcial
        '
        Me.Id_Resultado_Parcial.HeaderText = "Id_Resultado_Parcial"
        Me.Id_Resultado_Parcial.Name = "Id_Resultado_Parcial"
        Me.Id_Resultado_Parcial.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 551
        Me.Label3.Text = "Código de Competencia"
        '
        'txtCodigoPlanillaCrossCountry
        '
        Me.txtCodigoPlanillaCrossCountry.Location = New System.Drawing.Point(346, 485)
        Me.txtCodigoPlanillaCrossCountry.Name = "txtCodigoPlanillaCrossCountry"
        Me.txtCodigoPlanillaCrossCountry.ReadOnly = True
        Me.txtCodigoPlanillaCrossCountry.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoPlanillaCrossCountry.TabIndex = 552
        '
        'ckbEditarTiempo
        '
        Me.ckbEditarTiempo.AutoSize = True
        Me.ckbEditarTiempo.Location = New System.Drawing.Point(665, 298)
        Me.ckbEditarTiempo.Name = "ckbEditarTiempo"
        Me.ckbEditarTiempo.Size = New System.Drawing.Size(91, 17)
        Me.ckbEditarTiempo.TabIndex = 558
        Me.ckbEditarTiempo.Text = "Editar Tiempo"
        Me.ckbEditarTiempo.UseVisualStyleBackColor = True
        '
        'IngresodeTiemposCrossCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 532)
        Me.Controls.Add(Me.ckbEditarTiempo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.btnInformeFinal)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvTiempos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoPlanillaCrossCountry)
        Me.Name = "IngresodeTiemposCrossCountry"
        Me.Text = "Ingreso de Tiempos Cross Country"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTiempos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents btnInformeFinal As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtTiempo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempo1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTiempo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarTiempo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboJuez3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpfechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvTiempos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPlanillaCrossCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboPrueba As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ckbEditarTiempo As System.Windows.Forms.CheckBox
    Friend WithEvents Dorsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoJuez1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoJuez2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoJuez3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Atleta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Resultado_Parcial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
