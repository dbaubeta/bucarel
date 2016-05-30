Public Class ListaStockProductos


    Dim ctrl As New Negocio.Controller

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            btnAgregar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            btnEditar_Click(sender, e)
        End If
    End Sub

    Private Sub DTPFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles DTPFecha.KeyDown
        Form1_KeyDown(sender, e)
    End Sub

    Private Sub DGStockproductos_KeyDown(sender As Object, e As KeyEventArgs) Handles DGStockproductos.KeyDown
        Form1_KeyDown(sender, e)
    End Sub


    Private Sub Ingresoproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.btnEditar.Enabled = False
        Me.CenterToScreen()
        ctrl.llenarGrillaStockproducto(Me.DGStockproductos, Me.DTPFecha.Value)
        ctrl.llenarComboboxproductos(Me.cbproductos)

    End Sub



    Private Sub DTPFecha_ValueChanged(sender As Object, e As EventArgs) Handles DTPFecha.ValueChanged

        Me.btnEditar.Enabled = False
        ctrl.llenarGrillaStockproducto(Me.DGStockproductos, Me.DTPFecha.Value)
        Me.DGStockproductos.Refresh()
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub


    Private Sub DGStockproductos_SelectionChanged(sender As Object, e As EventArgs) Handles DGStockproductos.SelectionChanged

        If Not IsNothing(DGStockproductos.CurrentRow) Then
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        Else
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        End If

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim oe As New Entidades.Stockproducto
        Dim pant As New Bucarel.Stockproducto
        oe.cantidad = 0
        oe.fecha = Now
        pant.Stockproducto = oe
        pant.DateTimePicker1.Value = Me.DTPFecha.Value

        pant.ShowDialog()
        If pant.save Then
            ctrl.InsertarStockproducto(pant.Stockproducto)
        End If
        pant.Dispose()
        ctrl.llenarGrillaStockproducto(Me.DGStockproductos, Me.DTPFecha.Value)
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim oe As New Entidades.Stockproducto
        Dim pant As New Bucarel.Stockproducto
        oe.cantidad = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto).cantidad
        oe.productoid = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto).productoid
        oe.ID = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto).ID
        oe.fecha = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto).fecha
        oe.nombre = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto).nombre

        pant.Stockproducto = oe

        pant.ShowDialog()
        If pant.save Then
            ctrl.ModificarStockproducto(pant.Stockproducto)
        End If
        pant.Dispose()
        ctrl.llenarGrillaStockproducto(Me.DGStockproductos, Me.DTPFecha.Value)
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockproductos.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not IsNothing(DGStockproductos.CurrentRow) Then
            Dim p As Entidades.Stockproducto = DirectCast(DGStockproductos.CurrentRow.DataBoundItem, Entidades.Stockproducto)
            Dim result As Integer = MessageBox.Show("Esta seguro que quiere eliminar el movimiento de stock seleccionado?", "Eliminar stock", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ctrl.eliminarStockproducto(p)
                ctrl.llenarGrillaStockproducto(Me.DGStockproductos, Me.DTPFecha.Value)
                If Me.DGStockproductos.RowCount = 0 Then Me.btnEditar.Enabled = False
                If Me.DGStockproductos.RowCount = 0 Then Me.btnEliminar.Enabled = False

            End If
        End If

    End Sub

    Private Sub DGStockproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGStockproductos.CellContentClick

    End Sub
End Class