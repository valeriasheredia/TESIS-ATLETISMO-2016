Public Class CEAtletas_x_Competencia

    Private _Id_atleta_x_competencia As Integer
    Public Property Id_atleta_x_competencia() As Integer
        Get
            Return _Id_atleta_x_competencia
        End Get
        Set(value As Integer)
            _Id_atleta_x_competencia = value
        End Set
    End Property

    Private _id_competencia As Integer
    Public Property id_competencia() As Integer
        Get
            Return _id_competencia
        End Get
        Set(value As Integer)
            _id_competencia = value
        End Set
    End Property


    Private _id_atleta As Integer
    Public Property id_atleta() As Integer
        Get
            Return _id_atleta
        End Get
        Set(value As Integer)
            _id_atleta = value
        End Set
    End Property

    Private _id_resultado_parcial As Integer
    Public Property id_resultado_parcial() As Integer
        Get
            Return _id_resultado_parcial
        End Get
        Set(value As Integer)
            _id_resultado_parcial = value
        End Set
    End Property

    Private _id_resultado_final As Integer
    Public Property id_resultado_final() As Integer
        Get
            Return _id_resultado_final
        End Get
        Set(value As Integer)
            _id_resultado_final = value
        End Set
    End Property

    ' definicion y propiedad de la clave foranea
    'Private _ListaAtletas As List(Of CEAtletas_x_Competencia)
    'Public Property ListaAtletas() As List(Of CEAtletas_x_Competencia)
    '    Get
    '        Return _ListaAtletas
    '    End Get
    '    Set(value As List(Of CEAtletas_x_Competencia))
    '        _ListaAtletas = value
    '    End Set
    'End Property

    Private _Lista_Calle As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Calle() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Calle
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Calle = value
        End Set
    End Property

    Private _Lista_Cross_Country As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Cross_Country() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Cross_Country
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Cross_Country = value
        End Set
    End Property

    Private _Lista_Fondo As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Fondo() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Fondo
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Fondo = value
        End Set
    End Property

    Private _Lista_Lanzamiento As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Lanzamiento() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Lanzamiento
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Lanzamiento = value
        End Set
    End Property

    Private _Lista_Maraton As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Maraton() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Maraton
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Maraton = value
        End Set
    End Property

    Private _Lista_Marcha As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Marcha() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Marcha
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Marcha = value
        End Set
    End Property

    Private _Lista_Medio_Fondo As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Medio_Fondo() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Medio_Fondo
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Medio_Fondo = value
        End Set
    End Property

    Private _Lista_Obstaculos As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Obstaculos() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Obstaculos
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Obstaculos = value
        End Set
    End Property

    Private _Lista_Salto As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Salto() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Salto
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Salto = value
        End Set
    End Property

    Private _Lista_Velocidad As List(Of CEAtletas_x_Competencia)
    Public Property Lista_Velocidad() As List(Of CEAtletas_x_Competencia)
        Get
            Return _Lista_Velocidad
        End Get
        Set(value As List(Of CEAtletas_x_Competencia))
            _Lista_Velocidad = value
        End Set
    End Property
End Class
