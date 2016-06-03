Public Class Controller

    Dim bd As New BD.BD


    Public Sub New()
        bd.Conectar()
    End Sub


    Public Sub llenarComboboxTalleres(ByRef c As Object)

        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        c.datasource = bd.obtenertalleres

    End Sub

    Public Sub llenarComboboxTalles(ByRef c As Object, p As Entidades.producto, Optional minuslist As List(Of Entidades.talle) = Nothing)

        Dim temp As List(Of Entidades.talle)

        c.datasource = Nothing
        c.items.clear()
        c.DisplayMember = "nombre"
        c.ValueMember = "id"
        temp = p.talles 'bd.obtenertalles

        If Not IsNothing(minuslist) Then
            For Each m As Entidades.talle In minuslist
                temp.RemoveAll(Function(i) i.ID = m.ID)
            Next
        End If
        c.datasource = temp

    End Sub

    Public Sub llenarComboboxTalles(ByRef c As Object, o As Entidades.ordentrabajo, Optional minuslist As List(Of Entidades.talle) = Nothing)

        Dim temp As New List(Of Entidades.talle)

        c.datasource = Nothing
        c.items.clear()

        c.DisplayMember = "nombre"
        c.ValueMember = "id"

        For Each ot As Entidades.ordenTalle In o.listaTalles
            Dim t As New Entidades.talle
            t.ID = ot.IDTalle
            t.nombre = ot.nombre
            temp.Add(t)
        Next

        If Not IsNothing(minuslist) Then
            For Each m As Entidades.talle In minuslist
                temp.RemoveAll(Function(i) i.ID = m.ID)
            Next
        End If
        c.datasource = temp

    End Sub



    Public Sub llenarComboboxProductos(ByRef c As Object)

        c.datasource = Nothing
        c.items.clear()

        c.DisplayMember = "nombre"
        c.ValueMember = "id"

        Dim l As List(Of Entidades.producto) = bd.obtenerProductos
        For Each p In l
            bd.ObtenerTallesParaProducto(p)
        Next

        c.datasource = l


    End Sub

    Public Sub llenarComboboxMateriales(ByRef c As Object, Optional minuslist As List(Of Entidades.material) = Nothing)

        c.datasource = Nothing
        c.items.clear()


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

    Public Sub llenarGrillaStockMaterial(ByRef g As Object)

        g.AutoGenerateColumns = True

        Dim l As List(Of Entidades.StockMaterial) = bd.obtenerStockMateriales
        g.datasource = l

        With g
            .Columns("ID").Visible = False
            .Columns("fecha").DisplayIndex = 0
            .Columns("materialid").DisplayIndex = 1
            .Columns("nombre").DisplayIndex = 2
            .Columns("cantidad").DisplayIndex = 3
            .Columns("cantidad").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("fecha").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("materialid").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("nombre").AutoSizeMode = 16 ' Fill

        End With

    End Sub




    Public Sub llenarGrillaStockMaterial(ByRef g As Object, d As Date)

        g.AutoGenerateColumns = True

        Dim l As List(Of Entidades.StockMaterial) = bd.obtenerStockMateriales(d)
        g.datasource = l

        With g
            .Columns("ID").Visible = False
            .Columns("fecha").DisplayIndex = 0
            .Columns("materialid").DisplayIndex = 1
            .Columns("nombre").DisplayIndex = 2
            .Columns("cantidad").DisplayIndex = 3
            .Columns("cantidad").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("fecha").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("materialid").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("nombre").AutoSizeMode = 16 ' Fill

        End With
        If g.Rows.Count > 0 Then
            g.Rows(0).Selected = True
        End If


    End Sub

    Public Sub llenarGrillaStockProducto(ByRef g As Object)

        g.AutoGenerateColumns = True

        Dim l As List(Of Entidades.StockProducto) = bd.obtenerStockProductos
        g.datasource = l

        With g
            .Columns("ID").Visible = False
            .Columns("fecha").DisplayIndex = 0
            .Columns("productoid").DisplayIndex = 1
            .Columns("nombre").DisplayIndex = 2
            .Columns("cantidad").DisplayIndex = 3
            .Columns("cantidad").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("fecha").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("productoid").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("nombre").AutoSizeMode = 16 ' Fill

        End With

    End Sub

    Public Sub llenarGrillaStockProducto(ByRef g As Object, d As Date)

        g.AutoGenerateColumns = True

        Dim l As List(Of Entidades.StockProducto) = bd.obtenerStockProductos(d)
        g.datasource = l

        With g
            .Columns("ID").Visible = False
            .Columns("fecha").DisplayIndex = 0
            .Columns("productoid").DisplayIndex = 1
            .Columns("nombre").DisplayIndex = 2
            .Columns("cantidad").DisplayIndex = 3
            .Columns("cantidad").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("fecha").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("productoid").AutoSizeMode = 10 ' Ancho de las celdas desplegadas
            .Columns("nombre").AutoSizeMode = 16 ' Fill

        End With
        If g.Rows.Count > 0 Then
            g.Rows(0).Selected = True
        End If


    End Sub

    Public Sub llenarGrillaProductos(ByRef g As Object)

        g.AutoGenerateColumns = True

        Dim l As List(Of Entidades.producto) = bd.obtenerProductos
        For Each p In l
            bd.ObtenerTallesParaProducto(p)
        Next
        g.datasource = l
    End Sub

    Public Sub llenarGrillaProductos(ByRef g As Object, search As String)

        g.AutoGenerateColumns = True
        Dim l As List(Of Entidades.producto) = bd.obtenerProductosPorNombre(search)
        For Each p In l
            bd.ObtenerTallesParaProducto(p)
        Next
        g.datasource = l

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

    Public Sub eliminarorden(ByRef p As Entidades.ordentrabajo)

        bd.EliminarOrden(p)

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
        g.datasource = o.listaRecepciones

    End Sub

    Public Function obtenerReporteStock() As List(Of Entidades.reportestock)

        Return bd.obtenerreportestock

    End Function


    Public Function obtenerTalles() As List(Of Entidades.talle)

        Return bd.obtenertalles

    End Function


    ' ================================================================================================================================
    ' StockMaterial


    Public Sub InsertarStockMaterial(ByRef p As Entidades.StockMaterial)

        bd.InsertarStockMaterial(p)

    End Sub


    Public Sub ModificarStockMaterial(ByRef p As Entidades.StockMaterial)

        bd.ModificarStockMaterial(p)

    End Sub



    Public Sub eliminarStockMaterial(ByRef p As Entidades.StockMaterial)

        bd.EliminarStockMaterial(p)

    End Sub



    ' ================================================================================================================================
    ' StockMaterial


    Public Sub InsertarStockProducto(ByRef p As Entidades.StockProducto)

        bd.InsertarStockProducto(p)

    End Sub


    Public Sub ModificarStockProducto(ByRef p As Entidades.StockProducto)

        bd.ModificarStockProducto(p)

    End Sub



    Public Sub eliminarStockProducto(ByRef p As Entidades.StockProducto)

        bd.EliminarStockProducto(p)

    End Sub




End Class
