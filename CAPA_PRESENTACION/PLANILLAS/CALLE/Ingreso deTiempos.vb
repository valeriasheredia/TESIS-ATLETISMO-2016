Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization

Public Class IngresodeTiemposdeCalle

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCalle
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario


    Private Sub IngresodeTiempos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Public Function validar_Mail(ByVal tiempo As String) As Boolean
        ' retorna true o false   
      
        Return Regex.IsMatch(tiempo, _
                         "^([0-1]?\d|2[0-3]):([0-5]?\d):([0-5]?\d)$)|(^([0-5]?\d):([0-5]?\d)$)|(^[0-5]?\d$") '
    End Function

    Private Sub txtTiempo_Leave(sender As System.Object, e As System.EventArgs) Handles txtTiempo.Leave
        If validar_Mail(LCase(txtHora.Text)) = False Then
            MessageBox.Show("el formato de tiempo no es valido " & _
            " por favor seleccione un tiempo válido", "Validación de tiempo", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            txtHora.Focus()
            txtHora.SelectAll()
        End If
        '^ # Comienzo de la cadena (?: # Intentar emparejar ... (?: # ¿Tratar de emparejar ... ([01]? \ D | 2 [0-3]): # HH: . ([0-5]? \ D): # MM: (requerido))? # (Todo el grupo opcional, por lo tanto HH: MM :, MM: o nada) ([0-5]? \ D) # SS (requerido) $ # Fin de la cadena
        '^ # Start of string (?: # Try to match... (?: # Try to match... ([01]?\d|2[0-3]): # HH: )? # (optionally). ([0-5]?\d): # MM: (required) )? # (entire group optional, so either HH:MM:, MM: or nothing) ([0-5]?\d) # SS (required) $ # End of string 
    End Sub


    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = PLANILLACOMPETENCIACALLE.dgvAtletasdeCalle.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        'Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        IngresodeTiemposdeCalle.dgvTiempos.Rows.Add(atleta.dorsal,
                                                    atleta.Apellido_atleta,
                                                          "",
                                                          "",
                                                          "",
                                                          "",
                                                          atleta.id_atleta
                                                          )
    End Sub

    Const COLUMNA_PRIMER_TIEMPO As Integer = 2
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 3
    Const COLUMNA_TERCER_TIEMPO As Integer = 4
    Const COLUMNA_MEJOR_TIEMPO As Integer = 5

    Private Sub btnAgregarTiempo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo.Click

        If txtTiempo.Text = "" Then
            MessageBox.Show("Debe ingresar un tiempo para poder continuar")
            txtTiempo.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtTiempo.Text) Then
            MessageBox.Show("Debe ingresar un tiempo válido")
            txtTiempo.Focus()
            Exit Sub
        End If
        btnActualizar.Enabled = True
        'CONVERTIR UN ENTERO A DATE
        'Dim TestDateTime As Date = #1/27/2001 5:04:23 AM#
        'Dim TestStr As String = txtTiempo.Text

        'txtTiempo.Text = Format(TestDateTime, "H:m:s")
        ''Dim hour As Integer = txtTiempo.Text
        ''Dim time = New DateTime().Add(TimeSpan.FromHours(txtTiempo.Text))
        ''MessageBox.Show(time.ToLongTimeString())
        ''Resultado: 07:00:00


        'Dim stringfecha As String = txtTiempo.Text
        'Dim fecha As Date = Date.ParseExact(stringfecha, "hh:mm:ss", CultureInfo.InvariantCulture)


        Dim filaActual = Me.dgvTiempos.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(1).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Dim valor As String = txtTiempo.Text
            'Dim tiempo As Date = Date.ParseExact(valor, "H:mm:ss", CultureInfo.InvariantCulture)
            valor = txtTiempo.Text
            txtTiempo.Clear()
            CargarSiguienteCelda(filaActual, valor)
        End If
    End Sub

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

    Sub PrepararFormulario()
        'txtCodigoPlanillaCalle.Visible = False
        'Label3.Visible = False
        Label13.Visible = False
        cboUsuario.Visible = False
        ckbEditarTiempo.Checked = False
        GroupBox4.Enabled = False
        btnActualizar.Enabled = False
        btnInformeFinal.Enabled = False
        Label3.Visible = False
        txtCodigoPlanillaCalle.Visible = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        cboJuez1.Enabled = False
        cboJuez2.Enabled = False
        cboJuez3.Enabled = False
        dtpfechainicio.Enabled = False
        Me.dgvTiempos.Columns("Id_Atleta").Visible = False
        Me.dgvTiempos.Columns("Id_Resultado_Parcial").Visible = False
    End Sub

    Private Sub btnInformeFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeFinal.Click
        txtEstado.Text = "Finalizada"
        PlanillaFinalCalle.txtCodigoPlanillaCalle.Text = Me.txtCodigoPlanillaCalle.Text
        PlanillaFinalCalle.txtNombre.Text = Me.txtNombre.Text
        PlanillaFinalCalle.txtLugar.Text = Me.txtLugar.Text
        PlanillaFinalCalle.cboProvincia.Text = Me.cboProvincia.Text
        PlanillaFinalCalle.cboLocalidad.Text = Me.cboLocalidad.Text
        PlanillaFinalCalle.dtpfechainicio.Text = Me.dtpfechainicio.Text
        PlanillaFinalCalle.txtHora.Text = Me.txtHora.Text
        PlanillaFinalCalle.txtDistanciaCompetenciaCalle.Text = Me.txtDistanciaCompetenciaCalle.Text
        PlanillaFinalCalle.txtEstado.Text = Me.txtEstado.Text
        PlanillaFinalCalle.cboJuez1.Text = Me.cboJuez1.Text
        PlanillaFinalCalle.cboJuez2.Text = Me.cboJuez2.Text
        PlanillaFinalCalle.cboJuez3.Text = Me.cboJuez3.Text
        PlanillaFinalCalle.cboUsuario.Text = Me.cboUsuario.Text
        PlanillaFinalCalle.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        'CAMBIA SOLO UN TIEMPO DE LA FILA SELECCIONADA, CONTROLAR!!

        'If dgvTiempos.Rows(0).Selected = True Then
        '    If dgvTiempos.Columns(2).HeaderText = "Tiempo Juez 1" Then
        '        dgvTiempos.CurrentRow.Cells(2).Value = CInt(txtTiempo1.Text)
        '    Else
        '        If dgvTiempos.Columns(3).HeaderText = "Tiempo Juez 2" Then
        '            dgvTiempos.CurrentRow.Cells(3).Value = CInt(txtTiempo2.Text)
        '        Else
        '            If dgvTiempos.Columns(4).HeaderText = "Tiempo Juez 3" Then
        '                dgvTiempos.CurrentRow.Cells(4).Value = CInt(txtTiempo3.Text)
        '            End If
        '        End If
        '    End If
        'End If

        'If dgvTiempos.Rows(0).Selected = True Then
        '    If dgvTiempos.Columns(2).HeaderText = "Tiempo Juez 1" Then
        '        dgvTiempos.CurrentRow.Cells(2).Value = CInt(txtTiempo1.Text)
        '    End If

        '    If dgvTiempos.Columns(3).HeaderText = "Tiempo Juez 2" Then
        '        dgvTiempos.CurrentRow.Cells(3).Value = CInt(txtTiempo2.Text)
        '    End If

        '    If dgvTiempos.Columns(4).HeaderText = "Tiempo Juez 3" Then
        '        dgvTiempos.CurrentRow.Cells(4).Value = CInt(txtTiempo3.Text)
        '    End If
        'End If

        If dgvTiempos.Rows(0).Selected = True Then
            If dgvTiempos.Columns(2).HeaderText = "Tiempo Juez 1" Then
                Me.dgvTiempos.CurrentRow.Cells(2).Value = Me.txtTiempo1.Text
            End If
            If dgvTiempos.Columns(3).HeaderText = "Tiempo Juez 2" Then
                Me.dgvTiempos.CurrentRow.Cells(3).Value = Me.txtTiempo2.Text
            End If
            If dgvTiempos.Columns(2).HeaderText = "Tiempo Juez 3" Then
                Me.dgvTiempos.CurrentRow.Cells(4).Value = Me.txtTiempo3.Text
            End If
        End If

    End Sub

    Private Sub ckbEditarTiempo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbEditarTiempo.CheckedChanged

        If ckbEditarTiempo.Checked = True Then
            GroupBox4.Enabled = True
        Else
            ckbEditarTiempo.Checked = False
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        btnInformeFinal.Enabled = True
    End Sub




End Class


'' modelo de como poder sacar el mejor tiempo!!

'DataGridViewRow fila = dataGridView1.Rows.Cast<DataGridViewRow>()
'	.Where(x => !x.IsNewRow)
'	.OrderBy(x => TimeSpan.Parse(x.Cells["Tiempo"].Value.ToString())).FirstOrDefault();

'MessageBox.Show(string.Format("El atleta {0} tuvo el mejor tiempo {1}", 
'	fila.Cells["Nombre"].Value.ToString(), fila.Cells["Tiempo"].Value.ToString()));
'Dim TestDateTime As Date = #1/27/2001 5:04:23 PM#
'Dim TestStr As String
