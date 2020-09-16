Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD

Public Class LISTA_DE_ATLETAS
    Dim capanegocio As New CNAtletas
    Public Property TipoDeFormulario As TipoFormulario

    ''' SE EJECUTA AL CARGARSE EL FORMULARIO
    ''' PONER AQUI TODA LA LOGICA DE "RELLENO" DE CAMPOS
    ''' BOTONERÍA, ETC
    Private Sub PrepararFormulario()
        cargaatletas()
        If Me.dgvlistaatletas.Rows.Count = 0 Then
            MessageBox.Show("Ingrese datos en el grid.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Logica de los botones
        btnModificar.Enabled = True
        btnAgregarNuevo.Enabled = False
        btnAgregarACompetencia.Enabled = False
        btnEliminar.Enabled = True
        btnCerrar.Enabled = True
        btnImprimir.Enabled = True

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                btnAgregarNuevo.Enabled = False
            Case TipoFormulario.Baja
                btnEliminar.Enabled = True

            Case TipoFormulario.Consulta
                'AGREGAR A LA COMPETENCIA
                btnImprimir.Enabled = False
                btnAgregarACompetencia.Enabled = True

            Case TipoFormulario.Modificacion
                btnModificar.Enabled = True

            Case TipoFormulario.AgregarAtleta
                btnAgregarACompetencia.Enabled = True
                btnCerrar.Enabled = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnImprimir.Enabled = False
                btnAgregarNuevo.Enabled = False
        End Select
    End Sub

    Private Sub LISTA_DE_ATLETAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Sub cargaatletas()
        Dim listadoDeAtletas As List(Of CEAtletas) = capanegocio.ListadoDeAtletasDTO()
        dgvlistaatletas.DataSource = listadoDeAtletas
        lbltotalatletas.Text = listadoDeAtletas.Count
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        filtrarpordni(TextBox1.Text, dgvlistaatletas)
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim r% = MessageBox.Show("Está seguro de eliminar al atleta de la base de datos..?", "Mensaje",
         MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If r = 6 Then
            capanegocio.eliminarAtleta(Me.dgvlistaatletas.Rows(Me.dgvlistaatletas.CurrentRow.Index).Cells(0).Value)
            dgvlistaatletas.Columns.Clear()
            cargaatletas()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim atleta As CEAtletas = dgvlistaatletas.CurrentRow.DataBoundItem
        NUEVOATLETA.AtletaSeleccionado = atleta
        NUEVOATLETA.TipoDeFormulario = TipoFormulario.Modificacion
        NUEVOATLETA.ShowDialog()
    End Sub

    Private Sub btnAgregarACompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarACompetencia.Click
        'ESTO ES MUY IMPORTANTE PORQUE LE ESTOY PASANDO ELDTO DEL ATLETA SELECCIONADO, ESTO NO PUEDE ESTAR EN NULO PORQUE EXLOTA TODO
        'Y NOS VMOS A MORIR EN EL INFIERNO
        Dim atleta As CEAtletas = dgvlistaatletas.CurrentRow.DataBoundItem
        NUEVOATLETA.AtletaSeleccionado = atleta
        NUEVOATLETA.TipoDeFormulario = TipoFormulario.DatosAdicionalesDelAtleta
        NUEVOATLETA.ShowDialog()
    End Sub

    Private Sub btnAgregarNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarNuevo.Click
        NUEVOATLETA.TipoDeFormulario = TipoFormulario.Alta
        NUEVOATLETA.ShowDialog()
    End Sub
End Class