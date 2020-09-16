Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaMedioFondo

    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaMedioFondo(ByRef ObjPlanillaMedioFondo As CEPlanillaMedioFondo)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaMedioFondo", cn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Medio_Fondo", SqlDbType.Int).Value = ObjPlanillaMedioFondo.id_planilla_medio_fondo
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaMedioFondo.numero
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaMedioFondo.Nombre
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaMedioFondo.Apellido
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaMedioFondo.club
                .Add("@Tiempo1", SqlDbType.DateTime).Value = ObjPlanillaMedioFondo.tiempo1
                .Add("@Tiempo2", SqlDbType.DateTime).Value = ObjPlanillaMedioFondo.tiempo2
                .Add("@Tiempo3", SqlDbType.DateTime).Value = ObjPlanillaMedioFondo.tiempo3
                .Add("@Tiempo_Final_Medio_Fondo", SqlDbType.DateTime).Value = ObjPlanillaMedioFondo.Tiempo_final
                .Add("@Serie", SqlDbType.Int).Value = ObjPlanillaMedioFondo.serie
                .Add("@Clasificación_Medio_Fondo", SqlDbType.Int).Value = ObjPlanillaMedioFondo.Clasificacion_Medio_Fondo_Final
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

    Public Function ListadoDePlanillaMedioFondoDTO() As List(Of CEPlanillaMedioFondo)
        Dim miDS = PlanillaMedioFondo()
        Dim vectorDePlanillaMedioFondo = New List(Of CEPlanillaMedioFondo)()
        For Each row In miDS.Tables(0).Rows
            Dim vel As CEPlanillaMedioFondo = New CEPlanillaMedioFondo()
            vel.numero = row("Número")
            vel.Nombre = row("Nombre")
            vel.Apellido = row("Apellido")
            vel.tiempo1 = row("Tiempo1")
            vel.tiempo2 = row("Tiempo2")
            vel.tiempo3 = row("Tiempo3")
            vel.Tiempo_final = row("Tiempo_Final_Medio_Fondo")
            vel.serie = row("Serie")
            vel.Clasificacion_Medio_Fondo_Final = row("Clasificación_Medio_Fondo")

            vectorDePlanillaMedioFondo.Add(vel)
        Next
        Return vectorDePlanillaMedioFondo
    End Function

    Public Function PlanillaMedioFondo() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoPlanillaMedioFondo", cn)
        da.Fill(ds, "Planilla de Medio Fondo")
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

    Public Sub ActualizarPlanillaMedioFondo(ByVal Id_planilla_medio_fondo As Integer,
                              ByVal dorsal As Integer,
                              ByVal nombre As String,
                              ByVal apellido As String,
                              ByVal id_club As Integer,
                              ByVal tiempo1 As DateTime,
                              ByVal tiempo2 As DateTime,
                              ByVal tiempo3 As DateTime,
                              ByVal tiempo_final_medio_fondo As DateTime,
                              ByVal serie As Integer,
                              ByVal clasificacion_medio_fondo As Integer)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ActualizarPlanillaMedioFondo", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Medio_Fondo", SqlDbType.Int).Value = Id_planilla_medio_fondo
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        cmd.Parameters.Add("@Tiempo1", SqlDbType.DateTime).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.DateTime).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.DateTime).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Medio_Fondo", SqlDbType.DateTime).Value = tiempo_final_medio_fondo
        cmd.Parameters.Add("@Serie", SqlDbType.Int).Value = serie
        cmd.Parameters.Add("@Clasificación_Medio_Fondo", SqlDbType.Int).Value = clasificacion_medio_fondo
        'Ejecutamos el comando 
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub ActualizarPlanillaMedioFondo(ByVal planillamediofondo As CEPlanillaMedioFondo)
        ActualizarPlanillaMedioFondo(planillamediofondo.id_planilla_medio_fondo,
                                    planillamediofondo.numero,
                                    planillamediofondo.Nombre,
                                    planillamediofondo.Apellido,
                                    planillamediofondo.club,
                                    planillamediofondo.tiempo1,
                                   planillamediofondo.tiempo2,
                                   planillamediofondo.tiempo3,
                                    planillamediofondo.Tiempo_final,
                                    planillamediofondo.serie,
                                    planillamediofondo.Clasificacion_Medio_Fondo_Final)
    End Sub

    Public Sub EliminarPlanillaMedioFondo(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaMedioFondo", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Medio_Fondo", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try

    End Sub
End Class
