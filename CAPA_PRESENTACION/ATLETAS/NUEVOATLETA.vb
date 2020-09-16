Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions

Public Class NUEVOATLETA

    Dim capanegocio As New CNAtletas
    Shared Property AtletaSeleccionado As New CEAtletas
    Public Property TipoDeFormulario As TipoFormulario

    ' procedimiento que llena los campos (textbox....)
    Private Sub RellenarCampos()
        txtIdAtleta.Text = AtletaSeleccionado.id_atleta
        txtNombreAtleta.Text = AtletaSeleccionado.Nombre_atleta
        txtApellidoAtleta.Text = AtletaSeleccionado.Apellido_atleta
        dtpFechaNacimiento.Text = AtletaSeleccionado.fecha_nacimiento
        txtDniAtleta.Text = AtletaSeleccionado.dni_atleta
        cboSexo.SelectedValue = AtletaSeleccionado.id_sexo
        txtNacionalidad.Text = AtletaSeleccionado.nacionalidad
        cboProvAtleta.SelectedValue = AtletaSeleccionado.id_provincia
        cboLocAtleta.SelectedValue = AtletaSeleccionado.id_localidad
        txtDomicilioAtleta.Text = AtletaSeleccionado.domicilio
        txtBarrioAtleta.Text = AtletaSeleccionado.barrio
        txtFijoAtleta.Text = AtletaSeleccionado.telefono_fijo
        txtCelularAtleta.Text = AtletaSeleccionado.telefono_celular
        txtEmailAtleta.Text = AtletaSeleccionado.e_mail
        txtContactoEmergencia.Text = AtletaSeleccionado.contacto_emergencia
        txtFederado.Text = AtletaSeleccionado.federado
        cboClub.SelectedValue = AtletaSeleccionado.id_club_federacion
        txtinstitucion.Text = AtletaSeleccionado.otra_institucion
        TxtNumeroAtleta.Text = AtletaSeleccionado.dorsal
        txtEstadoAtleta.Text = AtletaSeleccionado.estado_atleta
    End Sub

    Private Sub PrepararFormulario()

        'Logica de los botones
        btnRegistrarAtleta.Enabled = False
        btnActualizarAtleta.Enabled = False
        btnLimpiar.Enabled = False
        btnCancelar.Enabled = False
        btnConfirmarAsistencia.Enabled = False

        Select Case TipoDeFormulario

            Case TipoFormulario.Alta
                btnRegistrarAtleta.Enabled = True
                btnLimpiar.Enabled = True

                ' If Me.Text = "NUEVO ATLETA" Then
                nuevoCodigoatleta()
                ListaProvinciaAtleta()
                ListaLocalidadAtleta()
                ListaClubAtleta()
                Sexo()
                btnRegistrarAtleta.Enabled = True
                btnActualizarAtleta.Enabled = False
                GroupBox3.Enabled = False
                btnConfirmarAsistencia.Enabled = False
                btnLimpiar.Enabled = False

            Case TipoFormulario.Baja
                'no hace nada
            Case TipoFormulario.DatosAdicionalesDelAtleta

                btnConfirmarAsistencia.Enabled = True
                btnCancelar.Enabled = True
                'ElseIf Me.Text = "DATOS ADICIONALES DEL ATLETA" Then
                Me.Text = "DATOS ADICIONALES DEL ATLETA"
                nuevoCodigoatleta()
                ListaProvinciaAtleta()
                ListaLocalidadAtleta()
                ListaClubAtleta()
                Sexo()
                cboClub.SelectedValue = AtletaSeleccionado.id_club_federacion
                txtDniAtleta.Enabled = False
                GroupBox3.Enabled = True
                GroupBox1.Enabled = False

                'Cargo los campos con los datos del atleta
                RellenarCampos()
                LISTA_DE_ATLETAS.Close()

            Case TipoFormulario.Modificacion
                ' botones
                btnActualizarAtleta.Enabled = True
                btnLimpiar.Enabled = True
                'combos
                ListaProvinciaAtleta()
                ListaLocalidadAtleta()
                ListaClubAtleta()

                Me.Text = "ACTUALIZAR LOS DATOS DEL ATLETA"
                capanegocio.ActualizarAtleta(AtletaSeleccionado)
                nuevoCodigoatleta()
                ListaProvinciaAtleta()
                ListaLocalidadAtleta()
                ListaClubAtleta()
                cboClub.SelectedValue = AtletaSeleccionado.id_club_federacion
                Sexo()
                txtDniAtleta.Enabled = False
                GroupBox3.Enabled = False

                'Cargo los campos con los datos del atleta
                RellenarCampos()
                LISTA_DE_ATLETAS.Close()
        End Select
    End Sub

    Private Sub NUEVOATLETA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' llamamos al procedimiento que carga el formulario
        PrepararFormulario()

    End Sub

    Sub nuevoCodigoatleta()
        txtIdAtleta.Text = capanegocio.nuevocodigoatleta
    End Sub

    Sub ListaProvinciaAtleta()
        cboProvAtleta.DisplayMember = "Nombre_Provincia"
        cboProvAtleta.ValueMember = "Id_Provincia"
        cboProvAtleta.DataSource = capanegocio.ListaProvinciaAtleta.Tables("provincias de atletas")
        cboProvAtleta.SelectedIndex = 22
    End Sub

    Sub ListaLocalidadAtleta()
        'limpiamos el combo
        cboLocAtleta.DataSource = Nothing
        If (Me.cboProvAtleta.SelectedValue Is Nothing) Then 'si no hay ninguna provincia seleccionada salgo
            Return
        End If
        With cboLocAtleta
            .DisplayMember = "Nombre_Localidad"
            .ValueMember = "Id_Localidad"
            'lleno el combo con el listado de localidades filtrado por provincia
            .DataSource = capanegocio.ListaLocalidadAtleta(Me.cboProvAtleta.SelectedValue).Tables(0)
        End With
    End Sub

    Sub ListaClubAtleta()
        cboClub.DataSource = capanegocio.ListaClubAtleta.Tables("Clubes de Atletas")
        cboClub.DisplayMember = "Nombre_Club"
        cboClub.ValueMember = "Id_Club_Federación"
        cboClub.SelectedIndex = 1
    End Sub

    Sub Sexo()
        cboSexo.DisplayMember = "Sexo"
        cboSexo.ValueMember = "Id_Sexo"
        cboSexo.DataSource = capanegocio.Sexoatleta.Tables("Sexo")
        cboSexo.SelectedIndex = 2
    End Sub

    Function getidatleta()
        Return txtIdAtleta.Text
    End Function

    Function getnombreatleta() As String
        Return txtNombreAtleta.Text
    End Function

    Function getapellidoatleta() As String
        Return txtApellidoAtleta.Text
    End Function

    Function getFechaNacimientoAtleta()
        Return CDate(dtpFechaNacimiento.Text)
    End Function

    Function getDniatleta() As String
        Return txtDniAtleta.Text
    End Function

    Function getNacionalidad() As String
        Return txtNacionalidad.Text
    End Function

    Function getidProvinciaAtleta()
        Return cboProvAtleta.SelectedValue
    End Function

    Function getidLocalidadAtleta()
        Return cboLocAtleta.SelectedValue
    End Function

    Function getDomicilioAtleta() As String
        Return txtDomicilioAtleta.Text
    End Function

    Function getbarrioAtleta() As String
        Return txtBarrioAtleta.Text
    End Function

    Function gettelefono_fijo() As String
        Return txtFijoAtleta.Text
    End Function

    Function gettelefono_celular() As String
        Return txtCelularAtleta.Text
    End Function

    Function gete_mail() As String
        Return txtEmailAtleta.Text
    End Function

    Function getContactoEmergencia() As String
        Return txtContactoEmergencia.Text
    End Function

    Function getFederado() As String
        Return txtFederado.Text
    End Function

    Function getIdClubAtleta() As Integer
        Return cboClub.SelectedValue
    End Function

    Function getOtraInstitucion() As String
        Return txtinstitucion.Text
    End Function

    Function getDorsal()
        Return CInt(TxtNumeroAtleta.Text)
    End Function

    Function getEstadoAtleta()
        Return txtEstadoAtleta.Text
    End Function

    Function getsexo()
        Return cboSexo.SelectedValue
    End Function

    Sub LimpiarControlesAtleta()
        txtNombreAtleta.Text = Nothing
        txtApellidoAtleta.Text = Nothing
        'txtDniAtleta.Text = Nothing
        dtpFechaNacimiento.Text = Nothing
        'txtNacionalidad.Text = Nothing
        'cboProvAtleta.SelectedIndex = -1
        'cboLocAtleta.SelectedIndex = -1
        txtDomicilioAtleta.Text = Nothing
        txtBarrioAtleta.Text = Nothing
        txtFijoAtleta.Text = Nothing
        txtCelularAtleta.Text = Nothing
        txtEmailAtleta.Text = Nothing
        txtContactoEmergencia.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarAtleta.Click

        Dim objeto As New CEAtletas ' llena los valores y los envia a la clase usuarios por medio del objeto

        If txtDniAtleta.Text = "" Then
            MessageBox.Show("El DNI del atleta no puede estar vacío")
            txtDniAtleta.Focus()
            Return
        End If

        If txtNombreAtleta.Text = "" Then
            MessageBox.Show("Complete el campo con el nombre del atleta")
            txtNombreAtleta.Focus()
            Return
        End If

        If txtApellidoAtleta.Text = Nothing Then
            MessageBox.Show("Complete el campo con el apellido del atleta")
            txtApellidoAtleta.Focus()
            Return
        End If

        If Me.dtpFechaNacimiento.Value.Date = DateTime.Now.Date Then
            MessageBox.Show("debe ingresar una fecha de nacimiento válida, ésta no puede ser el día de hoy.")
            dtpFechaNacimiento.Focus()
            Return
        End If

        If cboSexo.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar el Sexo del Atleta")
            cboSexo.Focus()
            Return
        End If

        If cboProvAtleta.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar una Provincia")
            cboProvAtleta.Focus()
            Return
        End If

        If txtDomicilioAtleta.Text = Nothing Then
            MessageBox.Show("Complete el campo con el domicilio del atleta")
            txtDomicilioAtleta.Focus()
            Return
        End If

        If txtCelularAtleta.Text = Nothing Then
            MessageBox.Show("Complete el campo con el Telefono Celular del atleta")
            txtCelularAtleta.Focus()
            Return
        End If


        If txtEmailAtleta.Text = Nothing Then
            MessageBox.Show("Complete el campo con el e-mail del atleta")
            txtEmailAtleta.Focus()
            Return
        End If



        'objeto.id_atleta = getidatleta()
        objeto.Nombre_atleta = getnombreatleta()
        objeto.Apellido_atleta = getapellidoatleta()
        objeto.dni_atleta = getDniatleta()
        objeto.fecha_nacimiento = getFechaNacimientoAtleta()
        objeto.id_sexo = getsexo()
        objeto.nacionalidad = getNacionalidad()
        objeto.id_provincia = getidProvinciaAtleta()
        objeto.id_localidad = getidLocalidadAtleta()
        objeto.domicilio = getDomicilioAtleta()
        objeto.barrio = getbarrioAtleta()
        objeto.telefono_fijo = gettelefono_fijo()
        objeto.telefono_celular = gettelefono_celular()
        objeto.e_mail = gete_mail()
        objeto.contacto_emergencia = getContactoEmergencia()
        objeto.federado = getFederado()
        objeto.id_club_federacion = getIdClubAtleta()
        objeto.otra_institucion = getOtraInstitucion()
        objeto.dorsal = getDorsal()
        objeto.estado_atleta = getEstadoAtleta()

        Try
            capanegocio.nuevoatleta(objeto) 'el objeto salta a la capa de negocio (ojbu), va al daousuarios a objusu y llena el formulario
            btnLimpiar.PerformClick() ' ejecuta el boton limpiar
            txtIdAtleta.Clear() 'borra campo codigo
            nuevoCodigoatleta() ' llama a procedimiento q carga el nuevo codigo
            Dim opc As DialogResult = MsgBox("Desea agregar a un nuevo Atleta..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
            If opc = Windows.Forms.DialogResult.Yes Then
                nuevoCodigoatleta()
                LimpiarControlesAtleta()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(" Error al registrar al Atleta")
        End Try

        MessageBox.Show("Asegúrese de haber llenado todos los campos para poder continuar")

    End Sub

    Private Sub txtNacionalidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNacionalidad.KeyPress
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

    Private Sub txtNacionalidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNacionalidad.TextChanged
        If Not txtNacionalidad.Text = "Argentina" Then
            cboProvAtleta.Text = "Otra"
            cboProvAtleta.Enabled = False
            cboLocAtleta.Enabled = False
        Else
            txtNacionalidad.Text = "Argentina"
            cboProvAtleta.Text = "--Seleccionar--"
            cboProvAtleta.Enabled = True
            cboLocAtleta.Enabled = True
        End If
    End Sub

    Private Sub cboProvAtleta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboProvAtleta.SelectedIndexChanged
        ListaLocalidadAtleta()
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click

        LimpiarControlesAtleta()
    End Sub

    Private Sub btnConfirmarAsistencia_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmarAsistencia.Click

        'cuando confirmo asistencia genere un registro nuevo en la tabla atleta por competencia
        If TxtNumeroAtleta.Text <> "0" Then
            Try
                AtletaSeleccionado.id_club_federacion = cboClub.SelectedValue
                AtletaSeleccionado.otra_institucion = txtinstitucion.Text
                AtletaSeleccionado.dorsal = TxtNumeroAtleta.Text ' dorsal=0
                AtletaSeleccionado.estado_atleta = txtEstadoAtleta.Text

                capanegocio.ActualizarAtleta(AtletaSeleccionado)
                LISTA_DE_ATLETAS.Close()

                'Agrego el atleta al formulario de acuerdo al tipo de competencia
                PLANILLACOMPETENCIACALLE.AgregarRegistroAGrilla(AtletaSeleccionado)
                PLANILLADELANZAMIENTOS.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaSaltoenAltoyGarrocha.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaDeVelocidad.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanilladeMedioFondo.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanilladeFondo.AgregarRegistroAGrilla(AtletaSeleccionado)
                IngresodeTiemposdeCalle.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanilladeObstáculos.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaCrossCountry.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaMaraton.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanilladeMarcha.AgregarRegistroAGrilla(AtletaSeleccionado)
                IngresodeTiempodeMarcha.AgregarRegistroAGrilla(AtletaSeleccionado)
                IngresodeTiemposCrossCountry.AgregarRegistroAGrilla(AtletaSeleccionado)
                IngresodeTiemposMaraton.AgregarRegistroAGrilla(AtletaSeleccionado)
                PLANILLASALTOENLARGOYTRIPLE.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaSaltoenAltoyGarrocha.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalCalle.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalCrossCountry.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalMaraton.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalMarcha.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalFondo.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalMedio_Fondo.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalObstaculos.AgregarRegistroAGrilla(AtletaSeleccionado)
                PlanillaFinalVelocidad.AgregarRegistroAGrilla(AtletaSeleccionado)
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos del Atleta")
                LISTA_DE_ATLETAS.Close()
                MsgBox("No se pudo agregar al Atleta a la Competencia", MsgBoxStyle.Critical)
            End Try
        Else
            MessageBox.Show("El Número o Dorsal del atleta no puede ser 0")
        End If

    End Sub

    Private Sub btnActualizarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarAtleta.Click
        Try
            AtletaSeleccionado.id_atleta = txtIdAtleta.Text
            AtletaSeleccionado.Nombre_atleta = txtNombreAtleta.Text
            AtletaSeleccionado.Apellido_atleta = txtApellidoAtleta.Text
            AtletaSeleccionado.fecha_nacimiento = dtpFechaNacimiento.Text
            AtletaSeleccionado.id_sexo = cboSexo.SelectedValue
            AtletaSeleccionado.dni_atleta = txtDniAtleta.Text
            AtletaSeleccionado.nacionalidad = txtNacionalidad.Text
            AtletaSeleccionado.id_provincia = cboProvAtleta.SelectedValue
            AtletaSeleccionado.id_localidad = cboLocAtleta.SelectedValue
            AtletaSeleccionado.domicilio = txtDomicilioAtleta.Text
            AtletaSeleccionado.barrio = txtBarrioAtleta.Text
            AtletaSeleccionado.telefono_fijo = txtFijoAtleta.Text
            AtletaSeleccionado.telefono_celular = txtCelularAtleta.Text
            AtletaSeleccionado.e_mail = txtEmailAtleta.Text
            AtletaSeleccionado.contacto_emergencia = txtContactoEmergencia.Text
            AtletaSeleccionado.federado = txtFederado.Text
            AtletaSeleccionado.id_club_federacion = cboClub.SelectedValue
            AtletaSeleccionado.otra_institucion = txtinstitucion.Text
            AtletaSeleccionado.dorsal = TxtNumeroAtleta.Text
            AtletaSeleccionado.estado_atleta = txtEstadoAtleta.Text

            ' al limpiar los controles y al querer guardar los cambios realizados,
            ' el sistema muestra que hay campos vacios que son necesarios
            ' una vez llenado con campos si permite la actualizacion del atleta

            If txtNombreAtleta.Text = "" Then
                MessageBox.Show("Complete el campo con el Nombre del atleta")
                txtNombreAtleta.Focus()
                Return
            End If

            If txtApellidoAtleta.Text = Nothing Then
                MessageBox.Show("Complete el campo con el apellido del atleta")
                txtApellidoAtleta.Focus()
                Return
            End If

            If Me.dtpFechaNacimiento.Value.Date = DateTime.Now.Date Then
                MessageBox.Show("debe ingresar una fecha de nacimiento válida, ésta no puede ser el día de hoy.")
                dtpFechaNacimiento.Focus()
                Return
            End If

            If txtDomicilioAtleta.Text = Nothing Then
                MessageBox.Show("Complete el campo con el domicilio del atleta")
                txtDomicilioAtleta.Focus()
                Return
            End If

            If txtCelularAtleta.Text = Nothing Then
                MessageBox.Show("Complete el campo con el Telefono Celular del atleta")
                txtCelularAtleta.Focus()
                Return
            End If

            If txtEmailAtleta.Text = Nothing Then
                MessageBox.Show("Complete el campo con el e-mail del atleta")
                txtEmailAtleta.Focus()
                Return
            End If

            capanegocio.ActualizarAtleta(AtletaSeleccionado)

            MsgBox(" Los datos del Atleta han sido actualizados correctamente")
            Me.Hide()
            LISTA_DE_ATLETAS.ShowDialog()
        Catch ex As Exception
            MsgBox("Error al actualizar los datos del Atleta")

            ' MsgBox("No se pudo agregar al Atleta a la Competencia", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtDniAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDniAtleta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombreAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreAtleta.KeyPress
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

    Private Sub txtApellidoAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoAtleta.KeyPress
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

    Private Sub txtBarrioAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarrioAtleta.KeyPress
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

    Private Sub txtFijoAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFijoAtleta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCelularAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelularAtleta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtFederado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFederado.KeyPress
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

    Private Sub txtEstadoAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstadoAtleta.KeyPress
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

    Private Sub TxtNumeroAtleta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroAtleta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtContactoEmergencia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactoEmergencia.KeyPress
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

    Private Sub txtEmailAtleta_Leave(sender As Object, e As System.EventArgs) Handles txtEmailAtleta.Leave
        If validar_Mail(LCase(txtEmailAtleta.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no es valido, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo válido", "Validación de correo electronico", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            txtEmailAtleta.Focus()
            txtEmailAtleta.SelectAll()
        End If
    End Sub

    Private Sub txtNombreAtleta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreAtleta.TextChanged
        Dim i As Integer
        txtNombreAtleta.Text = StrConv(txtNombreAtleta.Text, VbStrConv.ProperCase)
        i = Len(txtNombreAtleta.Text)
        txtNombreAtleta.SelectionStart = i
    End Sub

    Private Sub txtApellidoAtleta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellidoAtleta.TextChanged
        Dim i As Integer
        txtApellidoAtleta.Text = StrConv(txtApellidoAtleta.Text, VbStrConv.ProperCase)
        i = Len(txtApellidoAtleta.Text)
        txtApellidoAtleta.SelectionStart = i
    End Sub

    Private Sub txtDomicilioAtleta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDomicilioAtleta.TextChanged
        Dim i As Integer
        txtDomicilioAtleta.Text = StrConv(txtDomicilioAtleta.Text, VbStrConv.ProperCase)
        i = Len(txtDomicilioAtleta.Text)
        txtDomicilioAtleta.SelectionStart = i
    End Sub

    Private Sub txtBarrioAtleta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarrioAtleta.TextChanged
        Dim i As Integer
        txtBarrioAtleta.Text = StrConv(txtBarrioAtleta.Text, VbStrConv.ProperCase)
        i = Len(txtBarrioAtleta.Text)
        txtBarrioAtleta.SelectionStart = i
    End Sub

    Private Sub txtFederado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFederado.TextChanged
        Dim i As Integer
        txtFederado.Text = StrConv(txtFederado.Text, VbStrConv.ProperCase)
        i = Len(txtFederado.Text)
        txtFederado.SelectionStart = i
    End Sub

    Private Sub txtEstadoAtleta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEstadoAtleta.TextChanged
        Dim i As Integer
        txtEstadoAtleta.Text = StrConv(txtEstadoAtleta.Text, VbStrConv.ProperCase)
        i = Len(txtEstadoAtleta.Text)
        txtEstadoAtleta.SelectionStart = i
    End Sub

    Private Sub txtinstitucion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtinstitucion.TextChanged
        Dim i As Integer
        txtinstitucion.Text = StrConv(txtinstitucion.Text, VbStrConv.ProperCase)
        i = Len(txtinstitucion.Text)
        txtinstitucion.SelectionStart = i
    End Sub

  
   
End Class

