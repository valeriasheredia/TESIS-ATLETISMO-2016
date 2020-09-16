Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class PLANILLACOMPETENCIACALLE

    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCalle
    Dim capanegocio2 As New CNCompetencias
    Shared Property AtletaSeleccionado As New CEAtletas
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario
    Shared Property PlanillaCalleSeleccionada As New CEPlanillaCalle

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    'Creo una sobrecarga del constructor para obligarlo siempre a pasar un codigo de competencia
    'POR AHORA ESTO NO LO VEMOS
    Public Sub New(ByVal id_Competencia As Integer)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        If (id_Competencia <> 0) Then
            Me.Id_Competencia = id_Competencia
        End If
        ' llamo al método que me carga la pantalla
        CargarDatosFormulario()
    End Sub

    'Private Sub UltimaCompetenciaCreada()
    '    Dim capanegocio As New CNCompetencias
    '    dgvCompetencias.DataSource = capanegocio.UltimaCompetencia.Tables("Ultima Competencia")
    '    'lbltotalcompetenciacalle.Text = capanegocio.ListaCompetenciaCalle.Tables("Competencias de Calle").Rows.Count
    'End Sub

    Private Sub PLANILLACOMPETENCIACALLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    'POR AHORA ESTO NO LO VEMOS
    Private Sub CargarDatosFormulario()
        Dim objcompetencia As New CNCompetencias

        Dim tablaCompetencia = objcompetencia.ListadoTodasCompetencias(Me.Id_Competencia)
        Me.txtNombre.Text = tablaCompetencia.Rows(0)("Nombre")
        'Me.txtLugar.Text = tablaCompetencia.Rows(1)("Lugar")
        'Me.cboLocalidad.Text = tablaCompetencia.Rows(2)("Localidad")
        'Me.cboProvincia.Text = tablaCompetencia.Rows(3)("Provincia")

    End Sub

    ' CARGA EN EL DATAGRID LOS ATLETAS QUE VAN A PARTICIPAR DE LA COMPETENCIA
    Shared Sub AgregarRegistroAGrilla(atleta As CEAtletas)
        Dim Coleccion As DataGridViewSelectedRowCollection = LISTA_DE_ATLETAS.dgvlistaatletas.SelectedRows
        Dim cNegVarios = New CAPA_NEGOCIO.CNVarios
        Dim localidadNombre As String = cNegVarios.NombreLocalidadPorId(atleta.id_localidad)
        Dim sexoNombre As String = cNegVarios.NombreSexoPorId(atleta.id_sexo)
        'Dim tiempo1 As String = cNegVarios.Tiempo1PorId(atleta.id_atleta)
        PLANILLACOMPETENCIACALLE.dgvAtletasdeCalle.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta,
                                                          sexoNombre, _
                                                          localidadNombre, _
                                                          atleta.Edad, _
                                                          atleta.otra_institucion,
                                                          atleta.id_atleta,
                                                          "")
    End Sub

    'CARGA DE COMBO Y LOGICA DE BOTONES
    Private Sub PrepararFormulario()
        Me.Text = "PLANILLA COMPETENCIA CALLE"
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnImprimir.Enabled = False
        btnIngresar.Enabled = False
        btnComenzar.Enabled = False
        btnCerrar.Enabled = False
        btnIngresar.Enabled = False
        cboUsuario.Visible = False
        cboProvincia.Enabled = False
        cboLocalidad.Enabled = False
        dtpfechainicio.Enabled = False
        Label13.Visible = False
        cboJuez1.Focus()
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()

        Me.dgvAtletasdeCalle.Columns("Id_Atleta").Visible = False
        'RellenarCampos()
        Label1.Visible = False
        txtCodigoPlanillaCalle.Visible = False
        btnActualizar.Enabled = False

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                btnAgregarAtleta.Enabled = True
                btnQuitarAtleta.Enabled = True
                btnComenzar.Enabled = True

            Case TipoFormulario.Comenzar

        End Select
        'PABLOOOOOOOOO
        ' Me.txtNombre.Text = CStr(capanegocio2.BuscarCompetenciaporId(Me.txtCodigoPlanillaCalle.Text))

    End Sub

    ' BOTON COMENZAR DESACTIVA LOS BOTONES RELACIONADOS CON EL ATLETA Y ACTIVA LOS RELACIONADOS A CARGAR TIEMPOS Y GUARDAR FORMULARIOS
    Private Sub btnComenzar_Click(sender As System.Object, e As System.EventArgs) Handles btnComenzar.Click

        If Me.dgvAtletasdeCalle.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar atletas para poder comenzar a registrar los Tiempos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If
        ' VALIDACION DE JUECES
        If cboJuez1.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez1.Focus()
            Return
        End If

        If cboJuez2.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez2.Focus()
            Return
        End If

        If cboJuez3.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione un Juez")
            cboJuez3.Focus()
            Return
        End If

        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnCerrar.Enabled = True
        btnImprimir.Enabled = True
        btnIngresar.Enabled = True
        btnIngresar.Enabled = True
    End Sub

    Private Sub btnFinalizarCompetencia_Click(sender As System.Object, e As System.EventArgs)
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnComenzar.Enabled = False
        btnImprimir.Enabled = True
        btnCerrar.Enabled = True
        btnIngresar.Enabled = False
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    ' CARGA EL FORMULARIO CON LOS DATOS DE LA ULTIMA COMPETENCIA CREADA (NO CARGA NADA JAJAJA)

    'Private Sub RellenarCampos()
    '    'CompetenciaSeleccionada.id_competencia = txtCodigoCompetencia.Text
    '    CompetenciaSeleccionada.Nombre_competencia = txtNombre.Text
    '    CompetenciaSeleccionada.lugar_competencia = txtLugar.Text
    '    CompetenciaSeleccionada.distancia = txtDistanciaCompetenciaCalle.Text
    '    CompetenciaSeleccionada.fecha_inicio = dtpfechainicio.Text
    '    CompetenciaSeleccionada.hora_inicio = txtHora.Text
    '    CompetenciaSeleccionada.id_provincia = cboProvincia.SelectedValue
    '    CompetenciaSeleccionada.id_localidad = cboLocalidad.SelectedValue
    '    CompetenciaSeleccionada.juez1 = cboJuez1.SelectedValue
    '    CompetenciaSeleccionada.juez2 = cboJuez2.SelectedValue
    '    CompetenciaSeleccionada.juez3 = cboJuez3.SelectedValue
    '    CompetenciaSeleccionada.id_usuario = cboUsuario.SelectedValue
    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        If Me.dgvAtletasdeCalle.SelectedRows Is Nothing OrElse Me.dgvAtletasdeCalle.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una opción")
            Exit Sub
        End If
        Dim filaActual = Me.dgvAtletasdeCalle.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: \n" + filaActual.Cells(2).Value, "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
          
        End If
    End Sub

    Private Sub btnAgregarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        txtEstado.Text = "En Curso"
        IngresodeTiemposdeCalle.txtCodigoPlanillaCalle.Text = Me.txtCodigoPlanillaCalle.Text
        IngresodeTiemposdeCalle.txtNombre.Text = Me.txtNombre.Text
        IngresodeTiemposdeCalle.txtLugar.Text = Me.txtLugar.Text
        IngresodeTiemposdeCalle.cboProvincia.Text = Me.cboProvincia.Text
        IngresodeTiemposdeCalle.cboLocalidad.Text = Me.cboLocalidad.Text
        IngresodeTiemposdeCalle.dtpfechainicio.Text = Me.dtpfechainicio.Text
        IngresodeTiemposdeCalle.txtDistanciaCompetenciaCalle.Text = Me.txtDistanciaCompetenciaCalle.Text
        IngresodeTiemposdeCalle.txtHora.Text = Me.txtHora.Text
        IngresodeTiemposdeCalle.txtEstado.Text = Me.txtEstado.Text
        IngresodeTiemposdeCalle.cboJuez1.Text = Me.cboJuez1.Text
        IngresodeTiemposdeCalle.cboJuez2.Text = Me.cboJuez2.Text
        IngresodeTiemposdeCalle.cboJuez3.Text = Me.cboJuez3.Text
        IngresodeTiemposdeCalle.cboUsuario.Text = Me.cboUsuario.Text
        IngresodeTiemposdeCalle.ShowDialog()

    End Sub

    Private Sub btnQuitarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        dgvAtletasdeCalle.Rows.RemoveAt(dgvAtletasdeCalle.CurrentRow.Index)
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            PlanillaCalleSeleccionada.id_planilla = dgvAtletasdeCalle.CurrentRow.Cells.Item("Número").Value
            PlanillaCalleSeleccionada.dorsal = dgvAtletasdeCalle.CurrentRow.Cells.Item("Dorsal").Value
            PlanillaCalleSeleccionada.Nombre_atleta = dgvAtletasdeCalle.CurrentRow.Cells.Item("Nombre").Value
            PlanillaCalleSeleccionada.Apellido_atleta = dgvAtletasdeCalle.CurrentRow.Cells.Item("Apellido").Value
            PlanillaCalleSeleccionada.id_sexo = dgvAtletasdeCalle.CurrentRow.Cells.Item("Sexo").Value
            PlanillaCalleSeleccionada.id_localidad = dgvAtletasdeCalle.CurrentRow.Cells.Item("Localidad").Value
            PlanillaCalleSeleccionada.fecha_nacimiento = dgvAtletasdeCalle.CurrentRow.Cells.Item("Edad").Value
            PlanillaCalleSeleccionada.otra_institucion = dgvAtletasdeCalle.CurrentRow.Cells.Item("Institución").Value

            capanegocio.ActualizarPlanillaCalle(PlanillaCalleSeleccionada)
            MsgBox("Los datos de la Planilla han sido actualizados correctamente")
        Catch ex As Exception
            MsgBox("Error al actualizar los datos de la Planilla")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        ' valida que haya registros para poder guardarlos
        If Me.dgvAtletasdeCalle.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta.Focus()
            Return
        End If

        Dim objeto As New CEAtletas_x_Competencia
        Try
            For Each row As DataGridViewRow In Me.dgvAtletasdeCalle.Rows
                objeto.id_competencia = txtCodigoPlanillaCalle.Text
                objeto.id_atleta = row.Cells(7).Value
                ' objeto.id_resultado_parcial = row.Cells(8).Value
            Next
            MsgBox("La planilla se ha guardado correctamente")
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub juezprincipal1()
        cboJuez1.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez1.DisplayMember = "Apellido_Juez"
        cboJuez1.ValueMember = "Id_Juez"
        cboJuez1.SelectedIndex = 8
    End Sub
    Sub juezprincipal2()
        cboJuez2.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez2.DisplayMember = "Apellido_Juez"
        cboJuez2.ValueMember = "Id_Juez"
        cboJuez2.SelectedIndex = 8
    End Sub

    Sub juezprincipal3()
        cboJuez3.DataSource = capanegocio.JuezPrincipal.Tables("Apellido de Jueces")
        cboJuez3.DisplayMember = "Apellido_Juez"
        cboJuez3.ValueMember = "Id_Juez"
        cboJuez3.SelectedIndex = 8
    End Sub
End Class
