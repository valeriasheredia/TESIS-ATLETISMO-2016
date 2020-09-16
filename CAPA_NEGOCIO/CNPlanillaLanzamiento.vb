Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaLanzamiento
    Dim objPlanilla_Lanzamiento As New DAOPlanillaLanzamiento


    Public Sub NuevaPlanillaLanzamiento(ByVal objPlanillaLanzamiento As CEPlanillaLanzamiento)
        objPlanilla_Lanzamiento.NuevaPlanillaLanzamiento(objPlanillaLanzamiento)
    End Sub

    Public Function ListadoDePlanillaLanzamientoDTO() As List(Of CEPlanillaLanzamiento)
        Return objPlanilla_Lanzamiento.ListadoDePlanillaLanzamientoDTO()
    End Function

    Public Function PlanillaLanzamiento() As DataSet
        Return objPlanilla_Lanzamiento.PlanillaLanzamiento
    End Function


    Public Function JuezPrincipal() As DataSet
        Return objPlanilla_Lanzamiento.JuezPrincipal
    End Function
End Class
