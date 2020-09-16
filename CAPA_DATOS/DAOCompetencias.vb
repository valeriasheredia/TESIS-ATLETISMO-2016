Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOCompetencias
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    ' listado de las competencias de calle
    Public Function ListaCompetenciaCalle() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoCompetenciaCalle", cn)
        da.Fill(ds, "Competencias de Calle")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' ultima competencia registrada

    Public Function UltimaCompetencia() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("UltimaCompetencia", cn)
        da.Fill(ds, "Ultima Competencia")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' listado de las competencias de pista

    Public Function ListaCompetenciaPista() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoCompetenciaPista", cn)
        da.Fill(ds, "Listado de Competencias de Pista")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' listado de todas las competencias

    Public Function ListadoTodasCompetencias() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoTodasCompetencias", cn)
        da.Fill(ds, "Todas las Competencias")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function nuevoCodigoCompetencia() As String
        cn = objcon.Conectar 'declaracion de la cadena de conexion
        cn.Open()
        da = New SqlDataAdapter("ULTIMACOMPETENCIA", cn)
        Return da.SelectCommand.ExecuteScalar()
    End Function

    Public Function ListaProvinciaCompetencias() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Provincia_Competencias", cn)
        da.Fill(ds, "Lista Provincias Competencias")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function ListaLocalidadCompetencia() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Localidad_Competencia", cn)
        da.Fill(ds, "Localidades por Provincia Competencias")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Function ListaLocalidadCompetencia(Id_Provincia As Integer) As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        'genero un comando con el nombre del store procedure
        Dim cmd = New SqlCommand("Lista_Localidad_Competencia", cn)
        'genero el paramatero que le voy a pasar al SP
        Dim parametro1 = New SqlParameter("@Id_Provincia", Id_Provincia)
        cmd.CommandType = CommandType.StoredProcedure
        'Agrego los parametros
        cmd.Parameters.Add(parametro1)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Localidades por Provincia Competencias")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function ListaUsuariosCompetencia() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Usuarios_Competencia", cn)
        da.Fill(ds, "Lista de Usuarios para la Competencia")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Disciplinas() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Disciplinas", cn)
        da.Fill(ds, "Lista de Disciplinas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function UsuarioPrincipal() As DataSet 'emite la respuesta solicitada
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("UsuarioPrincipal", cn)
        da.Fill(ds, "Apellido de Usuario")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function JuezPrincipal1() As DataSet 'emite la respuesta solicitada
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("JuezPrincipal", cn)
        da.Fill(ds, "Apellido de Jueces")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function JuezPrincipal2() As DataSet 'emite la respuesta solicitada
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("JuezPrincipal", cn)
        da.Fill(ds, "Apellido de Jueces")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function JuezPrincipal3() As DataSet 'emite la respuesta solicitada
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("JuezPrincipal", cn)
        da.Fill(ds, "Apellido de Jueces")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Dim ds As New DataSet
    '    cn = objcon.Conectar
    '    cn.Open()
    '    da = New SqlDataAdapter("Sexoatleta", cn)
    '    da.Fill(ds, "Sexo")
    '    Return ds
    '    ds.Dispose()
    '    da.Dispose()
    '    cn.Dispose()
    'End Function

    Public Sub NuevaCompetencia(ByRef ObjCom As CECompetencias)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NUEVACOMPETENCIA", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Competencia", SqlDbType.Int).Value = ObjCom.id_competencia
                .Add("@Nombre_Competencia", SqlDbType.VarChar).Value = ObjCom.Nombre_competencia
                .Add("@Lugar_Competencia", SqlDbType.VarChar).Value = ObjCom.lugar_competencia
                .Add("@Distancia", SqlDbType.Int).Value = ObjCom.distancia
                .Add("@Fecha_Inicio", SqlDbType.Date).Value = ObjCom.fecha_inicio
                .Add("@Hora_Inicio", SqlDbType.VarChar).Value = ObjCom.hora_inicio
                .Add("@Id_Provincia", SqlDbType.Int).Value = ObjCom.id_provincia
                .Add("@Id_Localidad", SqlDbType.Int).Value = ObjCom.id_localidad
                .Add("@Id_Disciplina", SqlDbType.Int).Value = ObjCom.id_disciplina
                .Add("@Id_Prueba", SqlDbType.Int).Value = ObjCom.id_prueba
                .Add("@Otra", SqlDbType.VarChar).Value = ObjCom.otra
                .Add("@Id_Juez1", SqlDbType.Int).Value = ObjCom.juez1
                .Add("@Id_Juez2", SqlDbType.Int).Value = ObjCom.juez2
                .Add("@Id_Juez3", SqlDbType.Int).Value = ObjCom.juez3
                .Add("@Id_Usuario", SqlDbType.Int).Value = ObjCom.id_usuario
                .Add("@Estado_Competencia", SqlDbType.VarChar).Value = ObjCom.Estado_Competencia

            End With
            da.SelectCommand.ExecuteNonQuery()  'inserta los valores
            da.SelectCommand.CommandType = CommandType.Text
            da.SelectCommand.CommandText = "select @@IDENTITY"
            Dim ds As DataSet = New DataSet
            da.Fill(ds)
            ObjCom.id_competencia = ds.Tables(0)(0)(0)

        Catch ex As Exception
            Throw ex
            MsgBox("Error al registrar la Competencia", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    Function Pruebas_x_Disciplina(Id_Disciplina As Integer) As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        'genero un comando con el nombre del store procedure
        Dim cmd = New SqlCommand("Pruebas_x_Disciplina", cn)
        'genero el paramatero que le voy a pasar al SP
        Dim parametro1 = New SqlParameter("@Id_Disciplina", Id_Disciplina)
        cmd.CommandType = CommandType.StoredProcedure
        'Agrego los parametros
        cmd.Parameters.Add(parametro1)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Pruebas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Pruebas() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Pruebas", cn)
        da.Fill(ds, "Lista de Pruebas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
    ' profe
    Function ListadoTodasCompetencias(id_competencia As Integer) As DataTable
        'TODO: hacer el store procedure correspondiente que filtre por id_competencia
        'Ojo al piojo!!!!!
        Dim ds = ListadoTodasCompetencias()
        Dim dview As New DataView(ds.Tables(0))
        dview.RowFilter = "[id_competencia]=" + id_competencia.ToString()
        Return dview.Table
    End Function

    Public Sub ActualizarCompetencia(ByVal id_competencia As Integer,
                               ByVal nombre_competencia As String,
                               ByVal lugar_competencia As String,
                               ByVal distancia As Integer,
                               ByVal fecha_inicio As Date,
                               ByVal hora_inicio As String,
                               ByVal id_provincia As Integer,
                               ByVal id_localidad As Integer,
                               ByVal id_disciplina As Integer,
                               ByVal id_prueba As Integer,
                               ByVal otra As String,
                               ByVal id_juez1 As Integer,
                               ByVal id_juez2 As Integer,
                               ByVal id_juez3 As Integer,
                               ByVal id_usuario As Integer,
                               ByVal estado_competencia As String)
        cn = objcon.Conectar
        cmd = New SqlCommand("ACTUALIZARCOMPETENCIA", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Id_Competencia", SqlDbType.Int).Value = id_competencia
        cmd.Parameters.Add(ObtenerParametroString("@Nombre_Competencia", nombre_competencia))
        cmd.Parameters.Add(ObtenerParametroString("@Lugar_Competencia", lugar_competencia))
        cmd.Parameters.Add("@Distancia", SqlDbType.Int).Value = distancia  '           
        cmd.Parameters.Add("@Fecha_Inicio", SqlDbType.Date).Value = fecha_inicio
        cmd.Parameters.Add(ObtenerParametroString("@Hora_Inicio", hora_inicio))
        cmd.Parameters.Add("@Id_Provincia", SqlDbType.Int).Value = id_provincia
        cmd.Parameters.Add("@Id_Localidad", SqlDbType.Int).Value = id_localidad
        cmd.Parameters.Add("@Id_Disciplina", SqlDbType.Int).Value = id_disciplina
        cmd.Parameters.Add("@Id_Prueba", SqlDbType.Int).Value = id_prueba
        cmd.Parameters.Add(ObtenerParametroString("@Otra", otra))
        cmd.Parameters.Add("Id_Juez1", SqlDbType.Int).Value = id_juez1
        cmd.Parameters.Add("Id_Juez2", SqlDbType.Int).Value = id_juez2
        cmd.Parameters.Add("Id_Juez3", SqlDbType.Int).Value = id_juez3
        cmd.Parameters.Add("Id_Usuario", SqlDbType.Int).Value = id_usuario
        cmd.Parameters.Add(ObtenerParametroString("@Estado_Competencia", estado_competencia))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub ActualizarCompetencia(ByVal competencia As CECompetencias)

        ActualizarCompetencia(competencia.id_competencia,
                          competencia.Nombre_competencia,
                          competencia.lugar_competencia,
                          competencia.distancia,
                          competencia.fecha_inicio,
                          competencia.hora_inicio,
                          competencia.id_provincia,
                          competencia.id_localidad,
                          competencia.id_disciplina,
                          competencia.id_prueba,
                          competencia.otra,
                          competencia.juez1,
                          competencia.juez2,
                          competencia.juez3,
                          competencia.id_usuario,
                          competencia.Estado_Competencia)

    End Sub

    Public Sub eliminarCompetencia(ByVal codigo As Integer)
        Try
            cn = objcon.Conectar
            Dim cmd = New SqlCommand("ELIMINARCOMPETENCIA", cn)
            cmd.CommandType = CommandType.StoredProcedure 'tipo de comando
            cmd.Parameters.Add("@Id_Competencia", SqlDbType.Int).Value = codigo
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            'MsgBox("La Competencia ha sido eliminada correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Competencia" + ex.ToString)
        End Try
    End Sub

    Public Function ListaCalle() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("planillacalle", cn)
        da.Fill(ds, "Lista Calle")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function ListadoDeCompetenciasDTO() As List(Of CECompetencias)
        Dim miDS = ListadoTodasCompetencias()
        Dim vectorDeCompetencia = New List(Of CECompetencias)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CECompetencias = New CECompetencias()
            com.distancia = row("Distancia")
            com.fecha_inicio = row("Fecha")
            com.hora_inicio = row("Hora")
            com.id_competencia = row("Id_Competencia")
            com.id_disciplina = row("Id_Disciplina")
            com.id_localidad = row("Id_Localidad")
            com.id_provincia = row("Id_Provincia")
            com.id_prueba = row("Id_Prueba")
            com.lugar_competencia = row("Lugar")
            com.Nombre_competencia = row("Nombre")
            com.otra = row("Otra")
            com.juez1 = row("Id_Juez")
            com.juez2 = row("Id_Juez")
            com.juez3 = row("Id_Juez")
            com.id_usuario = row("Id_Usuario")
            com.Estado_Competencia = row("Estado_Competencia")

            vectorDeCompetencia.Add(com)
        Next
        Return vectorDeCompetencia
    End Function

    Public Function ListadoCompetenciaCalleDTO() As List(Of CECompetencias)
        Dim miDS = ListaCompetenciaCalle()
        Dim vectorCompetenciaCalle = New List(Of CECompetencias)()
        For Each row In miDS.Tables(0).Rows
            Dim calle As CECompetencias = New CECompetencias()
            calle.distancia = row("Distancia")
            calle.fecha_inicio = row("Fecha")
            calle.hora_inicio = row("Hora")
            calle.id_competencia = row("Id_Competencia")
            calle.id_disciplina = row("Id_Disciplina")
            calle.id_localidad = row("Id_Localidad")
            calle.id_provincia = row("Id_Provincia")
            calle.id_prueba = row("Id_Prueba")
            calle.lugar_competencia = row("Lugar")
            calle.Nombre_competencia = row("Nombre")
            calle.otra = row("Otra")
            calle.juez1 = row("Id_Juez1")
            calle.juez2 = row("Id_Juez2")
            calle.juez3 = row("Id_Juez3")
            calle.id_usuario = row("Id_Usuario")
            calle.Estado_Competencia = row("Estado_Competencia")

            vectorCompetenciaCalle.Add(calle)
        Next
        Return vectorCompetenciaCalle
    End Function

    ' controlar el listado de pista, da error en  pista.distancia = row("Distancia")

    Public Function ListadoCompetenciaPistaDTO() As List(Of CECompetencias)
        Dim miDS = ListaCompetenciaPista()
        Dim vectorCompetenciaPista = New List(Of CECompetencias)()
        For Each row In miDS.Tables(0).Rows
            Dim pista As CECompetencias = New CECompetencias()
            pista.distancia = row("Distancia_Recorrida")
            pista.fecha_inicio = row("Fecha")
            pista.hora_inicio = row("Hora")
            pista.id_competencia = row("Código")
            pista.id_disciplina = row("Id_Disciplina")
            pista.id_localidad = row("Id_Localidad")
            pista.id_provincia = row("Id_Provincia")
            pista.id_prueba = row("Id_Prueba")
            pista.lugar_competencia = row("Lugar")
            pista.Nombre_competencia = row("Nombre")
            pista.otra = row("Otra")
            pista.juez1 = row("Id_Juez1")
            pista.juez2 = row("Id_Juez2")
            pista.juez3 = row("Id_Juez3")
            pista.id_usuario = row("Id_Usuario")
            pista.Estado_Competencia = row("Estado_Competencia")
            vectorCompetenciaPista.Add(pista)
        Next
        Return vectorCompetenciaPista
    End Function

    Private Function ObtenerParametroString(nombreParametro As String, valorParametro As String) As SqlParameter
        If valorParametro Is Nothing Then
            Return New SqlParameter(nombreParametro, DBNull.Value)
        Else
            Return New SqlParameter(nombreParametro, valorParametro)
        End If
    End Function

End Class