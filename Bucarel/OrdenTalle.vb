Public Class OrdenTalle

    Dim ctrl As New Negocio.Controller


    Private _producto As Entidades.producto
    Public Property producto() As Entidades.producto
        Get
            Return _producto
        End Get
        Set(ByVal value As Entidades.producto)
            _producto = value
        End Set
    End Property


    Private _ordenTalle As Entidades.ordenTalle
    Public Property ordenTalle() As Entidades.ordenTalle
        Get
            Return _ordenTalle
        End Get
        Set(ByVal value As Entidades.ordenTalle)
            _ordenTalle = value
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



    Private Sub OrdenTalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxTalles(Me.cbtalles, Me.producto, minuslist)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar Talle en orden"
        If Me.ordenTalle.IDTalle <> 0 Then
            Dim lp As List(Of Entidades.talle) = DirectCast(Me.cbTalles.DataSource, List(Of Entidades.talle))
            Me.cbTalles.SelectedItem = lp.Find(Function(c) c.ID = Me.ordenTalle.IDTalle)
            Me.txtcantidad.Text = Me.ordenTalle.cantidad
            Me.Label1.Text = "Modificar Talle en orden"
        End If
        Me.save = False


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim mylong As Long

        If Not IsNothing(Me.cbTalles.SelectedItem) Then
            If IsNumeric(Me.txtcantidad.Text) Then
                If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                    If Long.Parse(Me.txtcantidad.Text) > 0 Then
                        Me.ordenTalle.IDTalle = DirectCast(Me.cbTalles.SelectedItem, Entidades.talle).ID
                        Me.ordenTalle.nombre = DirectCast(Me.cbTalles.SelectedItem, Entidades.talle).nombre
                        Me.ordenTalle.cantidad = Long.Parse(Me.txtcantidad.Text)
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