Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaObstaculos
    Dim objPlanilla_Obstaculos As New DAOPlanillaObstaculos

    Public Sub NuevaPlanillaObstaculos(ByVal objPlanillaObstaculos As CEPlanillaObstaculos)
        objPlanilla_Obstaculos.NuevaPlanillaObstaculos(objPlanillaObstaculos)
    End Sub

    Public Function ListadoDePlanillaObstaculosDTO() As List(Of CEPlanillaObstaculos)
        Return objPlanilla_Obstaculos.ListadoDePlanillasObstaculosDTO()
    End Function

    Public Function PlanillaObstaculos() As DataSet
        Return objPlanilla_Obstaculos.ListadoPlanillaObstaculos
    End Function

    Public Sub ActualizarPlanillaObstaculos(ByVal planillaobstaculos As CEPlanillaObstaculos)
        objPlanilla_Obstaculos.ActualizarPlanillaObstaculos(planillaobstaculos.id_planilla_obstaculos,
                                    planillaobstaculos.numero,
                                    planillaobstaculos.Nombre,
                                    planillaobstaculos.Apellido,
                                    planillaobstaculos.club,
                                    planillaobstaculos.tiempo1,
                                    planillaobstaculos.tiempo2,
                                    planillaobstaculos.tiempo3,
                                    planillaobstaculos.tiempo_final,
                                    planillaobstaculos.serie,
                                    planillaobstaculos.Clasificacion_Obstaculos_Final)
    End Sub

    Public Sub EliminarPlanillaObstaculos(ByVal idplanilla As Integer)
        objPlanilla_Obstaculos.EliminarPlanillaObstaculos(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanilla_Obstaculos.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanilla_Obstaculos.Sexoatleta
    'End Function
End Class
