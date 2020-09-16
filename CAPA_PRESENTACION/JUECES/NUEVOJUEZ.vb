Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions

Public Class NUEVOJUEZ
    Dim capanegocio As New CNJueces
    Shared Property JuezSeleccionado As New CEJueces
    Public Property TipoDeFormulario As TipoFormulario

    Private Sub NUEVOJUEZ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub RellenarCampos()
        txtCodigoJuez.Text = JuezSeleccionado.id_juez
        txtnombrejuez.Text = JuezSeleccionado.Nombre_j
        txtapejuez.Text = JuezSeleccionado.Apellido_j
        txtdnijuez.Text = JuezSeleccionado.Dni_j
        txtNacionalidad.Text = JuezSeleccionado.nacionalidad_j
        cboProv.SelectedValue = JuezSeleccionado.id_provincia_j
        txtdirejuez.Text = JuezSeleccionado.direccion_j
        txtfijojuez.Text = JuezSeleccionado.telefono_fijo_j
        txtcelujuez.Text = JuezSeleccionado.telefono_celular_j
        txtmailjuez.Text = JuezSeleccionado.e_mail_j
        cbotipo.SelectedValue = JuezSeleccionado.id_tipo_juez
    End Sub

    Sub PrepararFormulario()
        btnRegistrar.Enabled = False
        btnActualizarJuez.Enabled = False
        btnCancelar.Enabled = False

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                Me.Text = "NUEVO JUEZ"
                btnRegistrar.Enabled = True
                btnCancelar.Enabled = True
                generacodigojuez()
                cargaprov()
                cargatipo()

            Case TipoFormulario.Baja

            Case TipoFormulario.Modificacion

                'botones
                btnActualizarJuez.Enabled = True
                btnCancelar.Enabled = True
                'combos
                'generacodigojuez()
                cargaprov()
                cargatipo()

                Me.Text = "MODIFICAR DATOS DEL JUEZ"
                capanegocio.actualizarJuez(JuezSeleccionado)
                cboProv.SelectedValue = JuezSeleccionado.id_juez
                cbotipo.SelectedValue = JuezSeleccionado.id_tipo_juez

                RellenarCampos()
                LISTAJUECES.Close()

        End Select
    End Sub

    Sub generacodigojuez()
        txtCodigoJuez.Text = capanegocio.nuevocodigojuez
    End Sub

    Sub cargaprov()
        cboprov.DataSource = capanegocio.listaprovincia.Tables("provincias")
        cboprov.DisplayMember = "nombre_provincia"
        cboProv.ValueMember = "id_provincia"
        cboProv.SelectedIndex = 22
    End Sub

    Sub cargatipo()
        cbotipo.DataSource = capanegocio.listatipojuez.Tables("tipojuez")
        cbotipo.DisplayMember = "tipo_juez"
        cbotipo.ValueMember = "id_tipo_juez"
        cbotipo.SelectedIndex = 10
    End Sub

    ' funciones de captura de valor
    Function getidjuez() As Integer
        Return txtCodigoJuez.Text
    End Function

    Function getnombre() As String
        Return txtnombrejuez.Text
    End Function

    Function getapellido() As String
        Return txtapejuez.Text
    End Function

    Function getdnij() As String
        Return txtdnijuez.Text
    End Function

    Function getNacionalidad() As String
        Return txtNacionalidad.Text
    End Function

    Function getprovincia()
        Return cboprov.SelectedValue
    End Function

    Function getdireccion() As String
        Return txtdirejuez.Text
    End Function

    Function gettelefono_fijo() As String
        Return txtfijojuez.Text
    End Function

    Function gettelefono_celular() As String
        Return txtcelujuez.Text
    End Function

    Function gete_mail() As String
        Return txtmailjuez.Text
    End Function

    Function gettipojuez()
        Return cbotipo.SelectedValue
    End Function

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        Dim objeto As New CEJueces
        'If txtnombrejuez.Text <> "" And txtapejuez.Text <> "" And txtdnijuez.Text <> "" And txtNacionalidad.Text <> "" And cboProv.Text <> "" And txtdirejuez.Text <> "" And txtfijojuez.Text <> "" And txtcelujuez.Text <> "" And txtmailjuez.Text <> "" And cbotipo.Text <> "" And txtnrolicencia.Text = "" Then

        If txtnombrejuez.Text = "" Then
            MessageBox.Show("Complete el campo con el nombre del Juez")
            txtnombrejuez.Focus()
            Return
        End If

        If txtapejuez.Text = "" Then
            MessageBox.Show("Complete el campo con el nombre del Juez")
            txtapejuez.Focus()
            Return
        End If

        If txtdnijuez.Text = "" Then
            MessageBox.Show("Complete el campo con el Dni del Juez")
            txtdnijuez.Focus()
            Return
        End If

        If cboProv.Text = "--Seleccionar--" Then
            MessageBox.Show("Seleccione una provincia")
            cboProv.Focus()
            Return
        End If

        If txtcelujuez.Text = "" Then
            MessageBox.Show("Complete el campo con el Teléfono Celular del Juez")
            txtcelujuez.Focus()
            Return
        End If

        If txtmailjuez.Text = "" Then
            MessageBox.Show("Complete el campo con el E-mail del Juez")
            txtmailjuez.Focus()
            Return
        End If

        If cbotipo.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar un tipo de juez")
            cbotipo.Focus()
            Return
        End If


        objeto.id_juez = getidjuez()
        objeto.Nombre_j = getnombre()
        objeto.Apellido_j = getapellido()
        objeto.Dni_j = getdnij()
        objeto.nacionalidad_j = getNacionalidad()
        objeto.id_provincia_j = getprovincia()
        objeto.direccion_j = getdireccion()
        objeto.telefono_fijo_j = gettelefono_fijo()
        objeto.telefono_celular_j = gettelefono_celular()
        objeto.e_mail_j = gete_mail()
        objeto.id_tipo_juez = gettipojuez()
        Try
            capanegocio.nuevojuez(objeto)
            txtCodigoJuez.Clear() 'borra campo codigo
            generacodigojuez() ' llama a procedimiento q carga el nuevo codigo
        Catch ex As Exception
            MsgBox("Error al registrar al Juez", MsgBoxStyle.Critical)
        End Try
        ' Else
        MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar")
        ' End If
    End Sub

    Sub limpiarControles()
        txtnombrejuez.Text = Nothing
        txtapejuez.Text = Nothing
        txtdnijuez.Text = Nothing
        'txtNacionalidad.Text = Nothing
        'cboProv.SelectedIndex = -1
        txtdirejuez.Text = Nothing
        txtfijojuez.Text = Nothing
        txtcelujuez.Text = Nothing
        txtmailjuez.Text = Nothing
        'cbotipo.SelectedIndex = -1
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs)
        limpiarControles()
    End Sub

    Private Sub btnActualizarJuez_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarJuez.Click

        Try
            JuezSeleccionado.id_juez = txtCodigoJuez.Text
            JuezSeleccionado.Nombre_j = txtnombrejuez.Text
            JuezSeleccionado.Apellido_j = txtapejuez.Text
            JuezSeleccionado.Dni_j = txtdnijuez.Text
            JuezSeleccionado.nacionalidad_j = txtNacionalidad.Text
            JuezSeleccionado.id_provincia_j = cboProv.SelectedValue
            JuezSeleccionado.direccion_j = txtdirejuez.Text
            JuezSeleccionado.telefono_fijo_j = txtfijojuez.Text
            JuezSeleccionado.telefono_celular_j = txtcelujuez.Text
            JuezSeleccionado.e_mail_j = txtmailjuez.Text
            JuezSeleccionado.id_tipo_juez = cbotipo.SelectedValue

            capanegocio.actualizarJuez(JuezSeleccionado)
            MsgBox(" Los datos del Juez han sido actualizados correctamente")
            LISTAJUECES.ShowDialog()

        Catch ex As Exception
            MsgBox("Error al actualizar los datos del Juez")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtnombrejuez_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombrejuez.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombrejuez_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombrejuez.TextChanged
        Dim i As Integer
        txtnombrejuez.Text = StrConv(txtnombrejuez.Text, VbStrConv.ProperCase)
        i = Len(txtnombrejuez.Text)
        txtnombrejuez.SelectionStart = i
    End Sub

    Private Sub txtapejuez_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtapejuez.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdnijuez_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdnijuez.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtfijojuez_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfijojuez.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcelujuez_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelujuez.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                             "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub txtmailjuez_Leave(sender As Object, e As System.EventArgs) Handles txtmailjuez.Leave
        If validar_Mail(LCase(txtmailjuez.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no es valido, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo válido", "Validación de correo electronico", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            txtmailjuez.Focus()
            txtmailjuez.SelectAll()
        End If
    End Sub

    Private Sub txtapejuez_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtapejuez.TextChanged
        Dim i As Integer
        txtapejuez.Text = StrConv(txtapejuez.Text, VbStrConv.ProperCase)
        i = Len(txtapejuez.Text)
        txtapejuez.SelectionStart = i
    End Sub

    Private Sub txtdirejuez_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdirejuez.TextChanged
        Dim i As Integer
        txtdirejuez.Text = StrConv(txtdirejuez.Text, VbStrConv.ProperCase)
        i = Len(txtdirejuez.Text)
        txtdirejuez.SelectionStart = i
    End Sub

End Class