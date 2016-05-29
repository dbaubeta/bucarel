﻿Public Class producto

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

    Private _precio As Double
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    Private _activo As Boolean
    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property


    Private _talles As List(Of Entidades.talle)
    Public Property talles() As List(Of Entidades.talle)
        Get
            Return _talles
        End Get
        Set(ByVal value As List(Of Entidades.talle))
            _talles = value
        End Set
    End Property


    Public Sub New()

        Me.talles = New List(Of talle)


    End Sub



End Class
