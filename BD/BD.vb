﻿Imports Npgsql

Public Class BD

    Dim cn As Npgsql.NpgsqlConnection

    Public Sub Conectar()
        cn = New NpgsqlConnection("Host=localhost;Username=bucarel;Password=bucarel2015;Database=bucarel")
        cn.Open()
    End Sub

    Public Sub Desconectar()
        cn.Close()
    End Sub

    Public Function obtenerreportestock() As List(Of Entidades.reportestock)
        Dim l As New List(Of Entidades.reportestock)
        'cn.Open()
        Dim c As New NpgsqlCommand("select productoid, productonombre, fecha, talleid, tallenombre, sum(stock) stock from ( " + _
                                    "select productoid, p.nombre productonombre, fecha, talleid, t.nombre tallenombre, cantidad stock from stockproducto sp  " + _
                                    "join producto p on p.id = sp.productoid " + _
                                    "join talle t on t.id = sp.talleid " + _
                                    "union " + _
                                    "select productoid, p.nombre productonombre, sp.fecha, talleid, t.nombre tallenombre, cantidad stock from ordenentrega sp  " + _
                                    "join ordentrabajo o on o.id = sp.ordenid " + _
                                    "join producto p on p.id = o.productoid " + _
                                    "join talle t on t.id = sp.talleid) as x " + _
                                    "group by productoid, productonombre, fecha, talleid, tallenombre " + _
                                    "order by productonombre, tallenombre", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.reportestock
            p.grupo1 = "Productos"
            p.productoid = r.Item("productoid")
            p.productonombre = r.Item("productonombre")
            p.talle = r.Item("tallenombre")
            p.stock = r.Item("stock")
            l.Add(p)

        Loop

        r.Close()

        Return l

        'cn.Close()

    End Function


    Public Function obtenertalles() As List(Of Entidades.talle)
        Dim l As New List(Of Entidades.talle)
        'cn.Open()
        Dim c As New NpgsqlCommand("select id, nombre from talle", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.talle
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            l.Add(p)

        Loop

        r.Close()

        Return l

        'cn.Close()

    End Function


    Public Function obtenerProductos() As List(Of Entidades.producto)
        Dim l As New List(Of Entidades.producto)
        'cn.Open()
        Dim c As New NpgsqlCommand("select id, nombre, precio, activo from producto", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.producto
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            p.precio = r.Item("precio")
            p.activo = r.Item("activo")
            l.Add(p)

        Loop

        r.Close()

        Return l

        'cn.Close()

    End Function

    Public Function obtenerProductosPorNombre(search As String) As List(Of Entidades.producto)
        Dim l As New List(Of Entidades.producto)
        '       cn.Open()

        Dim c As New NpgsqlCommand("select id, nombre, precio, activo from producto where upper(nombre) like upper(:nombre)", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, "%" + search + "%")
        c.Prepare()

        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.producto
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            p.precio = r.Item("precio")
            p.activo = r.Item("activo")
            l.Add(p)

        Loop

        r.Close()
        '        cn.Close()
        Return l


    End Function

    Public Sub InsertarProducto(ByRef p As Entidades.producto)

        Dim c As New NpgsqlCommand("insert into producto (nombre, precio, activo) values(:nombre, :precio, :activo) returning id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
        c.Parameters.AddWithValue("precio", NpgsqlTypes.NpgsqlDbType.Numeric, p.precio)
        c.Parameters.AddWithValue("activo", NpgsqlTypes.NpgsqlDbType.Boolean, p.activo)

        Dim r As NpgsqlDataReader = c.ExecuteReader()
        Do While r.Read
            p.ID = r.GetInt32(0)
        Loop
        r.Close()

    End Sub

    Public Sub ModificarProducto(ByRef p As Entidades.producto)

        Dim c As New NpgsqlCommand("update producto set nombre = :nombre, precio = :precio, activo= :activo where id = :id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
        c.Parameters.AddWithValue("precio", NpgsqlTypes.NpgsqlDbType.Numeric, p.precio)
        c.Parameters.AddWithValue("activo", NpgsqlTypes.NpgsqlDbType.Boolean, p.activo)
        c.Parameters.AddWithValue("ID", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)

        c.ExecuteNonQuery()

    End Sub


    ' ===================================================================================================================================================
    ' materiales 

    Public Function obtenermateriales() As List(Of Entidades.material)
        Dim l As New List(Of Entidades.material)
        'cn.Open()
        Dim c As New NpgsqlCommand("select id, nombre from material", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.material
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            l.Add(p)

        Loop

        r.Close()

        Return l

        'cn.Close()

    End Function

    Public Function obtenermaterialesPorNombre(search As String) As List(Of Entidades.material)
        Dim l As New List(Of Entidades.material)
        '       cn.Open()

        Dim c As New NpgsqlCommand("select id, nombre from material where upper(nombre) like upper(:nombre)", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, "%" + search + "%")
        c.Prepare()

        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.material
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            l.Add(p)

        Loop

        r.Close()
        '        cn.Close()
        Return l


    End Function

    Public Sub Insertarmaterial(ByRef p As Entidades.material)

        Dim c As New NpgsqlCommand("insert into material (nombre) values(:nombre) returning id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)

        Dim r As NpgsqlDataReader = c.ExecuteReader()
        Do While r.Read
            p.ID = r.GetInt32(0)
        Loop
        r.Close()

    End Sub

    Public Sub Modificarmaterial(ByRef p As Entidades.material)

        Dim c As New NpgsqlCommand("update material set nombre = :nombre where id = :id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
        c.Parameters.AddWithValue("ID", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)

        c.ExecuteNonQuery()

    End Sub





    ' ===================================================================================================================================================
    ' Talleres 

    Public Function obtenertalleres() As List(Of Entidades.taller)
        Dim l As New List(Of Entidades.taller)
        'cn.Open()
        Dim c As New NpgsqlCommand("select id, nombre from taller", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.taller
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            l.Add(p)

        Loop

        r.Close()

        Return l

        'cn.Close()

    End Function

    Public Function obtenertalleresPorNombre(search As String) As List(Of Entidades.taller)
        Dim l As New List(Of Entidades.taller)
        '       cn.Open()

        Dim c As New NpgsqlCommand("select id, nombre from taller where upper(nombre) like upper(:nombre)", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, "%" + search + "%")
        c.Prepare()

        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim p As New Entidades.taller
            p.ID = r.Item("id")
            p.nombre = r.Item("nombre")
            l.Add(p)

        Loop

        r.Close()
        '        cn.Close()
        Return l


    End Function

    Public Sub Insertartaller(ByRef p As Entidades.taller)

        Dim c As New NpgsqlCommand("insert into taller (nombre) values(:nombre) returning id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)

        Dim r As NpgsqlDataReader = c.ExecuteReader()
        Do While r.Read
            p.ID = r.GetInt32(0)
        Loop
        r.Close()

    End Sub

    Public Sub Modificartaller(ByRef p As Entidades.taller)

        Dim c As New NpgsqlCommand("update taller set nombre = :nombre where id = :id", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
        c.Parameters.AddWithValue("ID", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)

        c.ExecuteNonQuery()

    End Sub





    ' ===================================================================================================================================================
    ' ordenes 

    Public Function obtenerOrdenes() As List(Of Entidades.ordentrabajo)
        Dim l As New List(Of Entidades.ordentrabajo)
        'cn.Open()
        Dim c As New NpgsqlCommand("select o.id, o.nombre, o.fecha, o.tallerid, t.nombre tallernombre, o.productoid productoid, p.nombre productonombre from ordentrabajo o join taller t on t.id = o.tallerid join producto p on p.id = o.productoid", cn)
        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim o As New Entidades.ordentrabajo
            o.ID = r.Item("id")
            o.nombre = r.Item("nombre")
            o.fecha = r.Item("fecha")
            Dim t As New Entidades.taller
            t.ID = r.Item("tallerid")
            t.nombre = r.Item("tallernombre")
            o.taller = t
            Dim p As New Entidades.producto
            p.ID = r.Item("productoid")
            p.nombre = r.Item("productonombre")
            o.producto = p
            l.Add(o)

            r.Close()

        Loop

        r.Close()

        OrdenCargarListas(l)

        Return l

        'cn.Close()

    End Function

    Public Function obtenerOrdenesPorNombre(search As String) As List(Of Entidades.ordentrabajo)
        Dim l As New List(Of Entidades.ordentrabajo)
        '       cn.Open()

        Dim c As New NpgsqlCommand("select o.id, o.nombre, o.fecha, o.tallerid, t.nombre tallernombre, o.productoid productoid, p.nombre productonombre from ordentrabajo o join taller t on t.id = o.tallerid join producto p on p.id = o.productoid where upper(nombre) like upper(:nombre)", cn)
        c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, "%" + search + "%")
        c.Prepare()

        Dim r As NpgsqlDataReader = c.ExecuteReader

        Do While r.Read

            Dim o As New Entidades.ordentrabajo
            o.ID = r.Item("id")
            o.nombre = r.Item("nombre")
            o.fecha = r.Item("fecha")
            Dim t As New Entidades.taller
            t.ID = r.Item("tallerid")
            t.nombre = r.Item("tallernombre")
            o.taller = t
            Dim p As New Entidades.producto
            p.ID = r.Item("productoid")
            p.nombre = r.Item("productonombre")
            o.producto = p
            l.Add(o)

        Loop

        r.Close()

        OrdenCargarListas(l)


        Return l


    End Function




    Private Sub OrdenCargarListas(ByRef l As List(Of Entidades.ordentrabajo))


        For Each p As Entidades.ordentrabajo In l


            ' Agregar lista de talles pedidos en la orden
            Dim tc As New NpgsqlCommand("select ot.id id, ot.talleid talleid, t.nombre nombre , ot.cantidad cantidad from ordentalle ot join talle t on t.id = ot.talleid where ordenid = :ordenid", cn)
            tc.Parameters.AddWithValue("ordenid", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            tc.Prepare()

            Dim tr As NpgsqlDataReader = tc.ExecuteReader
            Dim tl As New List(Of Entidades.ordenTalle)

            Do While tr.Read

                Dim ot As New Entidades.ordenTalle
                ot.IDTalle = tr.Item("talleid")
                ot.nombre = tr.Item("nombre")
                ot.cantidad = tr.Item("cantidad")
                tl.Add(ot)

            Loop
            tr.Close()
            p.listaTalles = tl

            ' Agregar lista de materiales utilizados en la orden
            Dim mc As New NpgsqlCommand("select om.id id, om.materialid materialid, m.nombre nombre , om.cantidad cantidad from ordenmaterial om join material m on m.id = om.materialid  where ordenid = :ordenid", cn)
            mc.Parameters.AddWithValue("ordenid", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            mc.Prepare()

            Dim mr As NpgsqlDataReader = mc.ExecuteReader
            Dim ml As New List(Of Entidades.ordenMaterial)

            Do While mr.Read

                Dim om As New Entidades.ordenMaterial
                om.IDMaterial = mr.Item("materialid")
                om.nombre = mr.Item("nombre")
                om.cantidad = mr.Item("cantidad")
                ml.Add(om)

            Loop
            mr.Close()

            ' Agregar lista de entregas hechas en la orden
            Dim ec As New NpgsqlCommand("select oe.id id, oe.talleid talleid, t.nombre nombre , oe.cantidad cantidad, oe.fecha fecha from ordenentrega oe join talle t on t.id = oe.talleid where ordenid = :ordenid", cn)
            ec.Parameters.AddWithValue("ordenid", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            ec.Prepare()

            Dim er As NpgsqlDataReader = ec.ExecuteReader
            Dim el As New List(Of Entidades.ordenEntrega)

            Do While er.Read

                Dim oe As New Entidades.ordenEntrega
                oe.ID = er.Item("id")
                oe.IDTalle = er.Item("talleid")
                oe.nombre = er.Item("nombre")
                oe.cantidad = er.Item("cantidad")
                oe.fecha = er.Item("fecha")
                el.Add(oe)

            Loop
            er.Close()

            p.listaTalles = tl
            p.listaMateriales = ml
            p.listaEntregas = el


        Next


    End Sub

    Public Sub GuardarOrden(ByRef p As Entidades.ordentrabajo)

        ' Insertar el registro dfe cabecera de la Orden
        If p.ID = 0 Then
            Dim c As New NpgsqlCommand("insert into ordentrabajo (nombre,fecha, productoid, tallerid) values(:nombre , :fecha, :productoid, :tallerid) returning id", cn)
            c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
            c.Parameters.AddWithValue("fecha", NpgsqlTypes.NpgsqlDbType.Date, p.fecha)
            c.Parameters.AddWithValue("productoid", NpgsqlTypes.NpgsqlDbType.Integer, p.producto.ID)
            c.Parameters.AddWithValue("tallerid", NpgsqlTypes.NpgsqlDbType.Integer, p.taller.ID)

            Dim r As NpgsqlDataReader = c.ExecuteReader()
            Do While r.Read
                p.ID = r.GetInt32(0)
            Loop
            r.Close()
        Else
            Dim c As New NpgsqlCommand("update ordentrabajo set nombre = :nombre, fecha = :fecha, productoid = :productoid, tallerid = :tallerid where id = :id", cn)
            c.Parameters.AddWithValue("nombre", NpgsqlTypes.NpgsqlDbType.Text, p.nombre)
            c.Parameters.AddWithValue("fecha", NpgsqlTypes.NpgsqlDbType.Date, p.fecha)
            c.Parameters.AddWithValue("ID", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            c.Parameters.AddWithValue("productoid", NpgsqlTypes.NpgsqlDbType.Integer, p.producto.ID)
            c.Parameters.AddWithValue("tallerid", NpgsqlTypes.NpgsqlDbType.Integer, p.taller.ID)

            c.ExecuteNonQuery()
        End If

        ' Borrar todos los materiales de la orden para volver a grabarlos.
        Dim dom As New NpgsqlCommand("delete from ordenmaterial where ordenid = :id", cn)
        dom.Parameters.AddWithValue("id", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
        dom.ExecuteNonQuery()

        ' Grabar los materiales de la orden
        For Each om As Entidades.ordenMaterial In p.listaMateriales
            Dim c As New NpgsqlCommand("insert into ordenmaterial (ordenid, materialid, cantidad) values(:ordenid, :materialid, :cantidad) returning id", cn)
            c.Parameters.AddWithValue("ordenid", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            c.Parameters.AddWithValue("materialid", NpgsqlTypes.NpgsqlDbType.Integer, om.IDMaterial)
            c.Parameters.AddWithValue("cantidad", NpgsqlTypes.NpgsqlDbType.Integer, om.cantidad)

            Dim r As NpgsqlDataReader = c.ExecuteReader()
            Do While r.Read
                Dim myvar As Long = r.GetInt32(0)
            Loop
            r.Close()

        Next

        ' Borrar todos los talles de la orden para volver a grabarlos.
        Dim tom As New NpgsqlCommand("delete from ordentalle where ordenid = :id", cn)
        tom.Parameters.AddWithValue("id", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
        tom.ExecuteNonQuery()

        ' Grabar los Talles de la orden
        For Each ot As Entidades.ordenTalle In p.listaTalles
            Dim c As New NpgsqlCommand("insert into ordentalle (ordenid, Talleid, cantidad) values(:ordenid, :Talleid, :cantidad) returning id", cn)
            c.Parameters.AddWithValue("ordenid", NpgsqlTypes.NpgsqlDbType.Integer, p.ID)
            c.Parameters.AddWithValue("talleid", NpgsqlTypes.NpgsqlDbType.Integer, ot.IDTalle)
            c.Parameters.AddWithValue("cantidad", NpgsqlTypes.NpgsqlDbType.Integer, ot.cantidad)

            Dim r As NpgsqlDataReader = c.ExecuteReader()
            Do While r.Read
                Dim myvar As Long = r.GetInt32(0)
            Loop
            r.Close()

        Next


    End Sub

End Class

