Public Class Planillade3SeriedeObstaculos

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnIraSerieFinal.Click
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
End Class