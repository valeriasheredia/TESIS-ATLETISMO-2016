Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD

Public Class LISTACOMPETENCIAS
    Dim capanegocio As New CNCompetencias
    Public Property TipoDeFormulario As TipoFormulario

    Private Sub LISTACOMPETENCIACALLE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    'Private Sub ListadoTodasCompetencias()
    '    Dim capanegocio As New CNCompetencias
    '    dgvCompetencias.AutoGenerateColumns = False
    '    dgvCompetencias.DataSource = capanegocio.ListadoTodasCompetencias.Tables("Todas las Competencias")
    '    lbltotalcompetencias.Text = capanegocio.ListadoTodasCompetencias.Tables("Todas las Competencias").Rows.Count
    'End Sub

    Sub ListadoTodasCompetencias()
        Dim ListadoTodasCompetencias As List(Of CECompetencias) = capanegocio.ListadoDeCompetenciasDTO()
        dgvCompetencias.DataSource = ListadoTodasCompetencias
        lbltotalcompetencias.Text = ListadoTodasCompetencias.Count
    End Sub

    Private Sub ListaCompetenciaCalle()
        Dim ListadoCompetenciaCalle As List(Of CECompetencias) = capanegocio.ListaCompetenciaCalleDTO()
        dgvCompetencias.DataSource = ListadoCompetenciaCalle
        lbltotalcompetencias.Text = ListadoCompetenciaCalle.Count

    End Sub

    Private Sub ListaCompetenciaPista()
        Dim ListadoCompetenciaPista As List(Of CECompetencias) = capanegocio.ListadoCompetenciaPistaDTO()
        dgvCompetencias.DataSource = ListadoCompetenciaPista
        lbltotalcompetencias.Text = ListadoCompetenciaPista.Count
    End Sub

    Private Sub txtNombreCompetenciaCalle_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCompetenciaCalle.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombreCompetenciaCalle_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreCompetenciaCalle.TextChanged
        filtrarNombreCompetenciaCalle(txtNombreCompetenciaCalle.Text, dgvCompetencias)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtTodas.CheckedChanged
        ListadoTodasCompetencias()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarCompetencia.Click

        Dim Competencia As CECompetencias = dgvCompetencias.CurrentRow.DataBoundItem
        NUEVACOMPETENCIA.CompetenciaSeleccionada = Competencia
        NUEVACOMPETENCIA.TipoDeFormulario = TipoFormulario.Modificacion
        NUEVACOMPETENCIA.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvCompetencias_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvCompetencias.DoubleClick
        Dim codigo = dgvCompetencias.SelectedRows(0).Cells("id_competencia").Value
        Dim result = MessageBox.Show("Desea cargar la competencia: " + dgvCompetencias.SelectedRows(0).Cells("Nombre_competencia").Value, "Confirmar acción", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If
        Dim f = New PLANILLACOMPETENCIACALLE(codigo)
        f.Show()

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim r% = MessageBox.Show("Está seguro de eliminar la Competencia..?", "Mensaje",
MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If r = 6 Then
            capanegocio.eliminarCompetencia(Me.dgvCompetencias.Rows(Me.dgvCompetencias.CurrentRow.Index).Cells(0).Value)
            dgvCompetencias.Columns.Clear()
            ListaCompetenciaCalle()
        End If
    End Sub

    Private Sub PrepararFormulario()
        'If Me.dgvCompetencias.Rows.Count = 0 Then
        '    MessageBox.Show("Ingrese datos en el grid.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        If rbtTodas.Checked = True And rbtDisciplina.Checked = False And rbtDistancia.Checked = False Then
            ListadoTodasCompetencias()
            rbtTodas.Checked = True
       
        End If

        If rbtDistancia.Checked = True And rbtTodas.Checked = False And rbtDisciplina.Checked = False Then
            ListaCompetenciaCalle()
            rbtDistancia.Checked = True
        End If

        If rbtDisciplina.Checked = True And rbtTodas.Checked = False And rbtDistancia.Checked = False Then
            ListaCompetenciaPista()
            rbtDisciplina.Checked = True
        End If

        'Logica de los botones
        btnNuevaCompetencia.Enabled = False
        btnEditarCompetencia.Enabled = False
        btnEliminar.Enabled = False
        btnCerrar.Enabled = False
        btnImprimir.Enabled = False
        btnEditarListaAtletas.Enabled = False

        Select Case TipoDeFormulario

            Case TipoFormulario.Alta
                btnNuevaCompetencia.Enabled = False
                btnEditarListaAtletas.Enabled = True
                btnCerrar.Enabled = True
                btnEliminar.Enabled = True
                btnEditarCompetencia.Enabled = True

            Case TipoFormulario.Baja
                btnEliminar.Enabled = True

            Case TipoFormulario.Consulta
                btnCerrar.Enabled = True

                'AGREGAR A LA COMPETENCIA
                btnImprimir.Enabled = True
                ' btnAgregarACompetencia.Enabled = True
            Case TipoFormulario.Modificacion

             

        End Select

    End Sub

    Private Sub btnNuevaCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevaCompetencia.Click, btnEditarListaAtletas.Click
        NUEVACOMPETENCIA.TipoDeFormulario = TipoFormulario.Alta
        NUEVACOMPETENCIA.ShowDialog()
    End Sub

    'Private Sub UltimaCompetencia()
    '    Dim capanegocio As New CNCompetencias
    '    dgvCompetencias.DataSource = capanegocio.UltimaCompetencia.Tables("Ultima Competencia")
    'End Sub

    Private Sub rbtDistancia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtDistancia.CheckedChanged
        ListaCompetenciaCalle()
    End Sub

    Private Sub rbtDisciplina_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtDisciplina.CheckedChanged
        ListaCompetenciaPista()
    End Sub
End Class


