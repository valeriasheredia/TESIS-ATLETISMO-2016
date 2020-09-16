Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNAtletas
    ' creamos el objeto de capa datos
    Dim objatleta As New DAOAtletas

    'este  metodo devulve un vector con los objetos del tipo Atleta
    Public Function ListadoDeAtletasDTO() As List(Of CEAtletas)
        Return objatleta.ListadoDeAtletasDTO()
    End Function


    'implementamos la funcion que retorna el data set
    Public Function listadoatletas() As DataSet
        Return objatleta.listadoatletas
    End Function

    'llamamos a la funcion generar
    Public Function nuevocodigoatleta() As String
        Return objatleta.nuevoCodigoatleta
    End Function

    Public Function Sexoatleta() As DataSet
        Return objatleta.Sexoatleta
    End Function

    'lista de las provincias
    Public Function ListaProvinciaAtleta() As DataSet
        Return objatleta.ListaProvinciaAtleta
    End Function

    'lista de las localidades
    Public Function ListaLocalidadAtleta() As DataSet
        Return objatleta.ListaLocalidadAtleta
    End Function

    Public Function ListaClubAtleta() As DataSet
        Return objatleta.ListaClubAtleta
    End Function

    'lista de las localidades segun la provincia
    Public Function ListaLocalidadAtleta(Id_Provincia As Integer) As DataSet
        Return objatleta.ListaLocalidadAtleta(Id_Provincia)
    End Function

    ' llamamos al procedimiento de registro de usuario
    Public Sub nuevoatleta(ByVal obju As CEAtletas)
        objatleta.nuevoatleta(obju)
    End Sub

    Public Sub eliminarAtleta(ByVal Id As Integer)
        objatleta.eliminarAtleta(Id)
    End Sub

    Public Sub ActualizarAtleta(ByVal atleta As CEAtletas)
        objatleta.ActualizarAtleta(atleta.id_atleta,
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
End Class

