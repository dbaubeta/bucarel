Public Class ListaStockMateriales

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

    Private Sub DGStockMateriales_KeyDown(sender As Object, e As KeyEventArgs) Handles DGStockMateriales.KeyDown
        Form1_KeyDown(sender, e)
    End Sub


    Private Sub IngresoMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.btnEditar.Enabled = False
        Me.CenterToScreen()
        ctrl.llenarGrillaStockMaterial(Me.DGStockMateriales, Me.DTPFecha.Value)
        ctrl.llenarComboboxMateriales(Me.cbmateriales)

    End Sub



    Private Sub DTPFecha_ValueChanged(sender As Object, e As EventArgs) Handles DTPFecha.ValueChanged

        Me.btnEditar.Enabled = False
        ctrl.llenarGrillaStockMaterial(Me.DGStockMateriales, Me.DTPFecha.Value)
        Me.DGStockMateriales.Refresh()
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub


    Private Sub DGStockMateriales_SelectionChanged(sender As Object, e As EventArgs) Handles DGStockMateriales.SelectionChanged

        If Not IsNothing(DGStockMateriales.CurrentRow) Then
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        Else
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        End If

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim oe As New Entidades.StockMaterial
        Dim pant As New Bucarel.StockMaterial
        oe.cantidad = 0
        oe.fecha = Now
        pant.StockMaterial = oe
        pant.DateTimePicker1.Value = Me.DTPFecha.Value

        pant.ShowDialog()
        If pant.save Then
            ctrl.InsertarStockMaterial(pant.StockMaterial)
        End If
        pant.Dispose()
        ctrl.llenarGrillaStockMaterial(Me.DGStockMateriales, Me.DTPFecha.Value)
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim oe As New Entidades.StockMaterial
        Dim pant As New Bucarel.StockMaterial
        oe.cantidad = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial).cantidad
        oe.materialid = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial).materialid
        oe.ID = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial).ID
        oe.fecha = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial).fecha
        oe.nombre = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial).nombre

        pant.StockMaterial = oe

        pant.ShowDialog()
        If pant.save Then
            ctrl.ModificarStockMaterial(pant.StockMaterial)
        End If
        pant.Dispose()
        ctrl.llenarGrillaStockMaterial(Me.DGStockMateriales, Me.DTPFecha.Value)
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEditar.Enabled = False
        If Me.DGStockMateriales.RowCount = 0 Then Me.btnEliminar.Enabled = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not IsNothing(DGStockMateriales.CurrentRow) Then
            Dim p As Entidades.StockMaterial = DirectCast(DGStockMateriales.CurrentRow.DataBoundItem, Entidades.StockMaterial)
            Dim result As Integer = MessageBox.Show("Esta seguro que quiere eliminar el movimiento de stock seleccionado?", "Eliminar stock", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ctrl.eliminarStockMaterial(p)
                ctrl.llenarGrillaStockMaterial(Me.DGStockMateriales, Me.DTPFecha.Value)
                If Me.DGStockMateriales.RowCount = 0 Then Me.btnEditar.Enabled = False
                If Me.DGStockMateriales.RowCount = 0 Then Me.btnEliminar.Enabled = False

            End If
        End If

    End Sub

    Private Sub DGStockMateriales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGStockMateriales.CellContentClick

    End Sub
End Class