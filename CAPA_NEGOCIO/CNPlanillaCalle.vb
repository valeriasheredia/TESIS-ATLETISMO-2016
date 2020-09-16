Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNPlanillaCalle
    Dim objPlanillaCalle As New DAOPlanillaCalle

    Public Sub NuevaPlanillaCalle(ByVal objPlanilla As CEPlanillaCalle)
        objPlanillaCalle.NuevaPlanillaCalle(objPlanilla)
    End Sub

    Public Function ListadoDePlanillasCalleDTO() As List(Of CEPlanillaCalle)
        Return objPlanillaCalle.ListadoDePlanillasCalleDTO()
    End Function

    Public Function LISTADOPLANILLACALLE() As DataSet
        Return objPlanillaCalle.LISTADOPLANILLACALLE
    End Function

    Public Function JuezPrincipal() As DataSet
        Return objPlanillaCalle.JuezPrincipal
    End Function

    Public Function Sexo() As DataSet
        Return objPlanillaCalle.Sexoatleta
    End Function

    Public Sub ActualizarPlanillaCalle(ByVal planillacalle As CEPlanillaCalle)
        objPlanillaCalle.ActualizarPlanillaCalle(planillacalle.id_planilla,
                       planillacalle.dorsal,
                       planillacalle.Nombre_atleta,
                       planillacalle.Apellido_atleta,
                       planillacalle.id_sexo,
                       planillacalle.id_localidad,
                       planillacalle.Edad,
                       planillacalle.otra_institucion,
                       planillacalle.Tiempo1,
                       planillacalle.Tiempo2,
                       planillacalle.Tiempo3,
                       planillacalle.tiempo_final
                       )
    End Sub

    Public Sub EliminarPlanillaCalle(ByVal idplanilla As Integer)
        objPlanillaCalle.EliminarPlanillaCalle(idplanilla)
    End Sub
End Class
