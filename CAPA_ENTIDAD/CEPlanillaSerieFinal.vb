Public Class CEPlanillaSerieFinal

    Private _Id_SerieFinal As Integer

    Public Property Id_SerieFinal() As Integer
        Get
            Return _Id_SerieFinal
        End Get
        Set(ByVal value As Integer)
            _Id_SerieFinal = value
        End Set
    End Property

    Private _Numero As Integer

    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
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

    Private _Crono1 As DateTime
    Public Property Crono1() As DateTime
        Get
            Return _Crono1
        End Get
        Set(ByVal value As DateTime)
            _Crono1 = value
        End Set
    End Property

    Private _Crono2 As DateTime
    Public Property Crono2() As DateTime
        Get
            Return _Crono2
        End Get
        Set(ByVal value As DateTime)
            _Crono2 = value
        End Set
    End Property

    Private _Crono3 As DateTime
    Public Property Crono3() As DateTime
        Get
            Return _Crono3
        End Get
        Set(ByVal value As DateTime)
            _Crono3 = value
        End Set
    End Property

    Private _Tiempo As DateTime
    Public Property Tiempo() As DateTime
        Get
            Return _Tiempo
        End Get
        Set(ByVal value As DateTime)
            _Tiempo = value
        End Set
    End Property

    Private _Clasificacion_Final As Integer

    Public Property Clasificacion_Final() As Integer
        Get
            Return _Clasificacion_Final
        End Get
        Set(ByVal value As Integer)
            _Clasificacion_Final = value
        End Set
    End Property
End Class
