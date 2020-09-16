Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaMarcha
    Dim objPlanillaMarcha As New DAOPlanillaMarcha

    Public Sub NuevaPlanillaMaraton(ByVal objPlanilla As CEPlanillaMarcha)
        objPlanillaMarcha.NuevaPlanillaMarcha(objPlanilla)
    End Sub

    Public Function ListadoDePlanillaMarchaDTO() As List(Of CEPlanillaMarcha)
        Return objPlanillaMarcha.ListadoDePlanillaMarchaDTO()
    End Function

    Public Function ListadoDePlanillaMarcha() As DataSet
        Return objPlanillaMarcha.ListadoPlanillaMarcha
    End Function

    Public Sub ActualizarPlanillaMarcha(ByVal planillamarcha As CEPlanillaMarcha)
        objPlanillaMarcha.ActualizarPlanillaMarcha(planillamarcha.id_planilla_marcha,
                                           planillamarcha.dorsal,
                                           planillamarcha.Apellido_atleta,
                                           planillamarcha.Nombre_atleta,
                                           planillamarcha.id_club_federacion,
                                           planillamarcha.Tiempo1,
                                           planillamarcha.Tiempo2,
                                           planillamarcha.Tiempo3,
                                           planillamarcha.tiempo_final_marcha,
                                           planillamarcha.Clasificacion_marcha)
    End Sub

    Public Sub EliminarPlanillaMarcha(ByVal idplanilla As Integer)
        objPlanillaMarcha.EliminarPlanillaMarcha(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanillaMarcha.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanillaMarcha.Sexoatleta
    'End Function
End Class
