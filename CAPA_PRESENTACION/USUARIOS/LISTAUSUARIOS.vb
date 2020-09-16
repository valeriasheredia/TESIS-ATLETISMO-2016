Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD ' aqui se encuentra la lista de usuarios

Public Class LISTAUSUARIOS
    Dim capanegocio As New CNUsuarios
    Public Property TipoDeFormulario As TipoFormulario

    Private Sub LISTAUSUARIOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub PrepararFormulario()
        cargaUsuarios()
        btnImprimir.Enabled = True
        btnModificar.Enabled = True
        btnCambiarContraseña.Enabled = True
        btnEliminar.Enabled = True
        btnCerrar.Enabled = True

        Select Case TipoDeFormulario
            Case TipoFormulario.Baja
                btnEliminar.Enabled = True
                btnCerrar.Enabled = True

            Case TipoFormulario.ModificarContraseñaUsuario
                btnCambiarContraseña.Enabled = True

            Case TipoFormulario.Modificacion
                btnImprimir.Enabled = False
                btnModificar.Enabled = True
                btnCambiarContraseña.Enabled = False
                btnEliminar.Enabled = False
                btnCerrar.Enabled = True


        End Select

    End Sub

    'procedimiento que carga los usuarios
    Sub cargaUsuarios()
        Dim listadoDeUsuarios As List(Of CEUsuarios) = capanegocio.ListadoDeUsuariosDTO 'capanegocio es el enlace 
        dgUsuarios.DataSource = listadoDeUsuarios 'datasource fuente de datos
        lbltotal.Text = listadoDeUsuarios.Count
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
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
        filtrarporapellido(txtApellido.Text, dgUsuarios)
    End Sub

    'Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs)
    '    NUEVOUSUARIO.Show()
    '    NUEVOUSUARIO.btnRegistrarUsuario.Visible = True
    '    NUEVOUSUARIO.txtNombre.Text = ""
    '    NUEVOUSUARIO.txtApellido.Text = ""
    '    NUEVOUSUARIO.txtDireccion.Text = ""
    '    NUEVOUSUARIO.txtBarrio.Text = ""
    '    NUEVOUSUARIO.cboprovincia.Text = ""
    '    NUEVOUSUARIO.txtTelefonoFijo.Text = ""
    '    NUEVOUSUARIO.txtTelefonoCelular.Text = ""
    '    NUEVOUSUARIO.txtEmail.Text = ""
    '    NUEVOUSUARIO.txtNombreUsuario.Text = ""
    '    NUEVOUSUARIO.txtContraseña.Text = ""
    '    NUEVOUSUARIO.cboPerfilUsuario.Text = ""
    'End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click

        Dim usuario As CEUsuarios = dgUsuarios.CurrentRow.DataBoundItem
        NUEVOUSUARIO.UsuarioSeleccionado = usuario
        NUEVOUSUARIO.TipoDeFormulario = TipoFormulario.Modificacion
        NUEVOUSUARIO.ShowDialog()
    End Sub

    Private Sub btnCambiarContraseña_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarContraseña.Click

        Dim usuario As CEUsuarios = dgUsuarios.CurrentRow.DataBoundItem
        NUEVOUSUARIO.UsuarioSeleccionado = Usuario
        NUEVOUSUARIO.TipoDeFormulario = TipoFormulario.ModificarContraseñaUsuario

        NUEVOUSUARIO.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim r% = MessageBox.Show("Está seguro de eliminar al Usuario..?", "Mensaje",
MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If r = 6 Then
            capanegocio.eliminarusuario(Me.dgUsuarios.Rows(Me.dgUsuarios.CurrentRow.Index).Cells(0).Value)
            dgUsuarios.Columns.Clear()
            cargaUsuarios()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click


        ReporteUsuario.Show()

    End Sub
End Class
