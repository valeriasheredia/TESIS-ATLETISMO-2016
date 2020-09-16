Public Class CEPlanillaAlto_Garrocha

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

    Private _Altura_1 As Double
    Public Property Altura_1() As Double
        Get
            Return _Altura_1
        End Get
        Set(value As Double)
            _Altura_1 = value
        End Set
    End Property


    Private _Altura_2 As Double
    Public Property Altura_2() As Double
        Get
            Return _Altura_2
        End Get
        Set(value As Double)
            _Altura_2 = value
        End Set
    End Property

    Private _Altura_3 As Double
    Public Property Altura_3() As Double
        Get
            Return _Altura_3
        End Get
        Set(value As Double)
            _Altura_3 = value
        End Set
    End Property

    Private _Altura_4 As Double
    Public Property Altura_4() As Double
        Get
            Return _Altura_4
        End Get
        Set(value As Double)
            _Altura_4 = value
        End Set
    End Property

    Private _Altura_5 As Double
    Public Property Altura_5() As Double
        Get
            Return _Altura_5
        End Get
        Set(value As Double)
            _Altura_5 = value
        End Set
    End Property

    Private _Mejor_Altura As Double
    Public Property Mejor_Altura() As Double
        Get
            Return _Mejor_Altura
        End Get
        Set(value As Double)
            _Mejor_Altura = value
        End Set
    End Property

    Private _Clasificación_Alto_Garrocha As Integer
    Public Property Clasificación_Alto_Garrocha() As Integer
        Get
            Return _Clasificación_Alto_Garrocha
        End Get
        Set(value As Integer)
            _Clasificación_Alto_Garrocha = value
        End Set
    End Property

    Private _Cantidad_Intentos_Alto_Garrocha As Integer
    Public Property Cantidad_Intentos_Alto_Garrocha() As Integer
        Get
            Return _Cantidad_Intentos_Alto_Garrocha
        End Get
        Set(value As Integer)
            _Cantidad_Intentos_Alto_Garrocha = value
        End Set
    End Property

    Private _Cantidad_Intentos_Nulos_Alto_Garrocha As Integer
    Public Property Cantidad_Intentos_Nulos_Alto_Garrocha() As Integer
        Get
            Return _Cantidad_Intentos_Nulos_Alto_Garrocha
        End Get
        Set(value As Integer)
            _Cantidad_Intentos_Nulos_Alto_Garrocha = value
        End Set
    End Property
End Class


