Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaVelocidad

    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand


    Public Sub NuevaPlanillaVelocidad(ByVal ObjPlanillaVelocidad As CEPlanillaVelocidad)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaVelocidad", cn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Velocidad", SqlDbType.Int).Value = ObjPlanillaVelocidad.id_planilla_velocidad
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaVelocidad.numero
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaVelocidad.Nombre
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaVelocidad.Apellido
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaVelocidad.club
                .Add("@Tiempo1", SqlDbType.DateTime).Value = ObjPlanillaVelocidad.tiempo1
                .Add("@Tiempo2", SqlDbType.DateTime).Value = ObjPlanillaVelocidad.tiempo2
                .Add("@Tiempo3", SqlDbType.DateTime).Value = ObjPlanillaVelocidad.tiempo3
                .Add("@Tiempo_Final_Velocidad", SqlDbType.DateTime).Value = ObjPlanillaVelocidad.tiempo_final
                .Add("@Serie", SqlDbType.Int).Value = ObjPlanillaVelocidad.serie
                .Add("@Clasificación_Velocidad", SqlDbType.Int).Value = ObjPlanillaVelocidad.Clasificacion_Velocidad_Final

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

    Public Function ListadoDePlanillasVelocidadDTO() As List(Of CEPlanillaVelocidad)
        Dim miDS = ListadoPlanillaVelocidad()
        Dim vectorDePlanillaVelocidad = New List(Of CEPlanillaVelocidad)()
        For Each row In miDS.Tables(0).Rows
            Dim vel As CEPlanillaVelocidad = New CEPlanillaVelocidad()
            vel.numero = row("Número")
            vel.Nombre = row("Nombre")
            vel.tiempo1 = row("Tiempo1")
            vel.tiempo2 = row("Tiempo2")
            vel.tiempo3 = row("Tiempo3")
            vel.club = row("Id_Club_Federación")
            vel.tiempo_final = row("Tiempo_Final_Velocidad")
            vel.serie = row("Serie")
            vel.Clasificacion_Velocidad_Final = row("Clasificación")

            vectorDePlanillaVelocidad.Add(vel)
        Next
        Return vectorDePlanillaVelocidad
    End Function

    Public Function ListadoPlanillaVelocidad() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoPlanillaVelocidad", cn)
        da.Fill(ds, "Listado de Velocidad")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function JuezPrincipal() As DataSet 'emite la respuesta solicitada
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

    Public Sub ActualizarPlanillaVelocidad(ByVal Id_planilla_velocidad As Integer,
                               ByVal dorsal As Integer,
                               ByVal nombre As String,
                               ByVal apellido As String,
                               ByVal id_club As Integer,
                               ByVal tiempo1 As DateTime,
                               ByVal tiempo2 As DateTime,
                               ByVal tiempo3 As DateTime,
                               ByVal tiempo_final As DateTime,
                               ByVal serie As Integer,
                               ByVal clasificacion_velocidad As Integer)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ActualizarPlanillaVelocidad", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Calle", SqlDbType.Int).Value = Id_planilla_velocidad
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        cmd.Parameters.Add("@Tiempo1", SqlDbType.DateTime).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.DateTime).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.DateTime).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Velocidad", SqlDbType.DateTime).Value = tiempo_final
        cmd.Parameters.Add("@Serie", SqlDbType.Int).Value = serie
        cmd.Parameters.Add("@Clasifcación_Final_Velocidad", SqlDbType.Int).Value = clasificacion_velocidad
        'Ejecutamos el comando 
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub ActualizarPlanillaVelocidad(ByVal planillavelocidad As CEPlanillaVelocidad)
        ActualizarPlanillaVelocidad(planillavelocidad.id_planilla_velocidad,
                                    planillavelocidad.numero,
                                    planillavelocidad.Nombre,
                                    planillavelocidad.Apellido,
                                    planillavelocidad.club,
                                    planillavelocidad.tiempo1,
                                   planillavelocidad.tiempo2,
                                   planillavelocidad.tiempo3,
                                    planillavelocidad.tiempo_final,
                                    planillavelocidad.serie,
                                    planillavelocidad.Clasificacion_Velocidad_Final)
    End Sub

    Public Sub EliminarPlanillaVelocidad(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaVelocidad", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Velocidad", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try

    End Sub
End Class
