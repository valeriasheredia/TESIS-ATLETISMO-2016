<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanillaFinalCalle
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
        Me.dgvAtletasdeCalle = New System.Windows.Forms.DataGridView()
        Me.Dorsal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Institución = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Atleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Resultado_Parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboRango = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cboJuez3 = New System.Windows.Forms.ComboBox()
        Me.cboJuez2 = New System.Windows.Forms.ComboBox()
        Me.cboJuez1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.txtCodigoPlanillaCalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAtletasdeCalle
        '
        Me.dgvAtletasdeCalle.AllowUserToAddRows = False
        Me.dgvAtletasdeCalle.AllowUserToDeleteRows = False
        Me.dgvAtletasdeCalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtletasdeCalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dorsal, Me.Nombre, Me.Apellido, Me.Sexo, Me.Localidad, Me.Edad, Me.Institución, Me.TiempoAsignado, Me.Id_Atleta, Me.Id_Resultado_Parcial})
        Me.dgvAtletasdeCalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAtletasdeCalle.Location = New System.Drawing.Point(76, 219)
        Me.dgvAtletasdeCalle.MultiSelect = False
        Me.dgvAtletasdeCalle.Name = "dgvAtletasdeCalle"
        Me.dgvAtletasdeCalle.ReadOnly = True
        Me.dgvAtletasdeCalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAtletasdeCalle.Size = New System.Drawing.Size(743, 281)
        Me.dgvAtletasdeCalle.TabIndex = 529
        '
        'Dorsal
        '
        Me.Dorsal.HeaderText = "Dorsal"
        Me.Dorsal.Name = "Dorsal"
        Me.Dorsal.ReadOnly = True
        Me.Dorsal.Width = 50
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
        'cboRango
        '
        Me.cboRango.FormattingEnabled = True
        Me.cboRango.Items.AddRange(New Object() {"Cada 5 años", "Cada 10 años"})
        Me.cboRango.Location = New System.Drawing.Point(117, 19)
        Me.cboRango.Name = "cboRango"
        Me.cboRango.Size = New System.Drawing.Size(121, 21)
        Me.cboRango.TabIndex = 530
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 531
        Me.Label4.Text = "Rango de Edades"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Ambos", "Femenino", "Masculino"})
        Me.cboSexo.Location = New System.Drawing.Point(282, 19)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 21)
        Me.cboSexo.TabIndex = 530
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 531
        Me.Label12.Text = "Sexo"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(409, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 533
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Controls.Add(Me.cboRango)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboSexo)
        Me.GroupBox2.Location = New System.Drawing.Point(147, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 46)
        Me.GroupBox2.TabIndex = 534
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(656, 506)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 533
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(744, 506)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 533
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.cboJuez3)
        Me.GroupBox1.Controls.Add(Me.cboJuez2)
        Me.GroupBox1.Controls.Add(Me.cboJuez1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
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
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 160)
        Me.GroupBox1.TabIndex = 535
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 236
        Me.Label11.Text = "Estado de Competencia"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(147, 130)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(95, 20)
        Me.txtEstado.TabIndex = 235
        Me.txtEstado.Text = "Activa"
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(550, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "Juez 3"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Juez 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Distancia (Km)"
        '
        'txtDistanciaCompetenciaCalle
        '
        Me.txtDistanciaCompetenciaCalle.Location = New System.Drawing.Point(273, 95)
        Me.txtDistanciaCompetenciaCalle.Name = "txtDistanciaCompetenciaCalle"
        Me.txtDistanciaCompetenciaCalle.ReadOnly = True
        Me.txtDistanciaCompetenciaCalle.Size = New System.Drawing.Size(39, 20)
        Me.txtDistanciaCompetenciaCalle.TabIndex = 210
        Me.txtDistanciaCompetenciaCalle.Text = "0"
        Me.txtDistanciaCompetenciaCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtHora.Location = New System.Drawing.Point(51, 96)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(73, 20)
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
        Me.cboLocalidad.Location = New System.Drawing.Point(73, 60)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(154, 21)
        Me.cboLocalidad.TabIndex = 115
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(14, 67)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 114
        Me.lblLocalidad.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Hora"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(327, 60)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 108
        Me.dtpfechainicio.Value = New Date(2016, 8, 5, 19, 21, 0, 0)
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(487, 21)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(154, 21)
        Me.cboProvincia.TabIndex = 107
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(282, 21)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.ReadOnly = True
        Me.txtLugar.Size = New System.Drawing.Size(134, 20)
        Me.txtLugar.TabIndex = 105
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Provincia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Fecha de Inicio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(242, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Lugar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(711, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 232
        Me.Label13.Text = "Usuario"
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(770, 186)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 231
        '
        'txtCodigoPlanillaCalle
        '
        Me.txtCodigoPlanillaCalle.Location = New System.Drawing.Point(841, 164)
        Me.txtCodigoPlanillaCalle.Name = "txtCodigoPlanillaCalle"
        Me.txtCodigoPlanillaCalle.ReadOnly = True
        Me.txtCodigoPlanillaCalle.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoPlanillaCalle.TabIndex = 215
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(715, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Código de Competencia"
        '
        'PlanillaFinalCalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 540)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dgvAtletasdeCalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoPlanillaCalle)
        Me.Name = "PlanillaFinalCalle"
        Me.Text = "Planilla Final Calle"
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAtletasdeCalle As System.Windows.Forms.DataGridView
    Friend WithEvents cboRango As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPlanillaCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Dorsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Institución As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Atleta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Resultado_Parcial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
End Class
