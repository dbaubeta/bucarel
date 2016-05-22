Public Class reportestock

    Private _group1 As String
    Public Property grupo1() As String
        Get
            Return _group1
        End Get
        Set(ByVal value As String)
            _group1 = value
        End Set
    End Property


    Private _productoid As Long
    Public Property productoid() As Long
        Get
            Return productoid
        End Get
        Set(ByVal value As Long)
            _productoid = value
        End Set
    End Property


    Private _productonombre As String
    Public Property productonombre() As String
        Get
            Return _productonombre
        End Get
        Set(ByVal value As String)
            _productonombre = value
        End Set
    End Property

    Private _stock As Long
    Public Property stock() As Long
        Get
            Return _stock
        End Get
        Set(ByVal value As Long)
            _stock = value
        End Set
    End Property

    Private _talle As String
    Public Property talle() As String
        Get
            Return _talle
        End Get
        Set(ByVal value As String)
            _talle = value
        End Set
    End Property


End Class
