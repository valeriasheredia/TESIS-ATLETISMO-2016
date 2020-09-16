Public Class CEPlanillaFondo

    Private _dorsal As Integer
    Public Property dorsal() As Integer
        Get
            Return _dorsal
        End Get
        Set(value As Integer)
            _dorsal = value
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

    Private _club As Integer
    Public Property club() As Integer
        Get
            Return _club
        End Get
        Set(value As Integer)
            _club = value
        End Set
    End Property

    Private _id_planilla_fondo As Integer

    Public Property id_planilla_fondo() As Integer
        Get
            Return _id_planilla_fondo
        End Get
        Set(ByVal value As Integer)
            _id_planilla_fondo = value
        End Set
    End Property

    Private _tiempo1 As DateTime
    Public Property tiempo1() As DateTime
        Get
            Return _tiempo1
        End Get
        Set(value As DateTime)
            _tiempo1 = value
        End Set
    End Property

    Private _tiempo2 As DateTime
    Public Property tiempo2() As DateTime
        Get
            Return _tiempo2
        End Get
        Set(value As DateTime)
            _tiempo2 = value
        End Set
    End Property

    Private _tiempo3 As DateTime
    Public Property tiempo3() As DateTime
        Get
            Return _tiempo3
        End Get
        Set(value As DateTime)
            _tiempo3 = value
        End Set
    End Property

    Private _tiempofinal As DateTime
    Public Property tiempofinal() As DateTime
        Get
            Return _tiempofinal
        End Get
        Set(value As DateTime)
            _tiempofinal = value
        End Set
    End Property

    Private _clasificacionfinal As Integer
    Public Property clasificacionfinal() As Integer
        Get
            Return _clasificacionfinal
        End Get
        Set(value As Integer)
            _clasificacionfinal = value
        End Set
    End Property

    Private _serie As Integer
    Public Property serie() As Integer
        Get
            Return _serie
        End Get
        Set(value As Integer)
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
