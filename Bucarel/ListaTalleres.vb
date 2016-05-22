Public Class Listatalleres

    Dim ctrl As New Negocio.Controller


    Private Sub Listatalleres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim img As New Bitmap(Me.btnguardar.Image, Me.btnguardar.Height, Me.btnguardar.Height)
        'btnguardar.Image = img

        Me.CenterToScreen()
        ctrl.llenarGrillatalleres(Me.DGtalleres)

    End Sub


    Private Sub DGtalleres_SelectionChanged(sender As Object, e As EventArgs) Handles DGtalleres.SelectionChanged

        If Not IsNothing(DGtalleres.CurrentRow.DataBoundItem) Then

            Me.txtCodigo.Text = DirectCast(DGtalleres.CurrentRow.DataBoundItem, Entidades.taller).ID.ToString
            Me.txtNombre.Text = DirectCast(DGtalleres.CurrentRow.DataBoundItem, Entidades.taller).nombre.ToString
            Me.txtNombre.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub DGtalleres_KeyDown(sender As Object, e As KeyEventArgs) Handles DGtalleres.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        ElseIf e.KeyCode = Keys.F4 Then
            btnAgregar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnguardar_Click(sender, e)
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Me.txtBuscar.Text <> "" Then

                ctrl.llenarGrillatalleres(Me.DGtalleres, Me.txtBuscar.Text)

            End If
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Me.txtCodigo.Text = ""
        Me.txtNombre.Text = ""
        Me.txtNombre.Focus()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click



        If Me.txtCodigo.Text = "" Then

            Dim p As New Entidades.taller
            p.nombre = Me.txtNombre.Text
            ctrl.Insertartaller(p)

        Else

            Dim p As Entidades.taller = DirectCast(DGtalleres.CurrentRow.DataBoundItem, Entidades.taller)
            p.nombre = Me.txtNombre.Text
            ctrl.Modificartaller(p)

        End If

        ctrl.llenarGrillatalleres(Me.DGtalleres)

    End Sub
End Class
