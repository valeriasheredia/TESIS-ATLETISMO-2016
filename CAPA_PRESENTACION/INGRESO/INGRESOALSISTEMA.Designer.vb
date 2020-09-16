<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INGRESOALSISTEMA
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAPA_PRESENTACION.My.Resources.Resources.Acceso_Usuarios
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(366, 108)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 23
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(285, 108)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 22
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(271, 66)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(185, 20)
        Me.txtcontraseña.TabIndex = 21
        '
        'txtnombreusuario
        '
        Me.txtnombreusuario.Location = New System.Drawing.Point(271, 34)
        Me.txtnombreusuario.Name = "txtnombreusuario"
        Me.txtnombreusuario.Size = New System.Drawing.Size(185, 20)
        Me.txtnombreusuario.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre deUsuario"
        '
        'INGRESOALSISTEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 168)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtnombreusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "INGRESOALSISTEMA"
        Me.Text = "INGRESO AL SISTEMA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
