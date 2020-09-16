Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaCalle
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    ' guardar planilla final  en BD
    Public Sub NuevaPlanillaCalle(ByRef ObjPlanilla As CEPlanillaCalle)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NuevaPlanillaCalle", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Planilla_Calle", SqlDbType.Int).Value = ObjPlanilla.id_planilla
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanilla.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanilla.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanilla.Apellido_atleta
                .Add("@Sexo", SqlDbType.Int).Value = ObjPlanilla.id_sexo
                .Add("@Nombre_Localidad", SqlDbType.VarChar).Value = ObjPlanilla.id_localidad
                .Add("@Fecha_Nacimiento", SqlDbType.Date).Value = ObjPlanilla.fecha_nacimiento
                .Add("@Otra_Institución", SqlDbType.VarChar).Value = ObjPlanilla.otra_institucion
                .Add("@Tiempo1", SqlDbType.Time).Value = ObjPlanilla.Tiempo1
                .Add("@Tiempo2", SqlDbType.Time).Value = ObjPlanilla.Tiempo2
                .Add("@Tiempo3", SqlDbType.Time).Value = ObjPlanilla.Tiempo3
                .Add("@Tiempo_Final_Calle", SqlDbType.Time).Value = ObjPlanilla.tiempo_final

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

    Public Sub ActualizarPlanillaCalle(ByVal planillacalle As CEPlanillaCalle)
        ActualizarPlanillaCalle(planillacalle.id_planilla,
                       planillacalle.dorsal,
                       planillacalle.Nombre_atleta,
                       planillacalle.Apellido_atleta,
                       planillacalle.id_sexo,
                       planillacalle.id_localidad,
                       planillacalle.Edad,
                       planillacalle.otra_institucion,
                       planillacalle.Tiempo1,
                       planillacalle.Tiempo2,
                       planillacalle.Tiempo3,
                       planillacalle.tiempo_final
                       )
    End Sub

    Public Sub ActualizarPlanillaCalle(ByVal Id_planilla_calle As Integer,
                                      ByVal dorsal As Integer,
                                ByVal nombre As String,
                                ByVal apellido As String,
                                ByVal sexo As Integer,
                               ByVal localidad As Integer,
                               ByVal edad As Integer,
                                ByVal otra_institucion As String,
                                ByVal tiempo1 As DateTime,
                                ByVal tiempo2 As DateTime,
                                ByVal tiempo3 As DateTime,
                                ByVal tiempo_final As DateTime)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ActualizarPlanillaCalle", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@Id_Planilla_Calle", SqlDbType.Int).Value = Id_planilla_calle
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido
        cmd.Parameters.Add("@Id_Sexo", SqlDbType.Int).Value = sexo
        cmd.Parameters.Add("@Id_Localidad", SqlDbType.Int).Value = localidad
        cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = edad
        cmd.Parameters.Add("@Otra_Institución", SqlDbType.VarChar).Value = otra_institucion
        cmd.Parameters.Add("@Tiempo1", SqlDbType.Int).Value = tiempo1
        cmd.Parameters.Add("@Tiempo2", SqlDbType.Int).Value = tiempo2
        cmd.Parameters.Add("@Tiempo3", SqlDbType.Int).Value = tiempo3
        cmd.Parameters.Add("@Tiempo_Final_Calle", SqlDbType.Date).Value = tiempo_final
        'Ejecutamos el comando 
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Function ListadoDePlanillasCalleDTO() As List(Of CEPlanillaCalle)
        Dim miDS = LISTADOPLANILLACALLE()
        Dim vectorDePlanillaCalle = New List(Of CEPlanillaCalle)()
        For Each row In miDS.Tables(0).Rows
            Dim com As CEPlanillaCalle = New CEPlanillaCalle()
            com.dorsal = row("Número")
            com.Nombre_atleta = row("Nombre")
            com.Apellido_atleta = row("Apellido")
            com.id_sexo = row("Id_Sexo")
            com.id_localidad = row("Id_Localidad")
            com.fecha_nacimiento = row("Edad")
            com.otra_institucion = row("Representa_a")
            com.Tiempo1 = row("Tiempo1")
            com.Tiempo2 = row("Tiempo2")
            com.Tiempo3 = row("Tiempo3")
            com.tiempo_final = row("Tiempo_Final_Calle")

            vectorDePlanillaCalle.Add(com)
        Next
        Return vectorDePlanillaCalle
    End Function


    Public Function LISTADOPLANILLACALLE() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("LISTADOPLANILLACALLE", cn)
        da.Fill(ds, "Planilla de Calle")
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

    Public Sub EliminarPlanillaCalle(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("EliminarPlanillaCalle", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Planilla_Calle", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar la Planilla" + ex.ToString)
        End Try

    End Sub

    Public Function Sexoatleta() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("Sexoatleta", cn)
        da.Fill(ds, "Sexo")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
End Class
