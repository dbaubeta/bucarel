Public Class OrdenEntrega
    Dim ctrl As New Negocio.Controller

    Private _ordenEntrega As Entidades.ordenEntrega
    Public Property ordenEntrega() As Entidades.ordenEntrega
        Get
            Return _ordenEntrega
        End Get
        Set(ByVal value As Entidades.ordenEntrega)
            _ordenEntrega = value
        End Set
    End Property

    Private _minuslist As List(Of Entidades.talle)
    Public Property minuslist() As List(Of Entidades.talle)
        Get
            Return _minuslist
        End Get
        Set(ByVal value As List(Of Entidades.talle))
            _minuslist = value
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



    Private Sub OrdenEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxTalles(Me.cbtalles, minuslist)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar Entrega en orden"
        If Me.ordenEntrega.IDTalle <> 0 Then
            Dim lp As List(Of Entidades.talle) = DirectCast(Me.cbtalles.DataSource, List(Of Entidades.talle))
            Me.cbtalles.SelectedItem = lp.Find(Function(c) c.ID = Me.ordenEntrega.IDTalle)
            Me.txtcantidad.Text = Me.ordenEntrega.cantidad
            Me.Label1.Text = "Modificar Entrega en orden"
        End If
        Me.save = False


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim mylong As Long

        If Not IsNothing(Me.cbtalles.SelectedItem) Then
            If IsNumeric(Me.txtcantidad.Text) Then
                If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                    If Long.Parse(Me.txtcantidad.Text) > 0 Then
                        Me.ordenEntrega.IDTalle = DirectCast(Me.cbtalles.SelectedItem, Entidades.talle).ID
                        Me.ordenEntrega.nombre = DirectCast(Me.cbtalles.SelectedItem, Entidades.talle).nombre
                        Me.ordenEntrega.cantidad = Long.Parse(Me.txtcantidad.Text)
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

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub
End Class