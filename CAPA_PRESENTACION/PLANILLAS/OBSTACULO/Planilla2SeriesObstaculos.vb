Public Class Planilla2SeriesObstaculos

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs)
        PlanillaSerieFinalObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
        PlanillaSerieFinalObstaculos.txtNombre.Text = Me.txtNombre.Text
        PlanillaSerieFinalObstaculos.txtLugar.Text = Me.txtLugar.Text
        PlanillaSerieFinalObstaculos.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaSerieFinalObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaSerieFinalObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaSerieFinalObstaculos.txtHora.Text = Me.txtHora.Text
        PlanillaSerieFinalObstaculos.txtEstado.Text = Me.txtEstado.Text
        PlanillaSerieFinalObstaculos.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaSerieFinalObstaculos.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaSerieFinalObstaculos.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaSerieFinalObstaculos.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaSerieFinalObstaculos.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaSerieFinalObstaculos.cboSexo.Text = Me.cboSexo.Text
        PlanillaSerieFinalObstaculos.Show()

    End Sub

    Private Sub Planilla2SeriesObstaculos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        txtCodigoObstaculos.Visible = False
        cboUsuario.Visible = False
        GroupBox4.Enabled = False
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
            PlanillaSerieFinalObstaculos.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
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
            PlanillaSerieFinalObstaculos.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
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
            PlanillaSerieFinalObstaculos.dgvSerie1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
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
            PlanillaSerieFinalObstaculos.dgvSerie1.Rows.Add(New Object() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value})
        Next
    End Sub

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
End Class