Imports System.Data.SqlClient
Imports System.Configuration

Public Class conexion
    Dim conexion As SqlConnection  'variable global

    'Funcion que devuelva la conexion correcta
    Public Function Conectar() As SqlConnection
        conexion = New SqlConnection("Data Source=VALE\VALERIA;Initial Catalog=TESIS ATLETISMO 2016;Integrated Security=True") ' nuevo objeto de sqlconnection
        Return conexion
    End Function
End Class


