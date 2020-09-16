Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports CAPA_NEGOCIO

Public Class LISTADOCLUBFEDERACION
    Dim capanegocio As New CNClubFederación
    Public Property TipoDeFormulario As TipoFormulario

    ''' SE EJECUTA AL CARGARSE EL FORMULARIO
    ''' PONER AQUI TODA LA LOGICA DE "RELLENO" DE CAMPOS
    ''' BOTONERÍA, ETC
    Private Sub PrepararFormulario()
        cargaclubes()

        'logica de botones
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnCerrar.Enabled = True

        Select Case TipoDeFormulario
            Case TipoFormulario.Modificacion
                btnModificar.Enabled = False
        End Select
    End Sub


    Private Sub NUEVOCLUBFEDERACION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Sub cargaclubes()
        Dim ListadoDeClubes As List(Of CEClubFederacion) = capanegocio.ListadoDeClubesDTO()

        dgvclubes.DataSource = ListadoDeClubes
        lbltotalclub.Text = ListadoDeClubes.Count
    End Sub

    Private Sub txtnombreclub_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombreclub.KeyPress
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

    Private Sub txtnombreclub_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombreclub.TextChanged
        filtrarnombreclub(txtnombreclub.Text, dgvclubes)
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim club As CEClubFederacion = dgvclubes.CurrentRow.DataBoundItem
        NUEVOCLUBFEDERACION.ClubSeleccionado = club
        NUEVOCLUBFEDERACION.TipoDeFormulario = TipoFormulario.Modificacion
        NUEVOCLUBFEDERACION.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim r% = MessageBox.Show("Está seguro de eliminar al Club/Federación..?", "Mensaje",
    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If r = 6 Then
            capanegocio.eliminarclub(Me.dgvclubes.Rows(Me.dgvclubes.CurrentRow.Index).Cells(0).Value)
            dgvclubes.Columns.Clear()
            cargaclubes()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class