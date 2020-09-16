Imports System.Data.SqlClient
Imports CAPA_ENTIDAD

Public Class DAOAtletas_x_Competencia
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    'Public Function ListadoAtletasPista() As DataSet
    '    Dim ds As New DataSet
    '    cn = objcon.Conectar
    '    da = New SqlDataAdapter("ListadoAtletasPista", cn)
    '    da.Fill(ds, "Atletas de Pista")
    '    Return ds
    '    ds.Dispose()
    '    da.Dispose()
    '    cn.Dispose()
    'End Function

    'Public Function ListadoAtletasCalle() As DataSet
    '    Dim ds As New DataSet
    '    cn = objcon.Conectar
    '    da = New SqlDataAdapter("ListadoAtletasCalle", cn)
    '    da.Fill(ds, "Atletas de Calle")
    '    Return ds
    '    ds.Dispose()
    '    da.Dispose()
    '    cn.Dispose()
    'End Function

    'Public Function ListadoDeAtletasDTO() As List(Of CEAtletas_x_Competencia)
    '    Dim miDS = listadoatletas()

    '    Dim vectorDeAtletas = New List(Of CEAtletas)()
    '    For Each row In miDS.Tables(0).Rows
    '        Dim at As CEAtletas = New CEAtletas()

    '        AxCId_Atleta = row("Id_Atleta")
    '        AxCId_Atleta_X_Competencia = row("Id_Atleta_X_Competencia")
    '        AxCId_Competencia = row("Id_Competencia")
    '        vectorDeAtletas.Add(at)
    '    Next
    '    Return vectorDeAtletas
    'End Function

    Public Sub Nuevo_Registro_Atleta_x_Competencia(ByRef ObjAxC As CEAtletas_x_Competencia)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("Nuevo_Registro_Atleta_x_Competencia", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Atleta_X_Competencia", SqlDbType.Int).Value = ObjAxC.Id_atleta_x_competencia
                .Add("@Id_Atleta", SqlDbType.Int).Value = ObjAxC.id_atleta
                .Add("@Id_Competencia", SqlDbType.Int).Value = ObjAxC.id_competencia
                .Add("@Id_Resultado_Parcial", SqlDbType.Int).Value = ObjAxC.id_resultado_parcial
                da.SelectCommand.ExecuteNonQuery()  'inserta los valores
                MsgBox("La Planilla se ha guardado correctamente", MsgBoxStyle.Information)
            End With
        Catch ex As Exception
            MsgBox("No se pudo guardar la Planilla", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    Public Function Nuevo_Codigo_Atleta_x_Competencia() As String
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("Nuevo_Codigo_Atleta_x_Competencia", cn)
        Return da.SelectCommand.ExecuteScalar()
    End Function

    Public Sub Eliminar_Atleta_x_Competencia(ByVal cod As Integer)
        Try
            cn = objcon.Conectar
            cmd = New SqlCommand("Eliminar_Atleta_x_Competencia", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Atleta_X_Competencia", SqlDbType.Int).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox("Error" + ex.ToString)
        End Try
    End Sub

    Public Function Lista_Calle_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Calle()
        Dim vector_Calle = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Calle.Add(com)
        Next
        Return vector_Calle
    End Function

    Public Function Lista_Calle() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Calle", cn)
        da.Fill(ds, "Lista_Calle")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Cross_Country_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Cross_Country()
        Dim vector_Cross_Country = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Cross_Country.Add(com)
        Next
        Return vector_Cross_Country
    End Function

    Public Function Lista_Cross_Country() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Cross_Country", cn)
        da.Fill(ds, "Lista_Cross_Country")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Fondo_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Fondo()
        Dim vector_Fondo = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Fondo.Add(com)
        Next
        Return vector_Fondo
    End Function

    Public Function Lista_Fondo() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Fondo", cn)
        da.Fill(ds, "Lista_Fondo")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Lanzamiento_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Lanzamiento()
        Dim vector_Lanzamiento = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Lanzamiento.Add(com)
        Next
        Return vector_Lanzamiento
    End Function

    Public Function Lista_Lanzamiento() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Lanzamiento", cn)
        da.Fill(ds, "Lista_Lanzamiento")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Maraton_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Maraton()
        Dim vector_Maraton = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Maraton.Add(com)
        Next
        Return vector_Maraton
    End Function

    Public Function Lista_Maraton() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Maraton", cn)
        da.Fill(ds, "Lista_Maraton")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Marcha_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Marcha()
        Dim vector_Marcha = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Marcha.Add(com)
        Next
        Return vector_Marcha
    End Function

    Public Function Lista_Marcha() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Marcha", cn)
        da.Fill(ds, "Lista_Marcha")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Medio_Fondo_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Medio_Fondo()
        Dim vector_Medio_Fondo = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Medio_Fondo.Add(com)
        Next
        Return vector_Medio_Fondo
    End Function

    Public Function Lista_Medio_Fondo() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Medio_Fondo", cn)
        da.Fill(ds, "Lista_Medio_Fondo")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Obstaculos_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Obstaculos()
        Dim vector_Obstaculos = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Obstaculos.Add(com)
        Next
        Return vector_Obstaculos
    End Function

    Public Function Lista_Obstaculos() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Obstaculos", cn)
        da.Fill(ds, "Lista_Obstaculos")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Salto_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Salto()
        Dim vector_Salto = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Salto.Add(com)
        Next
        Return vector_Salto
    End Function

    Public Function Lista_Salto() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Salto", cn)
        da.Fill(ds, "Lista_Salto")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Lista_Velocidad_DTO() As List(Of CEAtletas_x_Competencia)
        Dim miDS = Lista_Velocidad()
        Dim vector_Velocidad = New List(Of CEAtletas_x_Competencia)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEAtletas_x_Competencia = New CEAtletas_x_Competencia()
            com.Id_atleta_x_competencia = row("Id_atleta_x_competencia")
            com.id_atleta = row("Id_Atleta")
            com.id_competencia = row("Id_Competencia")
            com.id_resultado_parcial = row("Id_Resultado_Parcial")
            vector_Velocidad.Add(com)
        Next
        Return vector_Velocidad
    End Function

    Public Function Lista_Velocidad() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Velocidad", cn)
        da.Fill(ds, "Lista_Velocidad")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
End Class
