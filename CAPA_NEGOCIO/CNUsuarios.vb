Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNUsuarios
    ' creamos el objeto de capa datos
    Dim objusu As New DAOUsuarios 'nuevo elemento de DAOUsuario
    'implementamos la funcion que retorna el data set
    Public Function listadousuarios() As DataSet
        Return objusu.listadousuarios 'objusu es el acceso a la lista de usuarios
    End Function

    'llamamos a la funcion generar
    Public Function nuevocodigo() As String
        Return objusu.nuevoCodigo
    End Function

    Public Function listaperfil() As DataSet
        Return objusu.listaperfil
    End Function

    Public Function listaprovincia() As DataSet
        Return objusu.listaprovincia
    End Function

    ' llamamos al procedimiento de registro de usuario
    Public Sub nuevousuario(ByVal obju As CEUsuarios)
        objusu.nuevousuario(obju)
    End Sub

    Public Sub actualizarusuario(ByVal obju As CEUsuarios)
        objusu.actualizarUsuario(obju.id_usuario,
                                 obju.Nombre,
                                 obju.Apellido,
                                 obju.id_provincia,
                                 obju.direccion,
                                 obju.barrio,
                                 obju.telefono_fijo,
                                 obju.telefono_celular,
                                 obju.e_mail,
                                 obju.nombre_usuario,
                                 obju.contraseña,
                                 obju.perfil_usuario)
    End Sub

    Public Sub eliminarusuario(ByVal id As Integer)
        objusu.eliminarUsuario(id)
    End Sub


    Public Function ListadoDeUsuariosDTO() As List(Of CEUsuarios)
        Return objusu.ListadoDeUsuariosDTO
    End Function
End Class