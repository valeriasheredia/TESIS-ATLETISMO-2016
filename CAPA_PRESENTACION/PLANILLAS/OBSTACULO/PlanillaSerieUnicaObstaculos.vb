Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms


Public Class PlanillaSerieUnicaObstaculos

    Public Property TipoDeFormulario As TipoFormulario
    Shared Property CompetenciaSeleccionada As New CECompetencias

    Private Sub PlanillaSerieUnicaObstaculos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub chkEditar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEditar.CheckedChanged
        If chkEditar.Checked = True Then
            GroupBox4.Enabled = True
        Else
            If chkEditar.Checked = False Then
                GroupBox4.Enabled = False
            End If
        End If
    End Sub

    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)

        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PlanillaSerieUnicaObstaculos.dgvSerie1.Rows.Add(atleta.dorsal,
                                                          atleta.Apellido_atleta,
                                                          clubNombre,
                                                          "",
                                                          "",
                                                          "",
                                                          "",
                                                          "")
    End Sub

    Sub PrepararFormulario()
        GroupBox4.Enabled = False
        btnInformeFinal.Enabled = False
        btnActualizar.Enabled = False
        Me.dgvSerie1.Columns("Id_Atleta").Visible = False
        Me.dgvSerie1.Columns("Id_Resultado_Parcial").Visible = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        dtpfechainicio.Enabled = False
        cboPrueba.Enabled = False
        Label1.Visible = False
        Label19.Visible = False
        txtCodigoObstaculos.Visible = False
        cboUsuario.Visible = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        cboSexo.Enabled = False
        cboCategoria.Enabled = False
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
        'CONVERTIR UN ENTERO A DATE

        Dim filaActual = Me.dgvSerie1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempo.Text
            valor = txtTiempo.Text
            txtTiempo.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
        btnActualizar.Enabled = True
    End Sub

    Const COLUMNA_PRIMER_TIEMPO As Integer = 3
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 4
    Const COLUMNA_TERCER_TIEMPO As Integer = 5
    Const COLUMNA_MEJOR_TIEMPO As Integer = 6

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)
        ' recorre las columnas 4 a 6 que corresponden a los primeros tres tiempos
        For i As Integer = COLUMNA_PRIMER_TIEMPO To COLUMNA_TERCER_TIEMPO
            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                Exit Sub
            End If
        Next
        CalcularMejorTiempo(filaActual)
    End Sub

    Private Sub CalcularMejorTiempo(ByRef filaActual As DataGridViewRow)
        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then
            Dim Tiempos As List(Of Integer) = New List(Of Integer) ' esto es LINQ

            'PREGUNTAR SI LA CELDA DE TIEMPO ESTA VACIA, SI ESTA VACIA INGRESAR UN TIEMPO, SINO SALIR

            'If String.IsNullOrEmpty(filaActual.Cells(2).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_PRIMER_TIEMPO).Value)
            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If
            'If String.IsNullOrEmpty(filaActual.Cells(3).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_SEGUNDO_TIEMPO).Value)
            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If
            'If String.IsNullOrEmpty(filaActual.Cells(4).Value) Then
            Tiempos.Add(filaActual.Cells(COLUMNA_TERCER_TIEMPO).Value)
            'Else
            '    MsgBox("debe ingregar un tiempo")
            'End If
            filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = Tiempos.Max()
        End If
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click

        txtEstado.Text = "Finalizada"
        PlanillaFinalObstaculos.txtCodigoObstaculos.Text = Me.txtCodigoObstaculos.Text
        PlanillaFinalObstaculos.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalObstaculos.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalObstaculos.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalObstaculos.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalObstaculos.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalObstaculos.txtHora.Text = Me.txtHora.Text
        PlanillaFinalObstaculos.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalObstaculos.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalObstaculos.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalObstaculos.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalObstaculos.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalObstaculos.cboPrueba.Text = Me.cboPrueba.Text
        PlanillaFinalObstaculos.cboSexo.Text = Me.cboSexo.Text
        PlanillaFinalObstaculos.cboCategoria.Text = Me.cboCategoria.Text
        PlanillaFinalObstaculos.Show()

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        btnInformeFinal.Enabled = True
    End Sub
End Class