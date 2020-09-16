Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class IngresodeTiemposMaraton
    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaMaraton
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaCrossCountrySeleccionada As New CEPlanillaMaraton

    Private Sub IngresodeTiemposMaraton_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()

    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        IngresodeTiemposMaraton.dgvTiempos.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                          "",
                                                          "",
                                                          "",
                                                          "")
    End Sub

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click
        If txtTiempo.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo")
            txtTiempo.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempo.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempo.Focus()
            Exit Sub
        End If
        Dim filaActual = Me.dgvTiempos.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = txtTiempo.Text
            txtTiempo.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
    End Sub

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)

        ' recorre las columnas 4 a 6 que corresponden a los primeros tres lanzamientos
        For i As Integer = COLUMNA_PRIMER_TIEMPO To COLUMNA_TERCER_TIEMPO

            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                Exit Sub
            End If
        Next
        CalcularMejor123(filaActual)
    End Sub

    Const COLUMNA_PRIMER_TIEMPO As Integer = 2
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 3
    Const COLUMNA_TERCER_TIEMPO As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO As Integer = 5

    Private Sub CalcularMejor123(ByRef filaActual As DataGridViewRow)

        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then

            Dim tiempocross As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            tiempocross.Add(filaActual.Cells(COLUMNA_PRIMER_TIEMPO).Value)
            tiempocross.Add(filaActual.Cells(COLUMNA_SEGUNDO_TIEMPO).Value)
            tiempocross.Add(filaActual.Cells(COLUMNA_TERCER_TIEMPO).Value)

            filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = tiempocross.Max()

        End If
    End Sub

    Sub PrepararFormulario()
        Label3.Visible = False
        Label13.Visible = False
        txtCodigoPlanillaMaraton.Visible = False
        cboUsuario.Visible = False
        btnActualizar.Enabled = False
        btnInformeFinal.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        dtpfechainicio.Enabled = False
        Me.dgvTiempos.Columns("Id_Atleta").Visible = False
        Me.dgvTiempos.Columns("Id_Resultado_Parcial").Visible = False
       
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        btnInformeFinal.Enabled = True
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        txtEstado.Text = "Finalizada"
        PlanillaFinalMaraton.txtCodigoPlanillaMaraton.Text = Me.txtCodigoPlanillaMaraton.Text
        PlanillaFinalMaraton.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalMaraton.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalMaraton.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalMaraton.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalMaraton.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalMaraton.txtHora.Text = Me.txtHora.Text
        PlanillaFinalMaraton.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalMaraton.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalMaraton.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalMaraton.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalMaraton.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalMaraton.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalMaraton.cboCategoria.Text = Me.cboCategoria.Text
        PlanillaFinalMaraton.Show()
    End Sub

    Private Sub ckbEditarTiempo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbEditarTiempo.CheckedChanged
        If ckbEditarTiempo.Checked = True Then
            GroupBox4.Enabled = True
        End If

        If ckbEditarTiempo.Checked = False Then
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub txtEstado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEstado.TextChanged

    End Sub
End Class