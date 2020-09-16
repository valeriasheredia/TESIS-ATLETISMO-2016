Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PlanillaFinalMedio_Fondo

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMedioFondo
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaFondoSeleccionada As New CEPlanillaMedioFondo

    Private Sub PlanillaFinalMedio_Fondo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaFinalMedio_Fondo.dgvPlanillaFinalMedioFondo.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                              atleta.Nombre_atleta,
                                                          clubNombre,
                                                          "",
                                                          "")
    End Sub

    Sub PrepararFormulario()

        Label1.Visible = False
        Label18.Visible = False
        txtCodigoMedioFondo.Visible = False
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
        Me.dgvPlanillaFinalMedioFondo.Columns("Id_Atleta").Visible = False
        Me.dgvPlanillaFinalMedioFondo.Columns("Id_Resultado_Parcial").Visible = False
    End Sub
End Class