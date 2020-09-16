Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNAtletas_x_Competencia
    Dim objcompetencia As New DAOAtletas_x_Competencia

    Public Sub Nuevo_Registro_Atleta_x_Competencia(ByVal ObjAxC As CEAtletas_x_Competencia)
        objcompetencia.Nuevo_Registro_Atleta_x_Competencia(ObjAxC)
    End Sub

    Public Sub Nuevo_Codigo_Atleta_x_Competencia(ByVal ObjAxC As CEAtletas_x_Competencia)
        objcompetencia.Nuevo_Codigo_Atleta_x_Competencia()
    End Sub

    Public Sub Eliminar_Atleta_x_Competencia(ByVal id As Integer)
        objcompetencia.Eliminar_Atleta_x_Competencia(id)
    End Sub

    Public Function Lista_Calle_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Calle_DTO
    End Function

    Public Function Lista_Calle() As DataSet
        Return objcompetencia.Lista_Calle
    End Function

    Public Function Lista_Cross_Country_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Cross_Country_DTO
    End Function

    Public Function Lista_Cross_Country() As DataSet
        Return objcompetencia.Lista_Cross_Country
    End Function

    Public Function Lista_Fondo_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Fondo_DTO
    End Function

    Public Function Lista_Fondo() As DataSet
        Return objcompetencia.Lista_Fondo
    End Function

    Public Function Lista_Lanzamiento_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Lanzamiento_DTO
    End Function

    Public Function Lista_Lanzamiento() As DataSet
        Return objcompetencia.Lista_Lanzamiento
    End Function

    Public Function Lista_Maraton_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Maraton_DTO
    End Function

    Public Function Lista_Maraton() As DataSet
        Return objcompetencia.Lista_Maraton
    End Function

    Public Function Lista_Marcha_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Marcha_DTO
    End Function

    Public Function Lista_Marcha() As DataSet
        Return objcompetencia.Lista_Marcha
    End Function

    Public Function Lista_Medio_Fondo_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Medio_Fondo_DTO
    End Function

    Public Function Lista_Medio_Fondo() As DataSet
        Return objcompetencia.Lista_Medio_Fondo
    End Function

    Public Function Lista_Obstaculos_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Obstaculos_DTO
    End Function

    Public Function Lista_Obstaculos() As DataSet
        Return objcompetencia.Lista_Obstaculos
    End Function

    Public Function Lista_Salto_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Salto_DTO
    End Function

    Public Function Lista_Salto() As DataSet
        Return objcompetencia.Lista_Salto
    End Function

    Public Function Lista_Velocidad_DTO() As List(Of CEAtletas_x_Competencia)
        Return objcompetencia.Lista_Velocidad_DTO
    End Function

    Public Function Lista_Velocidad() As DataSet
        Return objcompetencia.Lista_Velocidad
    End Function
End Class
