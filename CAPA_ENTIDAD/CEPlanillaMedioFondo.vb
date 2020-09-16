Public Class CEPlanillaMedioFondo

    '

    Private _id_planilla_medio_fondo As Integer

    Public Property id_planilla_medio_fondo() As Integer
        Get
            Return _id_planilla_medio_fondo
        End Get
        Set(ByVal value As Integer)
            _id_planilla_medio_fondo = value
        End Set
    End Property

    Private _numero As Integer

    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
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

    Private _tiempo1 As DateTime
    Public Property tiempo1() As DateTime
        Get
            Return _tiempo1
        End Get
        Set(ByVal value As DateTime)
            _tiempo1 = value
        End Set
    End Property


    Private _tiempo2 As DateTime
    Public Property tiempo2() As DateTime
        Get
            Return _tiempo2
        End Get
        Set(ByVal value As DateTime)
            _tiempo2 = value
        End Set
    End Property


    Private _tiempo3 As DateTime
    Public Property tiempo3() As DateTime
        Get
            Return _tiempo3
        End Get
        Set(ByVal value As DateTime)
            _tiempo3 = value
        End Set
    End Property

    Private _club As String

    Public Property club() As String
        Get
            Return _club
        End Get
        Set(ByVal value As String)
            _club = value
        End Set
    End Property

    Private _Tiempo_final As DateTime
    Public Property Tiempo_final() As DateTime
        Get
            Return _Tiempo_final
        End Get
        Set(ByVal value As DateTime)
            _Tiempo_final = value
        End Set
    End Property

    Private _Clasificacion_Medio_Fondo_Final As Integer

    Public Property Clasificacion_Medio_Fondo_Final() As Integer
        Get
            Return _Clasificacion_Medio_Fondo_Final
        End Get
        Set(ByVal value As Integer)
            _Clasificacion_Medio_Fondo_Final = value
        End Set
    End Property

    Private _serie As Integer

    Public Property serie() As Integer
        Get
            Return _serie
        End Get
        Set(ByVal value As Integer)
            _serie = value
        End Set
    End Property

    Private _juez1 As Integer
    Public Property juez1() As Integer
        Get
            Return _juez1
        End Get
        Set(value As Integer)
            _juez1 = value
        End Set
    End Property

    Private _juez2 As Integer
    Public Property juez2() As Integer
        Get
            Return _juez2
        End Get
        Set(value As Integer)
            _juez2 = value
        End Set
    End Property

    Private _juez3 As Integer
    Public Property juez3() As Integer
        Get
            Return _juez3
        End Get
        Set(value As Integer)
            _juez3 = value
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
End Class
