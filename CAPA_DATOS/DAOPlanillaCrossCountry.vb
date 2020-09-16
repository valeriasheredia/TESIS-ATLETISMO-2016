Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaCrossCountry
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaCrossCountry(ByRef ObjPlanillaCrossCountry As CEPlanillaCrossCountry)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaCrossCountry", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Cross_Country", SqlDbType.Int).Value = ObjPlanillaCrossCountry.id_planilla_cross_country
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaCrossCountry.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaCrossCountry.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaCrossCountry.Apellido_atleta
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaCrossCountry.id_club_federacion
                .Add("@Tiempo1", SqlDbType.DateTime).Value = ObjPlanillaCrossCountry.Tiempo1
                .Add("@Tiempo2", SqlDbType.DateTime).Value = ObjPlanillaCrossCountry.Tiempo2
                .Add("@Tiempo3", SqlDbType.DateTime).Value = ObjPlanillaCrossCountry.Tiempo3
                .Add("@Tiempo_Final_Cross_Country", SqlDbType.DateTime).Value = ObjPlanillaCrossCountry.tiempo_final_cross_country
                .Add("@Clasificación_Cross_Country", SqlDbType.Int).Value = ObjPlanillaCrossCountry.Clasificacion_Cross_Country
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

    'Public Sub ActualizarPlanillaCrossCountry(ByVal PlanillaCrossCountry As CEPlanillaCrossCountry)
    '    ActualizarPlanillaCrossCountry(PlanillaCrossCountry.id_planilla_cross_country,
    '                                   PlanillaCrossCountry.dorsal,
    '                                   PlanillaCrossCountry.Apellido_atleta,
    '                                     PlanillaCrossCountry.Nombre_atleta,
    '                                     PlanillaCrossCountry.id_club_federacion,
    '                                     PlanillaCrossCountry.Tiempo1,
    '                                     PlanillaCrossCountry.Tiempo2,
    '                                     PlanillaCrossCountry.Tiempo3,
    '                                     PlanillaCrossCountry.tiempo_final_cross_country,
    '    PlanillaCrossCountry.Clasificacion_Cross_Country)
    'End Sub

    Public Sub ActualizarPlanillaCalle(ByVal Id_planilla_cross_country As Integer,
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
        cmd = New SqlCommand("ActualizarPlanillaCrossCountry", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Cross_Country", SqlDbType.Int).Value = Id_planilla_cross_country
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        cmd.Parameters.Add("@Tiempo1", SqlDbType.DateTime).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.DateTime).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.DateTime).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Calle", SqlDbType.DateTime).Value = tiempo_final
        cmd.Parameters.Add("@Clasificación_Cross_Country", SqlDbType.Int).Value = clasificacion
        'Ejecutamos el comando   
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Function ListadoDePlanillasCrossCountryDTO() As List(Of CEPlanillaCrossCountry)
        Dim miDS = ListadoPlanillaCrossCountry()
        Dim vectorDePlanillaCrossCountry = New List(Of CEPlanillaCrossCountry)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEPlanillaCrossCountry = New CEPlanillaCrossCountry()
            com.dorsal = row("Número")
            com.Nombre_atleta = row("Nombre")
            com.Apellido_atleta = row("Apellido")
            com.id_club_federacion = row("Id_Club_Federación")
            com.Tiempo1 = row("Tiempo1")
            com.Tiempo2 = row("Tiempo2")
            com.Tiempo3 = row("Tiempo3")
            com.tiempo_final_cross_country = row("Tiempo_Final_Cross_Country")
            com.Clasificacion_Cross_Country = row("Clasificación_Cross_Country")

            vectorDePlanillaCrossCountry.Add(com)
        Next
        Return vectorDePlanillaCrossCountry
    End Function

    Public Function ListadoPlanillaCrossCountry() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoPlanillaCrossCountry", cn)
        da.Fill(ds, "Planilla de Cross Country")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Sub EliminarPlanillaCrossCountry(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaCrossCountry", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Cross_Country", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try
    End Sub

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
End Class
