Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaMaraton

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMaraton
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMaratonSeleccionada As New CEPlanillaMaraton

    Private Sub PlanillaMaraton_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvAtletasdeMaraton.Rows.RemoveAt(dgvAtletasdeMaraton.CurrentRow.Index)
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click
        If Me.dgvAtletasdeMaraton.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar los Tiempos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If
        ' VALIDACION DE JUECES
        If cboJuez1.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez1.Focus()
            Return
        End If

        If cboJuez2.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez2.Focus()
            Return
        End If

        If cboJuez3.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
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
        btnIngresar.Enabled = True
        btnActualizar.Enabled = False
        btnGuardar.Enabled = False
        btnIngresar.Enabled = True
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

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            PlanillaMaratonSeleccionada.dorsal = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Dorsal").Value
            PlanillaMaratonSeleccionada.Nombre_atleta = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Nombre_Atleta").Value
            PlanillaMaratonSeleccionada.Apellido_atleta = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Apellido_Atleta").Value
            PlanillaMaratonSeleccionada.id_club_federacion = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Id_Club_Federación").Value
            PlanillaMaratonSeleccionada.Tiempo1 = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Tiempo1").Value
            PlanillaMaratonSeleccionada.Tiempo2 = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Tiempo2").Value
            PlanillaMaratonSeleccionada.Tiempo3 = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Tiempo3").Value
            PlanillaMaratonSeleccionada.tiempo_final_maraton = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Tiempo_Final_Maraton").Value
            PlanillaMaratonSeleccionada.Clasificacion_maraton = dgvAtletasdeMaraton.CurrentRow.Cells.Item("Clasificación_Maraton").Value
            capanegocio.ActualizarPlanillaMaraton(PlanillaMaratonSeleccionada)
            MsgBox("Los datos de l Planilla han sido actualizados correctamente")
        Catch ex As Exception
            MsgBox("Error al actualizar los datos de la Planilla")
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        txtEstado.Text = "En Curso"
        IngresodeTiemposMaraton.txtCodigoPlanillaMaraton.Text = Me.txtCodigoMaraton.Text
        IngresodeTiemposMaraton.txtNombre.Text = Me.txtNombre.Text
        IngresodeTiemposMaraton.txtLugar.Text = Me.txtLugar.Text
        IngresodeTiemposMaraton.cboProvincia.Text = Me.cboProvincia.Text
        IngresodeTiemposMaraton.cboLocalidad.Text = Me.cboLocalidad.Text
        IngresodeTiemposMaraton.dtpfechainicio.Text = Me.dtpfechainicio.Text
        IngresodeTiemposMaraton.txtHora.Text = Me.txtHora.Text
        IngresodeTiemposMaraton.txtEstado.Text = Me.txtEstado.Text
        IngresodeTiemposMaraton.cboJuez1.Text = Me.cboJuez1.Text
        IngresodeTiemposMaraton.cboJuez2.Text = Me.cboJuez2.Text
        IngresodeTiemposMaraton.cboJuez3.Text = Me.cboJuez3.Text
        IngresodeTiemposMaraton.cboUsuario.Text = Me.cboUsuario.Text
        IngresodeTiemposMaraton.cboSexo.Text = Me.cboSexo.Text
        IngresodeTiemposMaraton.cboCategoria.Text = Me.cboCategoria.Text
        IngresodeTiemposMaraton.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label13.Visible = False
        txtCodigoMaraton.Visible = False
        cboUsuario.Visible = False
        btnIngresar.Enabled = False
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnActualizar.Enabled = False
        btnComenzar.Enabled = True
        btnIngresar.Enabled = False
        btnGuardar.Enabled = True
        btnImprimir.Enabled = False
        Me.dgvAtletasdeMaraton.Columns("Id_Atleta").Visible = False
        Me.dgvAtletasdeMaraton.Columns("Id_Resultado_Parcial").Visible = False
        cboCategoria.SelectedIndex = 0
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        'Sexo()
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        dtpfechainicio.Enabled = False

    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaMaraton.dgvAtletasdeMaraton.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta, _
                                                          clubNombre,
                                                          "")
    End Sub

    Private Sub btnGuardarCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        ' valida que haya registros para poder guardarlos
        If Me.dgvAtletasdeMaraton.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvAtletasdeMaraton.Rows
                objeto.id_competencia = txtCodigoMaraton.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class