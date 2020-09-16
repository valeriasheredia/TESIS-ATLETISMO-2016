Imports System.Data.SqlClient
Imports CAPA_ENTIDAD

Public Class DAOIngreso
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    'funcion que permita mostrar el perfil de los usuarios

    Public Function perfilingreso() As DataSet
        Dim ds As New DataSet
        cn = objcon.conectar
        da = New SqlDataAdapter("PERFILINGRESO", cn) ' NOMBRE DEL PROCEDIMIENTO ALMACENADO
        da.Fill(ds, "PERFILINGRESO") 'ELEGIMOS UN NOMBRE O ALIAS
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

End Class
