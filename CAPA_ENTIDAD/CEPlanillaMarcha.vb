Public Class CEPlanillaMarcha
    Private _PlanillaMarcha As List(Of CEPlanillaMarcha)
    Public Property PlanillaMarcha() As List(Of CEPlanillaMarcha)
        Get
            Return _PlanillaMarcha
        End Get
        Set(value As List(Of CEPlanillaMarcha))
            _PlanillaMarcha = value
        End Set
    End Property

    Private _id_planilla_marcha As Integer
    Public Property id_planilla_marcha() As Integer
        Get
            Return _id_planilla_marcha
        End Get
        Set(ByVal value As Integer)
            _id_planilla_marcha = value
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

    Private _Apellido_atleta As String
    Public Property Apellido_atleta() As String
        Get
            Return _Apellido_atleta
        End Get
        Set(ByVal value As String)
            _Apellido_atleta = value
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

    Private _id_club_federacion As Integer
    Public Property id_club_federacion() As Integer
        Get
            Return _id_club_federacion
        End Get
        Set(ByVal value As Integer)
            _id_club_federacion = value
        End Set
    End Property

    Private _Tiempo1 As DateTime
    Public Property Tiempo1() As DateTime
        Get
            Return _Tiempo1
        End Get
        Set(ByVal value As DateTime)
            _Tiempo1 = value
        End Set
    End Property

    Private _Tiempo2 As DateTime
    Public Property Tiempo2() As DateTime
        Get
            Return _Tiempo2
        End Get
        Set(ByVal value As DateTime)
            _Tiempo2 = value
        End Set
    End Property

    Private _Tiempo3 As DateTime
    Public Property Tiempo3() As DateTime
        Get
            Return _Tiempo3
        End Get
        Set(ByVal value As DateTime)
            _Tiempo3 = value
        End Set
    End Property

    Private _tiempo_final_marcha As DateTime
    Public Property tiempo_final_marcha() As DateTime
        Get
            Return _tiempo_final_marcha
        End Get
        Set(value As DateTime)
            _tiempo_final_marcha = value
        End Set
    End Property

    Private _Clasificacion_marcha As Integer
    Public Property Clasificacion_marcha() As Integer
        Get
            Return _Clasificacion_marcha
        End Get
        Set(ByVal value As Integer)
            _Clasificacion_marcha = value
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
