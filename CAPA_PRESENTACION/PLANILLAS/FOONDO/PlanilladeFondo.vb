Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanilladeFondo

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCrossCountry
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaFondoSeleccionada As New CEPlanillaFondo

    Private Sub PlanilladeFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()

        Dim cantidad As DataGridView = CType(dgvPlanillaFondo, DataGridView)
        If cboPrueba.Text = "3000 metros" Or cboPrueba.Text = "5000 metros" Then
            If cantidad.Rows.Count >= 60 Then
                MessageBox.Show("Ha sido agregado el último atleta, no se permiten mas ingresos")
                btnAgregarAtleta.Enabled = False
                Return
            End If
        Else
            If cboPrueba.Text = "10000 metros" Then
                If cantidad.Rows.Count >= 72 Then
                    MessageBox.Show("Ha sido agregado el último atleta, no se permiten mas ingresos")
                    btnAgregarAtleta.Enabled = False
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvPlanillaFondo.Rows.RemoveAt(dgvPlanillaFondo.CurrentRow.Index)
    End Sub

    Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnImprimir.Enabled = False
        btnComenzar.Enabled = True
        btnCerrar.Enabled = True
        Label1.Visible = False
        txtcodigofondo.Visible = False
        btnActualizar.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        btnAceptar.Enabled = False
        Me.dgvPlanillaFondo.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaFondo.Columns("Id_Resultado_Parcial").Visible = False
        cboCategoria.SelectedIndex = 0
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        'Sexo()
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        Label22.Visible = False
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
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

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click


        If Me.dgvPlanillaFondo.Rows.Count = 0 Then
            MessageBox.Show("Ingrese a los atletas que participarán de la competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim dgv As DataGridView = CType(dgvPlanillaFondo, DataGridView)
        ' las series se arman a partir de los 20 atletas
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


        If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 2 Then
            GroupBox4.Enabled = False
            btnAceptar.Enabled = True
            GroupBox2.Enabled = True
            btnAgregaraSerie1.Enabled = True
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
            btnAceptar.Enabled = True
            GroupBox4.Enabled = True

        else
        If cboPrueba.Text = "10000 metros" Then
            If dgv.Rows.Count >= 1 And dgv.Rows.Count <= 24 Then

                btnAgregarSerie1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = False
                GroupBox4.Enabled = False

            ElseIf dgv.Rows.Count >= 25 And dgv.Rows.Count <= 48 Then

                GroupBox2.Enabled = False
                GroupBox4.Enabled = False
                btnAgregaraSerie1.Enabled = True
                btnAgregaraSerie2.Enabled = True
                GroupBox3.Enabled = True

            ElseIf dgv.Rows.Count >= 49 And dgv.Rows.Count <= 72 Then

                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
               
                btnAgregar1.Enabled = True
                btnAgregar2.Enabled = True
                btnAgregar3.Enabled = True
            End If
        End If
            End If
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanilladeFondo.dgvPlanillaFondo.Rows.Add(0,
                                                  atleta.dorsal,
                                                  atleta.Apellido_atleta,
                                                  atleta.Nombre_atleta,
                                                  clubNombre,
                                                  "",
                                                  "",
                                                  "")
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If Me.dgvPlanillaFondo.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvPlanillaFondo.Rows
                objeto.id_competencia = txtcodigofondo.Text
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
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            PlanillaSerieUnicaFondo.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaSerieUnicaFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        If GroupBox2.Enabled = True Then
            txtEstado.Text = "En Curso"
            PlanillaSerieUnicaFondo.txtCodigoFondo.Text = Me.txtcodigofondo.Text
            PlanillaSerieUnicaFondo.txtNombre.Text = Me.txtNombre.Text
            PlanillaSerieUnicaFondo.txtLugar.Text = Me.txtLugar.Text
            PlanillaSerieUnicaFondo.cboProvincia.Text = Me.cboProvincia.Text
            PlanillaSerieUnicaFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            PlanillaSerieUnicaFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            PlanillaSerieUnicaFondo.txtHora.Text = Me.txtHora.Text
            PlanillaSerieUnicaFondo.txtEstado.Text = Me.txtEstado.Text
            PlanillaSerieUnicaFondo.cboJuez1.Text = Me.cboJuez1.Text
            PlanillaSerieUnicaFondo.cboJuez2.Text = Me.cboJuez2.Text
            PlanillaSerieUnicaFondo.cboJuez3.Text = Me.cboJuez3.Text
            PlanillaSerieUnicaFondo.cboUsuario.Text = Me.cboUsuario.Text
            PlanillaSerieUnicaFondo.cboPrueba.Text = Me.cboPrueba.Text
            PlanillaSerieUnicaFondo.cboSexo.Text = Me.cboSexo.Text
            PlanillaSerieUnicaFondo.cboCategoria.Text = Me.cboCategoria.Text
            PlanillaSerieUnicaFondo.Show()
        End If
        If GroupBox3.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planilla2SeriesFondo.txtCodigoFondo.Text = Me.txtcodigofondo.Text
            Planilla2SeriesFondo.txtNombre.Text = Me.txtNombre.Text
            Planilla2SeriesFondo.txtLugar.Text = Me.txtLugar.Text
            Planilla2SeriesFondo.cboProvincia.Text = Me.cboProvincia.Text
            Planilla2SeriesFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            Planilla2SeriesFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planilla2SeriesFondo.txtHora.Text = Me.txtHora.Text
            Planilla2SeriesFondo.txtEstado.Text = Me.txtEstado.Text
            Planilla2SeriesFondo.cboJuez1.Text = Me.cboJuez1.Text
            Planilla2SeriesFondo.cboJuez2.Text = Me.cboJuez2.Text
            Planilla2SeriesFondo.cboJuez3.Text = Me.cboJuez3.Text
            Planilla2SeriesFondo.cboUsuario.Text = Me.cboUsuario.Text
            Planilla2SeriesFondo.cboPrueba.Text = Me.cboPrueba.Text
            Planilla2SeriesFondo.cboSexo.Text = Me.cboSexo.Text
            Planilla2SeriesFondo.cboCategoria.Text = Me.cboCategoria.Text
            Planilla2SeriesFondo.Show()
        End If
        If GroupBox4.Enabled = True Then
            txtEstado.Text = "En Curso"
            Planillade3SeriesdeFondo.txtCodigoFondo.Text = Me.txtcodigofondo.Text
            Planillade3SeriesdeFondo.txtNombre.Text = Me.txtNombre.Text
            Planillade3SeriesdeFondo.txtLugar.Text = Me.txtLugar.Text
            Planillade3SeriesdeFondo.cboProvincia.Text = Me.cboProvincia.Text
            Planillade3SeriesdeFondo.cboLocalidad.Text = Me.cboLocalidad.Text
            Planillade3SeriesdeFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
            Planillade3SeriesdeFondo.txtHora.Text = Me.txtHora.Text
            Planillade3SeriesdeFondo.txtEstado.Text = Me.txtEstado.Text
            Planillade3SeriesdeFondo.cboJuez1.Text = Me.cboJuez1.Text
            Planillade3SeriesdeFondo.cboJuez2.Text = Me.cboJuez2.Text
            Planillade3SeriesdeFondo.cboJuez3.Text = Me.cboJuez3.Text
            Planillade3SeriesdeFondo.cboUsuario.Text = Me.cboUsuario.Text
            Planillade3SeriesdeFondo.cboPrueba.Text = Me.cboPrueba.Text
            Planillade3SeriesdeFondo.cboSexo.Text = Me.cboSexo.Text
            Planillade3SeriesdeFondo.cboCategoria.Text = Me.cboCategoria.Text
            Planillade3SeriesdeFondo.Show()
        End If
    End Sub

    Private Sub btnAgregaraSerie1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            Planilla2SeriesFondo.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregaraSerie2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregaraSerie2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            Planilla2SeriesFondo.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planilla2SeriesFondo.dgvSerie2.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            Planillade3SeriesdeFondo.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            Planillade3SeriesdeFondo.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeFondo.dgvSerie2.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregar3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar3.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
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
            Planillade3SeriesdeFondo.dgvSerie3.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            dgvPlanillaFondo.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvPlanillaFondo.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Planillade3SeriesdeFondo.dgvSerie3.Rows.Add(New Object() {row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next
    End Sub
End Class