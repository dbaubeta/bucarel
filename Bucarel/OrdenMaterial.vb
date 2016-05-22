Public Class OrdenMaterial
    Dim ctrl As New Negocio.Controller

    Private _ordenmaterial As Entidades.ordenMaterial
    Public Property ordenmaterial() As Entidades.ordenMaterial
        Get
            Return _ordenmaterial
        End Get
        Set(ByVal value As Entidades.ordenMaterial)
            _ordenmaterial = value
        End Set
    End Property

    Private _minuslist As List(Of Entidades.material)
    Public Property minuslist() As List(Of Entidades.material)
        Get
            Return _minuslist
        End Get
        Set(ByVal value As List(Of Entidades.material))
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



    Private Sub OrdenMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxMateriales(Me.cbmateriales, minuslist)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar Material en orden"
        If Me.ordenmaterial.IDMaterial <> 0 Then
            Dim lp As List(Of Entidades.material) = DirectCast(Me.cbmateriales.DataSource, List(Of Entidades.material))
            Me.cbmateriales.SelectedItem = lp.Find(Function(c) c.ID = Me.ordenmaterial.IDMaterial)
            Me.txtcantidad.Text = Me.ordenmaterial.cantidad
            Me.Label1.Text = "Modificar Material en orden"
        End If
        Me.save = False


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim mylong As Long

        If Not IsNothing(Me.cbmateriales.SelectedItem) Then
            If IsNumeric(Me.txtcantidad.Text) Then
                If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                    If Long.Parse(Me.txtcantidad.Text) > 0 Then
                        Me.ordenmaterial.IDMaterial = DirectCast(Me.cbmateriales.SelectedItem, Entidades.material).ID
                        Me.ordenmaterial.nombre = DirectCast(Me.cbmateriales.SelectedItem, Entidades.material).nombre
                        Me.ordenmaterial.cantidad = Long.Parse(Me.txtcantidad.Text)
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