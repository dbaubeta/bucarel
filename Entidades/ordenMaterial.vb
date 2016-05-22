Public Class ordenMaterial

    Private _IDMaterial As Long
    Public Property IDMaterial() As Long
        Get
            Return _IDMaterial
        End Get
        Set(ByVal value As Long)
            _IDMaterial = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _cantidad As Long
    Public Property cantidad() As Long
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Long)
            _cantidad = value
        End Set
    End Property



End Class
