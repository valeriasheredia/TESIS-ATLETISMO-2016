Public Class PlanillaSerieFinalObstaculos

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        PlanillaFinalObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
        PlanillaFinalObstaculos.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalObstaculos.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalObstaculos.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalObstaculos.txtHora.Text = Me.txtHora.Text
        PlanillaFinalObstaculos.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalObstaculos.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalObstaculos.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalObstaculos.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalObstaculos.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalObstaculos.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalObstaculos.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalObstaculos.Show()
    End Sub
End Class