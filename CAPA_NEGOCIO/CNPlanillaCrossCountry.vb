Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaCrossCountry
    Dim objPlanillaCrossCountry As New DAOPlanillaCrossCountry

    Public Sub NuevaPlanillaCrossCountry(ByVal objPlanilla As CEPlanillaCrossCountry)
        objPlanillaCrossCountry.NuevaPlanillaCrossCountry(objPlanilla)
    End Sub

    Public Function ListadoDePlanillasCrossCountryDTO() As List(Of CEPlanillaCrossCountry)
        Return objPlanillaCrossCountry.ListadoDePlanillasCrossCountryDTO()
    End Function

    Public Function ListadoPlanillaCrossCountry() As DataSet
        Return objPlanillaCrossCountry.ListadoPlanillaCrossCountry
    End Function

    'Public Sub ActualizarPlanillaCrossCountry(ByVal planillacrosscountry As CEPlanillaCrossCountry)
    '    objPlanillaCrossCountry.ActualizarPlanillaCrossCountry(planillacrosscountry.id_planilla_cross_country,
    '                                       planillacrosscountry.dorsal,
    '                                       planillacrosscountry.Apellido_atleta,
    '                                       planillacrosscountry.Nombre_atleta,
    '                                       planillacrosscountry.id_club_federacion,
    '                                       planillacrosscountry.Tiempo1,
    '                                       planillacrosscountry.Tiempo2,
    '                                       planillacrosscountry.Tiempo3,
    '                                       planillacrosscountry.tiempo_final_cross_country,
    '                                       planillacrosscountry.Clasificacion_Cross_Country)
    'End Sub

    Public Sub EliminarPlanillaCrossCountry(ByVal idplanilla As Integer)
        objPlanillaCrossCountry.EliminarPlanillaCrossCountry(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanillaCrossCountry.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanillaCrossCountry.Sexoatleta
    'End Function
End Class
