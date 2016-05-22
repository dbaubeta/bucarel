<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTalleres = New System.Windows.Forms.ComboBox()
        Me.DGMateriales = New System.Windows.Forms.DataGridView()
        Me.DGTalles = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGEntregas = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbproductos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelMateriales = New System.Windows.Forms.Button()
        Me.btnEditMateriales = New System.Windows.Forms.Button()
        Me.btnAddMateriales = New System.Windows.Forms.Button()
        Me.btnDelTalles = New System.Windows.Forms.Button()
        Me.btnEditTalles = New System.Windows.Forms.Button()
        Me.btnAddTalles = New System.Windows.Forms.Button()
        Me.btnDelEntregas = New System.Windows.Forms.Button()
        Me.btnEditEntregas = New System.Windows.Forms.Button()
        Me.btnAddEntregas = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        CType(Me.DGMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ordenes de trabajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Taller"
        '
        'cbTalleres
        '
        Me.cbTalleres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTalleres.FormattingEnabled = True
        Me.cbTalleres.Location = New System.Drawing.Point(31, 154)
        Me.cbTalleres.Name = "cbTalleres"
        Me.cbTalleres.Size = New System.Drawing.Size(261, 21)
        Me.cbTalleres.TabIndex = 11
        '
        'DGMateriales
        '
        Me.DGMateriales.AllowUserToAddRows = False
        Me.DGMateriales.AllowUserToDeleteRows = False
        Me.DGMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGMateriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMateriales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMateriales.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGMateriales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMateriales.Location = New System.Drawing.Point(27, 206)
        Me.DGMateriales.MultiSelect = False
        Me.DGMateriales.Name = "DGMateriales"
        Me.DGMateriales.RowHeadersVisible = False
        Me.DGMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMateriales.Size = New System.Drawing.Size(546, 149)
        Me.DGMateriales.TabIndex = 12
        '
        'DGTalles
        '
        Me.DGTalles.AllowUserToAddRows = False
        Me.DGTalles.AllowUserToDeleteRows = False
        Me.DGTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGTalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGTalles.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGTalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGTalles.Location = New System.Drawing.Point(635, 206)
        Me.DGTalles.MultiSelect = False
        Me.DGTalles.Name = "DGTalles"
        Me.DGTalles.RowHeadersVisible = False
        Me.DGTalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTalles.Size = New System.Drawing.Size(310, 149)
        Me.DGTalles.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Materiales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(632, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Talles"
        '
        'DGEntregas
        '
        Me.DGEntregas.AllowUserToAddRows = False
        Me.DGEntregas.AllowUserToDeleteRows = False
        Me.DGEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGEntregas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEntregas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGEntregas.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGEntregas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGEntregas.Location = New System.Drawing.Point(27, 385)
        Me.DGEntregas.MultiSelect = False
        Me.DGEntregas.Name = "DGEntregas"
        Me.DGEntregas.RowHeadersVisible = False
        Me.DGEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEntregas.Size = New System.Drawing.Size(918, 188)
        Me.DGEntregas.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Entregas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Descripcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Código"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(108, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(461, 22)
        Me.txtNombre.TabIndex = 35
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(31, 102)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(71, 22)
        Me.txtCodigo.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(575, 104)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'cbproductos
        '
        Me.cbproductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbproductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbproductos.FormattingEnabled = True
        Me.cbproductos.Location = New System.Drawing.Point(316, 154)
        Me.cbproductos.Name = "cbproductos"
        Me.cbproductos.Size = New System.Drawing.Size(459, 21)
        Me.cbproductos.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(572, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Fecha final entrega (estimada)"
        '
        'btnDelMateriales
        '
        Me.btnDelMateriales.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Delete_icon32
        Me.btnDelMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelMateriales.Location = New System.Drawing.Point(579, 274)
        Me.btnDelMateriales.Name = "btnDelMateriales"
        Me.btnDelMateriales.Size = New System.Drawing.Size(27, 28)
        Me.btnDelMateriales.TabIndex = 34
        Me.btnDelMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelMateriales.UseVisualStyleBackColor = True
        '
        'btnEditMateriales
        '
        Me.btnEditMateriales.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Edit_icon32
        Me.btnEditMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditMateriales.Location = New System.Drawing.Point(579, 240)
        Me.btnEditMateriales.Name = "btnEditMateriales"
        Me.btnEditMateriales.Size = New System.Drawing.Size(27, 28)
        Me.btnEditMateriales.TabIndex = 33
        Me.btnEditMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditMateriales.UseVisualStyleBackColor = True
        '
        'btnAddMateriales
        '
        Me.btnAddMateriales.AccessibleName = "btnAddMateriales"
        Me.btnAddMateriales.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Add_icon32
        Me.btnAddMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddMateriales.Location = New System.Drawing.Point(579, 206)
        Me.btnAddMateriales.Name = "btnAddMateriales"
        Me.btnAddMateriales.Size = New System.Drawing.Size(27, 28)
        Me.btnAddMateriales.TabIndex = 32
        Me.btnAddMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddMateriales.UseVisualStyleBackColor = True
        '
        'btnDelTalles
        '
        Me.btnDelTalles.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Delete_icon32
        Me.btnDelTalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelTalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelTalles.Location = New System.Drawing.Point(951, 274)
        Me.btnDelTalles.Name = "btnDelTalles"
        Me.btnDelTalles.Size = New System.Drawing.Size(26, 28)
        Me.btnDelTalles.TabIndex = 31
        Me.btnDelTalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelTalles.UseVisualStyleBackColor = True
        '
        'btnEditTalles
        '
        Me.btnEditTalles.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Edit_icon32
        Me.btnEditTalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditTalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditTalles.Location = New System.Drawing.Point(951, 240)
        Me.btnEditTalles.Name = "btnEditTalles"
        Me.btnEditTalles.Size = New System.Drawing.Size(26, 28)
        Me.btnEditTalles.TabIndex = 30
        Me.btnEditTalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditTalles.UseVisualStyleBackColor = True
        '
        'btnAddTalles
        '
        Me.btnAddTalles.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Add_icon32
        Me.btnAddTalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTalles.Location = New System.Drawing.Point(951, 206)
        Me.btnAddTalles.Name = "btnAddTalles"
        Me.btnAddTalles.Size = New System.Drawing.Size(26, 28)
        Me.btnAddTalles.TabIndex = 29
        Me.btnAddTalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTalles.UseVisualStyleBackColor = True
        '
        'btnDelEntregas
        '
        Me.btnDelEntregas.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Delete_icon32
        Me.btnDelEntregas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelEntregas.Location = New System.Drawing.Point(951, 453)
        Me.btnDelEntregas.Name = "btnDelEntregas"
        Me.btnDelEntregas.Size = New System.Drawing.Size(26, 28)
        Me.btnDelEntregas.TabIndex = 28
        Me.btnDelEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelEntregas.UseVisualStyleBackColor = True
        '
        'btnEditEntregas
        '
        Me.btnEditEntregas.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Edit_icon32
        Me.btnEditEntregas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditEntregas.Location = New System.Drawing.Point(951, 419)
        Me.btnEditEntregas.Name = "btnEditEntregas"
        Me.btnEditEntregas.Size = New System.Drawing.Size(26, 28)
        Me.btnEditEntregas.TabIndex = 27
        Me.btnEditEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditEntregas.UseVisualStyleBackColor = True
        '
        'btnAddEntregas
        '
        Me.btnAddEntregas.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Add_icon32
        Me.btnAddEntregas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEntregas.Location = New System.Drawing.Point(951, 385)
        Me.btnAddEntregas.Name = "btnAddEntregas"
        Me.btnAddEntregas.Size = New System.Drawing.Size(26, 28)
        Me.btnAddEntregas.TabIndex = 26
        Me.btnAddEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddEntregas.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Bucarel.My.Resources.Resources.Button_Delete_icon32
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(757, 592)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 42)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnguardar.Image = Global.Bucarel.My.Resources.Resources.Treetog_I_Floppy_Small
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(870, 594)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(107, 39)
        Me.btnguardar.TabIndex = 24
        Me.btnguardar.Text = "Guardar (F6)"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 645)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbproductos)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnDelMateriales)
        Me.Controls.Add(Me.btnEditMateriales)
        Me.Controls.Add(Me.btnAddMateriales)
        Me.Controls.Add(Me.btnDelTalles)
        Me.Controls.Add(Me.btnEditTalles)
        Me.Controls.Add(Me.btnAddTalles)
        Me.Controls.Add(Me.btnDelEntregas)
        Me.Controls.Add(Me.btnEditEntregas)
        Me.Controls.Add(Me.btnAddEntregas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGEntregas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGTalles)
        Me.Controls.Add(Me.DGMateriales)
        Me.Controls.Add(Me.cbTalleres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrdenTrabajo"
        Me.Text = "OrdenTrabajo"
        CType(Me.DGMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTalleres As System.Windows.Forms.ComboBox
    Friend WithEvents DGMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents DGTalles As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGEntregas As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnDelEntregas As System.Windows.Forms.Button
    Friend WithEvents btnEditEntregas As System.Windows.Forms.Button
    Friend WithEvents btnAddEntregas As System.Windows.Forms.Button
    Friend WithEvents btnDelTalles As System.Windows.Forms.Button
    Friend WithEvents btnEditTalles As System.Windows.Forms.Button
    Friend WithEvents btnAddTalles As System.Windows.Forms.Button
    Friend WithEvents btnDelMateriales As System.Windows.Forms.Button
    Friend WithEvents btnEditMateriales As System.Windows.Forms.Button
    Friend WithEvents btnAddMateriales As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbproductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
