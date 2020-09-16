Public Class ATLETAS_POR_COMPETENCIA

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreCompetencia.TextChanged
        filtrarNombreCompetenciaAtleta(txtNombreCompetencia.Text, dgvAtletasxCompetencia)
    End Sub
End Class