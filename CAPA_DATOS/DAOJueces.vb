Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic

Public Class DAOJueces

    ' implementamos el store procedure de la BD

    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    ' funcion que permite mostrar una lista de usuarios

    Public Function listadojueces() As DataSet
        Dim ds As New DataSet
        cn = objcon.conectar
        da = New SqlDataAdapter("LISTADOJUECES", cn) ' NOMBRE DEL PROCEDIMIENTO ALMACENADO
        da.Fill(ds, "JUECES") 'ELEGIMOS UN NOMBRE O ALIAS
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function ListadoDeJuecesDTO() As List(Of CEJueces)
        Dim miDS = listadojueces()
        Dim vectorDeJueces = New List(Of CEJueces)()
        For Each row In miDS.Tables(0).Rows
            Dim ju As CEJueces = New CEJueces()
            ju.Apellido_j = row("Apellido")
            ju.Dni_j = row("Dni")
            ju.direccion_j = row("Domicilio")
            ju.e_mail_j = row("E_mail")
            ju.id_juez = row("Código")
            ju.id_provincia_j = row("Id_Provincia")
            ju.id_tipo_juez = row("Id_Tipo_Juez")
            ju.nacionalidad_j = row("País")
            ju.Nombre_j = row("Nombre")
            ju.telefono_celular_j = row("Celular")
            ju.telefono_fijo_j = row("Fijo")
            vectorDeJueces.Add(ju)
        Next
        Return vectorDeJueces
    End Function

    ' funcion que permita autogenerar el codigo del usuario 

    Public Function nuevoCodigojuez() As String
        cn = objcon.conectar
        cn.Open()
        da = New SqlDataAdapter("ULTIMOJUEZ", cn)
        Return da.SelectCommand.ExecuteScalar() ' permite obtener un valor unico de la consulta
    End Function

    'funcion que permita mostrar el perfil de los usuarios

    Public Function listatipojuez() As DataSet
        Dim ds As New DataSet
        cn = objcon.conectar
        da = New SqlDataAdapter("TIPOJUEZ", cn)
        da.Fill(ds, "TIPOJUEZ")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    '  funcion que permita mostrar la provincias

    Public Function listaprov() As DataSet
        Dim ds As New DataSet
        cn = objcon.conectar
        da = New SqlDataAdapter("LISTAPROVINCIAJUEZ", cn)
        da.Fill(ds, "provincias")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' procedimiento que insertar un nuevo JUEZ

    Public Sub nuevojuez(ByVal objuez As CEJueces)
        cn = objcon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("NUEVOJUEZ", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Juez", SqlDbType.Int).Value = objuez.id_juez
                .Add("@Nombre_Juez", SqlDbType.VarChar).Value = objuez.Nombre_j
                .Add("@Apellido_Juez", SqlDbType.VarChar).Value = objuez.Apellido_j
                .Add("@Dni_Juez", SqlDbType.VarChar).Value = objuez.Dni_j
                .Add("@Nacionalidad", SqlDbType.VarChar).Value = objuez.nacionalidad_j
                .Add("@Id_Provincia", SqlDbType.Int).Value = objuez.id_provincia_j
                .Add("@Domicilio", SqlDbType.VarChar).Value = objuez.direccion_j
                .Add("@Teléfono_Fijo", SqlDbType.VarChar).Value = objuez.telefono_fijo_j
                .Add("@Teléfono_Celular", SqlDbType.VarChar).Value = objuez.telefono_celular_j
                .Add("@E_mail", SqlDbType.VarChar).Value = objuez.e_mail_j
                .Add("@Id_Tipo_Juez", SqlDbType.Int).Value = objuez.id_tipo_juez

            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Juez registrado correctamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error al registrar el Juez", MsgBoxStyle.Critical).ToString()
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    Public Sub actualizarJuez(ByVal id_juez As Integer,
                              ByVal nombre_juez As String,
                              ByVal apellido_juez As String,
                              ByVal dni_juez As String,
                              ByVal nacionalidad As String,
                              ByVal id_provincia As Integer,
                              ByVal direccion As String,
                              ByVal telefono_fijo As String,
                              ByVal telefono_celular As String,
                              ByVal e_mail As String,
                              ByVal id_tipo_juez As Integer)
        cn = objcon.Conectar

        cmd = New SqlCommand("ACTUALIZARJUEZ", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Id_Juez", SqlDbType.Int).Value = id_juez
        cmd.Parameters.Add("@Nombre_Juez", SqlDbType.VarChar).Value = nombre_juez
        cmd.Parameters.Add("@Apellido_Juez", SqlDbType.VarChar).Value = apellido_juez
        cmd.Parameters.Add("@Dni_Juez", SqlDbType.VarChar).Value = dni_juez
        cmd.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = nacionalidad
        cmd.Parameters.Add("@id_provincia", SqlDbType.Int).Value = id_provincia
        cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = direccion
        cmd.Parameters.Add("@Teléfono_Fijo", SqlDbType.VarChar).Value = telefono_fijo
        cmd.Parameters.Add("@Teléfono_Celular", SqlDbType.VarChar).Value = telefono_celular
        cmd.Parameters.Add("@E_mail", SqlDbType.VarChar).Value = e_mail
        cmd.Parameters.Add("@Id_Tipo_Juez", SqlDbType.Int).Value = id_tipo_juez

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub ActualizarJuez(ByVal juez As CEJueces)
        actualizarJuez(juez.id_juez,
                       juez.Nombre_j,
                       juez.Apellido_j,
                       juez.Dni_j,
                       juez.nacionalidad_j,
                       juez.id_provincia_j,
                       juez.direccion_j,
                       juez.telefono_fijo_j,
                       juez.telefono_celular_j,
                       juez.e_mail_j,
                       juez.id_tipo_juez)
    End Sub
    Public Sub eliminarJuez(ByVal cod As String)
        Try
            cn = objcon.Conectar

            cmd = New SqlCommand("ELIMINARJUEZ", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Juez", SqlDbType.Char).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            ' MsgBox("Se ha eliminado al Juez correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar al Juez" + ex.ToString)
        End Try

    End Sub
End Class




