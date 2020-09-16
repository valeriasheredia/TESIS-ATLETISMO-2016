Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class IngresodeTiemposCrossCountry
    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCrossCountry
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaCrossCountrySeleccionada As New CEPlanillaCrossCountry

    Private Sub IngresodeTiemposCrossCountry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        IngresodeTiemposCrossCountry.dgvTiempos.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                          "",
                                                          "",
                                                          "",
                                                          "")
    End Sub

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click
        If txtTiempo.Text = "" Then
            MsgBox("Debe ingresar un tiempo para poder continuar")
            txtTiempo.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempo.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempo.Clear()
            txtTiempo.Focus()
            Exit Sub
        End If

        Dim filaActual = Me.dgvTiempos.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el salto conseguido..??: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' filaActual.Cells(4).Value = 0 'btnNulo.Text
            Dim valor As String
            valor = txtTiempo.Text
            txtTiempo.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
    End Sub

    Dim COLUMNA_PRIMER_TIEMPO As Integer = 2
    Dim COLUMNA_SEGUNDO_TIEMPO As Integer = 3
    Dim COLUMNA_TERCERA_TIEMPO As Integer = 4
    Dim COLUMNA_MEJOR_TIEMPO As Integer = 5

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As String)
        ' recorre las columnas 3 a 12 que corresponden a la cantidad de alturas
        For i As Integer = COLUMNA_PRIMER_TIEMPO To COLUMNA_TERCERA_TIEMPO
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía
                filaActual.Cells(i).Value = valorAponer
                Exit Sub
            End If
        Next
        CalcularMejor123(filaActual)
    End Sub

    Private Sub CalcularMejor123(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then
            Dim tiempocross As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            tiempocross.Add(filaActual.Cells(COLUMNA_PRIMER_TIEMPO).Value)
            tiempocross.Add(filaActual.Cells(COLUMNA_SEGUNDO_TIEMPO).Value)
            tiempocross.Add(filaActual.Cells(COLUMNA_TERCERA_TIEMPO).Value)
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = tiempocross.Max()
        End If
    End Sub

    Private Sub ckbEditarTiempo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbEditarTiempo.CheckedChanged
        If ckbEditarTiempo.Checked = True Then
            GroupBox4.Enabled = True
        End If
        If ckbEditarTiempo.Checked = False Then
            GroupBox4.Enabled = False
        End If
    End Sub

    Sub PrepararFormulario()
        GroupBox4.Enabled = False
        btnInformeFinal.Enabled = False
        Label3.Visible = False
        txtCodigoPlanillaCrossCountry.Visible = False
        Label13.Visible = False
        cboUsuario.Visible = False
        Me.dgvTiempos.Columns("Id_Atleta").Visible = False
        Me.dgvTiempos.Columns("Id_Resultado_Parcial").Visible = False
        btnActualizar.Enabled = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboPrueba.Enabled = False
        cboCategoria.Enabled = False
        cboSexo.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        dtpfechainicio.Enabled = False
    End Sub

    Private Sub btnGuardarCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        btnInformeFinal.Enabled = True
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        txtEstado.Text = "Finalizada"
        PlanillaFinalCrossCountry.txtCodigoPlanillaFinalCrossCountry.Text = Me.txtCodigoPlanillaCrossCountry.Text
        PlanillaFinalCrossCountry.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalCrossCountry.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalCrossCountry.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalCrossCountry.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalCrossCountry.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalCrossCountry.txtHora.Text = Me.txtHora.Text
        PlanillaFinalCrossCountry.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalCrossCountry.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalCrossCountry.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalCrossCountry.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalCrossCountry.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalCrossCountry.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalCrossCountry.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalCrossCountry.cboCategoria.Text = Me.cboCategoria.Text
        PlanillaFinalCrossCountry.Show()
    End Sub
End Class