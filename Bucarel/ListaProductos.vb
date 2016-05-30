Public Class ListaProductos

    Dim ctrl As New Negocio.Controller


    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim img As New Bitmap(Me.btnguardar.Image, Me.btnguardar.Height, Me.btnguardar.Height)
        'btnguardar.Image = img

        Me.CenterToScreen()
        ctrl.llenarGrillaProductos(Me.DGProductos)

    End Sub


    Private Sub DGProductos_SelectionChanged(sender As Object, e As EventArgs) Handles DGProductos.SelectionChanged

        If Not IsNothing(DGProductos.CurrentRow.DataBoundItem) Then

            Me.txtCodigo.Text = DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto).ID.ToString
            Me.txtNombre.Text = DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto).nombre.ToString
            Me.txtPrecio.Text = DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto).precio.ToString
            Me.chkActivo.Checked = DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto).activo
            Me.txtNombre.Focus()
            Me.CargarTalles()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        Me.Form1_KeyDown(sender, e)
    End Sub
    Private Sub DGProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles DGProductos.KeyDown
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

                ctrl.llenarGrillaProductos(Me.DGProductos, Me.txtBuscar.Text)

            End If
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Me.txtCodigo.Text = ""
        Me.txtNombre.Text = ""
        Me.txtPrecio.Text = ""
        Me.chkActivo.Checked = True
        Me.txtNombre.Focus()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click


        If Me.txtCodigo.Text = "" Then

            Dim p As New Entidades.producto
            p.nombre = Me.txtNombre.Text
            p.precio = Double.Parse(Me.txtPrecio.Text)
            p.activo = Me.chkActivo.Checked

            For Each i In Me.chklTalles.CheckedItems
                p.talles.Add(DirectCast(i, Entidades.talle))
            Next

            ctrl.InsertarProducto(p)

        Else

            Dim p As Entidades.producto = DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto)
            p.nombre = Me.txtNombre.Text
            p.precio = Double.Parse(Me.txtPrecio.Text)
            p.activo = Me.chkActivo.Checked
            p.talles.Clear()
            For Each i In Me.chklTalles.CheckedItems
                p.talles.Add(DirectCast(i, Entidades.talle))
            Next

            ctrl.ModificarProducto(p)

        End If

        ctrl.llenarGrillaProductos(Me.DGProductos)

    End Sub

    Private Sub CargarTalles()

        Dim l As New List(Of Entidades.talle)

        Me.chklTalles.Items.Clear()
        Me.chklTalles.DisplayMember = "nombre"

        l = ctrl.obtenerTalles
        For Each t In l
            Me.chklTalles.Items.Add(t)
        Next

        For Each t In DirectCast(DGProductos.CurrentRow.DataBoundItem, Entidades.producto).talles

            For r As Integer = 0 To Me.chklTalles.Items.Count - 1
                If DirectCast(chklTalles.Items(r), Entidades.talle).ID = t.ID Then Me.chklTalles.SetItemChecked(r, True)
            Next
        Next

    End Sub

    Private Sub DGProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellContentClick

    End Sub
End Class
