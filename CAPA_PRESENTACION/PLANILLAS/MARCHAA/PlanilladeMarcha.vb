Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanilladeMarcha
    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMarcha
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMarchaSeleccionada As New CEPlanillaMarcha

    Private Sub PlanilladeMarcha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvAtletasdeMarcha.Rows.RemoveAt(dgvAtletasdeMarcha.CurrentRow.Index)
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click
        If Me.dgvAtletasdeMarcha.Rows.Count = 0 Then
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
        btnIngresar.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            PlanillaMarchaSeleccionada.dorsal = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Dorsal").Value
            PlanillaMarchaSeleccionada.Nombre_atleta = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Nombre_Atleta").Value
            PlanillaMarchaSeleccionada.Apellido_atleta = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Apellido_Atleta").Value
            PlanillaMarchaSeleccionada.id_club_federacion = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Id_Club_Federación").Value
            PlanillaMarchaSeleccionada.Tiempo1 = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Tiempo1").Value
            PlanillaMarchaSeleccionada.Tiempo2 = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Tiempo2").Value
            PlanillaMarchaSeleccionada.Tiempo3 = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Tiempo3").Value
            PlanillaMarchaSeleccionada.tiempo_final_marcha = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Tiempo_Final_Maraton").Value
            PlanillaMarchaSeleccionada.Clasificacion_marcha = dgvAtletasdeMarcha.CurrentRow.Cells.Item("Clasificación_Maraton").Value
            capanegocio.ActualizarPlanillaMarcha(PlanillaMarchaSeleccionada)
            MsgBox("Los datos de l Planilla han sido actualizados correctamente")
        Catch ex As Exception
            MsgBox("Error al actualizar los datos de la Planilla")
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        txtEstado.Text = "En Curso"
        IngresodeTiempodeMarcha.txtCodigoMarcha.Text = Me.txtCodigoMarcha.Text
        IngresodeTiempodeMarcha.txtNombre.Text = Me.txtNombre.Text
        IngresodeTiempodeMarcha.txtLugar.Text = Me.txtLugar.Text
        IngresodeTiempodeMarcha.cboProvincia.Text = Me.cboProvincia.Text
        IngresodeTiempodeMarcha.cboLocalidad.Text = Me.cboLocalidad.Text
        IngresodeTiempodeMarcha.dtpfechainicio.Text = Me.dtpfechainicio.Text
        IngresodeTiempodeMarcha.txtHora.Text = Me.txtHora.Text
        IngresodeTiempodeMarcha.txtEstado.Text = Me.txtEstado.Text
        IngresodeTiempodeMarcha.cboJuez1.Text = Me.cboJuez1.Text
        IngresodeTiempodeMarcha.cboJuez2.Text = Me.cboJuez2.Text
        IngresodeTiempodeMarcha.cboJuez3.Text = Me.cboJuez3.Text
        IngresodeTiempodeMarcha.cboUsuario.Text = Me.cboUsuario.Text
        IngresodeTiempodeMarcha.cboSexo.Text = Me.cboSexo.Text
        IngresodeTiempodeMarcha.cboCategoria.Text = Me.cboCategoria.Text
        IngresodeTiempodeMarcha.cboPrueba.Text = Me.cboPrueba.Text
        IngresodeTiempodeMarcha.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        txtCodigoMarcha.Visible = False
        Label15.Visible = False
        cboUsuario.Visible = False
        btnIngresar.Enabled = False
        btnActualizar.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        dtpfechainicio.Enabled = False
        Me.dgvAtletasdeMarcha.Columns("Id_Atleta").Visible = False
        Me.dgvAtletasdeMarcha.Columns("Id_Resultado_Parcial").Visible = False
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

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanilladeMarcha.dgvAtletasdeMarcha.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta, _
                                                          clubNombre,
                                                          "")
    End Sub

  
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Me.dgvAtletasdeMarcha.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvAtletasdeMarcha.Rows
                objeto.id_competencia = txtCodigoMarcha.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtHora_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora.TextChanged

    End Sub
End Class