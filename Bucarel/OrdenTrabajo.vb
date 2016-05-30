Public Class OrdenTrabajo

    Dim ctrl As New Negocio.Controller

    Private _orden As Entidades.ordentrabajo
    Public Property orden() As Entidades.ordentrabajo
        Get
            Return _orden
        End Get
        Set(ByVal value As Entidades.ordentrabajo)
            _orden = value
        End Set
    End Property

    Private _save As Boolean
    Public Property save() As Boolean
        Get
            Return _save
        End Get
        Set(ByVal value As Boolean)
            _save = value
        End Set
    End Property


    Private Sub OrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsNothing(Me.orden.ID) Then
            Me.txtCodigo.Text = Me.orden.ID.ToString
            Me.txtNombre.Text = Me.orden.nombre
            Me.DateTimePicker1.Value = Me.orden.fecha

            ctrl.llenarComboboxTalleres(Me.cbTalleres)
            ctrl.llenarComboboxProductos(Me.cbproductos)

            ' Setear el valor del combo al del taller de la orden
            If Me.orden.ID <> 0 Then
                Dim lt As List(Of Entidades.taller) = DirectCast(Me.cbTalleres.DataSource, List(Of Entidades.taller))
                Me.cbTalleres.SelectedItem = lt.Find(Function(c) c.ID = Me.orden.taller.ID)
            End If
            ' Setear el valor del combo al del producto de la orden
            If Me.orden.ID <> 0 Then
                Dim lp As List(Of Entidades.producto) = DirectCast(Me.cbproductos.DataSource, List(Of Entidades.producto))
                Me.cbproductos.SelectedItem = lp.Find(Function(c) c.ID = Me.orden.producto.ID)
            End If

            ctrl.llenarGrillaOrdenMateriales(Me.DGMateriales, Me.orden)
            ctrl.llenarGrillaOrdenTalles(Me.DGTalles, Me.orden)
            ctrl.llenarGrillaOrdenEntregas(Me.DGEntregas, Me.orden)

        End If

        Me.save = False

    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click


        Me.orden.nombre = Me.txtNombre.Text
        Me.orden.fecha = Me.DateTimePicker1.Value
        Me.orden.producto = DirectCast(Me.cbproductos.SelectedItem, Entidades.producto)
        Me.orden.taller = DirectCast(Me.cbTalleres.SelectedItem, Entidades.taller)
        Me.save = True

        Me.Hide()
    End Sub


    ' Materiales
    ' =============================================================================================================================
    Private Sub btnAddMateriales_Click(sender As Object, e As EventArgs) Handles btnAddMateriales.Click

        Dim om As New Entidades.ordenMaterial
        Dim pant As New Bucarel.OrdenMaterial
        om.cantidad = 0
        pant.ordenmaterial = om
        Dim minus As New List(Of Entidades.material)
        For Each xm As Entidades.ordenMaterial In Me.DGMateriales.DataSource
            Dim m As New Entidades.material
            m.ID = xm.IDMaterial
            m.nombre = xm.nombre
            minus.Add(m)
        Next
        pant.minuslist = minus

        pant.ShowDialog()
        If pant.save Then
            Me.orden.listaMateriales.Add(om)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenMateriales(Me.DGMateriales, Me.orden)


    End Sub


    Private Sub btnDelMateriales_Click(sender As Object, e As EventArgs) Handles btnDelMateriales.Click

        Me.orden.listaMateriales.RemoveAll(Function(i) i.IDMaterial = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).IDMaterial)
        ctrl.llenarGrillaOrdenMateriales(Me.DGMateriales, Me.orden)

    End Sub

    Private Sub btnEditMateriales_Click(sender As Object, e As EventArgs) Handles btnEditMateriales.Click

        Dim om As New Entidades.ordenMaterial
        Dim pant As New Bucarel.OrdenMaterial
        om.cantidad = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).cantidad
        om.IDMaterial = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).IDMaterial
        om.nombre = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).nombre

        pant.ordenmaterial = om
        pant.cbmateriales.Enabled = False
        pant.ShowDialog()
        If pant.save Then
            DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).cantidad = om.cantidad
            DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).IDMaterial = om.IDMaterial
            DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.ordenMaterial).nombre = om.nombre
            ctrl.llenarGrillaOrdenMateriales(Me.DGMateriales, Me.orden)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenMateriales(Me.DGMateriales, Me.orden)

    End Sub

    ' Talles
    ' =============================================================================================================================
    Private Sub btnAddTalles_Click(sender As Object, e As EventArgs) Handles btnAddTalles.Click

        Dim om As New Entidades.ordenTalle
        Dim pant As New Bucarel.OrdenTalle
        om.cantidad = 0
        pant.ordenTalle = om
        pant.producto = DirectCast(Me.cbproductos.SelectedItem, Entidades.producto)
        Dim minus As New List(Of Entidades.talle)
        For Each xm As Entidades.ordenTalle In Me.DGTalles.DataSource
            Dim m As New Entidades.talle
            m.ID = xm.IDTalle
            m.nombre = xm.nombre
            minus.Add(m)
        Next
        pant.minuslist = minus

        pant.ShowDialog()
        If pant.save Then
            Me.orden.listaTalles.Add(om)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenTalles(Me.DGTalles, Me.orden)


    End Sub


    Private Sub btnDelTalles_Click(sender As Object, e As EventArgs) Handles btnDelTalles.Click

        Me.orden.listaTalles.RemoveAll(Function(i) i.IDTalle = DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).IDTalle)
        ctrl.llenarGrillaOrdenTalles(Me.DGTalles, Me.orden)

    End Sub

    Private Sub btnEditTalles_Click(sender As Object, e As EventArgs) Handles btnEditTalles.Click

        Dim om As New Entidades.ordenTalle
        Dim pant As New Bucarel.OrdenTalle
        om.cantidad = DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).cantidad
        om.IDTalle = DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).IDTalle
        om.nombre = DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).nombre

        pant.ordenTalle = om
        pant.producto = DirectCast(Me.cbproductos.SelectedItem, Entidades.producto)
        pant.cbtalles.Enabled = False
        pant.ShowDialog()
        If pant.save Then
            DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).cantidad = om.cantidad
            DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).IDTalle = om.IDTalle
            DirectCast(DGTalles.CurrentRow.DataBoundItem, Entidades.ordenTalle).nombre = om.nombre
            ctrl.llenarGrillaOrdenTalles(Me.DGTalles, Me.orden)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenTalles(Me.DGTalles, Me.orden)

    End Sub


    ' Entregas
    ' =============================================================================================================================
    Private Sub btnAddEntregas_Click(sender As Object, e As EventArgs) Handles btnAddEntregas.Click

        Dim oe As New Entidades.ordenRecepcion
        Dim pant As New Bucarel.OrdenRecepcion
        oe.cantidad = 0
        oe.fecha = Now
        pant.ordenEntrega = oe
        pant.orden = Me.orden

        pant.ShowDialog()
        If pant.save Then
            Me.orden.listaRecepciones.Add(oe)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenEntregas(Me.DGEntregas, Me.orden)

    End Sub


    Private Sub btnDelEntregas_Click(sender As Object, e As EventArgs) Handles btnDelEntregas.Click

        Me.orden.listaRecepciones.RemoveAll(Function(i) i.ID = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).ID)
        ctrl.llenarGrillaOrdenEntregas(Me.DGEntregas, Me.orden)

    End Sub

    Private Sub btnEditEntregas_Click(sender As Object, e As EventArgs) Handles btnEditEntregas.Click

        Dim oe As New Entidades.ordenRecepcion
        Dim pant As New Bucarel.OrdenRecepcion
        oe.cantidad = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).cantidad
        oe.IDTalle = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).IDTalle
        oe.ID = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).ID
        oe.fecha = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).fecha
        oe.nombre = DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).nombre

        pant.ordenEntrega = oe
        pant.orden = Me.orden

        pant.ShowDialog()
        If pant.save Then
            DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).cantidad = oe.cantidad
            DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).ID = oe.ID
            DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).fecha = oe.fecha
            DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).IDTalle = oe.IDTalle
            DirectCast(DGEntregas.CurrentRow.DataBoundItem, Entidades.ordenRecepcion).nombre = oe.nombre
            ctrl.llenarGrillaOrdenEntregas(Me.DGEntregas, Me.orden)
        End If
        pant.Dispose()
        ctrl.llenarGrillaOrdenEntregas(Me.DGEntregas, Me.orden)

    End Sub

    Private Sub btnAddEntregas_Click_1(sender As Object, e As EventArgs) Handles btnAddEntregas.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.save = False
        Me.Hide()

    End Sub

    Private Sub cbproductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproductos.SelectedIndexChanged

    End Sub
End Class