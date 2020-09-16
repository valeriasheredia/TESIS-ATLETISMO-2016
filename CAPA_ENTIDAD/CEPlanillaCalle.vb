Public Class CEPlanillaCalle
   
    Private _PlanillaCalle As List(Of CEPlanillaCalle)
    Public Property ListaAtletas() As List(Of CEPlanillaCalle)
        Get
            Return _PlanillaCalle
        End Get
        Set(value As List(Of CEPlanillaCalle))
            _PlanillaCalle = value
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

    Public ReadOnly Property Edad As Int32
        Get
            Return DateDiff(DateInterval.Year, fecha_nacimiento, DateTime.Now)
        End Get
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

    Private _otra_institucion As String
    Public Property otra_institucion() As String
        Get
            Return _otra_institucion
        End Get
        Set(value As String)
            _otra_institucion = value
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

    Private _id_localidad As Integer
    Public Property id_localidad() As Integer
        Get
            Return _id_localidad
        End Get
        Set(value As Integer)
            _id_localidad = value
        End Set
    End Property

    Private _tiempo_final As DateTime
    Public Property tiempo_final() As DateTime
        Get
            Return _tiempo_final
        End Get
        Set(value As DateTime)
            _tiempo_final = value
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

    Private _id_planilla As Integer
    Public Property id_planilla() As Integer
        Get
            Return _id_planilla
        End Get
        Set(ByVal value As Integer)
            _id_planilla = value
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
End Class
