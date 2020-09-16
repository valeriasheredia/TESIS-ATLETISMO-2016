Public Class Planillade2SeriesdeVelocidad

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs)
        SerieFinalVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoVelocidad.Text
        SerieFinalVelocidad.txtNombre.Text = Me.txtNombre.Text
        SerieFinalVelocidad.txtLugar.Text = Me.txtLugar.Text
        SerieFinalVelocidad.cboProvincia.Text = Me.cboProvincia.Text
        SerieFinalVelocidad.cboLocalidad.Text = Me.cboLocalidad.Text
        SerieFinalVelocidad.dtpfechainicio.Text = Me.dtpfechainicio.Text
        SerieFinalVelocidad.txtHora.Text = Me.txtHora.Text
        SerieFinalVelocidad.txtEstado.Text = Me.txtEstado.Text
        SerieFinalVelocidad.cboJuez1.Text = Me.cboJuez1.Text
        SerieFinalVelocidad.cboJuez2.Text = Me.cboJuez2.Text
        SerieFinalVelocidad.cboJuez3.Text = Me.cboJuez3.Text
        SerieFinalVelocidad.cboUsuario.Text = Me.cboUsuario.Text
        SerieFinalVelocidad.cboPrueba.Text = Me.cboPrueba.Text
        SerieFinalVelocidad.cboSexo.Text = Me.cboSexo.Text
        SerieFinalVelocidad.Show()


    End Sub

    Private Sub Planillade2SeriesdeVelocidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Label21.Visible = False
        Label23.Visible = False
        txtCodigoVelocidad.Visible = False
        cboUsuario.Visible = False
        btnAgregarSerie1.Enabled = True
        btnAgregarSerieFinal2.Enabled = False
        btnActualizar.Enabled = False

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
            Me.dgvSerie2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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
            Me.dgvSerie1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value)
            Me.dgvSerie2.Rows.Remove(row)
        Next

        Dim nuevo As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Me.dgvSerie2.Rows
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("DataGridViewCheckBoxColumn1"), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cellSelecion.Value) Then
                nuevo.Add(row)
            End If
        Next
        For Each row As DataGridViewRow In nuevo
            Me.dgvSerie1.Rows.Add(New Object() {row.Cells(1).Value, row.Cells(2).Value, row.Cells(4).Value})
        Next
    End Sub
End Class