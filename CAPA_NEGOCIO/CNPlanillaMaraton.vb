Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaMaraton
    Dim objPlanillaMaraton As New DAOPlanillaMaraton

    Public Sub NuevaPlanillaMaraton(ByVal objPlanilla As CEPlanillaMaraton)
        objPlanillaMaraton.NuevaPlanillaMaraton(objPlanilla)
    End Sub

    Public Function ListadoDePlanillaMaratonDTO() As List(Of CEPlanillaMaraton)
        Return objPlanillaMaraton.ListadoDePlanillaMaratonDTO()
    End Function

    Public Function ListadoDePlanillaMaraton() As DataSet
        Return objPlanillaMaraton.ListadoPlanillaMaraton
    End Function

    Public Sub ActualizarPlanillaMaraton(ByVal planillamaraton As CEPlanillaMaraton)
        objPlanillaMaraton.ActualizarPlanillaMaraton(planillamaraton.id_planilla_maraton,
                                           planillamaraton.dorsal,
                                           planillamaraton.Apellido_atleta,
                                           planillamaraton.Nombre_atleta,
                                           planillamaraton.id_club_federacion,
                                           planillamaraton.Tiempo1,
                                           planillamaraton.Tiempo2,
                                           planillamaraton.Tiempo3,
                                           planillamaraton.tiempo_final_maraton,
                                           planillamaraton.Clasificacion_maraton)
    End Sub

    Public Sub EliminarPlanillaMaraton(ByVal idplanilla As Integer)
        objPlanillaMaraton.EliminarPlanillaMaraton(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanillaMaraton.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanillaMaraton.Sexoatleta
    'End Function
End Class
