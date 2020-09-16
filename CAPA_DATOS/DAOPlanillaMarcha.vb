Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaMarcha
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaMarcha(ByRef ObjPlanillaMarcha As ceplanillamarcha)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaMarcha", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Marcha", SqlDbType.Int).Value = ObjPlanillaMarcha.id_planilla_marcha
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaMarcha.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaMarcha.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaMarcha.Apellido_atleta
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaMarcha.id_club_federacion
                .Add("@Tiempo1", SqlDbType.DateTime).Value = ObjPlanillaMarcha.Tiempo1
                .Add("@Tiempo2", SqlDbType.DateTime).Value = ObjPlanillaMarcha.Tiempo2
                .Add("@Tiempo3", SqlDbType.DateTime).Value = ObjPlanillaMarcha.Tiempo3
                .Add("@Tiempo_Final_Marcha", SqlDbType.DateTime).Value = ObjPlanillaMarcha.tiempo_final_marcha
                .Add("@Clasificación_Maracha", SqlDbType.Int).Value = ObjPlanillaMarcha.Clasificacion_marcha
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

    Public Sub ActualizarPlanillaMarcha(ByVal Id_planilla_marcha As Integer,
                                    ByVal dorsal As Integer,
                                    ByVal apellido As String,
                                    ByVal nombre As String,
                                    ByVal id_club As Integer,
                                    ByVal tiempo1 As DateTime,
                                    ByVal tiempo2 As DateTime,
                                    ByVal tiempo3 As DateTime,
                                    ByVal tiempo_final As DateTime,
                                    ByRef clasificacion As Integer)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ActualizarPlanillaMarcha", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Marcha", SqlDbType.Int).Value = Id_planilla_marcha
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        cmd.Parameters.Add("@Tiempo1", SqlDbType.DateTime).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.DateTime).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.DateTime).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Marcha", SqlDbType.DateTime).Value = tiempo_final
        cmd.Parameters.Add("@Clasificación_Marcha", SqlDbType.Int).Value = clasificacion
        'Ejecutamos el comando   
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub ActualizarPlanillaMarcha(ByVal PlanillaMaraton As CEPlanillaMarcha)
        ActualizarPlanillaMarcha(PlanillaMaraton.id_planilla_marcha,
                                       PlanillaMaraton.dorsal,
                                       PlanillaMaraton.Apellido_atleta,
                                       PlanillaMaraton.Nombre_atleta,
                                       PlanillaMaraton.id_club_federacion,
                                       PlanillaMaraton.Tiempo1,
                                       PlanillaMaraton.Tiempo2,
                                       PlanillaMaraton.Tiempo3,
                                       PlanillaMaraton.tiempo_final_marcha,
                                       PlanillaMaraton.Clasificacion_marcha
                                       )
    End Sub

    Public Function ListadoDePlanillaMarchaDTO() As List(Of CEPlanillaMarcha)
        Dim miDS = ListadoPlanillaMarcha()
        Dim vectorDePlanillaMarcha = New List(Of CEPlanillaMarcha)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEPlanillaMarcha = New CEPlanillaMarcha()
            com.dorsal = row("Número")
            com.Nombre_atleta = row("Nombre")
            com.Apellido_atleta = row("Apellido")
            com.id_club_federacion = row("Id_Club_Federación")
            com.Tiempo1 = row("Tiempo1")
            com.Tiempo2 = row("Tiempo2")
            com.Tiempo3 = row("Tiempo3")
            com.tiempo_final_marcha = row("Tiempo_Final_Marcha")
            com.Clasificacion_marcha = row("Clasificación_Marcha")

            vectorDePlanillaMarcha.Add(com)
        Next
        Return vectorDePlanillaMarcha
    End Function

    Public Function ListadoPlanillaMarcha() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoPlanillaMarcha", cn)
        da.Fill(ds, "Planilla de Marcha")
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

    Public Sub EliminarPlanillaMarcha(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaMarcha", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Marcha", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try

    End Sub
End Class
