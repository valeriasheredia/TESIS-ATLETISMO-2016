<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVOATLETA
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboClub = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtIdAtleta = New System.Windows.Forms.TextBox()
        Me.txtFederado = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDniAtleta = New System.Windows.Forms.TextBox()
        Me.txtContactoEmergencia = New System.Windows.Forms.TextBox()
        Me.txtEmailAtleta = New System.Windows.Forms.TextBox()
        Me.txtCelularAtleta = New System.Windows.Forms.TextBox()
        Me.txtFijoAtleta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBarrioAtleta = New System.Windows.Forms.TextBox()
        Me.cboLocAtleta = New System.Windows.Forms.ComboBox()
        Me.txtDomicilioAtleta = New System.Windows.Forms.TextBox()
        Me.cboProvAtleta = New System.Windows.Forms.ComboBox()
        Me.txtApellidoAtleta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreAtleta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegistrarAtleta = New System.Windows.Forms.Button()
        Me.btnActualizarAtleta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEstadoAtleta = New System.Windows.Forms.TextBox()
        Me.txtinstitucion = New System.Windows.Forms.TextBox()
        Me.TxtNumeroAtleta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnConfirmarAsistencia = New System.Windows.Forms.Button()
        Me.btnValidarExistencia = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnValidarExistencia)
        Me.GroupBox1.Controls.Add(Me.cboSexo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cboClub)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtIdAtleta)
        Me.GroupBox1.Controls.Add(Me.txtFederado)
        Me.GroupBox1.Controls.Add(Me.txtNacionalidad)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtDniAtleta)
        Me.GroupBox1.Controls.Add(Me.txtContactoEmergencia)
        Me.GroupBox1.Controls.Add(Me.txtEmailAtleta)
        Me.GroupBox1.Controls.Add(Me.txtCelularAtleta)
        Me.GroupBox1.Controls.Add(Me.txtFijoAtleta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBarrioAtleta)
        Me.GroupBox1.Controls.Add(Me.cboLocAtleta)
        Me.GroupBox1.Controls.Add(Me.txtDomicilioAtleta)
        Me.GroupBox1.Controls.Add(Me.cboProvAtleta)
        Me.GroupBox1.Controls.Add(Me.txtApellidoAtleta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreAtleta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 345)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(344, 103)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(165, 21)
        Me.cboSexo.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(304, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Sexo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(34, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Código"
        '
        'cboClub
        '
        Me.cboClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClub.FormattingEnabled = True
        Me.cboClub.Location = New System.Drawing.Point(307, 312)
        Me.cboClub.Name = "cboClub"
        Me.cboClub.Size = New System.Drawing.Size(165, 21)
        Me.cboClub.TabIndex = 57
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(215, 316)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Club/Federación"
        '
        'txtIdAtleta
        '
        Me.txtIdAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdAtleta.Location = New System.Drawing.Point(84, 19)
        Me.txtIdAtleta.Name = "txtIdAtleta"
        Me.txtIdAtleta.ReadOnly = True
        Me.txtIdAtleta.Size = New System.Drawing.Size(58, 20)
        Me.txtIdAtleta.TabIndex = 51
        '
        'txtFederado
        '
        Me.txtFederado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederado.Location = New System.Drawing.Point(125, 313)
        Me.txtFederado.Name = "txtFederado"
        Me.txtFederado.Size = New System.Drawing.Size(39, 20)
        Me.txtFederado.TabIndex = 54
        Me.txtFederado.Text = "No"
        Me.txtFederado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(84, 126)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(160, 20)
        Me.txtNacionalidad.TabIndex = 48
        Me.txtNacionalidad.Text = "Argentina"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 316)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Federado (Sí/No)"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(10, 129)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(69, 13)
        Me.label.TabIndex = 31
        Me.label.Text = "Nacionalidad"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(136, 100)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(82, 20)
        Me.dtpFechaNacimiento.TabIndex = 28
        '
        'txtDniAtleta
        '
        Me.txtDniAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDniAtleta.Location = New System.Drawing.Point(224, 19)
        Me.txtDniAtleta.Name = "txtDniAtleta"
        Me.txtDniAtleta.Size = New System.Drawing.Size(160, 20)
        Me.txtDniAtleta.TabIndex = 27
        '
        'txtContactoEmergencia
        '
        Me.txtContactoEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactoEmergencia.Location = New System.Drawing.Point(218, 281)
        Me.txtContactoEmergencia.Name = "txtContactoEmergencia"
        Me.txtContactoEmergencia.Size = New System.Drawing.Size(166, 20)
        Me.txtContactoEmergencia.TabIndex = 26
        '
        'txtEmailAtleta
        '
        Me.txtEmailAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAtleta.Location = New System.Drawing.Point(84, 257)
        Me.txtEmailAtleta.Name = "txtEmailAtleta"
        Me.txtEmailAtleta.Size = New System.Drawing.Size(271, 20)
        Me.txtEmailAtleta.TabIndex = 25
        '
        'txtCelularAtleta
        '
        Me.txtCelularAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularAtleta.Location = New System.Drawing.Point(377, 231)
        Me.txtCelularAtleta.Name = "txtCelularAtleta"
        Me.txtCelularAtleta.Size = New System.Drawing.Size(154, 20)
        Me.txtCelularAtleta.TabIndex = 24
        '
        'txtFijoAtleta
        '
        Me.txtFijoAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijoAtleta.Location = New System.Drawing.Point(84, 231)
        Me.txtFijoAtleta.Name = "txtFijoAtleta"
        Me.txtFijoAtleta.Size = New System.Drawing.Size(124, 20)
        Me.txtFijoAtleta.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(293, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Localidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Provincia"
        '
        'txtBarrioAtleta
        '
        Me.txtBarrioAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrioAtleta.Location = New System.Drawing.Point(84, 204)
        Me.txtBarrioAtleta.Name = "txtBarrioAtleta"
        Me.txtBarrioAtleta.Size = New System.Drawing.Size(187, 20)
        Me.txtBarrioAtleta.TabIndex = 20
        '
        'cboLocAtleta
        '
        Me.cboLocAtleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocAtleta.FormattingEnabled = True
        Me.cboLocAtleta.Location = New System.Drawing.Point(352, 153)
        Me.cboLocAtleta.Name = "cboLocAtleta"
        Me.cboLocAtleta.Size = New System.Drawing.Size(157, 21)
        Me.cboLocAtleta.TabIndex = 22
        '
        'txtDomicilioAtleta
        '
        Me.txtDomicilioAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilioAtleta.Location = New System.Drawing.Point(84, 178)
        Me.txtDomicilioAtleta.Name = "txtDomicilioAtleta"
        Me.txtDomicilioAtleta.Size = New System.Drawing.Size(344, 20)
        Me.txtDomicilioAtleta.TabIndex = 19
        '
        'cboProvAtleta
        '
        Me.cboProvAtleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvAtleta.FormattingEnabled = True
        Me.cboProvAtleta.Location = New System.Drawing.Point(84, 153)
        Me.cboProvAtleta.Name = "cboProvAtleta"
        Me.cboProvAtleta.Size = New System.Drawing.Size(175, 21)
        Me.cboProvAtleta.TabIndex = 21
        '
        'txtApellidoAtleta
        '
        Me.txtApellidoAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoAtleta.Location = New System.Drawing.Point(84, 74)
        Me.txtApellidoAtleta.Name = "txtApellidoAtleta"
        Me.txtApellidoAtleta.Size = New System.Drawing.Size(344, 20)
        Me.txtApellidoAtleta.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNombreAtleta
        '
        Me.txtNombreAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAtleta.Location = New System.Drawing.Point(84, 48)
        Me.txtNombreAtleta.Name = "txtNombreAtleta"
        Me.txtNombreAtleta.Size = New System.Drawing.Size(344, 20)
        Me.txtNombreAtleta.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dni"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Barrio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Contacto de Emergencia (Nro de Teléfono)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Teléfono Fijo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(284, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Teléfono Celular"
        '
        'btnRegistrarAtleta
        '
        Me.btnRegistrarAtleta.Location = New System.Drawing.Point(480, 351)
        Me.btnRegistrarAtleta.Name = "btnRegistrarAtleta"
        Me.btnRegistrarAtleta.Size = New System.Drawing.Size(84, 23)
        Me.btnRegistrarAtleta.TabIndex = 39
        Me.btnRegistrarAtleta.Text = "Registrar"
        Me.btnRegistrarAtleta.UseVisualStyleBackColor = True
        '
        'btnActualizarAtleta
        '
        Me.btnActualizarAtleta.Location = New System.Drawing.Point(480, 380)
        Me.btnActualizarAtleta.Name = "btnActualizarAtleta"
        Me.btnActualizarAtleta.Size = New System.Drawing.Size(84, 23)
        Me.btnActualizarAtleta.TabIndex = 62
        Me.btnActualizarAtleta.Text = "Actualizar"
        Me.btnActualizarAtleta.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(480, 438)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 23)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(480, 409)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(84, 23)
        Me.btnLimpiar.TabIndex = 42
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEstadoAtleta)
        Me.GroupBox3.Controls.Add(Me.txtinstitucion)
        Me.GroupBox3.Controls.Add(Me.TxtNumeroAtleta)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 351)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 144)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos para la Competencia"
        '
        'txtEstadoAtleta
        '
        Me.txtEstadoAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoAtleta.Location = New System.Drawing.Point(192, 52)
        Me.txtEstadoAtleta.Name = "txtEstadoAtleta"
        Me.txtEstadoAtleta.Size = New System.Drawing.Size(74, 20)
        Me.txtEstadoAtleta.TabIndex = 58
        Me.txtEstadoAtleta.Text = "Habilitado"
        '
        'txtinstitucion
        '
        Me.txtinstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinstitucion.Location = New System.Drawing.Point(156, 23)
        Me.txtinstitucion.Name = "txtinstitucion"
        Me.txtinstitucion.Size = New System.Drawing.Size(233, 20)
        Me.txtinstitucion.TabIndex = 45
        Me.txtinstitucion.Text = "--Ninguna--"
        Me.txtinstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNumeroAtleta
        '
        Me.TxtNumeroAtleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroAtleta.Location = New System.Drawing.Point(196, 87)
        Me.TxtNumeroAtleta.Multiline = True
        Me.TxtNumeroAtleta.Name = "TxtNumeroAtleta"
        Me.TxtNumeroAtleta.Size = New System.Drawing.Size(70, 50)
        Me.TxtNumeroAtleta.TabIndex = 43
        Me.TxtNumeroAtleta.Text = "0"
        Me.TxtNumeroAtleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(153, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Dorsal"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Estado de Inicio a la Competencia"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(132, 13)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Institución que representa:"
        '
        'btnConfirmarAsistencia
        '
        Me.btnConfirmarAsistencia.Location = New System.Drawing.Point(480, 467)
        Me.btnConfirmarAsistencia.Name = "btnConfirmarAsistencia"
        Me.btnConfirmarAsistencia.Size = New System.Drawing.Size(84, 41)
        Me.btnConfirmarAsistencia.TabIndex = 67
        Me.btnConfirmarAsistencia.Text = "Confirmar Asistencia"
        Me.btnConfirmarAsistencia.UseVisualStyleBackColor = True
        '
        'btnValidarExistencia
        '
        Me.btnValidarExistencia.Location = New System.Drawing.Point(390, 19)
        Me.btnValidarExistencia.Name = "btnValidarExistencia"
        Me.btnValidarExistencia.Size = New System.Drawing.Size(141, 20)
        Me.btnValidarExistencia.TabIndex = 60
        Me.btnValidarExistencia.Text = "Validar Existencia"
        Me.btnValidarExistencia.UseVisualStyleBackColor = True
        '
        'NUEVOATLETA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 513)
        Me.Controls.Add(Me.btnConfirmarAsistencia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizarAtleta)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegistrarAtleta)
        Me.Name = "NUEVOATLETA"
        Me.Text = "NUEVO ATLETA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDniAtleta As System.Windows.Forms.TextBox
    Friend WithEvents txtContactoEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAtleta As System.Windows.Forms.TextBox
    Friend WithEvents txtCelularAtleta As System.Windows.Forms.TextBox
    Friend WithEvents txtFijoAtleta As System.Windows.Forms.TextBox
    Friend WithEvents cboLocAtleta As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvAtleta As System.Windows.Forms.ComboBox
    Friend WithEvents txtBarrioAtleta As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilioAtleta As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoAtleta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreAtleta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarAtleta As System.Windows.Forms.Button
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtIdAtleta As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizarAtleta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboClub As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtFederado As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtinstitucion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumeroAtleta As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmarAsistencia As System.Windows.Forms.Button
    Friend WithEvents txtEstadoAtleta As System.Windows.Forms.TextBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnValidarExistencia As System.Windows.Forms.Button
End Class
