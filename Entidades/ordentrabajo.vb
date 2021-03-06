﻿Public Class ordentrabajo

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


    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _listatalles As List(Of Entidades.ordenTalle)
    Public Property listaTalles() As List(Of Entidades.ordenTalle)
        Get
            Return _listatalles
        End Get
        Set(ByVal value As List(Of Entidades.ordenTalle))
            _listatalles = value
        End Set
    End Property

    Private _listaMateriales As List(Of Entidades.ordenMaterial)
    Public Property listaMateriales() As List(Of Entidades.ordenMaterial)
        Get
            Return _listaMateriales
        End Get
        Set(ByVal value As List(Of Entidades.ordenMaterial))
            _listaMateriales = value
        End Set
    End Property

    Private _listaRecepciones As List(Of Entidades.ordenRecepcion)
    Public Property listaRecepciones() As List(Of Entidades.ordenRecepcion)
        Get
            Return _listaRecepciones
        End Get
        Set(ByVal value As List(Of Entidades.ordenRecepcion))
            _listaRecepciones = value
        End Set
    End Property


    Private _taller As Entidades.taller
    Public Property taller() As Entidades.taller
        Get
            Return _taller
        End Get
        Set(ByVal value As Entidades.taller)
            _taller = value
        End Set
    End Property

    Private _producto As Entidades.producto
    Public Property producto() As Entidades.producto
        Get
            Return _producto
        End Get
        Set(ByVal value As Entidades.producto)
            _producto = value
        End Set
    End Property



    Public Sub New()

        Me.listaRecepciones = New List(Of ordenRecepcion)
        Me.listaMateriales = New List(Of ordenMaterial)
        Me.listaTalles = New List(Of ordenTalle)

    End Sub

End Class
