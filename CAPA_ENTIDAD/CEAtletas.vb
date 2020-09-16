Public Class CEAtletas

    Private _id_atleta As Integer

    Public Property id_atleta() As Integer
        Get
            Return _id_atleta
        End Get
        Set(ByVal value As Integer)
            _id_atleta = value
        End Set
    End Property

    Private _Nombre_atleta As String
    Public Property Nombre_atleta() As String
        Get
            Return _Nombre_atleta
        End Get
        Set(ByVal value As String)
            _Nombre_atleta = value
        End Set
    End Property

    Private _Apellido_atleta As String
    Public Property Apellido_atleta() As String
        Get
            Return _Apellido_atleta
        End Get
        Set(ByVal value As String)
            _Apellido_atleta = value
        End Set
    End Property

    Private _dni_atleta As String
    Public Property dni_atleta() As String
        Get
            Return _dni_atleta
        End Get
        Set(ByVal value As String)
            _dni_atleta = value
        End Set
    End Property

    Private _fecha_nacimiento As Date
    Public Property fecha_nacimiento() As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(ByVal value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    Private _nacionalidad As String
    Public Property nacionalidad() As String
        Get
            Return _nacionalidad
        End Get
        Set(ByVal value As String)
            _nacionalidad = value
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

    Private _id_localidad As Integer
    Public Property id_localidad() As Integer
        Get
            Return _id_localidad
        End Get
        Set(value As Integer)
            _id_localidad = value
        End Set
    End Property

    Private _domicilio As String
    Public Property domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
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

    Private _contacto_emergencia As String

    Public Property contacto_emergencia() As String
        Get
            Return _contacto_emergencia
        End Get
        Set(ByVal value As String)
            _contacto_emergencia = value
        End Set
    End Property

    Private _federado As String

    Public Property federado() As String
        Get
            Return _federado
        End Get
        Set(ByVal value As String)
            _federado = value
        End Set
    End Property

    Private _id_club_federacion As Integer
    Public Property id_club_federacion() As Integer
        Get
            Return _id_club_federacion
        End Get
        Set(value As Integer)
            _id_club_federacion = value
        End Set
    End Property

    Private _otra_institucion As String
    Public Property otra_institucion() As String
        Get
            Return _otra_institucion
        End Get
        Set(value As String)
            _otra_institucion = value
        End Set
    End Property

    Private _dorsal As Integer
    Public Property dorsal() As Integer
        Get
            Return _dorsal
        End Get
        Set(value As Integer)
            _dorsal = value
        End Set
    End Property

    Private _estado_atleta As String
    Public Property estado_atleta() As String
        Get
            Return _estado_atleta
        End Get
        Set(value As String)
            _estado_atleta = value
        End Set
    End Property

    Private _id_sexo As Integer

    Public Property id_sexo() As Integer
        Get
            Return _id_sexo
        End Get
        Set(ByVal value As Integer)
            _id_sexo = value
        End Set
    End Property

    Public ReadOnly Property Edad As Int32
        Get
            Return DateDiff(DateInterval.Year, fecha_nacimiento, DateTime.Now)
        End Get
    End Property

End Class
