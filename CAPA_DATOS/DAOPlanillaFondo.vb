Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic


Public Class DAOPlanillaFondo

    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaFondo(ByVal ObjPlanillaFondo As CEPlanillaFondo)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaFondo", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Fondo", SqlDbType.Int).Value = ObjPlanillaFondo.id_planilla_fondo
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaFondo.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaFondo.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaFondo.Apellido_atleta
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaFondo.club
                .Add("@Tiempo1", SqlDbType.DateTime).Value = ObjPlanillaFondo.tiempo1
                .Add("@Tiempo2", SqlDbType.DateTime).Value = ObjPlanillaFondo.tiempo2
                .Add("@Tiempo3", SqlDbType.DateTime).Value = ObjPlanillaFondo.tiempo3
                .Add("@Tiempo_Final_Fondo", SqlDbType.DateTime).Value = ObjPlanillaFondo.tiempofinal
                .Add("@Serie", SqlDbType.Int).Value = ObjPlanillaFondo.serie
                .Add("@Clasificación_Fondo", SqlDbType.Int).Value = ObjPlanillaFondo.clasificacionfinal
                da.SelectCommand.ExecuteNonQuery()  'inserta los valores

                MsgBox("La Planilla se ha creado correctamente", MsgBoxStyle.Information)
            End With
        Catch ex As Exception
            MsgBox("No se pudo crear la Planilla", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    Public Function ListadoPlanillaFondo() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListadoPlanillaFondo", cn)
        da.Fill(ds, "Listado de Fondo")
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

    Public Function ListadoDePlanillasFondoDTO() As List(Of CEPlanillaFondo)
        Dim miDS = ListadoPlanillaFondo()
        Dim vectorDePlanillaFondo = New List(Of CEPlanillaFondo)()
        For Each row In miDS.Tables(0).Rows
            Dim fondo As CEPlanillaFondo = New CEPlanillaFondo()
            fondo.dorsal = row("Número")
            fondo.Apellido_atleta = row("Apellido")
            fondo.Nombre_atleta = row("Nombre")
            fondo.club = row("Id_Club_Federación")
            fondo.tiempo1 = row("Tiempo1")
            fondo.tiempo2 = row("Tiempo2")
            fondo.tiempo3 = row("Tiempo3")
            fondo.tiempofinal = row("Tiempo_Final_Fondo")
            fondo.serie = row("Serie")
            fondo.clasificacionfinal = row("Clasificación")

            vectorDePlanillaFondo.Add(fondo)
        Next
        Return vectorDePlanillaFondo
    End Function

    Public Sub ActualizarPlanillaFondo(ByVal Id_planilla_fondo As Integer,
                              ByVal dorsal As Integer,
                              ByVal nombre As String,
                              ByVal apellido As String,
                              ByVal id_club As Integer,
                              ByVal tiempo1 As DateTime,
                              ByVal tiempo2 As DateTime,
                              ByVal tiempo3 As DateTime,
                              ByVal tiempo_final As DateTime,
                              ByVal serie As Integer,
                              ByVal clasificacion_fondo As Integer)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ActualizarPlanillaVelocidad", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Calle", SqlDbType.Int).Value = Id_planilla_fondo
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club
        cmd.Parameters.Add("@Tiempo1", SqlDbType.DateTime).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.DateTime).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.DateTime).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Fondo", SqlDbType.DateTime).Value = tiempo_final
        cmd.Parameters.Add("@Serie", SqlDbType.Int).Value = serie
        cmd.Parameters.Add("@Clasifcación_Fondo", SqlDbType.Int).Value = clasificacion_fondo
        'Ejecutamos el comando 
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub ActualizarPlanillaFondo(ByVal planillafondo As CEPlanillaFondo)
        ActualizarPlanillaFondo(planillafondo.id_planilla_fondo,
                                    planillafondo.dorsal,
                                    planillafondo.Nombre_atleta,
                                    planillafondo.Apellido_atleta,
                                    planillafondo.club,
                                    planillafondo.tiempo1,
                                   planillafondo.tiempo2,
                                   planillafondo.tiempo3,
                                    planillafondo.tiempofinal,
                                    planillafondo.serie,
                                    planillafondo.clasificacionfinal)
    End Sub

    Public Sub EliminarPlanillaFondo(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaFondo", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Fondo", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try

    End Sub
End Class
