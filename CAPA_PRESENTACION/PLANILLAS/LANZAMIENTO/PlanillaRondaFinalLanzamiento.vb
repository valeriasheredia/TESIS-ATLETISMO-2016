Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaRondaFinalLanzamiento

    Dim capanegocio As New CNPlanillaLanzamiento
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMedioFondoSeleccionada As New CEPlanillaLanzamiento

    Private Sub Lanzamiento_SegundaFase__Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()

    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        TextBox4.Visible = False
        Label13.Visible = False
        cboUsuario.Visible = False
        cboLocalidad.Enabled = False
        cboProvincia.Enabled = False
        cboPrueba.Enabled = False
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
        cboJuez1.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False

    End Sub

    Private Sub btnVálido_Click(sender As System.Object, e As System.EventArgs) Handles btnVálido.Click
        'valida que el textbox no este vacio
        If Me.dgvLanzamientoRondaFinal.SelectedRows Is Nothing OrElse Me.dgvLanzamientoRondaFinal.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If

        'valida que no se ingresen otros caracteres ue no sean numericos
        If Not IsNumeric(txtDistancia.Text) Then
            MessageBox.Show("Debe ingresar una distancia válida")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamientoRondaFinal.SelectedRows(0)


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

    Private Sub btnNulo_Click(sender As System.Object, e As System.EventArgs) Handles btnNulo.Click
        If Me.dgvLanzamientoRondaFinal.SelectedRows Is Nothing OrElse Me.dgvLanzamientoRondaFinal.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamientoRondaFinal.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el lanzamiento de:" + filaActual.Cells(3).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, 0)
        End If
    End Sub

    Private Sub btnRehuso_Click(sender As System.Object, e As System.EventArgs) Handles btnRehuso.Click
        If Me.dgvLanzamientoRondaFinal.SelectedRows Is Nothing OrElse Me.dgvLanzamientoRondaFinal.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvLanzamientoRondaFinal.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el lanzamiento de:" + filaActual.Cells(3).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            CargarSiguienteCelda(filaActual, 0)
        End If
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        PlanillaFinalLanzamiento.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class