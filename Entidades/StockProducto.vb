﻿Public Class StockProducto


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

    Private _productoid As Long
    Public Property productoid() As Long
        Get
            Return _productoid
        End Get
        Set(ByVal value As Long)
            _productoid = value
        End Set
    End Property

    Private _talle As Entidades.talle
    Public Property talle() As Entidades.talle
        Get
            Return _talle
        End Get
        Set(ByVal value As Entidades.talle)
            _talle = value
        End Set
    End Property

    Public Sub New()
        Me.talle = New Entidades.talle
    End Sub

    Public ReadOnly Property tallenombre() As String
        Get
            Return Me.talle.nombre
        End Get
    End Property


End Class
