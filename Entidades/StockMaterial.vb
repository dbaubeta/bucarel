Public Class StockMaterial


    Private _ID As Long
    Public Property ID() As Long
        Get
            Return _ID
        End Get
        Set(ByVal value As Long)
            _ID = value
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

    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _materialid As Long
    Public Property materialid() As Long
        Get
            Return _materialid
        End Get
        Set(ByVal value As Long)
            _materialid = value
        End Set
    End Property



End Class
