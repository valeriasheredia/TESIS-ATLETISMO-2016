<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanilladeMarcha
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregarAtleta = New System.Windows.Forms.Button()
        Me.btnQuitarAtleta = New System.Windows.Forms.Button()
        Me.dgvAtletasdeCalle = New System.Windows.Forms.DataGridView()
        Me.Número = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Institución = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnGuardarCompetencia = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.cboJuez3 = New System.Windows.Forms.ComboBox()
        Me.cboJuez2 = New System.Windows.Forms.ComboBox()
        Me.cboJuez1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodigoCompetencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDistanciaCompetenciaCalle = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(815, 309)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(106, 44)
        Me.btnIngresar.TabIndex = 551
        Me.btnIngresar.Text = "Ingresar Tiempos"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(530, 489)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 23)
        Me.btnActualizar.TabIndex = 550
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregarAtleta
        '
        Me.btnAgregarAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAtleta.Location = New System.Drawing.Point(503, 178)
        Me.btnAgregarAtleta.Name = "btnAgregarAtleta"
        Me.btnAgregarAtleta.Size = New System.Drawing.Size(132, 27)
        Me.btnAgregarAtleta.TabIndex = 549
        Me.btnAgregarAtleta.Text = "Agregar Atleta"
        Me.btnAgregarAtleta.UseVisualStyleBackColor = True
        '
        'btnQuitarAtleta
        '
        Me.btnQuitarAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarAtleta.Location = New System.Drawing.Point(641, 178)
        Me.btnQuitarAtleta.Name = "btnQuitarAtleta"
        Me.btnQuitarAtleta.Size = New System.Drawing.Size(132, 27)
        Me.btnQuitarAtleta.TabIndex = 548
        Me.btnQuitarAtleta.Text = "Quitar Atleta"
        Me.btnQuitarAtleta.UseVisualStyleBackColor = True
        '
        'dgvAtletasdeCalle
        '
        Me.dgvAtletasdeCalle.AllowUserToAddRows = False
        Me.dgvAtletasdeCalle.AllowUserToDeleteRows = False
        Me.dgvAtletasdeCalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtletasdeCalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Número, Me.Nombre, Me.Apellido, Me.Sexo, Me.Localidad, Me.Edad, Me.Institución, Me.TiempoFinal})
        Me.dgvAtletasdeCalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAtletasdeCalle.Location = New System.Drawing.Point(32, 217)
        Me.dgvAtletasdeCalle.MultiSelect = False
        Me.dgvAtletasdeCalle.Name = "dgvAtletasdeCalle"
        Me.dgvAtletasdeCalle.ReadOnly = True
        Me.dgvAtletasdeCalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAtletasdeCalle.Size = New System.Drawing.Size(741, 257)
        Me.dgvAtletasdeCalle.TabIndex = 547
        '
        'Número
        '
        Me.Número.HeaderText = "Número"
        Me.Número.Name = "Número"
        Me.Número.ReadOnly = True
        Me.Número.Width = 50
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
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 50
        '
        'Institución
        '
        Me.Institución.HeaderText = "Institución"
        Me.Institución.Name = "Institución"
        Me.Institución.ReadOnly = True
        '
        'TiempoFinal
        '
        Me.TiempoFinal.HeaderText = "Tiempo Final"
        Me.TiempoFinal.Name = "TiempoFinal"
        Me.TiempoFinal.ReadOnly = True
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(449, 489)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(75, 23)
        Me.btnComenzar.TabIndex = 545
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'btnGuardarCompetencia
        '
        Me.btnGuardarCompetencia.Location = New System.Drawing.Point(616, 489)
        Me.btnGuardarCompetencia.Name = "btnGuardarCompetencia"
        Me.btnGuardarCompetencia.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCompetencia.TabIndex = 544
        Me.btnGuardarCompetencia.Text = "Guardar"
        Me.btnGuardarCompetencia.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(698, 489)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 543
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboUsuario)
        Me.GroupBox1.Controls.Add(Me.cboJuez3)
        Me.GroupBox1.Controls.Add(Me.cboJuez2)
        Me.GroupBox1.Controls.Add(Me.cboJuez1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCompetencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDistanciaCompetenciaCalle)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboLocalidad)
        Me.GroupBox1.Controls.Add(Me.lblLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpfechainicio)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.txtLugar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 160)
        Me.GroupBox1.TabIndex = 541
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(180, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 232
        Me.Label13.Text = "Usuario"
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(239, 132)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 231
        '
        'cboJuez3
        '
        Me.cboJuez3.FormattingEnabled = True
        Me.cboJuez3.Location = New System.Drawing.Point(594, 117)
        Me.cboJuez3.Name = "cboJuez3"
        Me.cboJuez3.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez3.TabIndex = 228
        '
        'cboJuez2
        '
        Me.cboJuez2.FormattingEnabled = True
        Me.cboJuez2.Location = New System.Drawing.Point(594, 93)
        Me.cboJuez2.Name = "cboJuez2"
        Me.cboJuez2.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez2.TabIndex = 229
        '
        'cboJuez1
        '
        Me.cboJuez1.FormattingEnabled = True
        Me.cboJuez1.Location = New System.Drawing.Point(594, 67)
        Me.cboJuez1.Name = "cboJuez1"
        Me.cboJuez1.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez1.TabIndex = 230
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(550, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Juez 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(550, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 226
        Me.Label8.Text = "Juez 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(550, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 225
        Me.Label12.Text = "Juez 1"
        '
        'txtCodigoCompetencia
        '
        Me.txtCodigoCompetencia.Location = New System.Drawing.Point(135, 21)
        Me.txtCodigoCompetencia.Name = "txtCodigoCompetencia"
        Me.txtCodigoCompetencia.ReadOnly = True
        Me.txtCodigoCompetencia.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoCompetencia.TabIndex = 215
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Código de Competencia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Distancia (Km)"
        '
        'txtDistanciaCompetenciaCalle
        '
        Me.txtDistanciaCompetenciaCalle.Location = New System.Drawing.Point(466, 105)
        Me.txtDistanciaCompetenciaCalle.Name = "txtDistanciaCompetenciaCalle"
        Me.txtDistanciaCompetenciaCalle.Size = New System.Drawing.Size(39, 20)
        Me.txtDistanciaCompetenciaCalle.TabIndex = 210
        Me.txtDistanciaCompetenciaCalle.Text = "0"
        Me.txtDistanciaCompetenciaCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox1.Location = New System.Drawing.Point(786, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(244, 106)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(109, 20)
        Me.txtHora.TabIndex = 154
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(739, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 48)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboLocalidad
        '
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(295, 63)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(154, 21)
        Me.cboLocalidad.TabIndex = 115
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(236, 70)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 114
        Me.lblLocalidad.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Hora"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(95, 106)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 108
        Me.dtpfechainicio.Value = New Date(2016, 8, 5, 19, 21, 0, 0)
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(64, 67)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(154, 21)
        Me.cboProvincia.TabIndex = 107
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(476, 21)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(134, 20)
        Me.txtLugar.TabIndex = 105
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(258, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Fecha de Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Lugar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Nombre"
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImprimir.Location = New System.Drawing.Point(32, 489)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 542
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PlanilladeMarcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 520)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregarAtleta)
        Me.Controls.Add(Me.btnQuitarAtleta)
        Me.Controls.Add(Me.dgvAtletasdeCalle)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.btnGuardarCompetencia)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "PlanilladeMarcha"
        Me.Text = "Planilla de Marcha"
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAtleta As System.Windows.Forms.Button
    Friend WithEvents btnQuitarAtleta As System.Windows.Forms.Button
    Friend WithEvents dgvAtletasdeCalle As System.Windows.Forms.DataGridView
    Friend WithEvents Número As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Institución As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCompetencia As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDistanciaCompetenciaCalle As System.Windows.Forms.TextBox
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
