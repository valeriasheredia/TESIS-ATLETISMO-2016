Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanilladeObstáculos

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaObstaculos
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaObstaculsSeleccionada As New CEPlanillaObstaculos

    Private Sub PlanilladeObstáculos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub


    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()

        Dim cantidad As DataGridView = CType(dgvPlanillaObstaculos, DataGridView)
        If cboPrueba.Text = "800 metros" Or cboPrueba.Text = "1200 metros" Then
            If cantidad.Rows.Count >= 24 Then
                MessageBox.Show("Ha sido agregado el último atleta, no se permiten mas ingresos")
                btnAgregarAtleta.Enabled = False
                Return
            End If
        Else
            If cboPrueba.Text = "1500 metros" Then
                If cantidad.Rows.Count >= 48 Then
                    MessageBox.Show("Ha sido agregado el último atleta, no se permiten mas ingresos")
                    btnAgregarAtleta.Enabled = False
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvPlanillaObstaculos.Rows.RemoveAt(dgvPlanillaObstaculos.CurrentRow.Index)
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanilladeObstáculos.dgvPlanillaObstaculos.Rows.Add(0,
                                                            atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                          atleta.Nombre_atleta, _
                                                          clubNombre,
                                                          "",
                                                          "",
                                                          "")
    End Sub

    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnImprimir.Enabled = False
        btnComenzar.Enabled = True
        btnCerrar.Enabled = True
        Label1.Visible = False
        Label16.Visible = False
        cboUsuario.Visible = False
        txtCodigoObstaculos.Visible = False
        btnActualizar.Enabled = False
        cboCategoria.SelectedIndex = 0
        btnAceptar.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        'Sexo()
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        Me.dgvPlanillaObstaculos.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaObstaculos.Columns("Id_Resultado_Parcial").Visible = False
        Me.dgvPlanillaObstaculos.Columns("Seleccionar").ReadOnly = False
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

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click

        If Me.dgvPlanillaObstaculos.Rows.Count = 0 Then
            MessageBox.Show("Ingrese a los atletas que participarán de la competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

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
            MessageBox.Show("seleccione un Categoría")
            cboCategoria.Focus()
            Return
        End If

        If cboSexo.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Sexo")
            cboSexo.Focus()
            Return
        End If

        Dim dgv As DataGridView = CType(dgvPlanillaObstaculos, DataGridView)
        'If cboPrueba.Text = "80 c/v" Or cboPrueba.Text = "100 c/v" Or cboPrueba.Text = "110 c/v" Or cboPrueba.Text = "400 c/v" Then
        'ATLETAS = 8
        If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 2 Then
            btnAgregarSerie1.Enabled = True
            GroupBox2.Enabled = True
            btnAceptar.Enabled = True
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            'ATLETAS = 16
        ElseIf dgv.Rows.Count >= 3 And dgv.Rows.Count <= 4 Then

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
            btnAgregaraSerie1.Enabled = True
            btnAgregaraSerie2.Enabled = True
            GroupBox3.Enabled = True
            btnAceptar.Enabled = True
            'ATLETAS = 24
        ElseIf dgv.Rows.Count >= 5 And dgv.Rows.Count <= 6 Then

            GroupBox2.Enabled = False
            GroupBox4.Enabled = True
            GroupBox3.Enabled = False
            btnAgregar1.Enabled = True
            btnAgregar2.Enabled = True
            btnAgregar3.Enabled = True
            btnAceptar.Enabled = True
        End If
        'End If

        'If cboPrueba.Text = "2000 c/o" Or cboPrueba.Text = "3000 c/o"" Then" Then
        '    'ATLETAS = 16
        '    If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 16 Then
        '        btnAgregarSerie1.Enabled = True
        '        GroupBox2.Enabled = True
        '        GroupBox3.Enabled = False
        '        GroupBox4.Enabled = False
        '        btnAceptar.Enabled = True
        '        'ATLETAS = 32
        '    ElseIf dgv.Rows.Count >= 17 And dgv.Rows.Count <= 32 Then

        '        GroupBox2.Enabled = False
        '        GroupBox4.Enabled = False
        '        btnAgregaraSerie1.Enabled = True
        '        btnAgregaraSerie2.Enabled = True
        '        GroupBox3.Enabled = True
        '        btnAceptar.Enabled = True
        '        'ATLETAS = 48
        '    ElseIf dgv.Rows.Count >= 33 And dgv.Rows.Count <= 48 Then
        '        GroupBox2.Enabled = False
        '        GroupBox3.Enabled = False
        '        btnAgregar1.Enabled = True
        '        btnAgregar2.Enabled = True
        '        btnAgregar3.Enabled = True
        '        GroupBox4.Enabled = True
        '        btnAceptar.Enabled = True
        '    End If
        'End If

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Me.dgvPlanillaObstaculos.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvPlanillaObstaculos.Rows
                objeto.id_competencia = txtCodigoObstaculos.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregarSerie1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            PlanillaSerieUnicaObstaculos.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaSerieUnicaObstaculos.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Planilla2SeriesObstaculos.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesObstaculos.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Planilla2SeriesObstaculos.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesObstaculos.dgvSerie2.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Planillade3SeriedeObstaculos.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriedeObstaculos.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Planillade3SeriedeObstaculos.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriedeObstaculos.dgvSerie2.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar3.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Planillade3SeriedeObstaculos.dgvSerie3.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaObstaculos.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaObstaculos.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriedeObstaculos.dgvSerie3.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAceptar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If GroupBox2.Enabled = True Then
            txtEstado.Text = "En Curso"
            PlanillaSerieUnicaObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
            PlanillaSerieUnicaObstaculos.txtNombre.Text = Me.txtNombre.Text
            PlanillaSerieUnicaObstaculos.txtLugar.Text = Me.txtLugar.Text
            PlanillaSerieUnicaObstaculos.cboProvincia.Text = Me.cboProvincia.Text
            PlanillaSerieUnicaObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
            PlanillaSerieUnicaObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
            PlanillaSerieUnicaObstaculos.txtHora.Text = Me.txtHora.Text
            PlanillaSerieUnicaObstaculos.txtEstado.Text = Me.txtEstado.Text
            PlanillaSerieUnicaObstaculos.cboJuez1.Text = Me.cboJuez1.Text
            PlanillaSerieUnicaObstaculos.cboJuez2.Text = Me.cboJuez2.Text
            PlanillaSerieUnicaObstaculos.cboJuez3.Text = Me.cboJuez3.Text
            PlanillaSerieUnicaObstaculos.cboUsuario.Text = Me.cboUsuario.Text
            PlanillaSerieUnicaObstaculos.cboPrueba.Text = Me.cboPrueba.Text
            PlanillaSerieUnicaObstaculos.cboSexo.Text = Me.cboSexo.Text
            PlanillaSerieUnicaObstaculos.cboCategoria.Text = Me.cboCategoria.Text
            PlanillaSerieUnicaObstaculos.Show()
        End If
        If GroupBox3.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planilla2SeriesObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
            Planilla2SeriesObstaculos.txtNombre.Text = Me.txtNombre.Text
            Planilla2SeriesObstaculos.txtLugar.Text = Me.txtLugar.Text
            Planilla2SeriesObstaculos.cboProvincia.Text = Me.cboProvincia.Text
            Planilla2SeriesObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
            Planilla2SeriesObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planilla2SeriesObstaculos.txtHora.Text = Me.txtHora.Text
            Planilla2SeriesObstaculos.txtEstado.Text = Me.txtEstado.Text
            Planilla2SeriesObstaculos.cboJuez1.Text = Me.cboJuez1.Text
            Planilla2SeriesObstaculos.cboJuez2.Text = Me.cboJuez2.Text
            Planilla2SeriesObstaculos.cboJuez3.Text = Me.cboJuez3.Text
            Planilla2SeriesObstaculos.cboUsuario.Text = Me.cboUsuario.Text
            Planilla2SeriesObstaculos.cboPrueba.Text = Me.cboPrueba.Text
            Planilla2SeriesObstaculos.cboSexo.Text = Me.cboSexo.Text
            Planilla2SeriesObstaculos.cboCategoria.Text = Me.cboCategoria.Text
            Planilla2SeriesObstaculos.Show()
        End If
        If GroupBox4.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planillade3SeriedeObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
            Planillade3SeriedeObstaculos.txtNombre.Text = Me.txtNombre.Text
            Planillade3SeriedeObstaculos.txtLugar.Text = Me.txtLugar.Text
            Planillade3SeriedeObstaculos.cboProvincia.Text = Me.cboProvincia.Text
            Planillade3SeriedeObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
            Planillade3SeriedeObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planillade3SeriedeObstaculos.txtHora.Text = Me.txtHora.Text
            Planillade3SeriedeObstaculos.txtEstado.Text = Me.txtEstado.Text
            Planillade3SeriedeObstaculos.cboJuez1.Text = Me.cboJuez1.Text
            Planillade3SeriedeObstaculos.cboJuez2.Text = Me.cboJuez2.Text
            Planillade3SeriedeObstaculos.cboJuez3.Text = Me.cboJuez3.Text
            Planillade3SeriedeObstaculos.cboUsuario.Text = Me.cboUsuario.Text
            Planillade3SeriedeObstaculos.cboPrueba.Text = Me.cboPrueba.Text
            Planillade3SeriedeObstaculos.cboSexo.Text = Me.cboSexo.Text
            Planillade3SeriedeObstaculos.cboCategoria.Text = Me.cboCategoria.Text
            Planillade3SeriedeObstaculos.Show()
        End If
    End Sub
End Class