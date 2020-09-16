
Imports System.Data.Sql
Imports System.Data.SqlClient

Module CombosDependientes

    Public cn As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'
    Sub New()
        Try
            cn = New SqlConnection("Data Source=VALE\VALERIA;Initial catalog= TESIS ATLETISMO 2016; Integrated Security=True")
            cn.Open()
            enunciado = New SqlCommand()
            enunciado.CommandTimeout = 100

        Catch ex As Exception
            MessageBox.Show("error en la conexion: " + ex.ToString)
        End Try
    End Sub

    'Retorna un arreglo con la lista de provincias'
    Function arregloProvincias() As String()

        Dim posicion As Integer = 0
        Dim resultado() As String
        ReDim resultado(numeroprovincia() - 1)
        Dim contador As Integer = 0


        Try
            enunciado = New SqlCommand("select Nombre_provincia from provincia", cn)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                resultado(posicion) = respuesta.Item("Nombre_´provincia")
                posicion += 1
            End While
            respuesta.Close()

        Catch ex As Exception

        End Try
        Return resultado

    End Function


    'Retorna un arreglo con la lista de Localidades'
    Function arregloLocalidad() As String()

        Dim posicion As Integer = 0
        Dim resultado() As String
        ReDim resultado(numeroLocalidad() - 1)
        Dim contador As Integer = 0


        Try
            enunciado = New SqlCommand("select * from localidad", cn)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                resultado(posicion) = respuesta.Item("Nombre_localidad")
                posicion += 1
            End While
            respuesta.Close()

        Catch ex As Exception

        End Try
        Return resultado

    End Function

    'Devuelve el numero de provincias en la base de datos
    Function numeroprovincia() As Integer

        Dim resultado As String = ""
        Dim contador As Integer = 0


        Try
            enunciado = New SqlCommand("select * from provincia", cn)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                contador += 1
            End While
            respuesta.Close()

        Catch ex As Exception

        End Try
        Return contador

    End Function

    'Devuelve el numero de localidades de la base de datos
    Function numerolocalidad() As Integer

        Dim resultado As String = ""
        Dim contador As Integer = 0


        Try
            enunciado = New SqlCommand("select * from localidad", cn)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                contador += 1
            End While
            respuesta.Close()

        Catch ex As Exception

        End Try
        Return contador

    End Function

End Module



