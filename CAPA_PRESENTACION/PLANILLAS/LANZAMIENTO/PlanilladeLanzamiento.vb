Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanilladeLanzamiento
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property CompetenciaSeleccionada As New CECompetencias

    'AGREGA ATLETA A LA COMPETENCIA
    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    'QUITA ATLETA DE LA COMPETENCIA
    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        If Me.dgvLanzamientoClasificacion.Rows.Count = 0 Then
            MessageBox.Show("No hay atletas para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dgvLanzamientoClasificacion.Rows.RemoveAt(dgvLanzamientoClasificacion.CurrentRow.Index)
        End If
    End Sub

    'CARGA LOS CAMPOS DEL DATAGRID QUE SIRVE PARA AGREGR ATLETAS A LA COMPETENCIA
    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanilladeLanzamiento.dgvLanzamientoClasificacion.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta, _
                                                          clubNombre,
                                                          Nothing,
                                                          Nothing,
                                                          Nothing,
                                                          Nothing)
    End Sub

    Private Sub PLANILLADELANZAMIENTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    ' LOGICA DE BOTONES Y LLENADO DE COMBOBOX
    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnImprimir.Enabled = False
        btnComenzar.Enabled = False
        btnGuardar.Enabled = False
        grbResultados.Enabled = False
        btnActualizar.Enabled = False
        btnCerrar.Enabled = False
        btnSiguienteRonda.Enabled = False
        GroupBox3.Enabled = False
        grbLanzamientosClasificacion.Enabled = False
        grbLanzamientoFinal.Enabled = False

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                btnAgregarAtleta.Enabled = True
                btnQuitarAtleta.Enabled = True
                btnComenzar.Enabled = True
                btnCerrar.Enabled = True

            Case TipoFormulario.ModificacionLanzamiento
                btnAgregarAtleta.Enabled = True
                btnQuitarAtleta.Enabled = True
                btnActualizar.Enabled = True
                btnCerrar.Enabled = True
        End Select

    End Sub
    ' BOTON VALIDO
    Private Sub btnVálido_Click(sender As System.Object, e As System.EventArgs) Handles btnVálido.Click

        'Me.dgvLanzamiento.Rows(0).Cells(4).Value = txtMetros.Text
        'txtMetros.Text = ""

        If Me.dgvLanzamientoClasificacion.SelectedRows Is Nothing OrElse Me.dgvLanzamientoClasificacion.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If

        If Not IsNumeric(txtDistancia.Text) Then
            MessageBox.Show("Debe ingresar una distancia")
            Exit Sub
        End If

        Dim filaActual = Me.dgvLanzamientoClasificacion.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el lanzamiento de: \n  " + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim distancia As Decimal = 0
            If Not Decimal.TryParse(txtDistancia.Text, distancia) Then
                MessageBox.Show("Ingrese una distancia correcta")
                Exit Sub
            End If
            'Dim result = String.Format("{0:N2} mts", distancia)
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCeldaClasificacion(filaActual, txtDistancia.Text)
        End If

    End Sub

    Const COLUMNA_PRIMER_LANZAMIENTO_CLASIFICACION As Integer = 3
    Const COLUMNA_SEGUNDO_LANZAMIENTO_CLASIFICACION As Integer = 4
    Const COLUMNA_TERCER_LANZAMIENTO_CLASIFICACION As Integer = 5
    Const COLUMNA_MEJOR_LANZAMIENTO_CLASIFICACION As Integer = 6

    ' VALIDA EL CONTENIDO DE LAS CELDAS VACIAS DE LA FILA SELECCIOADA Y AGREGA EL VALOR DEL TEXTBOX
    Private Sub CargarSiguienteCeldaClasificacion(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 4 a 6 que corresponden a los primeros tres lanzamientos
        For i As Integer = COLUMNA_PRIMER_LANZAMIENTO_CLASIFICACION To COLUMNA_TERCER_LANZAMIENTO_CLASIFICACION
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                CalcularMejorclasificacion(filaActual)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub CalcularMejorclasificacion(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO_CLASIFICACION).Value) Then
            Dim lanzamientos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            lanzamientos.Add(filaActual.Cells(COLUMNA_PRIMER_LANZAMIENTO_CLASIFICACION).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_SEGUNDO_LANZAMIENTO_CLASIFICACION).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_TERCER_LANZAMIENTO_CLASIFICACION).Value)
            filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO_CLASIFICACION).Value = lanzamientos.Max()
        End If
    End Sub

    Const COLUMNA_PRIMER_LANZAMIENTO_FINAL As Integer = 3
    Const COLUMNA_SEGUNDO_LANZAMIENTO_FINAL As Integer = 4
    Const COLUMNA_TERCER_LANZAMIENTO_FINAL As Integer = 5
    Const COLUMNA_MEJOR_LANZAMIENTO_FINAL As Integer = 6

    Private Sub CargarSiguienteCeldaFinal(ByRef filaActual As DataGridViewRow, valorAponer As Integer)

        ' recorre las columnas 4 a 6 que corresponden a los primeros tres lanzamientos
        For i As Integer = COLUMNA_PRIMER_LANZAMIENTO_FINAL To COLUMNA_TERCER_LANZAMIENTO_FINAL
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 9,10,11
                filaActual.Cells(i).Value = valorAponer
                CalcularMejorFinal(filaActual)
                Exit Sub
            End If
        Next
    End Sub
    ' CALCULA EL MEJOR DE LOS TRES PRIMEROS LANZAMIENTOS (AQUI ME DA ERROR CON EL TIPO DE DATO QUE INGRESO, POR ESO ESTAN COMENTADOS)
    'lanzamientos.Add(filaActual.Cells(COLUMNA_SEGUNDO_LANZAMIENTO).Value)
    'lanzamientos.Add(filaActual.Cells(COLUMNA_TERCER_LANZAMIENTO).Value)

    Private Sub CalcularMejorFinal(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO_FINAL).Value) Then
            Dim lanzamientos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            lanzamientos.Add(filaActual.Cells(COLUMNA_PRIMER_LANZAMIENTO_FINAL).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_SEGUNDO_LANZAMIENTO_FINAL).Value)
            lanzamientos.Add(filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO_FINAL).Value)
            filaActual.Cells(COLUMNA_MEJOR_LANZAMIENTO_FINAL).Value = lanzamientos.Max()
        End If
    End Sub

    ' BOTON NULO
    Private Sub btnNulo_Click(sender As System.Object, e As System.EventArgs) Handles btnNulo.Click
        If Me.dgvLanzamientoClasificacion.SelectedRows Is Nothing OrElse Me.dgvLanzamientoClasificacion.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamientoClasificacion.SelectedRows(0)
        If MessageBox.Show("Confirma el lanzamiento realizado por el atleta: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCeldaClasificacion(filaActual, 0)
        End If
    End Sub

    ' BOTON REHUSO
    Private Sub btnRehuso_Click(sender As System.Object, e As System.EventArgs) Handles btnRehuso.Click
        If Me.dgvLanzamientoClasificacion.SelectedRows Is Nothing OrElse Me.dgvLanzamientoClasificacion.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamientoClasificacion.SelectedRows(0)
        If MessageBox.Show("Confirma el lanzamiento realizado por el atleta: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCeldaClasificacion(filaActual, 0)
        End If
    End Sub

    'Private Sub dgvLanzamiento_SelectionChanged(sender As System.Object, e As System.EventArgs)
    '    If Me.dgvLanzamientoClasificacion.SelectedRows Is Nothing OrElse Me.dgvLanzamientoClasificacion.SelectedRows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    Dim filaActual = Me.dgvLanzamientoClasificacion.SelectedRows(0)
    '    If Not IsNumeric(filaActual.Cells(COLUMNA_SEXTO_LANZAMIENTO).Value) Then
    '        grbResultados.Enabled = True
    '    End If
    'End Sub
    ' FALTA COMPLETAR EL PROCEDIMIENTO QUE CALCULA EL MEJOR ORDEN
    Private Sub btnCalulcarMejorOrden_Click(sender As System.Object, e As System.EventArgs)
        If MessageBox.Show("Confirma Calcular mejor orden???", "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click

        If Me.dgvLanzamientoClasificacion.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar las Alturas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        grbResultados.Enabled = True
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnActualizar.Enabled = False
        grbLanzamientosClasificacion.Enabled = True

        Label8.Enabled = False
        Label9.Enabled = False
        Label12.Enabled = False
        txtPrimerLanzamiento.Enabled = False
        txtSegundoLanzamiento.Enabled = False
        txtTercerLanzamiento.Enabled = False
        btnAceptar3PrimerosLanzamientos.Enabled = False
        btnEditar3PrimerosLanzamientos.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnEditar3PrimerosLanzamientos_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar3PrimerosLanzamientos.Click
        Label8.Enabled = True
        Label9.Enabled = True
        Label12.Enabled = False
        txtPrimerLanzamiento.Enabled = True
        txtSegundoLanzamiento.Enabled = True
        txtTercerLanzamiento.Enabled = True
        btnAceptar3PrimerosLanzamientos.Enabled = True
        btnEditar3PrimerosLanzamientos.Enabled = True
    End Sub

    Private Sub btnEditar3UltimosLanzamientos_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar3UltimosLanzamientos.Click
        Label16.Enabled = True
        Label15.Enabled = True
        Label14.Enabled = False
        txtCuartoLanzamiento.Enabled = True
        txtQuintoLanzamiento.Enabled = True
        txtSextoLanzamiento.Enabled = True
        btnAceptar3UltimosLanzamientos.Enabled = True
        btnEditar3UltimosLanzamientos.Enabled = True
    End Sub
End Class
