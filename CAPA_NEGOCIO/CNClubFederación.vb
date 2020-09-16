Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNClubFederación

    ' creamos el objeto de capa datos
    Dim objclub As New DAOClubFederacion

    'implementamos la funcion que retorna el data set
    Public Function listadoclubes() As DataSet
        Return objclub.listadoclubes
    End Function

    'llamamos a la funcion generar
    Public Function nuevocodigoclub() As String
        Return objclub.nuevoCodigoclub
    End Function

    Public Sub nuevoclub(ByVal objc As CEClubFederacion)
        objclub.nuevoclub(objc)
    End Sub

    Public Function ListadoDeClubesDTO() As List(Of CEClubFederacion)
        Return objclub.ListadoDeClubesDTO()
    End Function


    Public Function ListaLocalidadClub() As DataSet
        Return objclub.ListaLocalidadClub
    End Function

    Public Function ListaLocalidadClub(Id_Provincia As Integer) As DataSet
        Return objclub.ListaLocalidadClub(Id_Provincia)
    End Function

    Public Function listaprovinciaclub() As DataSet
        Return objclub.listaprovinciaclub
    End Function
    Public Sub actualizarClub(ByVal objc As CEClubFederacion)
        objclub.actualizarClub(objc.id_club_federacion,
                               objc.Nombre_club,
                               objc.id_provincia,
                               objc.id_localidad,
                               objc.direccion,
                               objc.telefono_fijo,
                               objc.telefono_celular,
                               objc.e_mail)
    End Sub

    Public Sub eliminarclub(ByVal id As Integer)
        objclub.eliminarclub(id)
    End Sub
End Class
