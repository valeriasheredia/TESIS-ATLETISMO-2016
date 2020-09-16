Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaAlto_Garrocha
    Dim objPlanillaAltoGarrocha As New DAOPlanillaAlto_Garrocha

    Public Sub NuevaPlanillaAlto_Garrocha(ByVal objPlanAltoGarrocha As CEPlanillaAlto_Garrocha)
        objPlanillaAltoGarrocha.NuevaPlanillaAlto_Garrocha(objPlanAltoGarrocha)
    End Sub

    Public Function ListadoDePlanillaAltoyGarrochaDTO() As List(Of CEPlanillaAlto_Garrocha)
        Return objPlanillaAltoGarrocha.ListadoDePlanillaAltoyGarrochaDTO()
    End Function

    Public Function PlanillaSaltoAltoYGarrocha() As DataSet
        Return objPlanillaAltoGarrocha.PlanillaSaltoAltoYGarrocha
    End Function
End Class
