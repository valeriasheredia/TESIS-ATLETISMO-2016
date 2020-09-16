Public Class CEClubFederacion

    Private _id_club_federacion As Integer
    Public Property id_club_federacion() As Integer
        Get
            Return _id_club_federacion
        End Get
        Set(ByVal value As Integer)
            _id_club_federacion = value
        End Set
    End Property

    Private _Nombre_club As String
    Public Property Nombre_club() As String
        Get
            Return _Nombre_club
        End Get
        Set(ByVal value As String)
            _Nombre_club = value
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






End Class

