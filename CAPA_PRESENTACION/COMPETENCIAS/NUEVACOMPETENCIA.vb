Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class NUEVACOMPETENCIA
   
    Dim capanegocio As New CNCompetencias
    Shared Property CompetenciaSeleccionada As New CECompetencias
    Public Property TipoDeFormulario As TipoFormulario

    Sub juezprincipal1()
        cboJuez1.DataSource = capanegocio.JuezPrincipal1.Tables("Apellido de Jueces")
        cboJuez1.DisplayMember = "Apellido_Juez"
        cboJuez1.ValueMember = "Id_Juez"
        cboJuez1.SelectedIndex = 8
    End Sub

    Sub juezprincipal2()
        cboJuez2.DataSource = capanegocio.JuezPrincipal2.Tables("Apellido de Jueces")
        cboJuez2.DisplayMember = "Apellido_Juez"
        cboJuez2.ValueMember = "Id_Juez"
        cboJuez2.SelectedIndex = 8
    End Sub

    Sub juezprincipal3()
        cboJuez3.DataSource = capanegocio.JuezPrincipal3.Tables("Apellido de Jueces")
        cboJuez3.DisplayMember = "Apellido_Juez"
        cboJuez3.ValueMember = "Id_Juez"
        cboJuez3.SelectedIndex = 8
    End Sub

    Sub UsuarioPrincipal()
        cboUsuario.DataSource = capanegocio.UsuarioPrincipal.Tables("Apellido de Usuario")
        cboUsuario.DisplayMember = "Apellido_Usu"
        cboUsuario.ValueMember = "Id_Usuario"
        cboUsuario.SelectedIndex = 7
    End Sub

    Private Sub RellenarCampos()
        txtCodigoCompetencia.Text = CompetenciaSeleccionada.id_competencia
        txtNombreCompetencia.Text = CompetenciaSeleccionada.Nombre_competencia
        txtLugarCompetenciaCalle.Text = CompetenciaSeleccionada.lugar_competencia
        txtDistanciaCompetenciaCalle.Text = CompetenciaSeleccionada.distancia
        dtpFechaInicioCompetenciaCalle.Text = CompetenciaSeleccionada.fecha_inicio
        txtHora.Text = CompetenciaSeleccionada.hora_inicio
        cboProvinciaCompetencia.SelectedValue = CompetenciaSeleccionada.id_provincia
        cboLocalidadCompetenciaCalle.SelectedValue = CompetenciaSeleccionada.id_localidad
        cboDisciplinas.SelectedValue = CompetenciaSeleccionada.id_disciplina
        cboPruebas.SelectedValue = CompetenciaSeleccionada.id_prueba
        txtOtra.Text = CompetenciaSeleccionada.otra
        cboJuez1.SelectedValue = CompetenciaSeleccionada.juez1
        cboJuez2.SelectedValue = CompetenciaSeleccionada.juez2
        cboJuez3.SelectedValue = CompetenciaSeleccionada.juez3
        cboUsuario.SelectedValue = CompetenciaSeleccionada.id_usuario
    End Sub

    Private Sub PrepararFormulario()
        'Logica de los botones

        btnCrear.Enabled = False
        btnActualizar.Enabled = False
        btnCancelar.Enabled = False
        rbtCalle.Enabled = False
        rbtCalle.Checked = False
        rbtPistayCampo.Enabled = False
        rbtPistayCampo.Checked = False
        grbTipoCompetencia.Enabled = False
        'txtCodigoCompetencia.Visible = False
        'Label4.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        cboJuez1.Visible = False
        cboJuez2.Visible = False
        cboJuez3.Visible = False
        cboUsuario.Visible = False
        juezprincipal1()
        juezprincipal2()
        juezprincipal3()
        UsuarioPrincipal()
        Select Case TipoDeFormulario

            Case TipoFormulario.Alta

                btnCrear.Enabled = True
                btnActualizar.Enabled = False
                btnCancelar.Enabled = True
                Label13.Visible = False
                txtEstado.Visible = False
                nuevoCodigoCompetencia()
                ListaLocalidadCompetenciaCalle()
                ListaProvinciaCompetencias()
                Disciplinas()
                Pruebas_x_Disciplina()
                grbCalle.Enabled = False
                grbPistayCampo.Enabled = False
                grbTipoCompetencia.Enabled = True
                rbtCalle.Enabled = True
                rbtPistayCampo.Enabled = True
                'Sexo()
               
                Label4.Visible = False
                txtCodigoCompetencia.Visible = False
                Label8.Visible = False
                txtOtra.Visible = False
            Case TipoFormulario.Baja
                ' no hace nada
            Case TipoFormulario.Modificacion

                ' nombre del formulario
                Me.Text = "MODIFICAR DATOS DE LA COMPETENCIA"
                ' botones
                btnCrear.Enabled = False
                btnActualizar.Enabled = True
                btnCancelar.Enabled = True
                'carga de combobox
                ListaProvinciaCompetencias()
                'cboProvinciaCompetencia.SelectedValue = CompetenciaSeleccionada.id_provincia
                ListaLocalidadCompetenciaCalle()
                'cboLocalidadCompetenciaCalle.SelectedValue = CompetenciaSeleccionada.id_localidad
                Disciplinas()
                'cboDisciplinas.SelectedValue = CompetenciaSeleccionada.id_disciplina
                Pruebas_x_Disciplina()
                'cboPruebas.SelectedValue = CompetenciaSeleccionada.id_prueba
              
                ' activacion y desactivacion de botones y textbox en competencia de calle
                If LISTACOMPETENCIAS.rbtDistancia.Checked = True Then
                    rbtCalle.Enabled = True
                    rbtCalle.Checked = True
                    rbtPistayCampo.Checked = False
                    rbtPistayCampo.Enabled = False
                    grbPistayCampo.Enabled = False
                End If
                'LISTACOMPETENCIAS.Close()
                ' activacion y desactivacion de botones y textbox en competencia de pista y campo
                If LISTACOMPETENCIAS.rbtDisciplina.Checked = True Then
                    rbtCalle.Checked = False
                    rbtCalle.Enabled = False
                    rbtPistayCampo.Checked = True
                    rbtPistayCampo.Enabled = True
                    grbPistayCampo.Enabled = True
                    grbCalle.Enabled = False
                End If

                ' activacion y desactivacion de botones y textbox en todas competencias
                If LISTACOMPETENCIAS.rbtTodas.Checked = True And txtDistanciaCompetenciaCalle.Text = 0 Then
                    rbtCalle.Enabled = False
                    rbtCalle.Checked = False
                    rbtPistayCampo.Checked = True
                    rbtPistayCampo.Enabled = True
                    grbPistayCampo.Enabled = True
                End If

                If LISTACOMPETENCIAS.rbtTodas.Checked = True And txtDistanciaCompetenciaCalle.Text <> 0 Then
                    rbtCalle.Checked = False
                    rbtCalle.Enabled = False
                    rbtPistayCampo.Checked = True
                    rbtPistayCampo.Enabled = True
                    grbPistayCampo.Enabled = True
                End If
                RellenarCampos()
                capanegocio.ActualizarCompetencia(CompetenciaSeleccionada)
        End Select
    End Sub

    'Sub Sexo()
    '    cboSexo.DisplayMember = "Sexo"
    '    cboSexo.ValueMember = "Id_Sexo"
    '    cboSexo.DataSource = capanegocio.Sexoatleta.Tables("Sexo")
    '    cboSexo.SelectedIndex = 3
    'End Sub

    Private Sub CREACIONDECOMPETENCIAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Sub nuevoCodigoCompetencia()
        txtCodigoCompetencia.Text = capanegocio.nuevoCodigoCompetencia
    End Sub

    Sub ListaProvinciaCompetencias()
        cboProvinciaCompetencia.DisplayMember = "Nombre_Provincia"
        cboProvinciaCompetencia.ValueMember = "Id_Provincia"
        cboProvinciaCompetencia.DataSource = capanegocio.ListaProvinciaCompetencias.Tables("Lista Provincias Competencias")
        cboProvinciaCompetencia.SelectedIndex = 22

        'ESTO LO HIZO EL PROFE!!!!
        'si yo quiero que la provincia por defecto sea cordoba

        'Dim i As Integer = 0
        'For Each item As DataRowView In cboprovclub.Items
        '    Dim id_provincia_actual = item.Row("Id_Provincia")
        '    If id_provincia_actual = ID_PROVINCIA_DEFAULT Then
        '        cboprovclub.SelectedIndex = i
        '        Return
        '    End If
        '    i = i + 1
        'Next
        'cboprovclub.SelectedIndex = 0
    End Sub

    Sub ListaLocalidadCompetenciaCalle()
        'limpiamos el combo
        cboLocalidadCompetenciaCalle.DataSource = Nothing
        If (Me.cboProvinciaCompetencia.SelectedValue Is Nothing) Then 'si no hay ninguna provincia seleccionada salgo
            Return
        End If
        With cboLocalidadCompetenciaCalle
            .DisplayMember = "Nombre_Localidad"
            .ValueMember = "Id_Localidad"
            'lleno el combo con el listado de localidades filtrado por provincia
            .DataSource = capanegocio.ListaLocalidadCompetencia(Me.cboProvinciaCompetencia.SelectedValue).Tables(0)
        End With
    End Sub

    Private Sub cboProvinciaCompetenciaCalle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboProvinciaCompetencia.SelectedIndexChanged
        ListaLocalidadCompetenciaCalle()
    End Sub

    Sub Disciplinas()
        cboDisciplinas.DisplayMember = "Nombre_Disciplina"
        cboDisciplinas.ValueMember = "Id_Disciplina"
        cboDisciplinas.DataSource = capanegocio.Disciplinas.Tables("Lista de Disciplinas")
        cboDisciplinas.SelectedIndex = 8
    End Sub

    Sub Pruebas_x_Disciplina()
        'limpiamos el combo
        cboPruebas.DataSource = Nothing
        If (Me.cboDisciplinas.SelectedValue Is Nothing) Then 'si no hay ninguna combo seleccionada salgo
            Return
        End If
        With cboPruebas
            .DisplayMember = "Nombre_Prueba"
            .ValueMember = "Id_Prueba"
            'lleno el combo con el listado de listado de combos filtrados
            .DataSource = capanegocio.Pruebas_x_Disciplina(Me.cboDisciplinas.SelectedValue).Tables(0)
        End With
    End Sub

    Function getIdCompetencia() As Integer
        Return txtCodigoCompetencia.Text
    End Function

    Function getNombreCompetencia() As String
        Return txtNombreCompetencia.Text
    End Function

    Function getLugarCompetencia() As String
        Return txtLugarCompetenciaCalle.Text
    End Function

    Function getDistanciaCompetencia() As Integer
        Return txtDistanciaCompetenciaCalle.Text
    End Function

    Function getFechaInicioCompetencia() As Date
        Return dtpFechaInicioCompetenciaCalle.Text
    End Function

    Function getHoraInicioCompetencia() As String
        Return txtHora.Text
    End Function

    Function getIdProvinciaCompetencia() As Integer
        Return cboProvinciaCompetencia.SelectedValue
    End Function

    Function getIdLocalidadCompetencia() As Integer
        Return cboLocalidadCompetenciaCalle.SelectedValue
    End Function

    Function getidprueba() As Integer
        Return cboPruebas.SelectedValue
    End Function

    Function getIdDisciplina() As Integer
        Return cboDisciplinas.SelectedValue
    End Function

    Function getOtra() As String
        Return txtOtra.Text
    End Function

    Function getIdJuez1() As Integer
        Return cboJuez1.SelectedValue
    End Function

    Function getIdJuez2() As Integer
        Return cboJuez2.SelectedValue
    End Function

    Function getIdJuez3() As Integer
        Return cboJuez3.SelectedValue
    End Function

    Function getIdUsuario() As Integer
        Return cboUsuario.SelectedValue
    End Function

    Function getEstado() As String
        Return txtEstado.Text
    End Function
  
    Private Sub btnCrearCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click

        'VALIDACION DE CAMPOS DE LA COMPETENCIA
        If txtNombreCompetencia.Text = "" Then
            MessageBox.Show("Asegúrese de haber llenado el campo Nombre Competencia")
            txtNombreCompetencia.Focus()
            Return
        End If
        If txtLugarCompetenciaCalle.Text = "" Then
            MessageBox.Show("Asegúrese de haber llenado el campo Lugar Competencia")
            txtLugarCompetenciaCalle.Focus()
            Return
        End If
        If cboProvinciaCompetencia.Text = "--Seleccionar--" Then
            MessageBox.Show("seleccione una Provincia")
            cboProvinciaCompetencia.Focus()
            Return
        End If

        If txtHora.Text = "" Then
            MessageBox.Show("Asegúrese de haber llenado el campo Hora de la Competencia")
            txtHora.Focus()
            Return
        End If

        If rbtCalle.Checked = False And rbtPistayCampo.Checked = False Then
            MessageBox.Show("Asegúrese de haber seleccionado un tipo de Competencia")
            rbtCalle.Focus()
            Return
        End If
        If rbtCalle.Checked = True And txtDistanciaCompetenciaCalle.Text = 0 Then
            MessageBox.Show("Asegúrese de completado la Distancia a recorrer, ésta no puede ser 0")
            txtDistanciaCompetenciaCalle.Focus()
            Return
        End If
        If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "--Seleccionar--" Then
            MessageBox.Show("Debe seleccionar una Disciplina")
            cboDisciplinas.Focus()
            Return
        End If

        Dim objeto As New CECompetencias ' llena los valores y los envia a la clase usuarios por medio del objeto
        ' objeto.id_competencia = getIdCompetencia()
        objeto.Nombre_competencia = getNombreCompetencia()
        objeto.lugar_competencia = getLugarCompetencia()
        objeto.distancia = getDistanciaCompetencia()
        objeto.fecha_inicio = getFechaInicioCompetencia()
        objeto.hora_inicio = getHoraInicioCompetencia()
        objeto.id_provincia = getIdProvinciaCompetencia()
        objeto.id_localidad = getIdLocalidadCompetencia()
        objeto.id_disciplina = getIdDisciplina()
        objeto.id_prueba = getidprueba()
        objeto.otra = getOtra()
        objeto.juez1 = getIdJuez1()
        objeto.juez2 = getIdJuez2()
        objeto.juez3 = getIdUsuario()
        objeto.id_usuario = getIdUsuario()
        objeto.Estado_Competencia = getEstado()
        Try
            '   capanegocio.NuevaCompetencia(objeto) ' el objeto salta a la capa de negocio (ojbu), va al daousuarios a objusu y llena el formulario

            txtCodigoCompetencia.Clear() 'borra campo codigo
            nuevoCodigoCompetencia() ' llama a procedimiento q carga el nuevo codigo
            btnCrear.Enabled = False
            MsgBox("La Competencia ha sido registrada correctamente", MsgBoxStyle.Information)

            'ABRE PLANILLA DE CALLE
            If rbtCalle.Checked = True Then

                'guardo el id de competencia PABLOOOOOOOOO
                PLANILLACOMPETENCIACALLE.txtCodigoPlanillaCalle.Text = Me.txtCodigoCompetencia.Text
                PLANILLACOMPETENCIACALLE.txtNombre.Text = Me.txtNombreCompetencia.Text
                PLANILLACOMPETENCIACALLE.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PLANILLACOMPETENCIACALLE.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PLANILLACOMPETENCIACALLE.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PLANILLACOMPETENCIACALLE.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PLANILLACOMPETENCIACALLE.txtHora.Text = Me.txtHora.Text
                PLANILLACOMPETENCIACALLE.txtDistanciaCompetenciaCalle.Text = Me.txtDistanciaCompetenciaCalle.Text
                PLANILLACOMPETENCIACALLE.txtEstado.Text = Me.txtEstado.Text
                'PLANILLACOMPETENCIACALLE.cboJuez1.Text = Me.cboJuez1.Text
                'PLANILLACOMPETENCIACALLE.cboJuez2.Text = Me.cboJuez2.Text
                'PLANILLACOMPETENCIACALLE.cboJuez3.Text = Me.cboJuez3.Text
                PLANILLACOMPETENCIACALLE.cboUsuario.Text = Me.cboUsuario.Text
                PLANILLACOMPETENCIACALLE.ShowDialog()
            End If

            'ABRE PLANILLA DE LANZAMIENTO
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Lanzamiento" Then

                PLANILLADELANZAMIENTOS.txtCodigoLanzamiento.Text = Me.txtCodigoCompetencia.Text
                PLANILLADELANZAMIENTOS.txtNombre.Text = Me.txtNombreCompetencia.Text
                PLANILLADELANZAMIENTOS.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PLANILLADELANZAMIENTOS.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PLANILLADELANZAMIENTOS.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PLANILLADELANZAMIENTOS.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PLANILLADELANZAMIENTOS.txtHora.Text = Me.txtHora.Text
                PLANILLADELANZAMIENTOS.txtEstado.Text = Me.txtEstado.Text
                PLANILLADELANZAMIENTOS.cboJuez1.Text = Me.cboJuez1.Text
                PLANILLADELANZAMIENTOS.cboUsuario.Text = Me.cboUsuario.Text
                PLANILLADELANZAMIENTOS.cboPrueba.Text = Me.cboPruebas.Text

                PLANILLADELANZAMIENTOS.ShowDialog()
            End If
            'ABRE PLANILLA DE CROSS COUNTRY
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Cross Country" Then
                PlanillaCrossCountry.txtCodigoPlanillaCrossCountry.Text = Me.txtCodigoCompetencia.Text
                PlanillaCrossCountry.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanillaCrossCountry.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanillaCrossCountry.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanillaCrossCountry.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanillaCrossCountry.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanillaCrossCountry.txtHora.Text = Me.txtHora.Text
                PlanillaCrossCountry.txtEstado.Text = Me.txtEstado.Text
                PlanillaCrossCountry.cboJuez1.Text = Me.cboJuez1.Text
                PlanillaCrossCountry.cboJuez2.Text = Me.cboJuez2.Text
                PlanillaCrossCountry.cboJuez3.Text = Me.cboJuez3.Text
                PlanillaCrossCountry.cboUsuario.Text = Me.cboUsuario.Text
                PlanillaCrossCountry.cboPrueba.Text = Me.cboPruebas.Text

                PlanillaCrossCountry.ShowDialog()
            End If
            'ABRE PLANILLA DE FONDO
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Fondo" Then
                PlanilladeFondo.txtcodigofondo.Text = Me.txtCodigoCompetencia.Text
                PlanilladeFondo.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanilladeFondo.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanilladeFondo.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanilladeFondo.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanilladeFondo.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanilladeFondo.txtHora.Text = Me.txtHora.Text
                PlanilladeFondo.txtEstado.Text = Me.txtEstado.Text
                PlanilladeFondo.cboJuez1.Text = Me.cboJuez1.Text
                PlanilladeFondo.cboJuez2.Text = Me.cboJuez2.Text
                PlanilladeFondo.cboJuez3.Text = Me.cboJuez3.Text
                PlanilladeFondo.cboUsuario.Text = Me.cboUsuario.Text
                PlanilladeFondo.cboPrueba.Text = Me.cboPruebas.Text

                PlanilladeFondo.ShowDialog()
            End If
            'ABRE PLANILLA DE MARATON
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Maratón" Then
                PlanillaMaraton.txtCodigoMaraton.Text = Me.txtCodigoCompetencia.Text
                PlanillaMaraton.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanillaMaraton.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanillaMaraton.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanillaMaraton.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanillaMaraton.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanillaMaraton.txtHora.Text = Me.txtHora.Text
                PlanillaMaraton.txtEstado.Text = Me.txtEstado.Text
                PlanillaMaraton.cboJuez1.Text = Me.cboJuez1.Text
                PlanillaMaraton.cboJuez2.Text = Me.cboJuez2.Text
                PlanillaMaraton.cboJuez3.Text = Me.cboJuez3.Text
                PlanillaMaraton.cboUsuario.Text = Me.cboUsuario.Text
                PlanillaMaraton.cboPrueba.Text = Me.cboPruebas.Text

                PlanillaMaraton.ShowDialog()
            End If
            'ABRE PLANILLA DE MARCHA
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Marcha" Then
                PlanilladeMarcha.txtCodigoMarcha.Text = Me.txtCodigoCompetencia.Text
                PlanilladeMarcha.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanilladeMarcha.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanilladeMarcha.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanilladeMarcha.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanilladeMarcha.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanilladeMarcha.txtHora.Text = Me.txtHora.Text
                PlanilladeMarcha.txtEstado.Text = Me.txtEstado.Text
                PlanilladeMarcha.cboJuez1.Text = Me.cboJuez1.Text
                PlanilladeMarcha.cboJuez2.Text = Me.cboJuez2.Text
                PlanilladeMarcha.cboJuez3.Text = Me.cboJuez3.Text
                PlanilladeMarcha.cboUsuario.Text = Me.cboUsuario.Text
                PlanilladeMarcha.cboPrueba.Text = Me.cboPruebas.Text

                PlanilladeMarcha.ShowDialog()
            End If
            'ABRE PLANILLA DE MEDIO FONDO
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Medio Fondo" Then
                PlanilladeMedioFondo.txtCodigoMedioFondo.Text = Me.txtCodigoCompetencia.Text
                PlanilladeMedioFondo.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanilladeMedioFondo.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanilladeMedioFondo.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanilladeMedioFondo.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanilladeMedioFondo.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanilladeMedioFondo.txtHora.Text = Me.txtHora.Text
                PlanilladeMedioFondo.txtEstado.Text = Me.txtEstado.Text
                PlanilladeMedioFondo.cboJuez1.Text = Me.cboJuez1.Text
                PlanilladeMedioFondo.cboJuez2.Text = Me.cboJuez2.Text
                PlanilladeMedioFondo.cboJuez3.Text = Me.cboJuez3.Text
                PlanilladeMedioFondo.cboUsuario.Text = Me.cboUsuario.Text
                PlanilladeMedioFondo.cboPrueba.Text = Me.cboPruebas.Text

                PlanilladeMedioFondo.ShowDialog()
            End If
            'ABRE PLANILLA DE OBSTACULOS
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Obstáculos" Then
                PlanilladeObstáculos.txtCodigoObstaculos.Text = Me.txtCodigoCompetencia.Text
                PlanilladeObstáculos.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanilladeObstáculos.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanilladeObstáculos.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanilladeObstáculos.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanilladeObstáculos.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanilladeObstáculos.txtHora.Text = Me.txtHora.Text
                PlanilladeObstáculos.txtEstado.Text = Me.txtEstado.Text
                PlanilladeObstáculos.cboJuez1.Text = Me.cboJuez1.Text
                PlanilladeObstáculos.cboJuez2.Text = Me.cboJuez2.Text
                PlanilladeObstáculos.cboJuez3.Text = Me.cboJuez3.Text
                PlanilladeObstáculos.cboUsuario.Text = Me.cboUsuario.Text
                PlanilladeObstáculos.cboPrueba.Text = Me.cboPruebas.Text

                PlanilladeObstáculos.ShowDialog()
            End If
            'ABRE PLANILLA DE SALTO EN ALTO
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Salto" And cboPruebas.Text = "Alto" Then
                PlanillaSaltoenAltoyGarrocha.txtCodigoSalto.Text = Me.txtCodigoCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.txtHora.Text = Me.txtHora.Text
                PlanillaSaltoenAltoyGarrocha.txtEstado.Text = Me.txtEstado.Text
                PlanillaSaltoenAltoyGarrocha.cboJuez1.Text = Me.cboJuez1.Text
                PlanillaSaltoenAltoyGarrocha.cboUsuario.Text = Me.cboUsuario.Text
                PlanillaSaltoenAltoyGarrocha.cboPrueba.Text = Me.cboPruebas.Text

                PlanillaSaltoenAltoyGarrocha.ShowDialog()
            End If
            'ABRE PLANILLA SALTO CON GARROCHA
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Salto" And cboPruebas.Text = "Garrocha" Then
                PlanillaSaltoenAltoyGarrocha.txtCodigoSalto.Text = Me.txtCodigoCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanillaSaltoenAltoyGarrocha.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanillaSaltoenAltoyGarrocha.txtHora.Text = Me.txtHora.Text
                PlanillaSaltoenAltoyGarrocha.txtEstado.Text = Me.txtEstado.Text
                PlanillaSaltoenAltoyGarrocha.cboJuez1.Text = Me.cboJuez1.Text
                PlanillaSaltoenAltoyGarrocha.cboUsuario.Text = Me.cboUsuario.Text
                PlanillaSaltoenAltoyGarrocha.cboPrueba.Text = Me.cboPruebas.Text

                PlanillaSaltoenAltoyGarrocha.ShowDialog()
            End If
            'ABRE PLANILLA DE SALTO EN LARGO
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Salto" And cboPruebas.Text = "Largo" Then
                PLANILLASALTOENLARGOYTRIPLE.txtCodigoSalto.Text = Me.txtCodigoCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.txtNombre.Text = Me.txtNombreCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.txtHora.Text = Me.txtHora.Text
                PLANILLASALTOENLARGOYTRIPLE.txtEstado.Text = Me.txtEstado.Text
                PLANILLASALTOENLARGOYTRIPLE.cboJuez1.Text = Me.cboJuez1.Text
                PLANILLASALTOENLARGOYTRIPLE.cboUsuario.Text = Me.cboUsuario.Text
                PLANILLASALTOENLARGOYTRIPLE.cboPrueba.Text = Me.cboPruebas.Text

                PLANILLASALTOENLARGOYTRIPLE.ShowDialog()
            End If
            'ABRE PLANILLA DE SALTO TRIPLE
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Salto" And cboPruebas.Text = "Triple" Then
                PLANILLASALTOENLARGOYTRIPLE.txtCodigoSalto.Text = Me.txtCodigoCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.txtNombre.Text = Me.txtNombreCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PLANILLASALTOENLARGOYTRIPLE.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PLANILLASALTOENLARGOYTRIPLE.txtHora.Text = Me.txtHora.Text
                PLANILLASALTOENLARGOYTRIPLE.txtEstado.Text = Me.txtEstado.Text
                PLANILLASALTOENLARGOYTRIPLE.cboJuez1.Text = Me.cboJuez1.Text
                PLANILLASALTOENLARGOYTRIPLE.cboUsuario.Text = Me.cboUsuario.Text
                PLANILLASALTOENLARGOYTRIPLE.cboPrueba.Text = Me.cboPruebas.Text

                PLANILLASALTOENLARGOYTRIPLE.ShowDialog()
            End If
            'ABRE PLANILLA DE VELOCIDAD
            If rbtPistayCampo.Checked = True And cboDisciplinas.Text = "Velocidad" Then
                PlanillaDeVelocidad.txtCodigoVelocidad.Text = Me.txtCodigoCompetencia.Text
                PlanillaDeVelocidad.txtNombre.Text = Me.txtNombreCompetencia.Text
                PlanillaDeVelocidad.txtLugar.Text = Me.txtLugarCompetenciaCalle.Text
                PlanillaDeVelocidad.cboProvincia.Text = Me.cboProvinciaCompetencia.Text
                PlanillaDeVelocidad.cboLocalidad.Text = Me.cboLocalidadCompetenciaCalle.Text
                PlanillaDeVelocidad.dtpfechainicio.Text = Me.dtpFechaInicioCompetenciaCalle.Text
                PlanillaDeVelocidad.txtHora.Text = Me.txtHora.Text
                PlanillaDeVelocidad.txtEstado.Text = Me.txtEstado.Text
                PlanillaDeVelocidad.cboJuez1.Text = Me.cboJuez1.Text
                PlanillaDeVelocidad.cboJuez2.Text = Me.cboJuez2.Text
                PlanillaDeVelocidad.cboJuez3.Text = Me.cboJuez3.Text
                PlanillaDeVelocidad.cboUsuario.Text = Me.cboUsuario.Text
                PlanillaDeVelocidad.cboPrueba.Text = Me.cboPruebas.Text

                PlanillaDeVelocidad.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Error al registrar la Competencia", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

    End Sub

    Private Sub txtNombreCompetenciaCalle_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreCompetencia.TextChanged
        Dim i As Integer
        txtNombreCompetencia.Text = StrConv(txtNombreCompetencia.Text, VbStrConv.ProperCase)
        i = Len(txtNombreCompetencia.Text)
        txtNombreCompetencia.SelectionStart = i
    End Sub

    Private Sub txtLugarCompetenciaCalle_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLugarCompetenciaCalle.TextChanged
        Dim i As Integer
        txtLugarCompetenciaCalle.Text = StrConv(txtLugarCompetenciaCalle.Text, VbStrConv.ProperCase)
        i = Len(txtLugarCompetenciaCalle.Text)
        txtLugarCompetenciaCalle.SelectionStart = i
    End Sub

    Private Sub cboDisciplinaP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Pruebas_x_Disciplina()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboPruebas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If cboPruebas.Text.ToUpper = "Otra".ToUpper Then
            txtOtra.Enabled = True
        End If
    End Sub

    Private Sub rbtCalle_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles rbtCalle.CheckedChanged

        If rbtCalle.Checked = True Then
            grbPistayCampo.Enabled = False
            grbCalle.Enabled = True
            rbtCalle.Enabled = True
            rbtPistayCampo.Checked = False
        End If
    End Sub

    Private Sub rbtPistayCampo_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles rbtPistayCampo.CheckedChanged
        If rbtPistayCampo.Checked = True Then
            grbCalle.Enabled = False
            grbPistayCampo.Enabled = True
            rbtCalle.Checked = False
        End If
    End Sub

    Private Sub btnActualizar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        Try
            CompetenciaSeleccionada.id_competencia = txtCodigoCompetencia.Text
            CompetenciaSeleccionada.Nombre_competencia = txtNombreCompetencia.Text
            CompetenciaSeleccionada.lugar_competencia = txtLugarCompetenciaCalle.Text
            CompetenciaSeleccionada.distancia = txtDistanciaCompetenciaCalle.Text
            CompetenciaSeleccionada.fecha_inicio = dtpFechaInicioCompetenciaCalle.Text
            CompetenciaSeleccionada.hora_inicio = txtHora.Text
            CompetenciaSeleccionada.id_provincia = cboProvinciaCompetencia.SelectedValue
            CompetenciaSeleccionada.id_localidad = cboLocalidadCompetenciaCalle.SelectedValue
            CompetenciaSeleccionada.id_disciplina = cboDisciplinas.SelectedValue
            CompetenciaSeleccionada.id_prueba = cboPruebas.SelectedValue
            CompetenciaSeleccionada.otra = txtOtra.Text
            CompetenciaSeleccionada.juez1 = cboJuez1.SelectedValue
            CompetenciaSeleccionada.juez2 = cboJuez2.SelectedValue
            CompetenciaSeleccionada.juez3 = cboJuez3.SelectedValue
            CompetenciaSeleccionada.id_usuario = cboUsuario.SelectedValue
            CompetenciaSeleccionada.Estado_Competencia = txtEstado.Text

            capanegocio.ActualizarCompetencia(CompetenciaSeleccionada)

            MsgBox(" Los datos de la Competencia han sido actualizados correctamente")
            Me.Hide()
            LISTACOMPETENCIAS.ShowDialog()

        Catch ex As Exception
            'MsgBox("Error al actualizar los datos de la Competencia")
        End Try
    End Sub

    Private Sub cboDisciplinas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDisciplinas.SelectedIndexChanged
        Pruebas_x_Disciplina()
    End Sub

    Private Sub cboPruebas_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboPruebas.SelectedIndexChanged
        If cboPruebas.Text = "Otra" Then
            txtOtra.Enabled = True
        Else
            txtOtra.Enabled = False
        End If
    End Sub

End Class
