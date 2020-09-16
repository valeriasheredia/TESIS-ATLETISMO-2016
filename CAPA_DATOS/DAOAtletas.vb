Imports System.Data.SqlClient
Imports CAPA_ENTIDAD
Imports System.Collections.Generic


Public Class DAOAtletas
    'implementamos el store procedure de la BD
    Dim objcon As New conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand

    'funcion que permite mostrar una lista de atletas
    Public Function listadoatletas() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("LISTADOATLETAS", cn) ' NOMBRE DEL PROCEDIMIENTO ALMACENADO
        da.Fill(ds, "ATLETA") 'ELEGIMOS UN NOMBRE O ALIAS
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function ListadoDeAtletasDTO() As List(Of CEAtletas)
        Dim miDS = listadoatletas() ' nombre del procedimiento que llena la lista de atletas de la bd
        Dim vectorDeAtletas = New List(Of CEAtletas)()
        For Each row In miDS.Tables(0).Rows
            Dim at As CEAtletas = New CEAtletas()
            at.Apellido_atleta = row("Apellido")
            at.barrio = row("Barrio")
            at.contacto_emergencia = row("Contacto")
            at.dni_atleta = row("Documento")
            at.domicilio = row("Domicilio")
            at.dorsal = row("Número")
            at.e_mail = row("Mail")
            at.estado_atleta = row("Estado")
            at.fecha_nacimiento = row("Nacimiento")
            at.federado = row("Federado")
            at.id_atleta = row("Código")
            at.id_club_federacion = row("Id_Club_Federación")
            at.id_localidad = row("Id_Localidad")
            at.id_provincia = row("Id_Provincia")
            at.id_sexo = row("Id_Sexo")
            at.nacionalidad = row("Nacionalidad")
            at.Nombre_atleta = row("Nombre")
            at.otra_institucion = row("Institución")
            at.telefono_celular = row("Celular")
            at.telefono_fijo = row("Fijo")
            vectorDeAtletas.Add(at)
        Next
        Return vectorDeAtletas
    End Function


    'funcion que permita autogenerar el codigo del atleta
    Public Function nuevoCodigoatleta() As String
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("ULTIMOATLETA", cn)
        Return da.SelectCommand.ExecuteScalar()
    End Function

    Public Function Sexoatleta() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("Sexoatleta", cn)
        da.Fill(ds, "Sexo")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'funcion que permita mostrar la provincias
    Public Function ListaProvinciaAtleta() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        cn.Open()
        da = New SqlDataAdapter("Lista_Provincia_Atleta", cn)
        da.Fill(ds, "provincias de atletas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Function ListaLocalidadAtleta(Id_Provincia As Integer) As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        'genero un comando con el nombre del store procedure
        Dim cmd = New SqlCommand("Lista_Localidad_Atleta", cn)
        'genero el paramatero que le voy a pasar al SP
        Dim parametro1 = New SqlParameter("@id_provincia", Id_Provincia)
        cmd.CommandType = CommandType.StoredProcedure
        'Agrego los parametros
        cmd.Parameters.Add(parametro1)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "Localidades por Provincia")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'funcion que permita mostrar las localidades
    Public Function ListaLocalidadAtleta() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("Lista_Localidad_Atleta", cn)
        da.Fill(ds, "Localidades de atletas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'funcion que permita mostrar los clubes 
    Public Function ListaClubAtleta() As DataSet
        Dim ds As New DataSet
        cn = objcon.Conectar
        da = New SqlDataAdapter("ListaClubAtleta", cn) ' nombre del procedimiento
        da.Fill(ds, "Clubes de Atletas") ' alias
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'procedimiento que insertar un nuevo ATLETA
    Public Sub nuevoatleta(ByVal objusu As CEAtletas)
        cn = objcon.Conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("NUEVOATLETA", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Id_Atleta", SqlDbType.Int).Value = objusu.id_atleta
                .Add("@Nombre_Atleta", SqlDbType.VarChar).Value = objusu.Nombre_atleta
                .Add("@Apellido_Atleta", SqlDbType.VarChar).Value = objusu.Apellido_atleta
                .Add("@Fecha_Nacimiento", SqlDbType.Date).Value = objusu.fecha_nacimiento
                .Add("@Id_Sexo", SqlDbType.Int).Value = objusu.id_sexo
                .Add("@Dni", SqlDbType.VarChar).Value = objusu.dni_atleta
                .Add("@Nacionalidad", SqlDbType.VarChar).Value = objusu.nacionalidad
                .Add("@Id_Provincia", SqlDbType.Int).Value = objusu.id_provincia
                .Add("@Id_Localidad", SqlDbType.Int).Value = objusu.id_localidad
                .Add("@Domicilio", SqlDbType.VarChar).Value = objusu.domicilio
                .Add("@Barrio", SqlDbType.VarChar).Value = objusu.barrio
                .Add("@Teléfono_Fijo", SqlDbType.VarChar).Value = objusu.telefono_fijo
                .Add("@Teléfono_Celular", SqlDbType.VarChar).Value = objusu.telefono_celular
                .Add("@E_mail", SqlDbType.VarChar).Value = objusu.e_mail
                .Add("@Contacto_Emergencia", SqlDbType.VarChar).Value = objusu.contacto_emergencia
                .Add("@Federado", SqlDbType.VarChar).Value = objusu.federado
                .Add("@Id_Club_Federación", SqlDbType.Int).Value = objusu.id_club_federacion
                .Add("@Otra_Institución", SqlDbType.VarChar).Value = objusu.otra_institucion
                .Add("@Dorsal", SqlDbType.Int).Value = objusu.dorsal
                .Add("@Estado_Atleta", SqlDbType.VarChar).Value = objusu.estado_atleta

                da.SelectCommand.ExecuteNonQuery()
                MsgBox("Atleta registrado correctamente", MsgBoxStyle.Information)
            End With
        Catch ex As Exception
            MsgBox("Error al registrar al Atleta", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub


    Public Sub ActualizarAtleta(ByVal atleta As CEAtletas)

        ActualizarAtleta(atleta.id_atleta,
                         atleta.Nombre_atleta,
                         atleta.Apellido_atleta,
                         atleta.fecha_nacimiento,
                         atleta.id_sexo,
                         atleta.dni_atleta,
                         atleta.nacionalidad,
                         atleta.id_provincia,
                         atleta.id_localidad,
                         atleta.domicilio,
                         atleta.barrio,
                         atleta.telefono_fijo,
                         atleta.telefono_celular,
                         atleta.e_mail,
                         atleta.contacto_emergencia,
                         atleta.federado,
                         atleta.id_club_federacion,
                         atleta.otra_institucion,
                         atleta.dorsal,
                         atleta.estado_atleta)
    End Sub

    Public Sub ActualizarAtleta(ByVal id_atleta As Integer,
                                 ByVal nombre_atleta As String,
                                 ByVal apellido_atleta As String,
                                 ByVal fecha_nacimiento As Date,
                                 ByVal sexo As Integer,
                                 ByVal dni As String,
                                 ByVal nacionalidad As String,
                                 ByVal id_provincia As Integer,
                                 ByVal id_localidad As Integer,
                                 ByVal domicilio As String,
                                 ByVal barrio As String,
                                 ByVal telefono_fijo As String,
                                 ByVal telefono_celular As String,
                                 ByVal e_mail As String,
                                 ByVal contacto_emergencia As String,
                                 ByVal federado As String,
                                 ByVal id_club_federacion As Integer,
                                 ByVal otra_institucion As String,
                                 ByVal dorsal As Integer,
                                 ByVal estado_atleta As String)
        cn = objcon.Conectar
        cmd = New SqlCommand("ACTUALIZARATLETA", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@Id_Atleta", SqlDbType.Int).Value = id_atleta '0
        cmd.Parameters.Add("@Nombre_Atleta", SqlDbType.VarChar).Value = nombre_atleta '1
        cmd.Parameters.Add("@Apellido_Atleta", SqlDbType.VarChar).Value = apellido_atleta '2
        cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = fecha_nacimiento '3
        cmd.Parameters.Add("@Id_Sexo", SqlDbType.Int).Value = sexo '4
        cmd.Parameters.Add("@Dni", SqlDbType.VarChar).Value = dni
        cmd.Parameters.Add("@Nacionalidad", SqlDbType.VarChar).Value = nacionalidad '5
        cmd.Parameters.Add("@Id_Provincia", SqlDbType.Int).Value = id_provincia '6
        cmd.Parameters.Add("@Id_Localidad", SqlDbType.Int).Value = id_localidad '7
        cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = domicilio '8
        cmd.Parameters.Add("@Barrio", SqlDbType.VarChar).Value = barrio '9
        cmd.Parameters.Add("@Teléfono_Fijo", SqlDbType.VarChar).Value = telefono_fijo '10
        cmd.Parameters.Add("@Teléfono_Celular", SqlDbType.VarChar).Value = telefono_celular '11
        cmd.Parameters.Add("@E_mail", SqlDbType.VarChar).Value = e_mail '12
        cmd.Parameters.Add("@Contacto_Emergencia", SqlDbType.VarChar).Value = contacto_emergencia '13
        cmd.Parameters.Add("@Federado", SqlDbType.VarChar).Value = federado '14
        cmd.Parameters.Add("@Id_Club_Federación", SqlDbType.Int).Value = id_club_federacion '15
        cmd.Parameters.Add("@Otra_Institución", SqlDbType.VarChar).Value = otra_institucion '16
        cmd.Parameters.Add("@Dorsal", SqlDbType.Int).Value = dorsal '17
        cmd.Parameters.Add("@Estado_Atleta", SqlDbType.VarChar).Value = estado_atleta '18
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub eliminarAtleta(ByVal cod As Integer)
        Try
            cn = objcon.Conectar
            Dim cmd = New SqlCommand("ELIMINARATLETA", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id_Atleta", SqlDbType.Int).Value = cod
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("El Atleta ha sido eliminado correctamente")
        Catch ex As Exception
            MsgBox("Error al eliminar al Atleta" + ex.ToString)
        End Try
    End Sub
End Class
