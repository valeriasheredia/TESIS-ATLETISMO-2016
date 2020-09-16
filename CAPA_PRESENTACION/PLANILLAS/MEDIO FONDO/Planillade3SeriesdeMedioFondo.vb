Public Class Planillade3SeriesdeMedioFondo

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnIraSerieFinal.Click
        PlanillaSerieFinalMedioFondo.txtCodigoMedioFondo.Text = Me.txtCodigoMedioFondo.Text
        PlanillaSerieFinalMedioFondo.txtNombre.Text = Me.txtNombre.Text
        PlanillaSerieFinalMedioFondo.txtLugar.Text = Me.txtLugar.Text
        PlanillaSerieFinalMedioFondo.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaSerieFinalMedioFondo.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaSerieFinalMedioFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaSerieFinalMedioFondo.txtHora.Text = Me.txtHora.Text
        PlanillaSerieFinalMedioFondo.txtEstado.Text = Me.txtEstado.Text
        PlanillaSerieFinalMedioFondo.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaSerieFinalMedioFondo.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaSerieFinalMedioFondo.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaSerieFinalMedioFondo.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaSerieFinalMedioFondo.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaSerieFinalMedioFondo.cboSexo.Text = Me.cboSexo.Text
        PlanillaSerieFinalMedioFondo.Show()

    End Sub
End Class