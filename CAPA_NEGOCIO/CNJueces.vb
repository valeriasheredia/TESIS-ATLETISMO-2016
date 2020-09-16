Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNJueces
    ' creamos el objeto de capa datos

    Dim objuez As New DAOJueces

    'implementamos la funcion que retorna el data set

    Public Function listadojueces() As DataSet
        Return objuez.listadojueces
    End Function

    Public Function ListadoDeJuecesDTO() As List(Of CEJueces)
        Return objuez.ListadoDeJuecesDTO()
    End Function
    'llamamos a la funcion generar

    Public Function nuevocodigojuez() As String
        Return objuez.nuevoCodigojuez
    End Function

    Public Function listatipojuez() As DataSet
        Return objuez.listatipojuez

    End Function

    Public Function listaprovincia() As DataSet
        Return objuez.listaprov

    End Function
    ' llamamos al procedimiento de registro de jueces

    Public Sub nuevojuez(ByVal obju As CEJueces)
        objuez.nuevojuez(obju)
    End Sub
    Public Sub actualizarJuez(ByVal obju As CEJueces)

        objuez.actualizarJuez(obju.id_juez,
                                 obju.Nombre_j,
                                 obju.Apellido_j,
                                 obju.Dni_j,
                                 obju.nacionalidad_j,
                                 obju.id_provincia_j,
                                 obju.direccion_j,
                                 obju.telefono_fijo_j,
                                 obju.telefono_celular_j,
                                 obju.e_mail_j,
                                 obju.id_tipo_juez)
    End Sub

    Public Sub eliminarjuez(ByVal idjuez As Integer)
        objuez.eliminarJuez(idjuez)
    End Sub
End Class

