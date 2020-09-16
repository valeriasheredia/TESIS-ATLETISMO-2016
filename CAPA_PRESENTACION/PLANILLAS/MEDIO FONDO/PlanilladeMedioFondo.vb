Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanilladeMedioFondo

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMedioFondo
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMedioFondoSeleccionada As New CEPlanillaMedioFondo

    Private Sub PlanilladeMedioFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()

        Dim cantidad As DataGridView = CType(dgvPlanillaMedioFondo, DataGridView)
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
        dgvPlanillaMedioFondo.Rows.RemoveAt(dgvPlanillaMedioFondo.CurrentRow.Index)
    End Sub

    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnImprimir.Enabled = False
        btnComenzar.Enabled = True
        btnCerrar.Enabled = True
        Label1.Visible = False
        txtCodigoMedioFondo.Visible = False
        btnActualizar.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        btnAceptar.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        Label22.Visible = False
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
        Me.dgvPlanillaMedioFondo.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaMedioFondo.Columns("Id_Resultado_Parcial").Visible = False
        Me.dgvPlanillaMedioFondo.Columns("Seleccionar").ReadOnly = False
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

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click
       
        If Me.dgvPlanillaMedioFondo.Rows.Count = 0 Then
            MessageBox.Show("Ingrese a los atletas que participarán de la competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
      
        Dim dgv As DataGridView = CType(dgvPlanillaMedioFondo, DataGridView)
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
        'SERIE DE 8 ATLETAS
        'If cboPrueba.Text = "800 metros" Or cboPrueba.Text = "1200 metros" Then
        If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 2 Then
            btnAgregarSerie1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            btnAceptar.Enabled = True
            'SERIE DE 16 ATLETAS
        ElseIf dgv.Rows.Count >= 3 And dgv.Rows.Count <= 4 Then
            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
            btnAgregaraSerie1.Enabled = True
            btnAgregaraSerie2.Enabled = True
            GroupBox3.Enabled = True
            btnAceptar.Enabled = True
            'SERIE DE 24 ATLETAS
        ElseIf dgv.Rows.Count >= 5 And dgv.Rows.Count <= 6 Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            btnAceptar.Enabled = True
            btnAgregar1.Enabled = True
            btnAgregar2.Enabled = True
            btnAgregar3.Enabled = True
        End If
        ' Else
        'SERIE DE 16 ATLETAS
        If cboPrueba.Text = "1500 metros" Then
            If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 16 Then
                btnAgregarSerie1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = False
                GroupBox4.Enabled = False
                'SERIE DE 32 ATLETAS
            ElseIf dgv.Rows.Count >= 17 And dgv.Rows.Count <= 32 Then
                btnAgregaraSerie1.Enabled = True
                btnAgregaraSerie2.Enabled = True
                GroupBox3.Enabled = True
                'SERIE DE 48 ATLETAS
            ElseIf dgv.Rows.Count >= 33 And dgv.Rows.Count <= 48 Then
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
                btnAgregar1.Enabled = True
                btnAgregar2.Enabled = True
                btnAgregar3.Enabled = True
            End If
        End If
        ' End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Me.dgvPlanillaMedioFondo.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If
        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvPlanillaMedioFondo.Rows
                objeto.id_competencia = txtCodigoMedioFondo.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregarSerie1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            PlanillaSerieUnicaMedioFondo.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaSerieUnicaMedioFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            Planilla2SeriesMedioFondo.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesMedioFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            Planilla2SeriesMedioFondo.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesMedioFondo.dgvSerie2.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            Planillade3SeriesdeMedioFondo.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeMedioFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            Planillade3SeriesdeMedioFondo.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeMedioFondo.dgvSerie2.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar3_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar3.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
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
            Planillade3SeriesdeMedioFondo.dgvSerie3.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaMedioFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaMedioFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeMedioFondo.dgvSerie3.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If GroupBox2.Enabled = True Then
            txtEstado.Text = "En Curso"
            PlanillaSerieUnicaMedioFondo.txtCodigoMedioFondo.Text = Me.txtCodigoMedioFondo.Text
            PlanillaSerieUnicaMedioFondo.txtNombre.Text = Me.txtNombre.Text
            PlanillaSerieUnicaMedioFondo.txtLugar.Text = Me.txtLugar.Text
            PlanillaSerieUnicaMedioFondo.cboProvincia.Text = Me.cboProvincia.Text
            PlanillaSerieUnicaMedioFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            PlanillaSerieUnicaMedioFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            PlanillaSerieUnicaMedioFondo.txtHora.Text = Me.txtHora.Text
            PlanillaSerieUnicaMedioFondo.txtEstado.Text = Me.txtEstado.Text
            PlanillaSerieUnicaMedioFondo.cboJuez1.Text = Me.cboJuez1.Text
            PlanillaSerieUnicaMedioFondo.cboJuez2.Text = Me.cboJuez2.Text
            PlanillaSerieUnicaMedioFondo.cboJuez3.Text = Me.cboJuez3.Text
            PlanillaSerieUnicaMedioFondo.cboUsuario.Text = Me.cboUsuario.Text
            PlanillaSerieUnicaMedioFondo.cboPrueba.Text = Me.cboPrueba.Text
            PlanillaSerieUnicaMedioFondo.cboSexo.Text = Me.cboSexo.Text
            PlanillaSerieUnicaMedioFondo.cboCategoria.Text = Me.cboCategoria.Text

            PlanillaSerieUnicaMedioFondo.Show()
        End If
        If GroupBox3.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planilla2SeriesMedioFondo.txtCodigoMedioFondo.Text = Me.txtCodigoMedioFondo.Text
            Planilla2SeriesMedioFondo.txtNombre.Text = Me.txtNombre.Text
            Planilla2SeriesMedioFondo.txtLugar.Text = Me.txtLugar.Text
            Planilla2SeriesMedioFondo.cboProvincia.Text = Me.cboProvincia.Text
            Planilla2SeriesMedioFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            Planilla2SeriesMedioFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planilla2SeriesMedioFondo.txtHora.Text = Me.txtHora.Text
            Planilla2SeriesMedioFondo.txtEstado.Text = Me.txtEstado.Text
            Planilla2SeriesMedioFondo.cboJuez1.Text = Me.cboJuez1.Text
            Planilla2SeriesMedioFondo.cboJuez2.Text = Me.cboJuez2.Text
            Planilla2SeriesMedioFondo.cboJuez3.Text = Me.cboJuez3.Text
            Planilla2SeriesMedioFondo.cboUsuario.Text = Me.cboUsuario.Text
            Planilla2SeriesMedioFondo.cboPrueba.Text = Me.cboPrueba.Text
            Planilla2SeriesMedioFondo.cboSexo.Text = Me.cboSexo.Text
            PlanillaSerieUnicaMedioFondo.cboCategoria.Text = Me.cboCategoria.Text
            Planilla2SeriesMedioFondo.Show()
        End If
        If GroupBox4.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planillade3SeriesdeMedioFondo.txtCodigoMedioFondo.Text = Me.txtCodigoMedioFondo.Text
            Planillade3SeriesdeMedioFondo.txtNombre.Text = Me.txtNombre.Text
            Planillade3SeriesdeMedioFondo.txtLugar.Text = Me.txtLugar.Text
            Planillade3SeriesdeMedioFondo.cboProvincia.Text = Me.cboProvincia.Text
            Planillade3SeriesdeMedioFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            Planillade3SeriesdeMedioFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planillade3SeriesdeMedioFondo.txtHora.Text = Me.txtHora.Text
            Planillade3SeriesdeMedioFondo.txtEstado.Text = Me.txtEstado.Text
            Planillade3SeriesdeMedioFondo.cboJuez1.Text = Me.cboJuez1.Text
            Planillade3SeriesdeMedioFondo.cboJuez2.Text = Me.cboJuez2.Text
            Planillade3SeriesdeMedioFondo.cboJuez3.Text = Me.cboJuez3.Text
            Planillade3SeriesdeMedioFondo.cboUsuario.Text = Me.cboUsuario.Text
            Planillade3SeriesdeMedioFondo.cboPrueba.Text = Me.cboPrueba.Text
            Planillade3SeriesdeMedioFondo.cboSexo.Text = Me.cboSexo.Text
            Planillade3SeriesdeMedioFondo.cboCategoria.Text = Me.cboCategoria.Text
            PlanillaSerieUnicaMedioFondo.cboCategoria.Text = Me.cboCategoria.Text
            Planillade3SeriesdeMedioFondo.Show()
        End If
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanilladeMedioFondo.dgvPlanillaMedioFondo.Rows.Add(0,
                                                  atleta.dorsal,
                                                  atleta.Apellido_atleta,
                                                  atleta.Nombre_atleta,
                                                  clubNombre,
                                                  "",
                                                  "",
                                                  "")
    End Sub
End Class