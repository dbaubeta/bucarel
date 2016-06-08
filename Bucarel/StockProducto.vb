Public Class StockProducto

    Dim ctrl As New Negocio.Controller

    Private _Stockproducto As Entidades.Stockproducto
    Public Property Stockproducto() As Entidades.Stockproducto
        Get
            Return _Stockproducto
        End Get
        Set(ByVal value As Entidades.Stockproducto)
            _Stockproducto = value
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

    Private Sub StockProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F6 Then
            btnguardar_Click(sender, e)
        End If

    End Sub



    Private Sub Stockproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxProductos(Me.cbProductos)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar stock producto"
        If Me.cbProductos.Items.Count > 0 Then
            Me.cbProductos.SelectedIndex = 1
        End If
        Me.cbTipo.SelectedIndex = 1
        If Me.Stockproducto.ID <> 0 Then
            Dim lp As List(Of Entidades.producto) = DirectCast(Me.cbproductos.DataSource, List(Of Entidades.producto))
            Dim lt As List(Of Entidades.talle) = DirectCast(Me.cbTalles.DataSource, List(Of Entidades.talle))
            Me.cbProductos.SelectedItem = lp.Find(Function(c) c.ID = Me.Stockproducto.productoid)
            ctrl.llenarComboboxTalles(Me.cbTalles, Me.cbProductos.SelectedItem)
            Me.cbTalles.SelectedItem = lt.Find(Function(c) c.ID = Me.Stockproducto.talle.ID)
            '            Me.cbProductos.Enabled = False
            '            Me.cbTalles.Enabled = False
            Me.txtcantidad.Text = Math.Abs(Me.Stockproducto.cantidad)
            Me.DateTimePicker1.Value = Me.Stockproducto.fecha
            If Me.Stockproducto.cantidad > 0 Then
                Me.cbTipo.SelectedIndex = 0
            Else
                Me.cbTipo.SelectedIndex = 1
            End If
            Me.txtcantidad.Focus()
            Me.Label1.Text = "Modificar stock producto"
        End If
        Me.save = False


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim mylong As Long

        If Not IsNothing(Me.cbproductos.SelectedItem) Then

            If Not IsNothing(Me.cbTalles.SelectedItem) Then

                If IsNumeric(Me.txtcantidad.Text) Then
                    If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                        If Long.Parse(Me.txtcantidad.Text) > 0 Then
                            Me.Stockproducto.productoid = DirectCast(Me.cbProductos.SelectedItem, Entidades.producto).ID
                            Me.Stockproducto.talle.ID = DirectCast(Me.cbTalles.SelectedItem, Entidades.talle).ID
                            Me.Stockproducto.talle.nombre = DirectCast(Me.cbTalles.SelectedItem, Entidades.talle).nombre
                            Me.Stockproducto.fecha = Me.DateTimePicker1.Value
                            Me.Stockproducto.cantidad = Long.Parse(Me.txtcantidad.Text)
                            If Me.cbTipo.SelectedIndex = 1 Then Me.Stockproducto.cantidad *= -1
                            Me.save = True
                            Me.Hide()
                        Else
                            MsgBox("Ingrese solo cantidades positivas")
                        End If
                    Else
                        MsgBox("Ingrese solo cantidades enteras")
                    End If
                Else
                    MsgBox("Cantidad contiene un valor no numerico")
                End If

            Else
                MsgBox("No se eligió ningun elemento en la lista de talles")
            End If
        Else
            MsgBox("No se eligió ningun elemento en la lista de productos")
        End If

    End Sub

    Private Sub txtcantidad_GotFocus(sender As Object, e As EventArgs) Handles txtcantidad.GotFocus
        Me.txtcantidad.SelectAll()

    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnguardar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnguardar_Click(sender, e)
        End If

    End Sub

    Private Sub cbProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles cbProductos.KeyDown
        StockProducto_KeyDown(sender, e)
    End Sub

    Private Sub cbTalles_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTalles.KeyDown
        StockProducto_KeyDown(sender, e)
    End Sub


    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        ctrl.llenarComboboxTalles(Me.cbTalles, Me.cbProductos.SelectedItem)
    End Sub

End Class