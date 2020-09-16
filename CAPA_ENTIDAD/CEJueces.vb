Public Class CEJueces
    Private _id_juez As Integer

    Public Property id_juez() As Integer
        Get
            Return _id_juez
        End Get
        Set(ByVal value As Integer)
            _id_juez = value
        End Set
    End Property

    Private _Nombre_j As String
    Public Property Nombre_j() As String
        Get
            Return _Nombre_j
        End Get
        Set(ByVal value As String)
            _Nombre_j = value
        End Set
    End Property

    Private _Apellido_j As String
    Public Property Apellido_j() As String
        Get
            Return _Apellido_j
        End Get
        Set(ByVal value As String)
            _Apellido_j = value
        End Set
    End Property

    Private _Dni_j As String
    Public Property Dni_j() As String
        Get
            Return _Dni_j
        End Get
        Set(ByVal value As String)
            _Dni_j = value
        End Set
    End Property


    Private _nacionalidad_j As String
    Public Property nacionalidad_j() As String
        Get
            Return _nacionalidad_j
        End Get
        Set(ByVal value As String)
            _nacionalidad_j = value
        End Set
    End Property


    Private _direccion_j As String
    Public Property direccion_j() As String
        Get
            Return _direccion_j
        End Get
        Set(ByVal value As String)
            _direccion_j = value
        End Set
    End Property

    Private _id_provincia_j As Integer
    Public Property id_provincia_j() As Integer
        Get
            Return _id_provincia_j

        End Get
        Set(value As Integer)
            _id_provincia_j = value
        End Set
    End Property

    Private _telefono_fijo_j As String

    Public Property telefono_fijo_j() As String
        Get
            Return _telefono_fijo_j
        End Get
        Set(ByVal value As String)
            _telefono_fijo_j = value
        End Set
    End Property

    Private _telefono_celular_j As String

    Public Property telefono_celular_j() As String
        Get
            Return _telefono_celular_j
        End Get
        Set(ByVal value As String)
            _telefono_celular_j = value
        End Set
    End Property

    Private _e_mail_j As String

    Public Property e_mail_j() As String
        Get
            Return _e_mail_j
        End Get
        Set(ByVal value As String)
            _e_mail_j = value
        End Set
    End Property

    Private _id_tipo_juez As Integer

    Public Property id_tipo_juez() As Integer
        Get
            Return _id_tipo_juez
        End Get
        Set(ByVal value As Integer)
            _id_tipo_juez = value
        End Set
    End Property
End Class

