Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaVelocidad
    Dim objPlanilla_Velocidad As New DAOPlanillaVelocidad


    Public Sub NuevaPlanillaVelocidad(ByVal objPlanillaVelocidad As CEPlanillaVelocidad)
        objPlanilla_Velocidad.NuevaPlanillaVelocidad(objPlanillaVelocidad)
    End Sub

    Public Function ListadoDePlanillaVelocidadDTO() As List(Of CEPlanillaVelocidad)
        Return objPlanilla_Velocidad.ListadoDePlanillasVelocidadDTO()
    End Function

    Public Function PlanillaVelocidad() As DataSet
        Return objPlanilla_Velocidad.ListadoPlanillaVelocidad
    End Function

    Public Sub ActualizarPlanillaVelocidad(ByVal planillavelocidad As CEPlanillaVelocidad)
        objPlanilla_Velocidad.ActualizarPlanillaVelocidad(planillavelocidad.id_planilla_velocidad,
                                    planillavelocidad.numero,
                                    planillavelocidad.Nombre,
                                    planillavelocidad.Apellido,
                                    planillavelocidad.club,
                                    planillavelocidad.tiempo1,
                                    planillavelocidad.tiempo2,
                                    planillavelocidad.tiempo3,
                                    planillavelocidad.tiempo_final,
                                    planillavelocidad.serie,
                                    planillavelocidad.Clasificacion_Velocidad_Final)
    End Sub

    Public Sub EliminarPlanillaVelocidad(ByVal idplanilla As Integer)
        objPlanilla_Velocidad.EliminarPlanillaVelocidad(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanilla_Velocidad.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanilla_Velocidad.Sexoatleta
    'End Function
End Class
