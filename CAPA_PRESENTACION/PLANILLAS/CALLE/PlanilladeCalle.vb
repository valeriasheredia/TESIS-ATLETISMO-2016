Imports System.Data.SqlClient
Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PLANILLACOMPETENCIACALLE
    Dim conexion As New SqlConnection("Data Source=VALE\VALERIA;Initial Catalog=TESIS ATLETISMO 2016;Integrated Security=True")


    Public Property Id_Competencia As Int32
    Dim capanegocio As New CNPlanillaCalle
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
        'Dim clubNombre As String = cNegVarios.NombreClubPorId(atleta.id_club_federacion)
        PLANILLACOMPETENCIACALLE.dgvAtletasdeCalle.Rows.Add(atleta.dorsal,
                                                          atleta.Nombre_atleta, _
                                                          atleta.Apellido_atleta,
                                                          sexoNombre, _
                                                          localidadNombre, _
                                                          atleta.Edad, _
                                                          atleta.otra_institucion,
                                                          "")
    End Sub


    'CARGA DE COMBO Y LOGICA DE BOTONES
    Private Sub PrepararFormulario()

        Me.Text = "PLANILLA COMPETENCIA CALLE"
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnActualizar.Enabled = False
        btnImprimir.Enabled = False
        btnIngresar.Enabled = False
        btnComenzar.Enabled = False
        btnGuardarCompetencia.Enabled = True
        btnCerrar.Enabled = False
        btnIngresar.Enabled = False
        cboUsuario.Visible = False
        Label13.Visible = False
        RellenarCampos()

        Select Case TipoDeFormulario
            Case TipoFormulario.Alta
                btnAgregarAtleta.Enabled = True
                btnQuitarAtleta.Enabled = True
                btnActualizar.Enabled = False
                btnComenzar.Enabled = True
            Case TipoFormulario.Comenzar

        End Select
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
            MessageBox.Show("seleccione una Juez")
            cboJuez1.Focus()
            Return
        End If

        If cboJuez2.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Juez")
            cboJuez2.Focus()
            Return
        End If

        If cboJuez3.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Juez")
            cboJuez3.Focus()
            Return
        End If

        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnActualizar.Enabled = False
        btnGuardarCompetencia.Enabled = True
        btnCerrar.Enabled = True
        btnImprimir.Enabled = True
        btnIngresar.Enabled = True
        btnIngresar.Enabled = True
    End Sub

    Private Sub btnFinalizarCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCompetencia.Click
        btnAgregarAtleta.Enabled = False
        btnQuitarAtleta.Enabled = False
        btnActualizar.Enabled = False
        btnComenzar.Enabled = False
        btnImprimir.Enabled = True
        btnCerrar.Enabled = True
        btnIngresar.Enabled = False


        Dim agregar As SqlCommand = New SqlCommand("insert into Planilla_Calle values (@Dorsal, @Nombre_Atleta,@Apellido_Atleta, @Id_Sexo, @Id_Localidad, @Fecha_Nacimiento, @Otra_Institución, @Tiempo1,@Tiempo2,@Tiempo3,@Tiempo_Final_Calle)", conexion)
        conexion.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()

        ' Try
        For Each row In dgvAtletasdeCalle.Rows
            agregar.Parameters.Clear()
            ' agregar.Parameters.AddWithValue("@Id_Planilla_calle", Convert.ToInt32(row.Cells("Id").Value))
            agregar.Parameters.AddWithValue("@Dorsal", Convert.ToInt32(row.Cells("Número").Value))
            agregar.Parameters.AddWithValue("@Nombre_Atleta", Convert.ToString(row.Cells("Nombre").Value))
            agregar.Parameters.AddWithValue("@Apellido_Atleta", Convert.ToString(row.Cells("Apellido").Value))
            agregar.Parameters.AddWithValue("@Id_Sexo", Convert.ToString(row.Cells("Sexo").Value))
            agregar.Parameters.AddWithValue("@Id_Localidad", Convert.ToString(row.Cells("Localidad").Value))
            agregar.Parameters.AddWithValue("@Fecha_Nacimiento", Convert.ToString(row.Cells("Edad").Value))
            agregar.Parameters.AddWithValue("@Otra_Institución", Convert.ToString(row.Cells("Institución").Value))
            agregar.Parameters.AddWithValue("@Tiempo1", Convert.ToString(row.Cells("Tiempo1").Value))
            agregar.Parameters.AddWithValue("@Tiempo2", Convert.ToString(row.Cells("Tiempo2").Value))
            agregar.Parameters.AddWithValue("@Tiempo3", Convert.ToString(row.Cells("Tiempo3").Value))
            agregar.Parameters.AddWithValue("@Tiempo_Final_Calle", Convert.ToString(row.Cells("Tiempo_Final_Calle").Value))
            agregar.ExecuteNonQuery()
        Next
        MessageBox.Show("Registro Guardado con Exito...")
        ' Catch ex As Exception
        MessageBox.Show("Error al guardar los datos")
        ' Finally
        conexion.Close()
        'End Try
    End Sub

    'Function getdorsal()
    '    Return dgvAtletasdeCalle.Rows.Item("Dorsal")
    'End Function

    'Function getnombre()
    '    Return dgvAtletasdeCalle.Rows.Item("Número")

    'End Function

    'Function getapellido()
    '    Return dgvAtletasdeCalle.Rows.Item("Apellido")
    'End Function

    'Function getisexo()
    '    Return dgvAtletasdeCalle.Rows.Item("Sexo")
    'End Function

    'Function getlocalidad()
    '    Return dgvAtletasdeCalle.Rows.Item("Localidad")
    'End Function

    'Function getedad()
    '    Return dgvAtletasdeCalle.Rows.Item("Edad")
    'End Function

    'Function getinstitucion()
    '    Return dgvAtletasdeCalle.Rows.Item("Institución")
    'End Function

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    ' CARGA EL FORMULARIO CON LS DATOS DE LA ULTIMA COMPETENCIA CREADA (NO CARGA NADA JAJAJA)

    Private Sub RellenarCampos()
        'CompetenciaSeleccionada.id_competencia = txtCodigoCompetencia.Text
        CompetenciaSeleccionada.Nombre_competencia = txtNombre.Text
        CompetenciaSeleccionada.lugar_competencia = txtLugar.Text
        CompetenciaSeleccionada.distancia = txtDistanciaCompetenciaCalle.Text
        CompetenciaSeleccionada.fecha_inicio = dtpfechainicio.Text
        CompetenciaSeleccionada.hora_inicio = txtHora.Text
        CompetenciaSeleccionada.id_provincia = cboProvincia.SelectedValue
        CompetenciaSeleccionada.id_localidad = cboLocalidad.SelectedValue
        CompetenciaSeleccionada.juez1 = cboJuez1.SelectedValue
        CompetenciaSeleccionada.juez2 = cboJuez2.SelectedValue
        CompetenciaSeleccionada.juez3 = cboJuez3.SelectedValue
        CompetenciaSeleccionada.id_usuario = cboUsuario.SelectedValue
    End Sub

    'Private Sub btnMarcarTiempo_Click(sender As System.Object, e As System.EventArgs)
    '    'marca tiempo en el textbox

    '    Dim i As Integer
    '    For i = 0 To dgvAtletasdeCalle.SelectedRows.Count - 1
    '        dgvAtletasdeCalle.SelectedRows(i).Cells("Tiempo").Value = "'" & lblhoras.Text & "', '" & lblMinutos.Text & "','" & lblSegundos.Text & "','" & lblMilesimas.Text & "'"
    '    Next
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

    Const COLUMNA_PRIMER_TIEMPO As Integer = 7
    Const COLUMNA_SEGUNDO_TIEMPO As Integer = 8
    Const COLUMNA_TERCER_TIEMPO As Integer = 9
    Const COLUMNA_MEJOR_TIEMPO As Integer = 10

    Private Sub CargarSiguienteCelda(ByRef filaActual As DataGridViewRow, valorAponer As Integer)

        ' recorre las columnas 4 a 6 que corresponden a los primeros tres lanzamientos
        For i As Integer = COLUMNA_PRIMER_TIEMPO To COLUMNA_TERCER_TIEMPO

            ' valida que la posicion este vacia, si es asi agrega el valor
            If String.IsNullOrEmpty(filaActual.Cells(i).Value) Then 'busca la primer posición vacía d las celdas 4,5,6
                filaActual.Cells(i).Value = valorAponer
                CalcularMejorTiempo(filaActual)
                Exit Sub
            End If
        Next
    End Sub
     'Integer.TryParse(string, variable_numerica)
    Private Sub CalcularMejorTiempo(ByRef filaActual As DataGridViewRow)

        If String.IsNullOrEmpty(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then

            Dim TIEMPOS As List(Of Integer) = New List(Of Integer) ' esto es LINQ
            TIEMPOS.Add(filaActual.Cells(COLUMNA_PRIMER_TIEMPO).Value)
            'TIEMPOS.Add(filaActual.Cells(COLUMNA_SEGUNDO_TIEMPO).Value)
            'TIEMPOS.Add(filaActual.Cells(COLUMNA_TERCER_TIEMPO).Value)

            filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = TIEMPOS.Max()
        End If
    End Sub

    Private Sub dgvAtletasdeCalle_SelectionChanged(sender As Object, e As System.EventArgs)
        If Me.dgvAtletasdeCalle.SelectedRows Is Nothing OrElse Me.dgvAtletasdeCalle.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim filaActual = Me.dgvAtletasdeCalle.SelectedRows(0)
        If Not IsNumeric(filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value) Then
        End If
    End Sub

    Private Sub btnAgregarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta.Click
        LISTA_DE_ATLETAS.TipoDeFormulario = TipoFormulario.AgregarAtleta
        LISTA_DE_ATLETAS.ShowDialog()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        IngresodeTiempos.ShowDialog()

    End Sub

    Private Sub btnQuitarAtleta_Click_1(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta.Click
        If Me.dgvAtletasdeCalle.Rows.Count = 0 Then
            MessageBox.Show("No hay atletas para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dgvAtletasdeCalle.Rows.RemoveAt(dgvAtletasdeCalle.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
    End Sub

End Class
