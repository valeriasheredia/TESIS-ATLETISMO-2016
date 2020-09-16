Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions

Public Class PlanilladeSaltoenAltoyGarrocha
    Dim capanegocio As New CNCompetencias
    Public Property Id_Competencia As Int32
    Private Sub PLANILLASALTOENALTOYCONGARROCHA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'PrepararFormulario()

    End Sub

    Private Sub PrepararFormulario()
        btnAgregarAtleta.Enabled = True
        btnActualizar.Enabled = True
        btnQuitarAtleta.Enabled = True
        grbResultados.Enabled = False

    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        PlanilladeSaltoenAltoyGarrocha.dgvAltoyGarrocha.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta
                                                          )
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dgvAltoyGarrocha.Rows.RemoveAt(dgvAltoyGarrocha.CurrentRow.Index)
    End Sub

    Private Sub btnVálido_Click(sender As System.Object, e As System.EventArgs) Handles btnVálido.Click
        If Me.dgvAltoyGarrocha.SelectedRows Is Nothing OrElse Me.dgvAltoyGarrocha.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvAltoyGarrocha.SelectedRows(0)

        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = "O "
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub


    Dim COLUMNA_PRIMER_ALTURA As Integer = 3
    Dim COLUMNA_SEGUNDA_ALTURA As Integer = 4
    Dim COLUMNA_TERCERA_ALTURA As Integer = 5
    Dim COLUMNA_CUARTA_ALTURA As Integer = 6
    Dim COLUMNA_QUINTA_ALTURA As Integer = 7
    Dim COLUMNA_SEXTA_ALTURA As Integer = 8
    Dim COLUMNA_SEPTIMA_ALTURA As Integer = 9
    Dim COLUMNA_OCTAVA_ALTURA As Integer = 10
    Dim COLUMNA_NOVENA_ALTURA As Integer = 11
    Dim COLUMNA_DECIMA_ALTURA As Integer = 12
    'Const COLUMNA_CLASIFICACION As Integer = 13

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As String)
        ' recorre las columnas 3 a 12 que corresponden a la cantidad de alturas
        For i As Integer = COLUMNA_PRIMER_ALTURA To COLUMNA_DECIMA_ALTURA
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía
                filaActual.Cells(i).Value = valorAponer
                'CalcularMejor123(filaActual)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnNulo_Click(sender As System.Object, e As System.EventArgs) Handles btnNulo.Click
        If Me.dgvAltoyGarrocha.SelectedRows Is Nothing OrElse Me.dgvAltoyGarrocha.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvAltoyGarrocha.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = "X "
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub

    Private Sub btnRehuso_Click(sender As System.Object, e As System.EventArgs) Handles btnRehuso.Click
        If Me.dgvAltoyGarrocha.SelectedRows Is Nothing OrElse Me.dgvAltoyGarrocha.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo")
            Exit Sub
        End If
        Dim filaActual = Me.dgvAltoyGarrocha.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = "= "
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub

    Private Sub btnAltura_Click(sender As System.Object, e As System.EventArgs) Handles btnAltura.Click

        dgvAltoyGarrocha.Columns(2).HeaderText = txtAltura.Text

    End Sub
End Class