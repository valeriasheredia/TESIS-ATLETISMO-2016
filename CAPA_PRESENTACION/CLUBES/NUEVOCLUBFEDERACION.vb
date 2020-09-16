Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NUEVOCLUBFEDERACION

    'Dim datos As New BaseDataContext
    Dim capanegocio As New CNClubFederación
    Shared Property ClubSeleccionado As New CEClubFederacion
    Public Property TipoDeFormulario As TipoFormulario
    'Const ID_PROVINCIA_DEFAULT As Integer = 24 '--Seleccionar--

    Private Sub NUEVOCLUBFEDERACION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub RellenarCampos()
        txtCodigoClub.Text = ClubSeleccionado.id_club_federacion
        txtnombreclub.Text = ClubSeleccionado.Nombre_club
        cboprovclub.Text = ClubSeleccionado.id_provincia
        cbolocclub.Text = ClubSeleccionado.id_localidad
        txtdireccionclub.Text = ClubSeleccionado.direccion
        txtfijoclub.Text = ClubSeleccionado.telefono_fijo
        txtceluclub.Text = ClubSeleccionado.telefono_celular
        txtmailclub.Text = ClubSeleccionado.e_mail
    End Sub

    Sub PrepararFormulario()
        btnRegistrar.Enabled = False
        btnActualizar.Enabled = False
        btncancelar.Enabled = False

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                ' Me.Text = "NUEVO CLUB/FEDERACION"
                generacodigoclub()
                listaprovinciaclub()
                ListaLocalidadClub()
                btnRegistrar.Enabled = True
                btnActualizar.Enabled = False
                btncancelar.Enabled = True

            Case TipoFormulario.Alta
                btnRegistrar.Enabled = True

            Case TipoFormulario.Baja

            Case TipoFormulario.Modificacion

                ' botones
                btnRegistrar.Enabled = False
                btnActualizar.Enabled = True
                btncancelar.Enabled = True
                ' combos
                listaprovinciaclub()
                ListaLocalidadClub()
                cboprovclub.SelectedValue = ClubSeleccionado.id_provincia
                cbolocclub.SelectedValue = ClubSeleccionado.id_localidad

                Me.Text = "MODIFICAR DATOS DEL CLUB/FEDERACION"
                capanegocio.actualizarClub(ClubSeleccionado)
                RellenarCampos()
                LISTADOCLUBFEDERACION.Close()

        End Select
    End Sub

    Sub generacodigoclub()
        txtCodigoClub.Text = capanegocio.nuevocodigoclub
    End Sub

    Sub listaprovinciaclub()
        cboprovclub.DisplayMember = "Nombre_Provincia"
        cboprovclub.ValueMember = "Id_Provincia"
        cboprovclub.DataSource = capanegocio.listaprovinciaclub.Tables("Lista Provincias")
        cboprovclub.SelectedIndex = 22
        'ESTO LO HIZO EL PROFE!!!!
        'si yo quiero que la provincia por defecto sea cordoba
         
        'Dim i As Integer = 0
        'For Each item As DataRowView In cboprovclub.Items
        '    Dim id_provincia_actual = item.Row("Id_Provincia")
        '    If id_provincia_actual = ID_PROVINCIA_DEFAULT Then
        '        cboprovclub.SelectedIndex = i
        '        Return
        '    End If
        '    i = i + 1
        'Next
        'cboprovclub.SelectedIndex = 0

    End Sub

    Sub ListaLocalidadClub()
        'limpiamos el combo
        cbolocclub.DataSource = Nothing
        If (Me.cboprovclub.SelectedValue Is Nothing) Then 'si no hay ninguna provincia seleccionada salgo
            Return
        End If
        With cbolocclub
            .DisplayMember = "Nombre_Localidad"
            .ValueMember = "Id_Localidad"
            'lleno el combo con el listado de localidades filtrado por provincia
            .DataSource = capanegocio.ListaLocalidadClub(Me.cboprovclub.SelectedValue).Tables(0)
        End With
    End Sub

    Function getIdClub()
        Return txtCodigoClub.Text
    End Function

    Function getnombreclub() As String
        Return txtnombreclub.Text
    End Function

    Function getdireccionclub() As String
        Return txtdireccionclub.Text
    End Function

    Function getidprovclub() As String
        Return cboprovclub.SelectedIndex
    End Function

    Function getidlocclub() As String
        Return cbolocclub.SelectedIndex
    End Function

    Function getfijo() As String
        Return txtfijoclub.Text
    End Function

    Function getcelular() As String
        Return txtceluclub.Text
    End Function

    Function getmailclub() As String
        Return txtmailclub.Text
    End Function

    Private Sub cboprovclub_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboprovclub.SelectedIndexChanged
        ListaLocalidadClub()
    End Sub

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click

        Dim objeto As New CEClubFederacion ' llena los valores y los envia a la clase CLUB por medio del objeto

        If txtnombreclub.Text = "" Then
            MessageBox.Show("El nombre del club no puede estar vacio")
            txtnombreclub.Focus()
            Return
        End If


        If cboprovclub.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar una Provincia")
            cboprovclub.Focus()
            Return
        End If

        If txtmailclub.Text = "" Then
            MessageBox.Show("Ingrese un e-mail valido")
            txtmailclub.Focus()
            Return
        End If

        'objeto.id_club_federacion = getIdClub()
        objeto.Nombre_club = getnombreclub()
        objeto.id_provincia = getidprovclub()
        objeto.id_localidad = getidlocclub()
        objeto.direccion = getdireccionclub()
        objeto.telefono_fijo = getfijo()
        objeto.telefono_celular = getcelular()
        objeto.e_mail = getmailclub()
        Try
            capanegocio.nuevoclub(objeto) ' el objeto salta a la capa de negocio (ojbu), va al daousuarios a objusu y llena el formulario
            txtCodigoClub.Clear()
            generacodigoclub()

        Catch ex As Exception
            MsgBox("Error al registrar al Club/Federación", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        Try
            ClubSeleccionado.id_club_federacion = txtCodigoClub.Text
            ClubSeleccionado.Nombre_club = txtnombreclub.Text
            ClubSeleccionado.id_provincia = cboprovclub.SelectedValue
            ClubSeleccionado.id_localidad = cbolocclub.SelectedValue
            ClubSeleccionado.direccion = txtdireccionclub.Text
            ClubSeleccionado.telefono_fijo = txtfijoclub.Text
            ClubSeleccionado.telefono_celular = txtceluclub.Text
            ClubSeleccionado.e_mail = txtmailclub.Text

            ' si es necesario validar campos se realizan justamente aqui
            ' esto sirve por ejemplo cuando se limpian los campos. al actualizar
            ' se mostrara el mensaje de alerta de campos vacios

            capanegocio.actualizarClub(ClubSeleccionado)

            MsgBox(" Los datos del Club/Federación han sido actualizados correctamente").ToString()
            Me.Hide()
            LISTADOCLUBFEDERACION.ShowDialog()

        Catch ex As Exception
            MsgBox("Error al actualizar los datos del Club/Federación").ToString()
        End Try
    End Sub


    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtnombreclub_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombreclub.KeyPress
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

    Private Sub txtfijoclub_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfijoclub.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtfijoclub_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfijoclub.TextChanged

    End Sub

    Private Sub txtceluclub_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtceluclub.KeyPress
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

    Private Sub txtmailclub_Leave(sender As Object, e As System.EventArgs) Handles txtmailclub.Leave
        If validar_Mail(LCase(txtmailclub.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no es valido, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo válido", "Validación de correo electronico", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            txtmailclub.Focus()
            txtmailclub.SelectAll()
        End If
    End Sub

    Private Sub txtnombreclub_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombreclub.TextChanged
        Dim i As Integer
        txtnombreclub.Text = StrConv(txtnombreclub.Text, VbStrConv.ProperCase)
        i = Len(txtnombreclub.Text)
        txtnombreclub.SelectionStart = i
    End Sub

    Private Sub txtdireccionclub_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdireccionclub.TextChanged
        Dim i As Integer
        txtdireccionclub.Text = StrConv(txtdireccionclub.Text, VbStrConv.ProperCase)
        i = Len(txtdireccionclub.Text)
        txtdireccionclub.SelectionStart = i
    End Sub
End Class