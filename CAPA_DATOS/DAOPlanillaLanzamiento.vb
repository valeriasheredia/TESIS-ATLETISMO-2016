Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaLanzamiento

    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaLanzamiento(ByRef ObjPlanillaLanzamiento As CEPlanillaLanzamiento)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("PlanillaCalle", cn) ' hacer el procedimiento!!!!!

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaLanzamiento.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaLanzamiento.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaLanzamiento.Apellido_atleta
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = ObjPlanillaLanzamiento.id_club_federacion
                .Add("@lanzamiento_1", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Primer_Lanzamiento
                .Add("@lanzamiento_2", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Segundo_Lanzamiento
                .Add("@lanzamiento_3", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Tercer_Lanzamiento
                .Add("@lanzamiento_4", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Cuarto_Lanzamiento
                .Add("@lanzamiento_5", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Quinto_Lanzamiento
                .Add("@lanzamiento_6", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Sexto_Lanzamiento
                .Add("@Mejor_Lanzamiento123", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Mejor_Lanzamiento123
                .Add("@Orden_Lanzamiento", SqlDbType.Int).Value = ObjPlanillaLanzamiento.Orden_Lanzamiento
                .Add("@Mejor_Lanzamiento456", SqlDbType.Float).Value = ObjPlanillaLanzamiento.Mejor_Lanzamiento456
                .Add("@Clasificación_Lanzamiento", SqlDbType.Int).Value = ObjPlanillaLanzamiento.Clasificación_Lanzamiento
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

    Public Function ListadoDePlanillaLanzamientoDTO() As List(Of CEPlanillaLanzamiento)
        Dim miDS = PlanillaLanzamiento()
        Dim vectorDePlanillaLanzamiento = New List(Of CEPlanillaLanzamiento)()
        For Each row In miDS.Tables(0).Rows
            Dim lanz As CEPlanillaLanzamiento = New CEPlanillaLanzamiento()
            lanz.dorsal = row("Número")
            lanz.Nombre_atleta = row("Nombre")
            lanz.Apellido_atleta = row("Apellido")
            lanz.id_club_federacion = row("Id_Club_Federación")
            lanz.Primer_Lanzamiento = row("Lanz1")
            lanz.Segundo_Lanzamiento = row("Lanz2")
            lanz.Tercer_Lanzamiento = row("Lanz3")
            lanz.Mejor_Lanzamiento123 = row("Mejor_Lanz123")
            lanz.Orden_Lanzamiento = row("Orden")
            lanz.Cuarto_Lanzamiento = row("Lanz4")
            lanz.Quinto_Lanzamiento = row("Lanz5")
            lanz.Sexto_Lanzamiento = row("Lanz6")
            lanz.Mejor_Lanzamiento456 = row("Mejor_Lanz456")
            lanz.Clasificación_Lanzamiento = row("Clasificación")

            vectorDePlanillaLanzamiento.Add(lanz)
        Next
        Return vectorDePlanillaLanzamiento
    End Function

    Public Function PlanillaLanzamiento() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("PlanillaLanzamiento", cn)
        da.Fill(ds, "Planilla de Lanzamiento")
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
End Class
