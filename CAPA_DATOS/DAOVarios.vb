Imports System.Data.SqlClient

Public Class DAOVarios
    'implementamos el store procedure de la BD
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Function NombreLocalidadPorId(id_localidad As Object) As String
         
        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("NombreLocalidadPorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@ID_Localidad", SqlDbType.Int).Value = id_localidad
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Nombre_Localidad")
    End Function

    Function NombreSexoPorId(id_sexo As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("NombreSexoPorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_sexo", SqlDbType.Int).Value = id_sexo
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Sexo")
    End Function

    Function NombreClubPorId(id_club As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("NombreClubPorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Nombre_Club")
    End Function

    Function Tiempo1PorId(id_resultado1 As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("Tiempo1PorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_Resultado_Parcial", SqlDbType.Int).Value = id_resultado1
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Tiempo 1")
    End Function
   
    Function Tiempo2PorId(id_resultado2 As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("Tiempo2PorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_Resultado_Parcial", SqlDbType.Int).Value = id_resultado2
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Tiempo 2")
    End Function

    Function Tiempo3PorId(id_resultado3 As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("Tiempo3PorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_Resultado_Parcial", SqlDbType.Int).Value = id_resultado3
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Tiempo 3")
    End Function

    Function TiempoFinalCallePorId(id_resultadofinal As Object) As String

        Dim ds As DataSet = New DataSet()
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("TiempoFinalCallePorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@Id_Resultado_Parcial", SqlDbType.Int).Value = id_resultadofinal
        End With
        da.Fill(ds)
        Return ds.Tables(0).Rows(0)("Tiempo_Final_Calle")
    End Function

    'Function BuscarAtletaPorDni(dni As Object) As String

    '    Dim ds As DataSet = New DataSet()
    '    cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
    '    da = New SqlDataAdapter("BuscarAtletaPorDni", cn)
    '    da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    With da.SelectCommand.Parameters
    '        .Add("@Dni", SqlDbType.Int).Value = dni
    '    End With
    '    da.Fill(ds)
    '    Return ds.Tables(0).Rows(0)("Dni")
    'End Function

    ' PABLOOOOOOOOOOOOOOOOOOOOOOOOO
    Function BuscarCopmPorId(id As Object) As String
        Dim dp As String
        dp = "a"
        Dim ds As DataSet = New DataSet()

        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar

        da = New SqlDataAdapter("BuscarCompPorId", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        With da.SelectCommand.Parameters
            .Add("@id", SqlDbType.Int).Value = id
        End With
        da.Fill(ds)
        'Return ds.Tables(0).Rows(0)("id")
        Return da.ToString = dp

    End Function
End Class
