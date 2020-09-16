Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Planilla2SeriesMedioFondo

    Public Property TipoDeFormulario As TipoFormulario
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Shared Property AtletaSeleccionado As New CEAtletas

    Private Sub btnAgregarSerie1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In Me.dgvSerie1.Rows
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
            Me.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
            Me.dgvSerie1.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Me.dgvSerie1.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Me.dgvSerie2.Rows.Add(New Object() {row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnQuitarSerie1_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarSerie1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In Me.dgvSerie2.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("DataGridViewCheckBoxColumn1"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            Me.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
            Me.dgvSerie2.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Me.dgvSerie2.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Me.dgvSerie1.Rows.Add(New Object() {row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value})
        Next
    End Sub

    Private Sub btnAgregarSerieFinal1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerieFinal1.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvSerie1.Rows
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
            PlanillaSerieFinalMedioFondo.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value)
            dgvSerie1.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvSerie1.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaSerieFinalMedioFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
    End Sub

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click
        If txtTiempoSerie1.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo")
            txtTiempoSerie1.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerie1.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempoSerie1.Focus()
            Exit Sub
        End If
        'CONVERTIR UN ENTERO A DATE

        Dim filaActual = Me.dgvSerie1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempoSerie1.Text
            valor = txtTiempoSerie1.Text
            txtTiempoSerie1.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
        btnAgregarSerieFinal1.Enabled = True
    End Sub

    Const COLUMNA_PRIMER_TIEMPO As Integer = 4
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 5
    Const COLUMNA_TERCER_TIEMPO As Integer = 6
    Const COLUMNA_MEJOR_TIEMPO As Integer = 7

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

    Private Sub btnAgregarSerieFinal2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarSerieFinal2.Click
        'Se define una lista temporal de registro seleccionados
        Dim FilasSeleccionadas As New List(Of DataGridViewRow)()
        'Se recorre cada registro del grid de origen
        For Each row As DataGridViewRow In dgvSerie2.Rows
            'Se recupera el campo que representa el checkbox,
            'se valida que esté seleccionado y agregándolo a la lista temporal
            Dim cellSelecion As DataGridViewCheckBoxCell = _
            TryCast(row.Cells("DataGridViewCheckBoxColumn1"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                FilasSeleccionadas.Add(row)
            End If
        Next
        'Se agrega el ítem seleccionado al grid de destino
        'eliminando la fila del grid original
        For Each row As DataGridViewRow In FilasSeleccionadas
            PlanillaSerieFinalMedioFondo.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value)
            dgvSerie2.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In dgvSerie2.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("DataGridViewCheckBoxColumn1"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            PlanillaSerieFinalMedioFondo.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtTiempoSerie2.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo")
            txtTiempoSerie2.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempoSerie2.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempoSerie2.Focus()
            Exit Sub
        End If
        'CONVERTIR UN ENTERO A DATE

        Dim filaActual = Me.dgvSerie2.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempoSerie2.Text
            valor = txtTiempoSerie2.Text
            txtTiempoSerie2.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
        btnAgregarSerieFinal2.Enabled = True
    End Sub

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnIraSerieFinal.Click

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
        PlanillaSerieFinalMedioFondo.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaSerieFinalMedioFondo.cboSexo.Text = Me.cboSexo.Text
        PlanillaSerieFinalMedioFondo.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        btnIraSerieFinal.Enabled = True
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

    Private Sub Planilla2SeriesMedioFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()

    End Sub

    Sub PrepararFormulario()
        cboLocalidad.Enabled = False
        cboProvincia.Enabled = False
        cboPrueba.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        dtpfechainicio.Enabled = False
        Label1.Visible = False
        Label22.Visible = False
        txtCodigoMedioFondo.Visible = False
        cboUsuario.Visible = False
        GroupBox4.Enabled = False
        btnAgregarSerieFinal1.Enabled = False
        btnAgregarSerieFinal2.Enabled = False
        btnActualizar.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class