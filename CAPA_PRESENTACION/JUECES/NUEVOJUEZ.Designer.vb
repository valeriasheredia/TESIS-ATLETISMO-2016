<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOJUEZ
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.txtmailjuez = New System.Windows.Forms.TextBox()
        Me.txtcelujuez = New System.Windows.Forms.TextBox()
        Me.txtfijojuez = New System.Windows.Forms.TextBox()
        Me.txtdirejuez = New System.Windows.Forms.TextBox()
        Me.txtdnijuez = New System.Windows.Forms.TextBox()
        Me.txtapejuez = New System.Windows.Forms.TextBox()
        Me.txtnombrejuez = New System.Windows.Forms.TextBox()
        Me.cboTipoJuez = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.Label()
        Me.txtFijo = New System.Windows.Forms.Label()
        Me.txtDirección = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigoJuez = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnActualizarJuez = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(661, 247)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 49
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(496, 247)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 48
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(65, 15)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(269, 21)
        Me.cbotipo.TabIndex = 47
        '
        'txtmailjuez
        '
        Me.txtmailjuez.Location = New System.Drawing.Point(99, 256)
        Me.txtmailjuez.Name = "txtmailjuez"
        Me.txtmailjuez.Size = New System.Drawing.Size(238, 20)
        Me.txtmailjuez.TabIndex = 44
        '
        'txtcelujuez
        '
        Me.txtcelujuez.Location = New System.Drawing.Point(99, 230)
        Me.txtcelujuez.Name = "txtcelujuez"
        Me.txtcelujuez.Size = New System.Drawing.Size(157, 20)
        Me.txtcelujuez.TabIndex = 43
        '
        'txtfijojuez
        '
        Me.txtfijojuez.Location = New System.Drawing.Point(99, 204)
        Me.txtfijojuez.Name = "txtfijojuez"
        Me.txtfijojuez.Size = New System.Drawing.Size(157, 20)
        Me.txtfijojuez.TabIndex = 42
        '
        'txtdirejuez
        '
        Me.txtdirejuez.Location = New System.Drawing.Point(98, 177)
        Me.txtdirejuez.Name = "txtdirejuez"
        Me.txtdirejuez.Size = New System.Drawing.Size(262, 20)
        Me.txtdirejuez.TabIndex = 41
        '
        'txtdnijuez
        '
        Me.txtdnijuez.Location = New System.Drawing.Point(99, 97)
        Me.txtdnijuez.Name = "txtdnijuez"
        Me.txtdnijuez.Size = New System.Drawing.Size(157, 20)
        Me.txtdnijuez.TabIndex = 40
        '
        'txtapejuez
        '
        Me.txtapejuez.Location = New System.Drawing.Point(99, 71)
        Me.txtapejuez.Name = "txtapejuez"
        Me.txtapejuez.Size = New System.Drawing.Size(213, 20)
        Me.txtapejuez.TabIndex = 39
        '
        'txtnombrejuez
        '
        Me.txtnombrejuez.Location = New System.Drawing.Point(99, 45)
        Me.txtnombrejuez.Name = "txtnombrejuez"
        Me.txtnombrejuez.Size = New System.Drawing.Size(213, 20)
        Me.txtnombrejuez.TabIndex = 38
        '
        'cboTipoJuez
        '
        Me.cboTipoJuez.AutoSize = True
        Me.cboTipoJuez.Location = New System.Drawing.Point(6, 18)
        Me.cboTipoJuez.Name = "cboTipoJuez"
        Me.cboTipoJuez.Size = New System.Drawing.Size(53, 13)
        Me.cboTipoJuez.TabIndex = 35
        Me.cboTipoJuez.Text = "Tipo Juez"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Location = New System.Drawing.Point(55, 259)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(38, 13)
        Me.txtEmail.TabIndex = 34
        Me.txtEmail.Text = "E_mail"
        '
        'txtCelular
        '
        Me.txtCelular.AutoSize = True
        Me.txtCelular.Location = New System.Drawing.Point(9, 233)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(84, 13)
        Me.txtCelular.TabIndex = 33
        Me.txtCelular.Text = "Teléfono Celular"
        '
        'txtFijo
        '
        Me.txtFijo.AutoSize = True
        Me.txtFijo.Location = New System.Drawing.Point(25, 207)
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(68, 13)
        Me.txtFijo.TabIndex = 32
        Me.txtFijo.Text = "Teléfono Fijo"
        '
        'txtDirección
        '
        Me.txtDirección.AutoSize = True
        Me.txtDirección.Location = New System.Drawing.Point(40, 180)
        Me.txtDirección.Name = "txtDirección"
        Me.txtDirección.Size = New System.Drawing.Size(52, 13)
        Me.txtDirección.TabIndex = 30
        Me.txtDirección.Text = "Dirección"
        '
        'txtDni
        '
        Me.txtDni.AutoSize = True
        Me.txtDni.Location = New System.Drawing.Point(70, 100)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(23, 13)
        Me.txtDni.TabIndex = 29
        Me.txtDni.Text = "Dni"
        '
        'txtApellido
        '
        Me.txtApellido.AutoSize = True
        Me.txtApellido.Location = New System.Drawing.Point(49, 74)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(44, 13)
        Me.txtApellido.TabIndex = 28
        Me.txtApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(49, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(44, 13)
        Me.txtNombre.TabIndex = 27
        Me.txtNombre.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigoJuez)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNacionalidad)
        Me.GroupBox1.Controls.Add(Me.cboProv)
        Me.GroupBox1.Controls.Add(Me.txtdirejuez)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDirección)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtmailjuez)
        Me.GroupBox1.Controls.Add(Me.txtcelujuez)
        Me.GroupBox1.Controls.Add(Me.txtfijojuez)
        Me.GroupBox1.Controls.Add(Me.txtdnijuez)
        Me.GroupBox1.Controls.Add(Me.txtapejuez)
        Me.GroupBox1.Controls.Add(Me.txtnombrejuez)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtFijo)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 289)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'txtCodigoJuez
        '
        Me.txtCodigoJuez.Location = New System.Drawing.Point(99, 19)
        Me.txtCodigoJuez.Name = "txtCodigoJuez"
        Me.txtCodigoJuez.ReadOnly = True
        Me.txtCodigoJuez.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoJuez.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Código"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(99, 123)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(213, 20)
        Me.txtNacionalidad.TabIndex = 51
        Me.txtNacionalidad.Text = "Argentina"
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(99, 149)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(157, 21)
        Me.cboProv.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nacionalidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Provincia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboTipoJuez)
        Me.GroupBox2.Controls.Add(Me.cbotipo)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 55)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.arbitro
        Me.PictureBox1.Location = New System.Drawing.Point(538, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'btnActualizarJuez
        '
        Me.btnActualizarJuez.Location = New System.Drawing.Point(577, 247)
        Me.btnActualizarJuez.Name = "btnActualizarJuez"
        Me.btnActualizarJuez.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarJuez.TabIndex = 54
        Me.btnActualizarJuez.Text = "Actualizar"
        Me.btnActualizarJuez.UseVisualStyleBackColor = True
        '
        'NUEVOJUEZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 302)
        Me.Controls.Add(Me.btnActualizarJuez)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Name = "NUEVOJUEZ"
        Me.Text = "NUEVO JUEZ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtmailjuez As System.Windows.Forms.TextBox
    Friend WithEvents txtcelujuez As System.Windows.Forms.TextBox
    Friend WithEvents txtfijojuez As System.Windows.Forms.TextBox
    Friend WithEvents txtdirejuez As System.Windows.Forms.TextBox
    Friend WithEvents txtdnijuez As System.Windows.Forms.TextBox
    Friend WithEvents txtapejuez As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrejuez As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoJuez As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.Label
    Friend WithEvents txtFijo As System.Windows.Forms.Label
    Friend WithEvents txtDirección As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoJuez As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnActualizarJuez As System.Windows.Forms.Button
End Class
