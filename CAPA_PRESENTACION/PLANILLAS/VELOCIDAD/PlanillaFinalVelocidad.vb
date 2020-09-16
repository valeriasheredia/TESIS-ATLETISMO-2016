Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaFinalVelocidad

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMedioFondo
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaFondoSeleccionada As New CEPlanillaMedioFondo

    Private Sub PlanillaFinalMedioFondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaFinalVelocidad.dgvPlanillaVelocidad.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                              atleta.Nombre_atleta,
                                                          clubNombre,
                                                          "",
                                                          "")
    End Sub

    Sub PrepararFormulario()
        Label1.Visible = False
        Label19.Visible = False
        cboCategoria.Visible = False
        txtCodigoVelocidad.Visible = False
        dtpfechainicio.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
        Me.dgvPlanillaVelocidad.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaVelocidad.Columns("Id_Resultado_Parcial").Visible = False
    End Sub
End Class