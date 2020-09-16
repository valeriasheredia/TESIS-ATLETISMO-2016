Imports System.Data.SqlClient
Imports CAPA_ENTIDAD

Public Class DAOUsuarios

    Dim objcon As New conexion ' objeto de la clase conexion
    'la clase conexion es la que realiza la conexion con la base de datos, objcon es un objeto de esa conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter ' ejecuta la consulta y la envia a dataset
    Dim cmd As SqlCommand

    'funcion que permite mostrar una lista de usuarios
    Public Function listadousuarios() As DataSet 'emite la respuesta solicitada
        Dim ds As New DataSet 'dataset es donde se envian los resultados de la base
        cn = objcon.Conectar 'objeto de conexion conectada por medio de la funcion conectar
        da = New SqlDataAdapter("LISTAUSUARIOS", cn) ' NOMBRE DEL PROCEDIMIENTO ALMACENADO
        da.Fill(ds, "USUARIO") 'ELEGIMOS UN NOMBRE O ALIAS hacia los registros que provienen del da
        Return ds 'ds lleno a partir de la funcion listausuario
        ds.Dispose() ' cierre de las variables
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function nuevoCodigo() As String
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("ULTIMOUSUARIO", cn)
        Return da.SelectCommand.ExecuteScalar()
    End Function

    'funcion que permita mostrar el perfil de los usuarios
    Public Function listaperfil() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("LISTAPERFIL", cn)
        da.Fill(ds, "perfiles")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'funcion que permita mostrar la provincias
    Public Function listaprovincia() As DataSet
        Dim ds As New DataSet 'muestra la lista de provincias
        cn = objcon.Conectar
        da = New SqlDataAdapter("LISTAPROVINCIA", cn) ' nombre del procedimiento almacenado
        da.Fill(ds, "provincias") 'vacia la informacion al ds
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'procedimiento que insertar un nuevo usuario
    Public Sub nuevousuario(ByVal objusu As CEUsuarios)
        cn = objcon.Conectar
        Try
            cn.Open() 'se ubica siempre antes de ejecutar el comando
            da = New SqlDataAdapter("NUEVOUSUARIO", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@id_usuario", SqlDbType.Int).Value = objusu.id_usuario
                .Add("@nombre_usu", SqlDbType.VarChar).Value = objusu.Nombre
                .Add("@apellido_usu", SqlDbType.VarChar).Value = objusu.Apellido
                .Add("@id_provincia", SqlDbType.Int).Value = objusu.id_provincia
                .Add("@domicilio", SqlDbType.VarChar).Value = objusu.direccion
                .Add("@barrio", SqlDbType.VarChar).Value = objusu.barrio
                .Add("@teléfono_fijo", SqlDbType.VarChar).Value = objusu.telefono_fijo
                .Add("@teléfono_celular", SqlDbType.VarChar).Value = objusu.telefono_celular
                .Add("@e_mail", SqlDbType.VarChar).Value = objusu.e_mail
                .Add("@nombre_usuario", SqlDbType.VarChar).Value = objusu.nombre_usuario
                .Add("@contraseña", SqlDbType.VarChar).Value = objusu.contraseña
                .Add("@id_perfil_usuario", SqlDbType.Int).Value = objusu.perfil_usuario
            End With
            da.SelectCommand.ExecuteNonQuery()  'inserta los valores
            MsgBox("Usuario registrado correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar el Usuario", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    ' Actualiza un contacto a la base de datos
    Public Sub actualizarUsuario(ByVal id_usuario As Integer,
                                 ByVal nombre_u As String,
                                 ByVal apellido_u As String,
                                 ByVal id_provincia As Integer,
                                ByVal direccion As String,
                                ByVal barrio As String,
                                 ByVal telefono_fijo As String,
                                 ByVal telefono_celular As String,
                                 ByVal e_mail As String,
                                 ByVal nombre_usuario As String,
                                ByVal contraseña As String,
                                 ByVal id_perfil_usuario As Integer)
        cn = objcon.Conectar
        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        cn.Open()
        cmd = New SqlCommand("ACTUALIZARUSUARIO", cn)
        'utilizamos stored procedures
        cmd.CommandType = CommandType.StoredProcedure
        'le asignamos los parámetros para el stored procedure
        'los valores viene en el parámetro item del procedimiento
        cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario
        cmd.Parameters.Add("@nombre_usu", SqlDbType.VarChar).Value = nombre_u
        cmd.Parameters.Add("@apellido_usu", SqlDbType.VarChar).Value = apellido_u
        cmd.Parameters.Add("@id_provincia", SqlDbType.Int).Value = id_provincia
        cmd.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = direccion
        cmd.Parameters.Add("@barrio", SqlDbType.VarChar).Value = barrio
        cmd.Parameters.Add("@Teléfono_Fijo", SqlDbType.VarChar).Value = telefono_fijo
        cmd.Parameters.Add("@Teléfono_Celular", SqlDbType.VarChar).Value = telefono_celular
        cmd.Parameters.Add("@E_mail", SqlDbType.VarChar).Value = e_mail
        cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = nombre_usuario
        cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña
        cmd.Parameters.Add("@id_perfil_usuario", SqlDbType.Int).Value = id_perfil_usuario
        'Ejecutamos el comando 
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub ActualizarUsuario(ByVal usuario As CEUsuarios)
        actualizarUsuario(usuario.id_usuario,
                          usuario.Nombre,
                          usuario.Apellido,
                          usuario.id_provincia,
                          usuario.direccion,
                          usuario.barrio,
                          usuario.telefono_fijo,
                          usuario.telefono_celular,
                          usuario.e_mail,
                          usuario.nombre_usuario,
                          usuario.contraseña,
                          usuario.perfil_usuario)
    End Sub

    Public Sub eliminarUsuario(ByVal codigo As Integer)
        Try
            cn = objcon.Conectar
            Dim cmd = New SqlCommand("ELIMINARUSUARIO", cn)
            cmd.CommandType = CommandType.StoredProcedure 'tipo de comando
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = codigo
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            'MsgBox("El Usuario ha sido eliminado correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar al Usuario" + ex.ToString)
        End Try
    End Sub

    Public Function ListadoDeUsuariosDTO() As List(Of CEUsuarios)
        Dim miDS = listadousuarios()
        Dim vectorDeUsuarios = New List(Of CEUsuarios)()
        For Each row In miDS.Tables(0).Rows
            Dim usu As CEUsuarios = New CEUsuarios()
            usu.Apellido = row("Apellido")
            usu.barrio = row("Barrio")
            usu.contraseña = row("Contraseña")
            usu.id_provincia = row("id_provincia")
            usu.direccion = row("Domicilio")
            usu.e_mail = row("E_mail")
            usu.perfil_usuario = row("Id_Perfil_Usuario")
            usu.id_provincia = row("Id_Provincia")
            usu.id_usuario = row("Código")
            usu.Nombre = row("Nombre")
            usu.nombre_usuario = row("Usuario")
            usu.telefono_celular = row("Celular")
            usu.telefono_fijo = row("Fijo")
            vectorDeUsuarios.Add(usu)
        Next
        Return vectorDeUsuarios

    End Function
End Class

