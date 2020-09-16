Public Class CNVarios

    Dim daoVarios As CAPA_DATOS.DAOVarios = New CAPA_DATOS.DAOVarios()

    Public Function NombreLocalidadPorId(id_localidad) As String
        Return daoVarios.NombreLocalidadPorId(id_localidad)
    End Function

    Public Function NombreSexoPorId(id_sexo) As String
        Return daoVarios.NombreSexoPorId(id_sexo)
    End Function

    Public Function NombreClubPorId(id_club) As String
        Return daoVarios.NombreClubPorId(id_club)
    End Function

    Public Function Tiempo1PorId(tiempo1) As String
        Return daoVarios.Tiempo1PorId(tiempo1)
    End Function

    Public Function Tiempo2PorId(tiempo2) As String
        Return daoVarios.Tiempo2PorId(tiempo2)
    End Function

    Public Function Tiempo3PorId(tiempo3) As String
        Return daoVarios.Tiempo3PorId(tiempo3)
    End Function

    Public Function TiempoFinalCallePorId(tiempofinal) As String
        Return daoVarios.TiempoFinalCallePorId(tiempofinal)
    End Function

    'Public Function BuscarAtletaPorDni(dni) As String
    '    Return daoVarios.BuscarAtletaPorDni(dni)
    'End Function
End Class
