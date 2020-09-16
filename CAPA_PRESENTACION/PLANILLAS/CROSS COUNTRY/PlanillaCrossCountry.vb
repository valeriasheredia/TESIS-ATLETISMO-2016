Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaCrossCountry

    Public Property Id_Competencia As Int32
    Dim capanegocio As New cnplanillacrosscountry
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaCrossCountrySeleccionada As New CEPlanillaCrossCountry

    Private Sub PlanillaCrossCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvAtletasdeCrossCountry.Rows.RemoveAt(dgvAtletasdeCrossCountry.CurrentRow.Index)
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click
        If Me.dgvAtletasdeCrossCountry.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar los Tiempos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If
        ' VALIDACION DE JUECES
        If cboJuez1.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Juez")
            cboJuez1.Focus()
            Return
        End If

        If cboJuez2.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Juez")
            cboJuez2.Focus()
            Return
        End If

        If cboJuez3.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Juez")
            cboJuez3.Focus()
            Return
        End If

        If cboCategoria.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Categoría")
            cboCategoria.Focus()
            Return
        End If

        If cboSexo.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Sexo")
            cboSexo.Focus()
            Return
        End If

        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnCerrar.Enabled = True
        btnImprimir.Enabled = True
        btnIngresarTiempos.Enabled = True
        btnActualizar.Enabled = False
        btnGuardarCompetencia.Enabled = False

    End Sub

    'Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
    '    Try
    '        PlanillaCrossCountrySeleccionada.id_planilla_cross_country = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Número").Value
    '        PlanillaCrossCountrySeleccionada.dorsal = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Dorsal").Value
    '        PlanillaCrossCountrySeleccionada.Nombre_atleta = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Nombre").Value
    '        PlanillaCrossCountrySeleccionada.Apellido_atleta = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Apellido").Value
    '        PlanillaCrossCountrySeleccionada.id_club_federacion = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Sexo").Value
    '        PlanillaCrossCountrySeleccionada.Tiempo1 = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Localidad").Value
    '        PlanillaCrossCountrySeleccionada.Tiempo2 = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Edad").Value
    '        PlanillaCrossCountrySeleccionada.Tiempo3 = dgvAtletasdeCrossCountry.CurrentRow.Cells.Item("Institución").Value

    '        capanegocio.ActualizarPlanillaCrossCountry(PlanillaCrossCountrySeleccionada)
    '        MsgBox("Los datos de l Planilla han sido actualizados correctamente")
    '    Catch ex As Exception
    '        MsgBox("Error al actualizar los datos de la Planilla")
    '    End Try
    'End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresarTiempos.Click
        txtEstado.Text = "En Curso"
        IngresodeTiemposCrossCountry.txtCodigoPlanillaCrossCountry.Text = Me.txtCodigoPlanillaCrossCountry.Text
        IngresodeTiemposCrossCountry.txtNombre.Text = Me.txtNombre.Text
        IngresodeTiemposCrossCountry.txtLugar.Text = Me.txtLugar.Text
        IngresodeTiemposCrossCountry.cboProvincia.Text = Me.cboProvincia.Text
        IngresodeTiemposCrossCountry.cboLocalidad.Text = Me.cboLocalidad.Text
        IngresodeTiemposCrossCountry.dtpfechainicio.Text = Me.dtpfechainicio.Text
        IngresodeTiemposCrossCountry.txtHora.Text = Me.txtHora.Text
        IngresodeTiemposCrossCountry.txtEstado.Text = Me.txtEstado.Text
        IngresodeTiemposCrossCountry.cboJuez1.Text = Me.cboJuez1.Text
        IngresodeTiemposCrossCountry.cboJuez2.Text = Me.cboJuez2.Text
        IngresodeTiemposCrossCountry.cboJuez3.Text = Me.cboJuez3.Text
        IngresodeTiemposCrossCountry.cboUsuario.Text = Me.cboUsuario.Text
        IngresodeTiemposCrossCountry.cboPrueba.Text = Me.cboPrueba.Text
        IngresodeTiemposCrossCountry.cboSexo.Text = Me.cboSexo.Text
        IngresodeTiemposCrossCountry.cboCategoria.Text = Me.cboCategoria.Text

        IngresodeTiemposCrossCountry.ShowDialog()
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaCrossCountry.dgvAtletasdeCrossCountry.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta, _
                                                          clubNombre,
                                                          "")
    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label13.Visible = False
        txtCodigoPlanillaCrossCountry.Visible = False
        cboUsuario.Visible = False
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnCerrar.Enabled = True
        btnImprimir.Enabled = True
        btnIngresarTiempos.Enabled = False
        btnActualizar.Enabled = False
        btnGuardarCompetencia.Enabled = True
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        dtpfechainicio.Enabled = False
        Me.dgvAtletasdeCrossCountry.Columns("Id_Atleta").Visible = False
        Me.dgvAtletasdeCrossCountry.Columns("Id_Resultado_Parcial").Visible = False
        cboCategoria.SelectedIndex = 0
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        'Sexo()
    End Sub

    Sub juezprincipal1()
        cboJuez1.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez1.DisplayMember = "Apellido_Juez"
        cboJuez1.ValueMember = "Id_Juez"
        cboJuez1.SelectedIndex = 8
    End Sub
    Sub juezprincipal2()
        cboJuez2.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez2.DisplayMember = "Apellido_Juez"
        cboJuez2.ValueMember = "Id_Juez"
        cboJuez2.SelectedIndex = 8
    End Sub

    Sub juezprincipal3()
        cboJuez3.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez3.DisplayMember = "Apellido_Juez"
        cboJuez3.ValueMember = "Id_Juez"
        cboJuez3.SelectedIndex = 8
    End Sub

    'Sub Sexo()
    '    cboSexo.DisplayMember = "Sexo"
    '    cboSexo.ValueMember = "Id_Sexo"
    '    cboSexo.DataSource = capanegocio.Sexoatleta.Tables("Sexo")
    '    cboSexo.SelectedIndex = 3
    'End Sub


    Private Sub btnGuardarCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCompetencia.Click
        ' valida que haya registros para poder guardarlos
        If Me.dgvAtletasdeCrossCountry.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvAtletasdeCrossCountry.Rows
                objeto.id_competencia = txtCodigoPlanillaCrossCountry.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class