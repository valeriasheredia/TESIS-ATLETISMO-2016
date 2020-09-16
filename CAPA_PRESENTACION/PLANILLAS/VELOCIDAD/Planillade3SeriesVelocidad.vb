Public Class Planillade3SeriesVelocidad

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
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
End Class