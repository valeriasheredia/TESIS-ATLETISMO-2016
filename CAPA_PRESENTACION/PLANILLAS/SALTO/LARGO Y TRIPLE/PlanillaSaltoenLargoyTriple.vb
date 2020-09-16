Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions

Public Class PLANILLASALTOENLARGOYTRIPLE
    Dim capanegocio As New CNCompetencias
    Public Property Id_Competencia As Int32
    'Dim capanegocio As New cnplanillasalto
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    'Shared Property PlanillaSaltoSeleccionada As New CE

    Private Sub PLANILLASALTOENLARGOYTRIPLE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnQuitarAtleta.Enabled = True
        btnImprimir.Enabled = True
        btnActualizar.Enabled = False
        btnGuardar.Enabled = False
        txtCodigoSalto.Enabled = False
        grbResultados.Enabled = False
        GroupBox1.Enabled = False
        Label1.Visible = False
        txtCodigoSalto.Visible = False
        GroupBox1.Enabled = False
        cboCategoria.SelectedIndex = 0
    End Sub

    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs)
        If Me.dgvSaltoTripleyLargo.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar las alturas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        btnAgregarAtleta.Enabled = False
        btnVálido.Enabled = True
        btnRehuso.Enabled = True
        btnNulo.Enabled = True
        btnImprimir.Enabled = True
        btnGuardar.Enabled = True
        btnQuitarAtleta.Enabled = False
        txtCodigoSalto.Enabled = True
        grbResultados.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Enabled = True
        End If
        If CheckBox1.Checked = False Then
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub btnAgregarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnQuitarAtleta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvSaltoTripleyLargo.Rows.RemoveAt(dgvSaltoTripleyLargo.CurrentRow.Index)
    End Sub

    Private Sub btnNulo_Click(sender As System.Object, e As System.EventArgs) Handles btnNulo.Click

        If Me.dgvSaltoTripleyLargo.SelectedRows Is Nothing OrElse Me.dgvSaltoTripleyLargo.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvSaltoTripleyLargo.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = "X "
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub

    Private Sub btnRehuso_Click(sender As System.Object, e As System.EventArgs) Handles btnRehuso.Click
        If Me.dgvSaltoTripleyLargo.SelectedRows Is Nothing OrElse Me.dgvSaltoTripleyLargo.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvSaltoTripleyLargo.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = "= "
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub

    Dim COLUMNA_PRIMER_SALTO As Integer = 5
    Dim COLUMNA_SEGUNDA_SALTO As Integer = 6
    Dim COLUMNA_TERCERA_SALTO As Integer = 7
    Dim COLUMNA_MEJOR_SALTO As Integer = 8

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As String)
        ' recorre las columnas 3 a 12 que corresponden a la cantidad de alturas
        For i As Integer = COLUMNA_PRIMER_SALTO To COLUMNA_TERCERA_SALTO
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía
                filaActual.Cells(i).Value = valorAponer
                CalcularMejor123(filaActual)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub CalcularMejor123(ByRef filaActual As DataGridViewRow)

        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_SALTO).Value) Then

            Dim salto As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            salto.Add(filaActual.Cells(COLUMNA_PRIMER_SALTO).Value)
            'salto.Add(filaActual.Cells(COLUMNA_SEGUNDO_LANZAMIENTO).Value)
            'salto.Add(filaActual.Cells(COLUMNA_TERCER_LANZAMIENTO).Value)

            filaActual.Cells(COLUMNA_MEJOR_SALTO).Value = salto.Max()

        End If
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        PlanillaSaltoenAltoyGarrocha.dgvAltoyGarrocha.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta
                                                          )
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvSaltoTripleyLargo.Rows
                objeto.id_competencia = txtCodigoSalto.Text
                objeto.id_atleta = row.Cells(7).Value
                objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class