﻿Public Class Controller

    Dim bd As New BD.BD


    Public Sub New()
        bd.Conectar()
    End Sub


    Public Sub llenarComboboxTalleres(ByRef c As Object)

        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        c.datasource = bd.obtenertalleres

    End Sub

    Public Sub llenarComboboxTalles(ByRef c As Object, Optional minuslist As List(Of Entidades.talle) = Nothing)

        Dim temp As List(Of Entidades.talle)

        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        temp = bd.obtenertalles

        If Not IsNothing(minuslist) Then
            For Each m As Entidades.talle In minuslist
                temp.RemoveAll(Function(i) i.ID = m.ID)
            Next
        End If
        c.datasource = temp

    End Sub


    Public Sub llenarComboboxProductos(ByRef c As Object)

        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        c.datasource = bd.obtenerProductos

    End Sub

    Public Sub llenarComboboxMateriales(ByRef c As Object, Optional minuslist As List(Of Entidades.material) = Nothing)

        Dim temp As List(Of Entidades.material)

        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        temp = bd.obtenermateriales

        If Not IsNothing(minuslist) Then
            For Each m As Entidades.material In minuslist
                temp.RemoveAll(Function(i) i.ID = m.ID)
            Next
        End If
        c.datasource = temp

    End Sub


    Public Sub llenarGrillaProductos(ByRef g As Object)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerProductos

    End Sub

    Public Sub llenarGrillaProductos(ByRef g As Object, search As String)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerProductosPorNombre(search)

    End Sub

    Public Sub InsertarProducto(ByRef p As Entidades.producto)

        bd.InsertarProducto(p)

    End Sub

    Public Sub ModificarProducto(ByRef p As Entidades.producto)

        bd.ModificarProducto(p)

    End Sub

    ' ================================================================================================================================
    ' Materiales

    Public Sub llenarGrillaMateriales(ByRef g As Object)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerMateriales

    End Sub

    Public Sub llenarGrillaMateriales(ByRef g As Object, search As String)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerMaterialesPorNombre(search)

    End Sub

    Public Sub InsertarMaterial(ByRef p As Entidades.material)

        bd.Insertarmaterial(p)

    End Sub

    Public Sub ModificarMaterial(ByRef p As Entidades.material)

        bd.Modificarmaterial(p)

    End Sub


    ' ================================================================================================================================
    ' talleres

    Public Sub llenarGrillatalleres(ByRef g As Object)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenertalleres

    End Sub

    Public Sub llenarGrillatalleres(ByRef g As Object, search As String)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenertalleresPorNombre(search)

    End Sub

    Public Sub Insertartaller(ByRef p As Entidades.taller)

        bd.Insertartaller(p)

    End Sub

    Public Sub Modificartaller(ByRef p As Entidades.taller)

        bd.Modificartaller(p)

    End Sub

    ' ================================================================================================================================
    ' ordenes

    Public Sub llenarGrillaordenes(ByRef g As Object)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerordenes

    End Sub

    Public Sub llenarGrillaordenes(ByRef g As Object, search As String)

        g.AutoGenerateColumns = True
        g.datasource = bd.obtenerordenesPorNombre(search)

    End Sub

    Public Sub guardarorden(ByRef p As Entidades.ordentrabajo)

        bd.GuardarOrden(p)

    End Sub

    Public Sub llenarGrillaOrdenTalles(ByRef g As Object, ByRef o As Entidades.ordentrabajo)

        g.datasource = Nothing
        g.AutoGenerateColumns = True
        g.datasource = o.listaTalles

    End Sub



    Public Sub llenarGrillaOrdenMateriales(ByRef g As Object, ByRef o As Entidades.ordentrabajo)

        g.datasource = Nothing
        g.AutoGenerateColumns = True
        g.datasource = o.listaMateriales

    End Sub


    Public Sub llenarGrillaOrdenEntregas(ByRef g As Object, ByRef o As Entidades.ordentrabajo)

        g.datasource = Nothing
        g.AutoGenerateColumns = True
        g.datasource = o.listaEntregas

    End Sub

    Public Function obtenerReporteStock() As List(Of Entidades.reportestock)

        Return bd.obtenerreportestock

    End Function

End Class