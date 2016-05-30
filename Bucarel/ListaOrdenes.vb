Public Class ListaOrdenes

    Dim ctrl As New Negocio.Controller


    Private Sub ListaOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        ctrl.llenarGrillaordenes(Me.DGordenes)
        Me.DGOrdenes.Columns("taller").DataPropertyName = "taller"

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs)
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs)
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs)
        Me.Form1_KeyDown(sender, e)
    End Sub
    Private Sub DGordenes_KeyDown(sender As Object, e As KeyEventArgs) Handles DGordenes.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        ElseIf e.KeyCode = Keys.F4 Then
            btnAgregar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            btnEditar_Click(sender, e)
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Me.txtBuscar.Text <> "" Then

                ctrl.llenarGrillaordenes(Me.DGordenes, Me.txtBuscar.Text)

            End If
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim p As New Entidades.ordentrabajo
        Dim o As New OrdenTrabajo
        p.fecha = Now
        o.orden = p
        o.ShowDialog()
        If o.save Then ctrl.guardarorden(p)
        o.Dispose()
        ctrl.llenarGrillaordenes(Me.DGOrdenes)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim p As Entidades.ordentrabajo = DirectCast(DGOrdenes.CurrentRow.DataBoundItem, Entidades.ordentrabajo)
        Dim o As New OrdenTrabajo
        o.orden = p
        o.ShowDialog()
        If o.save Then ctrl.guardarorden(p)
        o.Dispose()
        ctrl.llenarGrillaordenes(Me.DGOrdenes)



    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        Dim p As Entidades.ordentrabajo = DirectCast(DGOrdenes.CurrentRow.DataBoundItem, Entidades.ordentrabajo)
        Dim result As Integer = MessageBox.Show("Esta seguro que quiere eliminar la orden de trabajo?", "Eliminar Orden", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ctrl.eliminarorden(p)
            ctrl.llenarGrillaordenes(Me.DGOrdenes)
        End If


    End Sub

End Class
