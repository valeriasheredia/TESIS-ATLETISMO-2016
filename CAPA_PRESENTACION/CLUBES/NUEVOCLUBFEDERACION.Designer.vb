<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOCLUBFEDERACION
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
        Me.cbolocclub = New System.Windows.Forms.ComboBox()
        Me.cboprovclub = New System.Windows.Forms.ComboBox()
        Me.txtmailclub = New System.Windows.Forms.TextBox()
        Me.txtceluclub = New System.Windows.Forms.TextBox()
        Me.txtfijoclub = New System.Windows.Forms.TextBox()
        Me.txtdireccionclub = New System.Windows.Forms.TextBox()
        Me.txtnombreclub = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigoClub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbolocclub
        '
        Me.cbolocclub.DisplayMember = "ID_LOCALIDAD"
        Me.cbolocclub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolocclub.FormattingEnabled = True
        Me.cbolocclub.Location = New System.Drawing.Point(253, 65)
        Me.cbolocclub.Name = "cbolocclub"
        Me.cbolocclub.Size = New System.Drawing.Size(121, 21)
        Me.cbolocclub.TabIndex = 35
        Me.cbolocclub.ValueMember = "ID_LOCALIDAD"
        '
        'cboprovclub
        '
        Me.cboprovclub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboprovclub.FormattingEnabled = True
        Me.cboprovclub.Location = New System.Drawing.Point(62, 65)
        Me.cboprovclub.Name = "cboprovclub"
        Me.cboprovclub.Size = New System.Drawing.Size(131, 21)
        Me.cboprovclub.TabIndex = 34
        '
        'txtmailclub
        '
        Me.txtmailclub.Location = New System.Drawing.Point(106, 170)
        Me.txtmailclub.Name = "txtmailclub"
        Me.txtmailclub.Size = New System.Drawing.Size(232, 20)
        Me.txtmailclub.TabIndex = 33
        '
        'txtceluclub
        '
        Me.txtceluclub.Location = New System.Drawing.Point(106, 144)
        Me.txtceluclub.Name = "txtceluclub"
        Me.txtceluclub.Size = New System.Drawing.Size(146, 20)
        Me.txtceluclub.TabIndex = 32
        '
        'txtfijoclub
        '
        Me.txtfijoclub.Location = New System.Drawing.Point(106, 118)
        Me.txtfijoclub.Name = "txtfijoclub"
        Me.txtfijoclub.Size = New System.Drawing.Size(146, 20)
        Me.txtfijoclub.TabIndex = 31
        '
        'txtdireccionclub
        '
        Me.txtdireccionclub.Location = New System.Drawing.Point(62, 92)
        Me.txtdireccionclub.Name = "txtdireccionclub"
        Me.txtdireccionclub.Size = New System.Drawing.Size(246, 20)
        Me.txtdireccionclub.TabIndex = 30
        '
        'txtnombreclub
        '
        Me.txtnombreclub.Location = New System.Drawing.Point(72, 39)
        Me.txtnombreclub.Name = "txtnombreclub"
        Me.txtnombreclub.Size = New System.Drawing.Size(284, 20)
        Me.txtnombreclub.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "E_mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Teléfono Celular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Teléfono Fijo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(560, 216)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 26)
        Me.btncancelar.TabIndex = 93
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(398, 216)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 27)
        Me.btnRegistrar.TabIndex = 92
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigoClub)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdireccionclub)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbolocclub)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboprovclub)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtmailclub)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtceluclub)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfijoclub)
        Me.GroupBox1.Controls.Add(Me.txtnombreclub)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 198)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        '
        'txtCodigoClub
        '
        Me.txtCodigoClub.Location = New System.Drawing.Point(72, 13)
        Me.txtCodigoClub.Name = "txtCodigoClub"
        Me.txtCodigoClub.ReadOnly = True
        Me.txtCodigoClub.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoClub.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Código"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.ATLETISMO
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(479, 216)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 27)
        Me.btnActualizar.TabIndex = 98
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'NUEVOCLUBFEDERACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 252)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NUEVOCLUBFEDERACION"
        Me.Text = "NUEVO CLUB/FEDERACION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbolocclub As System.Windows.Forms.ComboBox
    Friend WithEvents cboprovclub As System.Windows.Forms.ComboBox
    Friend WithEvents txtmailclub As System.Windows.Forms.TextBox
    Friend WithEvents txtceluclub As System.Windows.Forms.TextBox
    Friend WithEvents txtfijoclub As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionclub As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreclub As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodigoClub As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
