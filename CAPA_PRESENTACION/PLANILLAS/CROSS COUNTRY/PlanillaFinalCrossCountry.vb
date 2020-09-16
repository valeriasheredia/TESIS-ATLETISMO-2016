Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class PlanillaFinalCrossCountry

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCalle
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario

    Private Sub PlanillaFinalCrossCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Sub PrepararFormulario()
        Label3.Visible = False
        Label13.Visible = False
        txtCodigoPlanillaFinalCrossCountry.Visible = False
        cboUsuario.Visible = False
        cboSexo.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        dtpfechainicio.Enabled = False
        cboCategoria.Enabled = False
        Me.dgvAtletasdeCrossCountry.Columns("Id_Atleta").Visible = False
        Me.dgvAtletasdeCrossCountry.Columns("Id_Resultado_Parcial").Visible = False
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim localidadNombre As String = cNegVarios.NombreLocalidadPorId(atleta.id_localidad)
        Dim sexoNombre As String = cNegVarios.NombreSexoPorId(atleta.id_sexo)
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaFinalCrossCountry.dgvAtletasdeCrossCountry.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta,
                                                          clubNombre)
    End Sub
End Class