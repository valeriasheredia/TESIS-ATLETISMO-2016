Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaFondo
    Dim objPlanilla_Fondo As New DAOPlanillaFondo

    Public Sub NuevaPlanillaFondo(ByRef ObjPlanillaFondo As CEPlanillaFondo)
        objPlanilla_Fondo.NuevaPlanillaFondo(ObjPlanillaFondo)
    End Sub

    Public Function ListadoDePlanillasFondoDTO() As List(Of CEPlanillaFondo)
        Return objPlanilla_Fondo.ListadoDePlanillasFondoDTO()
    End Function

    Public Function ListadoPlanillaFondo() As DataSet
        Return objPlanilla_Fondo.ListadoPlanillaFondo
    End Function

    Private Sub ActualizarPlanillaFondo(ByVal planillafondo As CEPlanillaFondo)
        objPlanilla_Fondo.ActualizarPlanillaFondo(planillafondo.id_planilla_fondo,
                                    planillafondo.dorsal,
                                    planillafondo.Nombre_atleta,
                                    planillafondo.Apellido_atleta,
                                    planillafondo.club,
                                    planillafondo.tiempo1,
                                   planillafondo.tiempo2,
                                   planillafondo.tiempo3,
                                    planillafondo.tiempofinal,
                                    planillafondo.serie,
                                    planillafondo.clasificacionfinal)
    End Sub

    Public Sub EliminarPlanillaFondo(ByVal idplanilla As Integer)
        objPlanilla_Fondo.EliminarPlanillaFondo(idplanilla)
    End Sub

    Public Function JuezPrincipal() As DataSet
        Return objPlanilla_Fondo.JuezPrincipal
    End Function

    'Public Function Sexoatleta() As DataSet
    '    Return objPlanilla_Fondo.Sexoatleta
    'End Function
End Class
