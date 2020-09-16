Public Class CEUsuarios

    'declaracion de propiedades

    Private _id_usuario As Integer

    Public Property id_usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Private _id_provincia As Integer
    Public Property id_provincia() As Integer
        Get
            Return _id_provincia

        End Get
        Set(value As Integer)
            _id_provincia = value
        End Set
    End Property

    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _barrio As String
    Public Property barrio() As String
        Get
            Return _barrio
        End Get
        Set(value As String)
            _barrio = value
        End Set
    End Property

    Private _telefono_fijo As String

    Public Property telefono_fijo() As String
        Get
            Return _telefono_fijo
        End Get
        Set(ByVal value As String)
            _telefono_fijo = value
        End Set
    End Property

    Private _telefono_celular As String

    Public Property telefono_celular() As String
        Get
            Return _telefono_celular
        End Get
        Set(ByVal value As String)
            _telefono_celular = value
        End Set
    End Property


    Private _e_mail As String

    Public Property e_mail() As String
        Get

            Return _e_mail
        End Get
        Set(ByVal value As String)
            _e_mail = value
        End Set
    End Property



    Private _nombre_usuario As String

    Public Property nombre_usuario() As String
        Get
            Return _nombre_usuario
        End Get
        Set(ByVal value As String)
            _nombre_usuario = value
        End Set
    End Property

    Private _contraseña As String

    Public Property contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property

    Private _perfil_usuario As Integer

    Public Property perfil_usuario() As Integer
        Get
            Return _perfil_usuario
        End Get
        Set(ByVal value As Integer)
            _perfil_usuario = value
        End Set
    End Property


End Class
