<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVACOMPETENCIA
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cboJuez3 = New System.Windows.Forms.ComboBox()
        Me.cboJuez2 = New System.Windows.Forms.ComboBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.cboJuez1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNombreCompetencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLocalidadCompetenciaCalle = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtLugarCompetenciaCalle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboProvinciaCompetencia = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicioCompetenciaCalle = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigoCompetencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkCalle = New System.Windows.Forms.GroupBox()
        Me.grbPistayCampo = New System.Windows.Forms.GroupBox()
        Me.txtOtra = New System.Windows.Forms.TextBox()
        Me.cboPruebas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPista = New System.Windows.Forms.Label()
        Me.cboDisciplinas = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grbTipoCompetencia = New System.Windows.Forms.GroupBox()
        Me.rbtPistayCampo = New System.Windows.Forms.RadioButton()
        Me.rbtCalle = New System.Windows.Forms.RadioButton()
        Me.grbCalle = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDistanciaCompetenciaCalle = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chkCalle.SuspendLayout()
        Me.grbPistayCampo.SuspendLayout()
        Me.grbTipoCompetencia.SuspendLayout()
        Me.grbCalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtEstado)
        Me.GroupBox5.Controls.Add(Me.cboJuez3)
        Me.GroupBox5.Controls.Add(Me.cboJuez2)
        Me.GroupBox5.Controls.Add(Me.cboUsuario)
        Me.GroupBox5.Controls.Add(Me.cboJuez1)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtHora)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtNombreCompetencia)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.cboLocalidadCompetenciaCalle)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.lblLocalidad)
        Me.GroupBox5.Controls.Add(Me.txtLugarCompetenciaCalle)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.cboProvinciaCompetencia)
        Me.GroupBox5.Controls.Add(Me.dtpFechaInicioCompetenciaCalle)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(842, 165)
        Me.GroupBox5.TabIndex = 223
        Me.GroupBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 13)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "Estado de Competencia"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(342, 135)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(95, 20)
        Me.txtEstado.TabIndex = 225
        Me.txtEstado.Text = "Activa"
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboJuez3
        '
        Me.cboJuez3.FormattingEnabled = True
        Me.cboJuez3.Location = New System.Drawing.Point(510, 130)
        Me.cboJuez3.Name = "cboJuez3"
        Me.cboJuez3.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez3.TabIndex = 224
        '
        'cboJuez2
        '
        Me.cboJuez2.FormattingEnabled = True
        Me.cboJuez2.Location = New System.Drawing.Point(510, 106)
        Me.cboJuez2.Name = "cboJuez2"
        Me.cboJuez2.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez2.TabIndex = 224
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(71, 135)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 224
        '
        'cboJuez1
        '
        Me.cboJuez1.FormattingEnabled = True
        Me.cboJuez1.Location = New System.Drawing.Point(510, 80)
        Me.cboJuez1.Name = "cboJuez1"
        Me.cboJuez1.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez1.TabIndex = 224
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(466, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 223
        Me.Label11.Text = "Juez 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(466, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "Juez 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 221
        Me.Label12.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "Juez 1"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(249, 105)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(62, 20)
        Me.txtHora.TabIndex = 220
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox2.Location = New System.Drawing.Point(689, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 219
        Me.PictureBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(631, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(193, 48)
        Me.Label18.TabIndex = 218
        Me.Label18.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNombreCompetencia
        '
        Me.txtNombreCompetencia.Location = New System.Drawing.Point(60, 28)
        Me.txtNombreCompetencia.Name = "txtNombreCompetencia"
        Me.txtNombreCompetencia.Size = New System.Drawing.Size(172, 20)
        Me.txtNombreCompetencia.TabIndex = 202
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Lugar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Fecha de Inicio"
        '
        'cboLocalidadCompetenciaCalle
        '
        Me.cboLocalidadCompetenciaCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalidadCompetenciaCalle.FormattingEnabled = True
        Me.cboLocalidadCompetenciaCalle.Location = New System.Drawing.Point(276, 62)
        Me.cboLocalidadCompetenciaCalle.Name = "cboLocalidadCompetenciaCalle"
        Me.cboLocalidadCompetenciaCalle.Size = New System.Drawing.Size(171, 21)
        Me.cboLocalidadCompetenciaCalle.TabIndex = 211
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Provincia"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(217, 65)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 210
        Me.lblLocalidad.Text = "Localidad"
        '
        'txtLugarCompetenciaCalle
        '
        Me.txtLugarCompetenciaCalle.Location = New System.Drawing.Point(278, 28)
        Me.txtLugarCompetenciaCalle.Name = "txtLugarCompetenciaCalle"
        Me.txtLugarCompetenciaCalle.Size = New System.Drawing.Size(161, 20)
        Me.txtLugarCompetenciaCalle.TabIndex = 203
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 209
        Me.Label10.Text = "Hora"
        '
        'cboProvinciaCompetencia
        '
        Me.cboProvinciaCompetencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvinciaCompetencia.FormattingEnabled = True
        Me.cboProvinciaCompetencia.Location = New System.Drawing.Point(60, 62)
        Me.cboProvinciaCompetencia.Name = "cboProvinciaCompetencia"
        Me.cboProvinciaCompetencia.Size = New System.Drawing.Size(136, 21)
        Me.cboProvinciaCompetencia.TabIndex = 205
        '
        'dtpFechaInicioCompetenciaCalle
        '
        Me.dtpFechaInicioCompetenciaCalle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioCompetenciaCalle.Location = New System.Drawing.Point(105, 102)
        Me.dtpFechaInicioCompetenciaCalle.Name = "dtpFechaInicioCompetenciaCalle"
        Me.dtpFechaInicioCompetenciaCalle.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicioCompetenciaCalle.TabIndex = 206
        '
        'txtCodigoCompetencia
        '
        Me.txtCodigoCompetencia.Location = New System.Drawing.Point(160, 355)
        Me.txtCodigoCompetencia.Name = "txtCodigoCompetencia"
        Me.txtCodigoCompetencia.ReadOnly = True
        Me.txtCodigoCompetencia.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoCompetencia.TabIndex = 213
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Código de Competencia"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(534, 348)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(161, 23)
        Me.btnCrear.TabIndex = 224
        Me.btnCrear.Text = "Crear Competencia"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(779, 348)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 226
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkCalle
        '
        Me.chkCalle.Controls.Add(Me.grbPistayCampo)
        Me.chkCalle.Controls.Add(Me.grbTipoCompetencia)
        Me.chkCalle.Controls.Add(Me.grbCalle)
        Me.chkCalle.Location = New System.Drawing.Point(12, 175)
        Me.chkCalle.Name = "chkCalle"
        Me.chkCalle.Size = New System.Drawing.Size(843, 167)
        Me.chkCalle.TabIndex = 532
        Me.chkCalle.TabStop = False
        '
        'grbPistayCampo
        '
        Me.grbPistayCampo.Controls.Add(Me.txtOtra)
        Me.grbPistayCampo.Controls.Add(Me.cboPruebas)
        Me.grbPistayCampo.Controls.Add(Me.Label8)
        Me.grbPistayCampo.Controls.Add(Me.txtPista)
        Me.grbPistayCampo.Controls.Add(Me.cboDisciplinas)
        Me.grbPistayCampo.Controls.Add(Me.Label14)
        Me.grbPistayCampo.Location = New System.Drawing.Point(510, 31)
        Me.grbPistayCampo.Name = "grbPistayCampo"
        Me.grbPistayCampo.Size = New System.Drawing.Size(289, 122)
        Me.grbPistayCampo.TabIndex = 221
        Me.grbPistayCampo.TabStop = False
        Me.grbPistayCampo.Text = "Opciones de Pista y Campo"
        '
        'txtOtra
        '
        Me.txtOtra.Location = New System.Drawing.Point(64, 89)
        Me.txtOtra.Name = "txtOtra"
        Me.txtOtra.Size = New System.Drawing.Size(127, 20)
        Me.txtOtra.TabIndex = 84
        Me.txtOtra.Text = "--Ninguna--"
        Me.txtOtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboPruebas
        '
        Me.cboPruebas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPruebas.FormattingEnabled = True
        Me.cboPruebas.Location = New System.Drawing.Point(65, 66)
        Me.cboPruebas.Name = "cboPruebas"
        Me.cboPruebas.Size = New System.Drawing.Size(175, 21)
        Me.cboPruebas.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Otra"
        '
        'txtPista
        '
        Me.txtPista.AutoSize = True
        Me.txtPista.Location = New System.Drawing.Point(9, 42)
        Me.txtPista.Name = "txtPista"
        Me.txtPista.Size = New System.Drawing.Size(52, 13)
        Me.txtPista.TabIndex = 83
        Me.txtPista.Text = "Disciplina"
        '
        'cboDisciplinas
        '
        Me.cboDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisciplinas.FormattingEnabled = True
        Me.cboDisciplinas.Location = New System.Drawing.Point(64, 39)
        Me.cboDisciplinas.Name = "cboDisciplinas"
        Me.cboDisciplinas.Size = New System.Drawing.Size(176, 21)
        Me.cboDisciplinas.TabIndex = 82
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Prueba"
        '
        'grbTipoCompetencia
        '
        Me.grbTipoCompetencia.Controls.Add(Me.rbtPistayCampo)
        Me.grbTipoCompetencia.Controls.Add(Me.rbtCalle)
        Me.grbTipoCompetencia.Location = New System.Drawing.Point(16, 17)
        Me.grbTipoCompetencia.Name = "grbTipoCompetencia"
        Me.grbTipoCompetencia.Size = New System.Drawing.Size(137, 136)
        Me.grbTipoCompetencia.TabIndex = 222
        Me.grbTipoCompetencia.TabStop = False
        Me.grbTipoCompetencia.Text = "Tipo de Competencia"
        '
        'rbtPistayCampo
        '
        Me.rbtPistayCampo.AutoSize = True
        Me.rbtPistayCampo.Location = New System.Drawing.Point(6, 53)
        Me.rbtPistayCampo.Name = "rbtPistayCampo"
        Me.rbtPistayCampo.Size = New System.Drawing.Size(92, 17)
        Me.rbtPistayCampo.TabIndex = 1
        Me.rbtPistayCampo.Text = "Pista y Campo"
        Me.rbtPistayCampo.UseVisualStyleBackColor = True
        '
        'rbtCalle
        '
        Me.rbtCalle.AutoSize = True
        Me.rbtCalle.Location = New System.Drawing.Point(6, 30)
        Me.rbtCalle.Name = "rbtCalle"
        Me.rbtCalle.Size = New System.Drawing.Size(48, 17)
        Me.rbtCalle.TabIndex = 0
        Me.rbtCalle.Text = "Calle"
        Me.rbtCalle.UseVisualStyleBackColor = True
        '
        'grbCalle
        '
        Me.grbCalle.Controls.Add(Me.Label5)
        Me.grbCalle.Controls.Add(Me.txtDistanciaCompetenciaCalle)
        Me.grbCalle.Location = New System.Drawing.Point(221, 31)
        Me.grbCalle.Name = "grbCalle"
        Me.grbCalle.Size = New System.Drawing.Size(283, 122)
        Me.grbCalle.TabIndex = 220
        Me.grbCalle.TabStop = False
        Me.grbCalle.Text = "Opciones de Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Distancia (Km)"
        '
        'txtDistanciaCompetenciaCalle
        '
        Me.txtDistanciaCompetenciaCalle.Location = New System.Drawing.Point(107, 35)
        Me.txtDistanciaCompetenciaCalle.Name = "txtDistanciaCompetenciaCalle"
        Me.txtDistanciaCompetenciaCalle.Size = New System.Drawing.Size(39, 20)
        Me.txtDistanciaCompetenciaCalle.TabIndex = 208
        Me.txtDistanciaCompetenciaCalle.Text = "0"
        Me.txtDistanciaCompetenciaCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(701, 348)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 533
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'NUEVACOMPETENCIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 382)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.chkCalle)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigoCompetencia)
        Me.Name = "NUEVACOMPETENCIA"
        Me.Text = "NUEVA COMPETENCIA"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chkCalle.ResumeLayout(False)
        Me.grbPistayCampo.ResumeLayout(False)
        Me.grbPistayCampo.PerformLayout()
        Me.grbTipoCompetencia.ResumeLayout(False)
        Me.grbTipoCompetencia.PerformLayout()
        Me.grbCalle.ResumeLayout(False)
        Me.grbCalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboLocalidadCompetenciaCalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents txtLugarCompetenciaCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboProvinciaCompetencia As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaInicioCompetenciaCalle As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkCalle As System.Windows.Forms.GroupBox
    Friend WithEvents grbTipoCompetencia As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPistayCampo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCalle As System.Windows.Forms.RadioButton
    Friend WithEvents grbPistayCampo As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtra As System.Windows.Forms.TextBox
    Friend WithEvents cboPruebas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPista As System.Windows.Forms.Label
    Friend WithEvents cboDisciplinas As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grbCalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDistanciaCompetenciaCalle As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents cboJuez3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboJuez1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
