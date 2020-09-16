Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNIngreso
    Dim objingreso As New DAOIngreso


    Public Function perfilingreso() As DataSet
        Return objingreso.perfilingreso

    End Function
End Class

