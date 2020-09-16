Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaFinalFondo

    Dim capanegocio As New CNPlanillaFondo
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaMedioFondoSeleccionada As New CEPlanillaFondo

    Private Sub PlanillaFinalFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label22.Visible = False
        txtcodigofondo.Visible = False
        cboUsuario.Visible = False
        cboLocalidad.Enabled = False
        cboProvincia.Enabled = False
        cboPrueba.Enabled = False
        cboUsuario.Visible = False
        dtpfechainicio.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
        Me.dgvPlanillaFinalFondo.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaFinalFondo.Columns("Id_Resultado_Parcial").Visible = False
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaFinalFondo.dgvPlanillaFinalFondo.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                              atleta.Nombre_atleta,
                                                          clubNombre,
                                                          "",
                                                          "")
    End Sub
End Class