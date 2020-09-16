Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions

Public Class NUEVOUSUARIO

    Dim capanegocio As New CNUsuarios
    Shared Property UsuarioSeleccionado As New CEUsuarios
    Public Property TipoDeFormulario As TipoFormulario


    Public Sub RellenarCampos()
        txtcodigo.Text = UsuarioSeleccionado.id_usuario
        txtNombre.Text = UsuarioSeleccionado.Nombre
        txtApellido.Text = UsuarioSeleccionado.Apellido
        cboprovincia.SelectedValue = UsuarioSeleccionado.id_provincia
        txtDireccion.Text = UsuarioSeleccionado.direccion
        txtBarrio.Text = UsuarioSeleccionado.barrio
        txtTelefonoFijo.Text = UsuarioSeleccionado.telefono_fijo
        txtTelefonoCelular.Text = UsuarioSeleccionado.telefono_celular
        txtEmail.Text = UsuarioSeleccionado.e_mail
        txtNombreUsuario.Text = UsuarioSeleccionado.nombre_usuario
        txtContraseña.Text = UsuarioSeleccionado.contraseña
        cboPerfilUsuario.SelectedValue = UsuarioSeleccionado.perfil_usuario

    End Sub

    Private Sub NUEVOUSUARIO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PrepararFormulario()
    End Sub

    Private Sub PrepararFormulario()
        btnRegistrarUsuario.Enabled = False
        btnActualizarUsuario.Enabled = False
        cboPerfilUsuario.Enabled = False
        btncancelar.Enabled = False

        Select Case TipoDeFormulario

            Case TipoFormulario.Alta
                btnRegistrarUsuario.Enabled = True
                btncancelar.Enabled = True
                generacodigo()
                cargarprovincia()
                cargarperfil()
                cboPerfilUsuario.Enabled = True
            Case TipoFormulario.ModificarContraseñaUsuario

                'botones
                btnActualizarUsuario.Enabled = True
                btncancelar.Enabled = True
                'combos
                cargarprovincia()
                cargarperfil()
                cboPerfilUsuario.SelectedValue = UsuarioSeleccionado.perfil_usuario
                cboprovincia.SelectedValue = UsuarioSeleccionado.id_provincia
                GroupBox1.Enabled = False
                cboPerfilUsuario.Enabled = False

                Me.Text = "CAMBIAR USUARIO Y/O CONTRASEÑA"
                capanegocio.actualizarusuario(UsuarioSeleccionado)
                RellenarCampos()
                LISTAUSUARIOS.Close()
               

            Case TipoFormulario.Modificacion
                'botones
                btnActualizarUsuario.Visible = True
                btnRegistrarUsuario.Visible = False
                btnActualizarUsuario.Enabled = True
                btncancelar.Enabled = True
                'combos
                cargarprovincia()
                cargarperfil()
                cboPerfilUsuario.SelectedValue = UsuarioSeleccionado.perfil_usuario
                cboprovincia.SelectedValue = UsuarioSeleccionado.id_provincia

                Me.Text = "MODIFICAR DATOS DEL USUARIO"
                capanegocio.actualizarusuario(UsuarioSeleccionado)
                cboPerfilUsuario.Enabled = False
                GroupBox2.Enabled = False
                RellenarCampos()
                LISTAUSUARIOS.Close()

        End Select
    End Sub

    Sub generacodigo()
        txtcodigo.Text = capanegocio.nuevocodigo
    End Sub

    Sub cargarprovincia()
        cboprovincia.DataSource = capanegocio.listaprovincia.Tables("provincias")
        cboprovincia.DisplayMember = "nombre_provincia"
        cboprovincia.ValueMember = "id_provincia"
        cboprovincia.SelectedIndex = 22
    End Sub

    Sub cargarperfil()
        cboPerfilUsuario.DataSource = capanegocio.listaperfil.Tables("PERFILES")
        cboPerfilUsuario.DisplayMember = "perfil"
        cboPerfilUsuario.ValueMember = "id_perfil_usuario"
        cboPerfilUsuario.SelectedIndex = 2
    End Sub

    Sub limpiarControles()
        txtNombre.Text = Nothing
        txtApellido.Text = Nothing
        txtDireccion.Text = Nothing
        txtBarrio.Text = Nothing
        txtTelefonoFijo.Text = Nothing
        txtTelefonoCelular.Text = Nothing
        txtEmail.Text = Nothing
        btnActualizarUsuario.Enabled = False
    End Sub

    ' funciones de captura de valor. seleccionar todos los elementos que fueron ingresados por el usuario
    Function getCodigo() As Integer
        Return txtcodigo.Text
    End Function

    Function getnombre() As String
        Return txtNombre.Text
    End Function

    Function getapellido() As String
        Return txtApellido.Text
    End Function

    Function getprovincia()
        Return cboprovincia.SelectedValue
    End Function

    Function getdireccion() As String
        Return txtDireccion.Text
    End Function

    Function getbarrio() As String
        Return txtBarrio.Text
    End Function

    Function gettelefono_fijo() As String
        Return txtTelefonoFijo.Text
    End Function

    Function gettelefono_celular() As String
        Return txtTelefonoCelular.Text
    End Function

    Function gete_mail() As String
        Return txtEmail.Text
    End Function

    Function getnombre_usuario() As String
        Return txtNombreUsuario.Text
    End Function

    Function getcontraseña() As String
        Return txtContraseña.Text
    End Function

    Function getperfil()
        Return cboPerfilUsuario.SelectedValue
    End Function

    Private Sub btnRegistrarUsuario_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarUsuario.Click
        Dim objeto As New CEUsuarios ' llena los valores y los envia a la clase usuarios por medio del objeto

        If txtNombre.Text = "" Then
            MessageBox.Show("Complete el campo con el nombre del Usuario")
            txtNombre.Focus()
            Return
        End If

        If txtApellido.Text = "" Then
            MessageBox.Show("Complete el campo con el apellido del Usuario")
            txtApellido.Focus()
            Return
        End If

        If cboprovincia.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar una provincia")
            cboprovincia.Focus()
            Return
        End If

        If txtDireccion.Text = "" Then
            MessageBox.Show("Complete el campo con la dirección del Usuario")
            txtDireccion.Focus()
            Return
        End If

        If txtTelefonoCelular.Text = "" Then
            MessageBox.Show("Complete el campo con el teléfono celular del Usuario")
            txtTelefonoCelular.Focus()
            Return
        End If

        If txtEmail.Text = "" Then
            MessageBox.Show("Complete el campo con un mail válido")
            txtEmail.Focus()
            Return
        End If

        If txtNombreUsuario.Text = "" Then
            MessageBox.Show("El nombre de usuario no puede estar vacío")
            txtNombreUsuario.Focus()
            Return
        End If

        If txtContraseña.Text = "" Then
            MessageBox.Show("La contraseña de usuario no puede estar vacía")
            txtContraseña.Focus()
            Return
        End If

        If cboPerfilUsuario.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar un perfil de Usuario")
            cboPerfilUsuario.Focus()
            Return
        End If

        ' objeto.id_usuario = getCodigo()
        objeto.Nombre = getnombre()
        objeto.Apellido = getapellido()
        objeto.id_provincia = getprovincia()
        objeto.direccion = getdireccion()
        objeto.barrio = getbarrio()
        objeto.telefono_fijo = gettelefono_fijo()
        objeto.telefono_celular = gettelefono_celular()
        objeto.e_mail = gete_mail()
        objeto.nombre_usuario = getnombre_usuario()
        objeto.contraseña = getcontraseña()
        objeto.perfil_usuario = getperfil()
        Try
            capanegocio.nuevousuario(objeto) ' el objeto salta a la capa de negocio (ojbu), va al daousuarios a objusu y llena el formulario

            txtcodigo.Clear() 'borra campo codigo
            generacodigo() ' llama a procedimiento q carga el nuevo codigo
            'Dim opc As DialogResult = MsgBox("Desea agregar a un nuevo Usuario..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
            'If opc = Windows.Forms.DialogResult.Yes Then
            '    generacodigo()
            '    limpiarControles()

            'Else
            '    Me.Close()
            'End If
        Catch ex As Exception
            MsgBox("Error al registrar el Usuario", MsgBoxStyle.Critical)
        End Try

        MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar")

    End Sub


    Private Sub btnActualizarUsuario_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarUsuario.Click

        Try
            UsuarioSeleccionado.id_usuario = txtcodigo.Text
            UsuarioSeleccionado.Nombre = txtNombre.Text
            UsuarioSeleccionado.Apellido = txtApellido.Text
            UsuarioSeleccionado.id_provincia = cboprovincia.SelectedValue
            UsuarioSeleccionado.direccion = txtDireccion.Text
            UsuarioSeleccionado.barrio = txtBarrio.Text
            UsuarioSeleccionado.telefono_fijo = txtTelefonoFijo.Text
            UsuarioSeleccionado.telefono_celular = txtTelefonoCelular.Text
            UsuarioSeleccionado.e_mail = txtEmail.Text
            UsuarioSeleccionado.nombre_usuario = txtNombreUsuario.Text
            UsuarioSeleccionado.contraseña = txtContraseña.Text
            UsuarioSeleccionado.perfil_usuario = cboPerfilUsuario.SelectedValue

            capanegocio.actualizarusuario(UsuarioSeleccionado)

            MsgBox(" Los datos del Usuario han sido actualizados correctamente")
            Me.Hide()
            LISTAUSUARIOS.ShowDialog()
            'Me.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar los datos del Usuario")
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtTelefonoFijo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoFijo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefonoCelular_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoCelular.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
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

    Private Sub txtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido.TextChanged
        Dim i As Integer
        txtApellido.Text = StrConv(txtApellido.Text, VbStrConv.ProperCase)
        i = Len(txtApellido.Text)
        txtApellido.SelectionStart = i
    End Sub

    Private Sub txtBarrio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarrio.KeyPress
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

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                             "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub txtEmail_Leave(sender As Object, e As System.EventArgs) Handles txtEmail.Leave
        If validar_Mail(LCase(txtEmail.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no es valido, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo válido", "Validación de correo electronico", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            txtEmail.SelectAll()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        'CREACIONDECOMPETENCIAS.txtUsuarioResponsable.Text = Me.txtApellido.Text
        Dim i As Integer
        txtNombre.Text = StrConv(txtNombre.Text, VbStrConv.ProperCase)
        i = Len(txtNombre.Text)
        txtNombre.SelectionStart = i
    End Sub

    Private Sub txtDireccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDireccion.TextChanged
        Dim i As Integer
        txtDireccion.Text = StrConv(txtDireccion.Text, VbStrConv.ProperCase)
        i = Len(txtDireccion.Text)
        txtDireccion.SelectionStart = i
    End Sub

    Private Sub txtBarrio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarrio.TextChanged
        Dim i As Integer
        txtBarrio.Text = StrConv(txtBarrio.Text, VbStrConv.ProperCase)
        i = Len(txtBarrio.Text)
        txtBarrio.SelectionStart = i
    End Sub
End Class
