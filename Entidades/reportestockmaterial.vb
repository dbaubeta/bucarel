Public Class reportestockmaterial

    Private _group1 As String
    Public Property grupo1() As String
        Get
            Return _group1
        End Get
        Set(ByVal value As String)
            _group1 = value
        End Set
    End Property


    Private _materialid As Long
    Public Property materialid() As Long
        Get
            Return materialid
        End Get
        Set(ByVal value As Long)
            _materialid = value
        End Set
    End Property


    Private _materialnombre As String
    Public Property materialnombre() As String
        Get
            Return _materialnombre
        End Get
        Set(ByVal value As String)
            _materialnombre = value
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
