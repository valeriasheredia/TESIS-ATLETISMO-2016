Public Class CEPlanillaLanzamiento

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

    Private _id_club_federacion As Integer
    Public Property id_club_federacion() As Integer
        Get
            Return _id_club_federacion
        End Get
        Set(value As Integer)
            _id_club_federacion = value
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


    Private _Primer_Lanzamiento As Double
    Public Property Primer_Lanzamiento() As Double
        Get
            Return _Primer_Lanzamiento
        End Get
        Set(value As Double)
            _Primer_Lanzamiento = value
        End Set
    End Property


    Private _Segundo_Lanzamiento As Double
    Public Property Segundo_Lanzamiento() As Double
        Get
            Return _Segundo_Lanzamiento
        End Get
        Set(value As Double)
            _Segundo_Lanzamiento = value
        End Set
    End Property

    Private _Tercer_Lanzamiento As Double
    Public Property Tercer_Lanzamiento() As Double
        Get
            Return _Tercer_Lanzamiento
        End Get
        Set(value As Double)
            _Tercer_Lanzamiento = value
        End Set
    End Property

    Private _Cuarto_Lanzamiento As Double
    Public Property Cuarto_Lanzamiento() As Double
        Get
            Return _Cuarto_Lanzamiento
        End Get
        Set(value As Double)
            _Cuarto_Lanzamiento = value
        End Set
    End Property

    Private _Quinto_Lanzamiento As Double
    Public Property Quinto_Lanzamiento() As Double
        Get
            Return _Quinto_Lanzamiento
        End Get
        Set(value As Double)
            _Quinto_Lanzamiento = value
        End Set
    End Property


    Private _Sexto_Lanzamiento As Double
    Public Property Sexto_Lanzamiento() As Double
        Get
            Return _Sexto_Lanzamiento
        End Get
        Set(value As Double)
            _Sexto_Lanzamiento = value
        End Set
    End Property

    Private _Mejor_Lanzamiento123 As Double
    Public Property Mejor_Lanzamiento123() As Double
        Get
            Return _Mejor_Lanzamiento123
        End Get
        Set(value As Double)
            _Mejor_Lanzamiento123 = value
        End Set
    End Property

    Private _Orden_Lanzamiento As Double
    Public Property Orden_Lanzamiento() As Double
        Get
            Return _Orden_Lanzamiento
        End Get
        Set(value As Double)
            _Orden_Lanzamiento = value
        End Set
    End Property

    Private _Mejor_Lanzamiento456 As Double
    Public Property Mejor_Lanzamiento456() As Double
        Get
            Return _Mejor_Lanzamiento456
        End Get
        Set(value As Double)
            _Mejor_Lanzamiento456 = value
        End Set
    End Property

    Private _Clasificación_Lanzamiento As Double
    Public Property Clasificación_Lanzamiento() As Double
        Get
            Return _Clasificación_Lanzamiento
        End Get
        Set(value As Double)
            _Clasificación_Lanzamiento = value
        End Set
    End Property

    Private _id_juez As Integer
    Public Property id_juez() As Integer
        Get
            Return _id_juez
        End Get
        Set(value As Integer)
            _id_juez = value
        End Set
    End Property
End Class
