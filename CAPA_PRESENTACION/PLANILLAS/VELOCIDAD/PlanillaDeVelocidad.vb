Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaDeVelocidad

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaVelocidad
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaVelocidadSeleccionada As New CEPlanillaVelocidad


    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()

        Dim cantidad As DataGridView = CType(dgvPlanillaVelocidad, DataGridView)
        If cantidad.Rows.Count >= 24 Then
            MessageBox.Show("Ha sido agregado el último atleta, no se permiten mas ingresos")
            btnAgregarAtleta.Enabled = False
            Return
        End If
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvPlanillaVelocidad.Rows.RemoveAt(dgvPlanillaVelocidad.CurrentRow.Index)
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaDeVelocidad.dgvPlanillaVelocidad.Rows.Add(0,
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
        txtCodigoVelocidad.Visible = False
        btnActualizar.Enabled = False
        Label15.Visible = False
        cboUsuario.Visible = False
        Me.dgvPlanillaVelocidad.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaVelocidad.Columns("Id_Resultado_Parcial").Visible = False
        cboCategoria.SelectedIndex = 0
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        'Sexo()
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        btnAceptar.Enabled = False
        Me.dgvPlanillaVelocidad.Columns("Seleccionar").ReadOnly = False
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

    Private Sub PlanillaDeVelocidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click

        If Me.dgvPlanillaVelocidad.Rows.Count = 0 Then
            MessageBox.Show("Ingrese a los atletas que participarán de la competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

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

        Dim dgv As DataGridView = CType(dgvPlanillaVelocidad, DataGridView)
        If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 2 Then

            btnAgregarSerie1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            btnAceptar.Enabled = True

        ElseIf dgv.Rows.Count >= 3 And dgv.Rows.Count <= 4 Then

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
            btnAgregaraSerie1.Enabled = True
            btnAgregaraSerie2.Enabled = True
            GroupBox3.Enabled = True
            btnAceptar.Enabled = True
        ElseIf dgv.Rows.Count >= 5 And dgv.Rows.Count <= 6 Then

            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            btnAgregar1.Enabled = True
            btnAgregar2.Enabled = True
            btnAgregar3.Enabled = True
            GroupBox4.Enabled = True
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Me.dgvPlanillaVelocidad.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvPlanillaVelocidad.Rows
                objeto.id_competencia = txtCodigoVelocidad.Text
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
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            PlanilladeSerieUnicaVelocidad.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanilladeSerieUnicaVelocidad.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            Planillade2SeriesdeVelocidad.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade2SeriesdeVelocidad.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            Planillade2SeriesdeVelocidad.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade2SeriesdeVelocidad.dgvSerie2.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            Planillade3SeriesVelocidad.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesVelocidad.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            Planillade3SeriesVelocidad.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesVelocidad.dgvSerie2.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAgregar3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar3.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
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
            Planillade3SeriesVelocidad.dgvSerie3.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaVelocidad.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaVelocidad.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesVelocidad.dgvSerie3.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value})
        Next
    End Sub

    Private Sub btnAceptar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If GroupBox2.Enabled = True Then
            txtEstado.Text = "En Curso"
            PlanilladeSerieUnicaVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoVelocidad.Text
            PlanilladeSerieUnicaVelocidad.txtNombre.Text = Me.txtNombre.Text
            PlanilladeSerieUnicaVelocidad.txtLugar.Text = Me.txtLugar.Text
            PlanilladeSerieUnicaVelocidad.cboProvincia.Text = Me.cboProvincia.Text
            PlanilladeSerieUnicaVelocidad.cboLocalidad.Text = Me.cboLocalidad.Text
            PlanilladeSerieUnicaVelocidad.dtpfechainicio.Text = Me.dtpfechainicio.Text
            PlanilladeSerieUnicaVelocidad.txtHora.Text = Me.txtHora.Text
            PlanilladeSerieUnicaVelocidad.txtEstado.Text = Me.txtEstado.Text
            PlanilladeSerieUnicaVelocidad.cboJuez1.Text = Me.cboJuez1.Text
            PlanilladeSerieUnicaVelocidad.cboJuez2.Text = Me.cboJuez2.Text
            PlanilladeSerieUnicaVelocidad.cboJuez3.Text = Me.cboJuez3.Text
            PlanilladeSerieUnicaVelocidad.cboUsuario.Text = Me.cboUsuario.Text
            PlanilladeSerieUnicaVelocidad.cboPrueba.Text = Me.cboPrueba.Text
            PlanilladeSerieUnicaVelocidad.cboSexo.Text = Me.cboSexo.Text
            PlanilladeSerieUnicaVelocidad.cboCategoria.Text = Me.cboCategoria.Text
            PlanilladeSerieUnicaVelocidad.Show()
        End If
        If GroupBox3.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planillade2SeriesdeVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoVelocidad.Text
            Planillade2SeriesdeVelocidad.txtNombre.Text = Me.txtNombre.Text
            Planillade2SeriesdeVelocidad.txtLugar.Text = Me.txtLugar.Text
            Planillade2SeriesdeVelocidad.cboProvincia.Text = Me.cboProvincia.Text
            Planillade2SeriesdeVelocidad.cboLocalidad.Text = Me.cboLocalidad.Text
            Planillade2SeriesdeVelocidad.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planillade2SeriesdeVelocidad.txtHora.Text = Me.txtHora.Text
            Planillade2SeriesdeVelocidad.txtEstado.Text = Me.txtEstado.Text
            Planillade2SeriesdeVelocidad.cboJuez1.Text = Me.cboJuez1.Text
            Planillade2SeriesdeVelocidad.cboJuez2.Text = Me.cboJuez2.Text
            Planillade2SeriesdeVelocidad.cboJuez3.Text = Me.cboJuez3.Text
            Planillade2SeriesdeVelocidad.cboUsuario.Text = Me.cboUsuario.Text
            Planillade2SeriesdeVelocidad.cboPrueba.Text = Me.cboPrueba.Text
            Planillade2SeriesdeVelocidad.cboSexo.Text = Me.cboSexo.Text
            Planillade2SeriesdeVelocidad.cboCategoria.Text = Me.cboCategoria.Text
            Planillade2SeriesdeVelocidad.Show()
        End If
        If GroupBox4.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planillade3SeriesVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoVelocidad.Text
            Planillade3SeriesVelocidad.txtNombre.Text = Me.txtNombre.Text
            Planillade3SeriesVelocidad.txtLugar.Text = Me.txtLugar.Text
            Planillade3SeriesVelocidad.cboProvincia.Text = Me.cboProvincia.Text
            Planillade3SeriesVelocidad.cboLocalidad.Text = Me.cboLocalidad.Text
            Planillade3SeriesVelocidad.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planillade3SeriesVelocidad.txtHora.Text = Me.txtHora.Text
            Planillade3SeriesVelocidad.txtEstado.Text = Me.txtEstado.Text
            Planillade3SeriesVelocidad.cboJuez1.Text = Me.cboJuez1.Text
            Planillade3SeriesVelocidad.cboJuez2.Text = Me.cboJuez2.Text
            Planillade3SeriesVelocidad.cboJuez3.Text = Me.cboJuez3.Text
            Planillade3SeriesVelocidad.cboUsuario.Text = Me.cboUsuario.Text
            Planillade3SeriesVelocidad.cboPrueba.Text = Me.cboPrueba.Text
            Planillade3SeriesVelocidad.cboSexo.Text = Me.cboSexo.Text
            Planillade3SeriesVelocidad.cboCategoria.Text = Me.cboCategoria.Text
            Planillade3SeriesVelocidad.Show()
        End If
    End Sub
End Class

