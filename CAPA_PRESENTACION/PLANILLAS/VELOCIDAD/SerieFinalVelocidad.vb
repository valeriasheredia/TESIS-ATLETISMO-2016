Public Class SerieFinalVelocidad

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        PlanillaFinalVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoVelocidad.Text
        PlanillaFinalVelocidad.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalVelocidad.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalVelocidad.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalVelocidad.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalVelocidad.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalVelocidad.txtHora.Text = Me.txtHora.Text
        PlanillaFinalVelocidad.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalVelocidad.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalVelocidad.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalVelocidad.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalVelocidad.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalVelocidad.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalVelocidad.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalVelocidad.Show()

    End Sub
End Class