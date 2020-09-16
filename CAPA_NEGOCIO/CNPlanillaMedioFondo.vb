Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaMedioFondo
    Dim objPlanilla_Medio_Fondo As New DAOPlanillaMedioFondo


    Public Sub NuevaPlanillaMedioFondo(ByVal objPlanillaMedioFondo As CEPlanillaMedioFondo)
        objPlanilla_Medio_Fondo.NuevaPlanillaMedioFondo(objPlanillaMedioFondo)
    End Sub

    Public Function ListadoDePlanillaMedioFondoDTO() As List(Of CEPlanillaMedioFondo)
        Return objPlanilla_Medio_Fondo.ListadoDePlanillaMedioFondoDTO()
    End Function

    Public Function PlanillaMedioFondo() As DataSet
        Return objPlanilla_Medio_Fondo.PlanillaMedioFondo
    End Function

    Private Sub ActualizarPlanillaMedioFondo(ByVal planillamediofondo As CEPlanillaMedioFondo)
        objPlanilla_Medio_Fondo.ActualizarPlanillaMedioFondo(planillamediofondo.id_planilla_medio_fondo,
                                    planillamediofondo.numero,
                                    planillamediofondo.Nombre,
                                    planillamediofondo.Apellido,
                                    planillamediofondo.club,
                                    planillamediofondo.tiempo1,
                                   planillamediofondo.tiempo2,
                                   planillamediofondo.tiempo3,
                                    planillamediofondo.Tiempo_final,
                                    planillamediofondo.serie,
                                    planillamediofondo.Clasificacion_Medio_Fondo_Final)
    End Sub

    Public Sub EliminarPlanillaMedioFondo(ByVal idplanilla As Integer)
        objPlanilla_Medio_Fondo.EliminarPlanillaMedioFondo(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanilla_Medio_Fondo.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanilla_Medio_Fondo.Sexoatleta
    'End Function
End Class
