Public Class ListaMateriales

    Dim ctrl As New Negocio.Controller


    Private Sub ListaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim img As New Bitmap(Me.btnguardar.Image, Me.btnguardar.Height, Me.btnguardar.Height)
        'btnguardar.Image = img

        Me.CenterToScreen()
        ctrl.llenarGrillaMateriales(Me.DGMateriales)

    End Sub


    Private Sub DGMateriales_SelectionChanged(sender As Object, e As EventArgs) Handles DGMateriales.SelectionChanged

        If Not IsNothing(DGMateriales.CurrentRow.DataBoundItem) Then

            Me.txtCodigo.Text = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.material).ID.ToString
            Me.txtNombre.Text = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.material).nombre.ToString
            Me.txtNombre.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub DGMateriales_KeyDown(sender As Object, e As KeyEventArgs) Handles DGMateriales.KeyDown
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

                ctrl.llenarGrillaMateriales(Me.DGMateriales, Me.txtBuscar.Text)

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

            Dim p As New Entidades.material
            p.nombre = Me.txtNombre.Text
            ctrl.InsertarMaterial(p)

        Else

            Dim p As Entidades.material = DirectCast(DGMateriales.CurrentRow.DataBoundItem, Entidades.material)
            p.nombre = Me.txtNombre.Text
            ctrl.ModificarMaterial(p)

        End If

        ctrl.llenarGrillaMateriales(Me.DGMateriales)

    End Sub



End Class
