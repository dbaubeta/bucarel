﻿Public Class ListaOrdenes

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
        ctrl.guardarorden(p)
        o.Dispose()



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim p As Entidades.ordentrabajo = DirectCast(DGOrdenes.CurrentRow.DataBoundItem, Entidades.ordentrabajo)
        Dim o As New OrdenTrabajo
        o.orden = p
        o.ShowDialog()
        ctrl.guardarorden(p)
        o.Dispose()
        Me.DGOrdenes.Refresh()


    End Sub
End Class