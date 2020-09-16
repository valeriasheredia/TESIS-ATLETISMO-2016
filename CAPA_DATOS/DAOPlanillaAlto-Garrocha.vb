Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOPlanillaAlto_Garrocha
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    Public Sub NuevaPlanillaAlto_Garrocha(ByRef ObjPlanillaAlto_Garrocha As CEPlanillaAlto_Garrocha)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("PlanillaSaltoAltoYGarrocha", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Dorsal", SqlDbType.Int).Value = ObjPlanillaAlto_Garrocha.dorsal
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = ObjPlanillaAlto_Garrocha.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = ObjPlanillaAlto_Garrocha.Apellido_atleta
                .Add("@Altura1", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Altura_1
                .Add("@Altura2", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Altura_2
                .Add("@Altura3", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Altura_3
                .Add("@Altura4", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Altura_4
                .Add("@Altura5", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Altura_5
                .Add("@Mejor_Altura", SqlDbType.Float).Value = ObjPlanillaAlto_Garrocha.Mejor_Altura
                .Add("@Cantidad_Intentos_Alto_Garrocha", SqlDbType.Int).Value = ObjPlanillaAlto_Garrocha.Cantidad_Intentos_Alto_Garrocha
                .Add("@Cantidad_Intentos_Nulos_Alto_Garrocha", SqlDbType.Int).Value = ObjPlanillaAlto_Garrocha.Cantidad_Intentos_Nulos_Alto_Garrocha
                .Add("@Clasificación_Alto_Garrocha", SqlDbType.Int).Value = ObjPlanillaAlto_Garrocha.Clasificación_Alto_Garrocha

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

    Public Function ListadoDePlanillaAltoyGarrochaDTO() As List(Of CEPlanillaAlto_Garrocha)
        Dim miDS = PlanillaSaltoAltoYGarrocha()
        Dim vectorDePlanillaSaltoAltoYGarrocha = New List(Of CEPlanillaAlto_Garrocha)()
        For Each row In miDS.Tables(0).Rows
            Dim altogarrocha As CEPlanillaAlto_Garrocha = New CEPlanillaAlto_Garrocha()
            altogarrocha.dorsal = row("Número")
            altogarrocha.Nombre_atleta = row("Nombre")
            altogarrocha.Apellido_atleta = row("Apellido")
            altogarrocha.Altura_1 = row("Altura1")
            altogarrocha.Altura_2 = row("Altura2")
            altogarrocha.Altura_3 = row("Altura3")
            altogarrocha.Altura_4 = row("Altura4")
            altogarrocha.Altura_5 = row("Altura5")
            'altogarrocha.Altura_6 = row("Altura6")
            'altogarrocha.Altura_7 = row("Altura7")
            'altogarrocha.Altura_8 = row("Altura8")
            'altogarrocha.Altura_9 = row("Altura9")
            'altogarrocha.Altura_10 = row("Altura10")
            altogarrocha.Mejor_Altura = row("Mejor_Altura")
            altogarrocha.Cantidad_Intentos_Alto_Garrocha = row("Cantidad_Intentos_Alto_Garrocha")
            altogarrocha.Cantidad_Intentos_Nulos_Alto_Garrocha = row("Cantidad_Intentos_Nulos_Alto_Garrocha")
            altogarrocha.Clasificación_Alto_Garrocha = row("Clasificación_Alto_Garrocha")
            vectorDePlanillaSaltoAltoYGarrocha.Add(altogarrocha)
        Next
        Return vectorDePlanillaSaltoAltoYGarrocha
    End Function

    Public Function PlanillaSaltoAltoYGarrocha() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("PlanillaSaltoAltoYGarrocha", cn)
        da.Fill(ds, "Planilla de Salto en Alto y Garrocha")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
End Class
