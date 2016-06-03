Public Class StockMaterial

    Dim ctrl As New Negocio.Controller

    Private _StockMaterial As Entidades.StockMaterial
    Public Property StockMaterial() As Entidades.StockMaterial
        Get
            Return _StockMaterial
        End Get
        Set(ByVal value As Entidades.StockMaterial)
            _StockMaterial = value
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



    Private Sub StockMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ctrl.llenarComboboxMateriales(Me.cbMateriales)
        Me.txtcantidad.Text = 0
        Label1.Text = "Ingresar stock material"
        Me.cbTipo.SelectedIndex = 0
        If Me.StockMaterial.ID <> 0 Then
            Dim lp As List(Of Entidades.material) = DirectCast(Me.cbMateriales.DataSource, List(Of Entidades.material))
            Me.cbMateriales.SelectedItem = lp.Find(Function(c) c.ID = Me.StockMaterial.materialid)
            Me.txtcantidad.Text = System.Math.Abs(Me.StockMaterial.cantidad)
            Me.DateTimePicker1.Value = Me.StockMaterial.fecha
            If Me.StockMaterial.cantidad > 0 Then
                Me.cbTipo.SelectedIndex = 0
            Else
                Me.cbTipo.SelectedIndex = 1
            End If

            Me.Label1.Text = "Modificar stock material"
        End If
            Me.save = False


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim mylong As Long

        If Not IsNothing(Me.cbMateriales.SelectedItem) Then
            If IsNumeric(Me.txtcantidad.Text) Then
                If Long.TryParse(Me.txtcantidad.Text, mylong) Then
                    If Long.Parse(Me.txtcantidad.Text) > 0 Then
                        Me.StockMaterial.materialid = DirectCast(Me.cbMateriales.SelectedItem, Entidades.material).ID
                        Me.StockMaterial.fecha = Me.DateTimePicker1.Value
                        Me.StockMaterial.cantidad = Long.Parse(Me.txtcantidad.Text)
                        If Me.cbTipo.SelectedIndex = 1 Then Me.StockMaterial.cantidad *= -1
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