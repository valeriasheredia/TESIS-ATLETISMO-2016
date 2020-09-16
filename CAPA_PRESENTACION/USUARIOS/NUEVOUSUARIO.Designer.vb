<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOUSUARIO
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.cboPerfilUsuario = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboprovincia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnActualizarUsuario = New System.Windows.Forms.Button()
        Me.btnRegistrarUsuario = New System.Windows.Forms.Button()
        Me.pkbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pkbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox2.Controls.Add(Me.cboPerfilUsuario)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtContraseña)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 105)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(108, 19)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(146, 20)
        Me.txtNombreUsuario.TabIndex = 83
        '
        'cboPerfilUsuario
        '
        Me.cboPerfilUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfilUsuario.FormattingEnabled = True
        Me.cboPerfilUsuario.Location = New System.Drawing.Point(108, 71)
        Me.cboPerfilUsuario.Name = "cboPerfilUsuario"
        Me.cboPerfilUsuario.Size = New System.Drawing.Size(134, 21)
        Me.cboPerfilUsuario.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Perfil de Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Nombre de Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(108, 45)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(158, 20)
        Me.txtContraseña.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Contraseña"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboprovincia)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoCelular)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoFijo)
        Me.GroupBox1.Controls.Add(Me.txtBarrio)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 274)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(98, 25)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(53, 20)
        Me.txtcodigo.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Código"
        '
        'cboprovincia
        '
        Me.cboprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboprovincia.FormattingEnabled = True
        Me.cboprovincia.Location = New System.Drawing.Point(98, 103)
        Me.cboprovincia.Name = "cboprovincia"
        Me.cboprovincia.Size = New System.Drawing.Size(129, 21)
        Me.cboprovincia.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Provincia"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(98, 234)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtEmail.TabIndex = 80
        '
        'txtTelefonoCelular
        '
        Me.txtTelefonoCelular.Location = New System.Drawing.Point(98, 208)
        Me.txtTelefonoCelular.Name = "txtTelefonoCelular"
        Me.txtTelefonoCelular.Size = New System.Drawing.Size(145, 20)
        Me.txtTelefonoCelular.TabIndex = 79
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(98, 182)
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(145, 20)
        Me.txtTelefonoFijo.TabIndex = 78
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(98, 156)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(191, 20)
        Me.txtBarrio.TabIndex = 77
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(98, 130)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(223, 20)
        Me.txtDireccion.TabIndex = 76
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(98, 77)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(191, 20)
        Me.txtApellido.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Barrio"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(98, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 20)
        Me.txtNombre.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "E_Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Teléfono Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Teléfono Fijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Apellido"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(48, 54)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(44, 13)
        Me.nombre.TabIndex = 63
        Me.nombre.Text = "Nombre"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(601, 269)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 95
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnActualizarUsuario
        '
        Me.btnActualizarUsuario.Location = New System.Drawing.Point(519, 269)
        Me.btnActualizarUsuario.Name = "btnActualizarUsuario"
        Me.btnActualizarUsuario.Size = New System.Drawing.Size(75, 41)
        Me.btnActualizarUsuario.TabIndex = 101
        Me.btnActualizarUsuario.Text = "Actualizar"
        Me.btnActualizarUsuario.UseVisualStyleBackColor = True
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(438, 269)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(75, 41)
        Me.btnRegistrarUsuario.TabIndex = 100
        Me.btnRegistrarUsuario.Text = "Registrar"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'pkbImagen
        '
        Me.pkbImagen.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.index1
        Me.pkbImagen.Location = New System.Drawing.Point(441, 12)
        Me.pkbImagen.Name = "pkbImagen"
        Me.pkbImagen.Size = New System.Drawing.Size(133, 124)
        Me.pkbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pkbImagen.TabIndex = 96
        Me.pkbImagen.TabStop = False
        '
        'NUEVOUSUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 320)
        Me.Controls.Add(Me.btnActualizarUsuario)
        Me.Controls.Add(Me.btnRegistrarUsuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pkbImagen)
        Me.Controls.Add(Me.btncancelar)
        Me.Name = "NUEVOUSUARIO"
        Me.Text = "NUEVO USUARIO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pkbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegistrarUsuario As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cboPerfilUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents pkbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarUsuario As System.Windows.Forms.Button
End Class
