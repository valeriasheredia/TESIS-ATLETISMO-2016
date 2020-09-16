Public Class CEIngreso
    Private _nombre_usuario As Integer

    Public Property nombre_usuario() As Integer
        Get
            Return _nombre_usuario
        End Get
        Set(ByVal value As Integer)
            _nombre_usuario = value
        End Set
    End Property

    Private _contraseña As String
    Public Property contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property

    Private _id_perfil_usuario As String
    Public Property id_perfil_usuario() As String
        Get
            Return _id_perfil_usuario
        End Get
        Set(ByVal value As String)
            _id_perfil_usuario = value
        End Set
    End Property
End Class
