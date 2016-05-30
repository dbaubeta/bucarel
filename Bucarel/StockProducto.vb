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



    Private Sub Stockproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxproductos(Me.cbproductos)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar stock producto"
        If Me.Stockproducto.ID <> 0 Then
            Dim lp As List(Of Entidades.producto) = DirectCast(Me.cbproductos.DataSource, List(Of Entidades.producto))
            Me.cbproductos.SelectedItem = lp.Find(Function(c) c.ID = Me.Stockproducto.productoid)
            Me.txtcantidad.Text = Me.Stockproducto.cantidad
            Me.DateTimePicker1.Value = Me.Stockproducto.fecha

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
            If IsNumeric(Me.txtcantidad.Text) Then
                If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                    If Long.Parse(Me.txtcantidad.Text) > 0 Then
                        Me.Stockproducto.productoid = DirectCast(Me.cbproductos.SelectedItem, Entidades.producto).ID
                        Me.Stockproducto.fecha = Me.DateTimePicker1.Value
                        Me.Stockproducto.cantidad = Long.Parse(Me.txtcantidad.Text)
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
            MsgBox("No se eligió ningun elemento en la lista desplegable")
        End If

    End Sub

    Private Sub txtcantidad_GotFocus(sender As Object, e As EventArgs) Handles txtcantidad.GotFocus
        Me.txtcantidad.SelectAll()

    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnguardar_Click(sender, e)
        End If

    End Sub



End Class