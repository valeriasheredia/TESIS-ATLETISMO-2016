Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaSerieFinalFondo
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Shared Property AtletaSeleccionado As New CEAtletas

    Private Sub PlanillaSerieFinalFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click

        txtEstado.Text = "Finalizada"
        PlanillaFinalFondo.txtcodigofondo.Text = Me.txtcodigofondo.Text
        PlanillaFinalFondo.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalFondo.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalFondo.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalFondo.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalFondo.txtHora.Text = Me.txtHora.Text
        PlanillaFinalFondo.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalFondo.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalFondo.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalFondo.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalFondo.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalFondo.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalFondo.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalFondo.cboCategoria.Text = Me.cboCategoria.Text
        PlanillaFinalFondo.Show()

    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label22.Visible = False
        cboUsuario.Visible = False
        txtcodigofondo.Visible = False
        chkEditar.Checked = False
    End Sub

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click
        If txtTiempoSerieFinal.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo")
            txtTiempoSerieFinal.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerieFinal.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempoSerieFinal.Focus()
            Exit Sub
        End If
        'CONVERTIR UN ENTERO A DATE

        Dim filaActual = Me.dgvSerie1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de : \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempoSerieFinal.Text
            valor = txtTiempoSerieFinal.Text
            txtTiempoSerieFinal.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
        btnInformeFinal.Enabled = True
    End Sub

    Const COLUMNA_PRIMER_TIEMPO As Integer = 2
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 3
    Const COLUMNA_TERCER_TIEMPO As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO As Integer = 5

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 4 a 6 que corresponden a los primeros tres tiempos
        For i As Integer = COLUMNA_PRIMER_TIEMPO To COLUMNA_TERCER_TIEMPO
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                Exit Sub
            End If
        Next
        CalcularMejorTiempo(filaActual)
    End Sub

    Private Sub CalcularMejorTiempo(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then
            Dim Tiempos As List(Of Integer) = New List(Of Integer) ' esto es LINQ

            'PREGUNTAR SI LA CELDA DE TIEMPO ESTA VACIA, SI ESTA VACIA INGRESAR UN TIEMPO, SINO SALIR

            'If String.IsNullOrEmpty(filaActual.Cells(2).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_PRIMER_TIEMPO).Value)

            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If

            'If String.IsNullOrEmpty(filaActual.Cells(3).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_SEGUNDO_TIEMPO).Value)
            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If

            'If String.IsNullOrEmpty(filaActual.Cells(4).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_TERCER_TIEMPO).Value)
            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = Tiempos.Max()

        End If
    End Sub

    Private Sub chkEditar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEditar.CheckedChanged
        If chkEditar.Checked = True Then
            GroupBox4.Enabled = True
        Else
            If chkEditar.Checked = False Then
                GroupBox4.Enabled = False
            End If
        End If
    End Sub
End Class