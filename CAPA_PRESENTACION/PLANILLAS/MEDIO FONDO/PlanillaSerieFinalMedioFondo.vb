Public Class PlanillaSerieFinalMedioFondo

    Private Sub PlanillaSerieFinalMedioFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()

    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label18.Visible = False
        txtCodigoMedioFondo.Visible = False
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
        cboPrueba.Enabled = False
        chkEditar.Checked = False
        Me.dgvSerie1.Columns("Id_Atleta").Visible = False
        Me.dgvSerie1.Columns("Id_Resultado_Parcial").Visible = False
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        PlanillaFinalMedio_Fondo.txtCodigoMedioFondo.Text = Me.txtCodigoMedioFondo.Text
        PlanillaFinalMedio_Fondo.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalMedio_Fondo.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalMedio_Fondo.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalMedio_Fondo.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalMedio_Fondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalMedio_Fondo.txtHora.Text = Me.txtHora.Text
        PlanillaFinalMedio_Fondo.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalMedio_Fondo.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalMedio_Fondo.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalMedio_Fondo.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalMedio_Fondo.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalMedio_Fondo.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalMedio_Fondo.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalMedio_Fondo.Show()

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

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click
        If txtTiempoFinalMedioFondo.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo")
            txtTiempoFinalMedioFondo.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoFinalMedioFondo.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempoFinalMedioFondo.Focus()
            Exit Sub
        End If
        'CONVERTIR UN ENTERO A DATE

        Dim filaActual = Me.dgvSerie1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de : \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempoFinalMedioFondo.Text
            valor = txtTiempoFinalMedioFondo.Text
            txtTiempoFinalMedioFondo.Clear()
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
End Class