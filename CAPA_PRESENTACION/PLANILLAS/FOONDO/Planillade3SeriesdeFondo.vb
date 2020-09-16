Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Planillade3SeriesdeFondo

    Public Property TipoDeFormulario As TipoFormulario
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Shared Property AtletaSeleccionado As New CEAtletas

    Private Sub chkEditar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEditar.CheckedChanged
        If chkEditar.Checked = True Then
            GroupBox4.Enabled = True
        Else
            If chkEditar.Checked = False Then
                GroupBox4.Enabled = False
            End If
        End If
    End Sub

    Private Sub Planillade3SeriesdeFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIraSerieFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnIraSerieFinal.Click
        PlanillaFinalFondo.txtcodigofondo.Text = Me.txtCodigoFondo.Text
        PlanillaFinalFondo.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalFondo.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalFondo.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalFondo.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalFondo.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalFondo.txtHora.Text = Me.txtHora.Text
        PlanillaFinalFondo.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalFondo.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalFondo.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalFondo.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalFondo.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalFondo.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalFondo.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalFondo.Show()


    End Sub
End Class