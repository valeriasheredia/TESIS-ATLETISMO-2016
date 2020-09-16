Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PLANILLADELANZAMIENTOS

    Dim capanegocio As New CNPlanillaLanzamiento
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMedioFondoSeleccionada As New CEPlanillaLanzamiento

    'CARGA LOS CAMPOS DEL DATAGRID QUE SIRVE PARA AGREGAR ATLETAS A LA COMPETENCIA
    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PLANILLADELANZAMIENTOS.dgvLanzamiento.Rows.Add(0,
                                                       atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta,
                                                          clubNombre,
                                                          "",
                                                          "",
                                                          "",
                                                          "",
                                                          "",
                                                          atleta.id_atleta
                                                          )
    End Sub

    Private Sub PLANILLADELANZAMIENTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    ' LOGICA DE BOTONES Y LLENADO DE COMBOBOX
    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnImprimir.Enabled = False
        btnComenzar.Enabled = True
        btnGuardar.Enabled = True
        grbResultados.Enabled = False
        Label1.Visible = False
        txtCodigoLanzamiento.Visible = False
        btnActualizar.Enabled = False
        btnSiguienteRonda.Enabled = False
        cboLocalidad.Enabled = False
        cboProvincia.Enabled = False
        cboPrueba.Enabled = False
        cboSexo.SelectedIndex = 0
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
        Me.dgvLanzamiento.Columns("Id_Atleta").Visible = False
        Me.dgvLanzamiento.Columns("Id_Resultado_Parcial").Visible = False
        cboCategoria.SelectedIndex = 0
        Label13.Visible = False
        txtCodigoLanzamiento.Visible = False
        juezprincipal1()
    End Sub
    ' BOTON VALIDO
    Private Sub btnVálido_Click(sender As System.Object, e As System.EventArgs) Handles btnVálido.Click

        'valida que el textbox no este vacio
        If Me.dgvLanzamiento.SelectedRows Is Nothing OrElse Me.dgvLanzamiento.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If

        'valida que no se ingresen otros caracteres ue no sean numericos
        If Not IsNumeric(txtDistancia.Text) Then
            MessageBox.Show("Debe ingresar una distancia válida")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamiento.SelectedRows(0)


        If MessageBox.Show("Confirma ingresar el lanzamiento de:" + filaActual.Cells(3).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim distancia As Decimal = 0

            If Not Decimal.TryParse(txtDistancia.Text, distancia) Then
                MessageBox.Show("Ingrese una distancia correcta")
                Exit Sub
            End If
            Dim result = String.Format("{0:N2} mts", distancia)

            CargarSiguienteCelda(filaActual, txtDistancia.Text)

            txtDistancia.Clear()

        End If
    End Sub

    Const COLUMNA_PRIMER_LANZAMIENTO As Integer = 5
    Const COLUMNA_SEGUNDO_LANZAMIENTO As Integer = 6
    Const COLUMNA_TERCER_LANZAMIENTO As Integer = 7
    Const COLUMNA_MEJOR_LANZAMIENTO As Integer = 8
    Const COLUMNA_ORDEN As Integer = 9

    ' VALIDA EL CONTENIDO DE LAS CELDAS VACIAS DE LA FILA SELECCIONADA Y AGREGA EL VALOR DEL TEXTBOX
    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)

        ' recorre las columnas 4 a 6 que corresponden a los primeros tres lanzamientos
        For i As Integer = COLUMNA_PRIMER_LANZAMIENTO To COLUMNA_TERCER_LANZAMIENTO
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                Exit Sub
            End If
        Next
        CalcularMejor123(filaActual)
    End Sub
    ' CALCULA EL MEJOR DE LOS TRES PRIMEROS LANZAMIENTOS 

    Private Sub CalcularMejor123(ByRef filaActual As DataGridViewRow)

        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO).Value) Then

            Dim lanzamientos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            lanzamientos.Add(filaActual.Cells(COLUMNA_PRIMER_LANZAMIENTO).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_SEGUNDO_LANZAMIENTO).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_TERCER_LANZAMIENTO).Value)
            filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO).Value = lanzamientos.Max()
        End If
    End Sub

    ' BOTON NULO
    Private Sub btnNulo_Click(sender As System.Object, e As System.EventArgs) Handles btnNulo.Click

        If Me.dgvLanzamiento.SelectedRows Is Nothing OrElse Me.dgvLanzamiento.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamiento.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el lanzamiento de:" + filaActual.Cells(3).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, 0)
        End If

    End Sub

    ' BOTON REHUSO
    Private Sub btnRehuso_Click(sender As System.Object, e As System.EventArgs) Handles btnRehuso.Click

        If Me.dgvLanzamiento.SelectedRows Is Nothing OrElse Me.dgvLanzamiento.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamiento.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el lanzamiento de:" + filaActual.Cells(3).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, 0)
        End If
    End Sub

    'Private Sub dgvLanzamiento_SelectionChanged(sender As System.Object, e As System.EventArgs)
    '    If Me.dgvLanzamiento.SelectedRows Is Nothing OrElse Me.dgvLanzamiento.SelectedRows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    Dim filaActual = Me.dgvLanzamiento.SelectedRows(0)
    '    If Not IsNumeric(filaActual.Cells(COLUMNA_SEXTO_LANZAMIENTO).Value) Then
    '        grbResultados.Enabled = True
    '    End If
    'End Sub
    ' FALTA COMPLETAR EL PROCEDIMIENTO QUE CALCULA EL MEJOR ORDEN
    'Private Sub btnCalulcarMejorOrden_Click(sender As System.Object, e As System.EventArgs)
    '    If MessageBox.Show("Confirma Calcular mejor orden???", "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub btnAgregarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnQuitarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        'QUITA ATLETA DE LA COMPETENCIA
        dgvLanzamiento.Rows.RemoveAt(dgvLanzamiento.CurrentRow.Index)
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        ' valida que haya registros para poder guardarlos
        If Me.dgvLanzamiento.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvLanzamiento.Rows
                objeto.id_competencia = txtCodigoLanzamiento.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
            btnSiguienteRonda.Enabled = True
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click

        If Me.dgvLanzamiento.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar sus Lanzamientos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If
        If cboJuez1.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez1.Focus()
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
        grbResultados.Enabled = True

        btnImprimir.Enabled = True
        Me.dgvLanzamiento.Columns("Id_Atleta").Visible = False
        Me.dgvLanzamiento.Columns("Id_Resultado_Parcial").Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Sub juezprincipal1()
        cboJuez1.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez1.DisplayMember = "Apellido_Juez"
        cboJuez1.ValueMember = "Id_Juez"
        cboJuez1.SelectedIndex = 8
    End Sub

    Private Sub btnAgregarSerieFinal1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerieFinal1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvLanzamiento.Rows
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
            PlanillaRondaFinalLanzamiento.dgvLanzamientoRondaFinal.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
            dgvLanzamiento.Rows.Remove(row)
        Next
        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvLanzamiento.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaRondaFinalLanzamiento.dgvLanzamientoRondaFinal.Rows.Add(New Object() {row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value})
        Next
        btnSiguienteRonda.Enabled = True
    End Sub

    Private Sub btnSiguienteRonda_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguienteRonda.Click
        PlanillaRondaFinalLanzamiento.Show()
    End Sub

End Class
