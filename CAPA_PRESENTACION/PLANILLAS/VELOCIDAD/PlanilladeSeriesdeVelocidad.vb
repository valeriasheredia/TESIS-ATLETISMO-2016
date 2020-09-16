Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class PlanilladeSeriesdeVelocidad

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNCompetencias
    Shared Property CompetenciaSeleccionada As New CECompetencias

    Sub PrepararFormulario()
        Me.Text = "Planilla Final de Velocidad"
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    'VARIABLES DE LA SERIE 1
    Const COLUMNA_PRIMER_CRONOMETRO_SERIE1 As Integer = 2
    Const COLUMNA_SEGUNDO_CRONOMETRO_SERIE1 As Integer = 3
    Const COLUMNA_TERCER_CRONOMETRO_SERIE1 As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO_SERIE1 As Integer = 5

    'VALIDA SIGUIENTE CELDA DE LA SERIE 1
    Private Sub CargarSiguienteCeldaSerie1(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 2 a 4 que corresponden a los tres tiempos
        For i As Integer = COLUMNA_PRIMER_CRONOMETRO_SERIE1 To COLUMNA_TERCER_CRONOMETRO_SERIE1

            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 2,3,4
                filaActual.Cells(i).Value = valorAponer
                txtTiempoSerie1.Text = ""
                CalcularMejorTiempoSerie1(filaActual)
                Exit Sub
            End If
        Next
    End Sub

    'CARGA DE TIEMPOS EN LA SERIE 1
    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempoSerie1.Click
        If Me.dgvSerie1.SelectedRows Is Nothing OrElse Me.dgvSerie1.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerie1.Text) Then
            MessageBox.Show("Debe ingresar un numero")
            Exit Sub
        End If
        Dim filaActual = Me.dgvSerie1.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, txtTiempoSerie1.Text)
        End If
    End Sub

    'CALCULO DEL MEJOR TIEMPO DE LA SERIE 1
    Private Sub CalcularMejorTiempoSerie1(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE1).Value) Then
            Dim tiempos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            tiempos.Add(filaActual.Cells(COLUMNA_PRIMER_CRONOMETRO_SERIE1).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_SEGUNDO_CRONOMETRO_SERIE1).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_TERCER_CRONOMETRO_SERIE1).Value)
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE1).Value = tiempos.Max()
        End If
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    'VARIABLES DE LA SERIE 2
    Const COLUMNA_PRIMER_CRONOMETRO_SERIE2 As Integer = 2
    Const COLUMNA_SEGUNDO_CRONOMETRO_SERIE2 As Integer = 3
    Const COLUMNA_TERCER_CRONOMETRO_SERIE2 As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO_SERIE2 As Integer = 5

    'VALIDA SIGUIENTE CELDA DE LA SERIE 2
    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 2 a 4 que corresponden a los tres tiempos
        For i As Integer = COLUMNA_PRIMER_CRONOMETRO_SERIE2 To COLUMNA_TERCER_CRONOMETRO_SERIE2

            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 2,3,4
                filaActual.Cells(i).Value = valorAponer
                txtTiempoSerie1.Text = ""
                CalcularMejorTiempoSerie2(filaActual)
                Exit Sub
            End If
        Next
    End Sub
    'CARGA DE TIEMPOS EN LA SERIE 2
    Private Sub btnAgregarTiempoSerie2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempoSerie2.Click
        If Me.dgvSerie2.SelectedRows Is Nothing OrElse Me.dgvSerie2.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerie2.Text) Then
            MessageBox.Show("Debe ingresar un numero")
            Exit Sub
        End If
        Dim filaActual = Me.dgvSerie2.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, txtTiempoSerie2.Text)
        End If
    End Sub

    'CALCULO DEL MEJOR TIEMPO DE LA SERIE 2
    Private Sub CalcularMejorTiempoSerie2(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE2).Value) Then
            Dim tiempos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            tiempos.Add(filaActual.Cells(COLUMNA_PRIMER_CRONOMETRO_SERIE2).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_SEGUNDO_CRONOMETRO_SERIE2).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_TERCER_CRONOMETRO_SERIE2).Value)
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE1).Value = tiempos.Max()
        End If
    End Sub

    '------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------

    'VARIABLES DE LA SERIE 3
    Const COLUMNA_PRIMER_CRONOMETRO_SERIE3 As Integer = 2
    Const COLUMNA_SEGUNDO_CRONOMETRO_SERIE3 As Integer = 3
    Const COLUMNA_TERCER_CRONOMETRO_SERIE3 As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO_SERIE3 As Integer = 5

    'VALIDA SIGUIENTE CELDA DE LA SERIE 3
    Private Sub CargarSiguienteCeldaSerie3(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 2 a 4 que corresponden a los tres tiempos
        For i As Integer = COLUMNA_PRIMER_CRONOMETRO_SERIE3 To COLUMNA_TERCER_CRONOMETRO_SERIE3

            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 2,3,4
                filaActual.Cells(i).Value = valorAponer
                txtTiempoSerie1.Text = ""
                CalcularMejorTiempoSerie3(filaActual)
                Exit Sub
            End If
        Next
    End Sub

    'CALCULO DEL MEJOR TIEMPO DE LA SERIE 3
    Private Sub CalcularMejorTiempoSerie3(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE3).Value) Then
            Dim tiempos As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            tiempos.Add(filaActual.Cells(COLUMNA_PRIMER_CRONOMETRO_SERIE3).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_SEGUNDO_CRONOMETRO_SERIE3).Value)
            tiempos.Add(filaActual.Cells(COLUMNA_TERCER_CRONOMETRO_SERIE3).Value)
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO_SERIE1).Value = tiempos.Max()
        End If
    End Sub
    'CARGA DE TIEMPOS EN LA SERIE 3
    Private Sub btnAgregarTiempoSerie3_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempoSerie3.Click
        If Me.dgvSerie3.SelectedRows Is Nothing OrElse Me.dgvSerie3.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerie3.Text) Then
            MessageBox.Show("Debe ingresar un numero")
            Exit Sub
        End If
        Dim filaActual = Me.dgvSerie3.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, txtTiempoSerie3.Text)
        End If
    End Sub

    Private Sub PlanillaFinaldeVelocidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub
End Class