<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanillaFinalMarcha
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPrueba = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvAtletasdeCalle = New System.Windows.Forms.DataGridView()
        Me.Dorsal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Institución = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Atleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Resultado_Parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigoMarcha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(603, 468)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 538
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(515, 468)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 537
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboPrueba)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboSexo)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.cboJuez3)
        Me.GroupBox1.Controls.Add(Me.cboJuez2)
        Me.GroupBox1.Controls.Add(Me.cboJuez1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
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
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 160)
        Me.GroupBox1.TabIndex = 559
        Me.GroupBox1.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(347, 130)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(109, 20)
        Me.txtEstado.TabIndex = 688
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 680
        Me.Label14.Text = "Prueba"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(221, 133)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 13)
        Me.Label17.TabIndex = 687
        Me.Label17.Text = "Estado de Competencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 678
        Me.Label4.Text = "Categoría"
        '
        'cboPrueba
        '
        Me.cboPrueba.FormattingEnabled = True
        Me.cboPrueba.Location = New System.Drawing.Point(63, 78)
        Me.cboPrueba.Name = "cboPrueba"
        Me.cboPrueba.Size = New System.Drawing.Size(121, 21)
        Me.cboPrueba.TabIndex = 679
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 677
        Me.Label7.Text = "Sexo"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(262, 96)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 21)
        Me.cboSexo.TabIndex = 675
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(69, 115)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 676
        '
        'cboJuez3
        '
        Me.cboJuez3.FormattingEnabled = True
        Me.cboJuez3.Location = New System.Drawing.Point(519, 125)
        Me.cboJuez3.Name = "cboJuez3"
        Me.cboJuez3.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez3.TabIndex = 228
        '
        'cboJuez2
        '
        Me.cboJuez2.FormattingEnabled = True
        Me.cboJuez2.Location = New System.Drawing.Point(519, 101)
        Me.cboJuez2.Name = "cboJuez2"
        Me.cboJuez2.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez2.TabIndex = 229
        '
        'cboJuez1
        '
        Me.cboJuez1.FormattingEnabled = True
        Me.cboJuez1.Location = New System.Drawing.Point(519, 75)
        Me.cboJuez1.Name = "cboJuez1"
        Me.cboJuez1.Size = New System.Drawing.Size(121, 21)
        Me.cboJuez1.TabIndex = 230
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(475, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Juez 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(475, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 226
        Me.Label8.Text = "Juez 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(475, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 225
        Me.Label12.Text = "Juez 1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources._972035_491669154244375_182680477_n
        Me.PictureBox1.Location = New System.Drawing.Point(692, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(469, 47)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(109, 20)
        Me.txtHora.TabIndex = 154
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(645, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 48)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Asociación Atlética " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Córdoba Centro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboLocalidad
        '
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(65, 43)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(154, 21)
        Me.cboLocalidad.TabIndex = 115
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(6, 50)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 114
        Me.lblLocalidad.Text = "Localidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(433, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Hora"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(323, 47)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpfechainicio.TabIndex = 108
        Me.dtpfechainicio.Value = New Date(2016, 8, 5, 19, 21, 0, 0)
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(485, 13)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(154, 21)
        Me.cboProvincia.TabIndex = 107
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(277, 13)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.ReadOnly = True
        Me.txtLugar.Size = New System.Drawing.Size(134, 20)
        Me.txtLugar.TabIndex = 105
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(59, 13)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Fecha de Inicio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Lugar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Nombre"
        '
        'dgvAtletasdeCalle
        '
        Me.dgvAtletasdeCalle.AllowUserToAddRows = False
        Me.dgvAtletasdeCalle.AllowUserToDeleteRows = False
        Me.dgvAtletasdeCalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtletasdeCalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dorsal, Me.Nombre, Me.Apellido, Me.Institución, Me.TiempoAsignado, Me.Id_Atleta, Me.Id_Resultado_Parcial})
        Me.dgvAtletasdeCalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAtletasdeCalle.Location = New System.Drawing.Point(184, 181)
        Me.dgvAtletasdeCalle.MultiSelect = False
        Me.dgvAtletasdeCalle.Name = "dgvAtletasdeCalle"
        Me.dgvAtletasdeCalle.ReadOnly = True
        Me.dgvAtletasdeCalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAtletasdeCalle.Size = New System.Drawing.Size(494, 281)
        Me.dgvAtletasdeCalle.TabIndex = 560
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
        'txtCodigoMarcha
        '
        Me.txtCodigoMarcha.Location = New System.Drawing.Point(57, 181)
        Me.txtCodigoMarcha.Name = "txtCodigoMarcha"
        Me.txtCodigoMarcha.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoMarcha.TabIndex = 686
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 685
        Me.Label1.Text = "codigo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(54, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 688
        Me.Label18.Text = "Usuario"
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(15, 240)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboUsuario.TabIndex = 687
        '
        'PlanillaFinalMarcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 500)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.txtCodigoMarcha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAtletasdeCalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "PlanillaFinalMarcha"
        Me.Text = "Planilla Final Marcha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAtletasdeCalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPrueba As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgvAtletasdeCalle As System.Windows.Forms.DataGridView
    Friend WithEvents Dorsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Institución As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Atleta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Resultado_Parcial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodigoMarcha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
End Class
