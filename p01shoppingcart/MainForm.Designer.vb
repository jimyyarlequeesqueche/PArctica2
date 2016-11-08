<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHombres = New System.Windows.Forms.Button()
        Me.btnMujeres = New System.Windows.Forms.Button()
        Me.btnCalzado = New System.Windows.Forms.Button()
        Me.btnAccesorios = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAbajoL1 = New System.Windows.Forms.Button()
        Me.ilFlechas = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCantL1 = New System.Windows.Forms.Label()
        Me.lblAbajoL4 = New System.Windows.Forms.Button()
        Me.lblAbajoL3 = New System.Windows.Forms.Button()
        Me.lblAbajoL2 = New System.Windows.Forms.Button()
        Me.lblArribaL1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdL1 = New System.Windows.Forms.Label()
        Me.lblPrecioL1 = New System.Windows.Forms.Label()
        Me.lblVerProdL1 = New System.Windows.Forms.Button()
        Me.lblCantL2 = New System.Windows.Forms.Label()
        Me.lblCantL3 = New System.Windows.Forms.Label()
        Me.lblCantL4 = New System.Windows.Forms.Label()
        Me.btnVerProdL2 = New System.Windows.Forms.Button()
        Me.btnVerProdL3 = New System.Windows.Forms.Button()
        Me.btnVerProdL4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdL2 = New System.Windows.Forms.Label()
        Me.lblPrecioL2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdL3 = New System.Windows.Forms.Label()
        Me.lblPrecioL3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdL4 = New System.Windows.Forms.Label()
        Me.lblPrecioL4 = New System.Windows.Forms.Label()
        Me.lblArribaL2 = New System.Windows.Forms.Button()
        Me.lblArribaL3 = New System.Windows.Forms.Button()
        Me.lblArribaL4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdTitulo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbProdTitulo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTallaP1 = New System.Windows.Forms.Label()
        Me.lblTallaP2 = New System.Windows.Forms.Label()
        Me.lblTallaP3 = New System.Windows.Forms.Label()
        Me.lblTallaP4 = New System.Windows.Forms.Label()
        Me.lblTallaP5 = New System.Windows.Forms.Label()
        Me.lblTallaTitulo = New System.Windows.Forms.Label()
        Me.lblPrecioTitulo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ilProductosH = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosM = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosC = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosA = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.pbProdTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 12)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCerrar.Location = New System.Drawing.Point(331, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(21, 21)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnHombres, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMujeres, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCalzado, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAccesorios, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 246)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(351, 38)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnHombres
        '
        Me.btnHombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHombres.FlatAppearance.BorderSize = 0
        Me.btnHombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHombres.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHombres.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnHombres.Location = New System.Drawing.Point(8, 3)
        Me.btnHombres.Name = "btnHombres"
        Me.btnHombres.Size = New System.Drawing.Size(77, 32)
        Me.btnHombres.TabIndex = 0
        Me.btnHombres.Text = "HOMBRES"
        Me.btnHombres.UseVisualStyleBackColor = True
        '
        'btnMujeres
        '
        Me.btnMujeres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMujeres.FlatAppearance.BorderSize = 0
        Me.btnMujeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMujeres.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMujeres.ForeColor = System.Drawing.Color.Black
        Me.btnMujeres.Location = New System.Drawing.Point(93, 3)
        Me.btnMujeres.Name = "btnMujeres"
        Me.btnMujeres.Size = New System.Drawing.Size(77, 32)
        Me.btnMujeres.TabIndex = 1
        Me.btnMujeres.Text = "MUJERES"
        Me.btnMujeres.UseVisualStyleBackColor = True
        '
        'btnCalzado
        '
        Me.btnCalzado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalzado.FlatAppearance.BorderSize = 0
        Me.btnCalzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalzado.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalzado.ForeColor = System.Drawing.Color.Black
        Me.btnCalzado.Location = New System.Drawing.Point(178, 3)
        Me.btnCalzado.Name = "btnCalzado"
        Me.btnCalzado.Size = New System.Drawing.Size(77, 32)
        Me.btnCalzado.TabIndex = 2
        Me.btnCalzado.Text = "CALZADO"
        Me.btnCalzado.UseVisualStyleBackColor = True
        '
        'btnAccesorios
        '
        Me.btnAccesorios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccesorios.AutoSize = True
        Me.btnAccesorios.FlatAppearance.BorderSize = 0
        Me.btnAccesorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccesorios.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesorios.Location = New System.Drawing.Point(262, 3)
        Me.btnAccesorios.Name = "btnAccesorios"
        Me.btnAccesorios.Size = New System.Drawing.Size(82, 32)
        Me.btnAccesorios.TabIndex = 3
        Me.btnAccesorios.Text = " ACCESORIOS"
        Me.btnAccesorios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAccesorios.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.571652!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.43147!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.332294!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.332294!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.332294!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAbajoL1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCantL1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAbajoL4, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAbajoL3, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAbajoL2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArribaL1, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblVerProdL1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCantL2, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCantL3, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCantL4, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnVerProdL2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnVerProdL3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnVerProdL4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel10, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel11, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel12, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArribaL2, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArribaL3, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblArribaL4, 4, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 289)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(351, 268)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnAbajoL1
        '
        Me.btnAbajoL1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAbajoL1.FlatAppearance.BorderSize = 0
        Me.btnAbajoL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbajoL1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbajoL1.ImageKey = "down-arrow-key.png"
        Me.btnAbajoL1.ImageList = Me.ilFlechas
        Me.btnAbajoL1.Location = New System.Drawing.Point(273, 20)
        Me.btnAbajoL1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnAbajoL1.Name = "btnAbajoL1"
        Me.btnAbajoL1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.btnAbajoL1.Size = New System.Drawing.Size(19, 23)
        Me.btnAbajoL1.TabIndex = 1
        Me.btnAbajoL1.UseVisualStyleBackColor = True
        '
        'ilFlechas
        '
        Me.ilFlechas.ImageStream = CType(resources.GetObject("ilFlechas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilFlechas.TransparentColor = System.Drawing.Color.Transparent
        Me.ilFlechas.Images.SetKeyName(0, "down-arrow-key.png")
        Me.ilFlechas.Images.SetKeyName(1, "up-arrow-key.png")
        '
        'lblCantL1
        '
        Me.lblCantL1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantL1.AutoSize = True
        Me.lblCantL1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantL1.ForeColor = System.Drawing.Color.Black
        Me.lblCantL1.Location = New System.Drawing.Point(298, 17)
        Me.lblCantL1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.lblCantL1.Name = "lblCantL1"
        Me.lblCantL1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lblCantL1.Size = New System.Drawing.Size(22, 30)
        Me.lblCantL1.TabIndex = 0
        Me.lblCantL1.Text = "0"
        Me.lblCantL1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAbajoL4
        '
        Me.lblAbajoL4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAbajoL4.FlatAppearance.BorderSize = 0
        Me.lblAbajoL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAbajoL4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAbajoL4.ImageKey = "down-arrow-key.png"
        Me.lblAbajoL4.ImageList = Me.ilFlechas
        Me.lblAbajoL4.Location = New System.Drawing.Point(273, 221)
        Me.lblAbajoL4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAbajoL4.Name = "lblAbajoL4"
        Me.lblAbajoL4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblAbajoL4.Size = New System.Drawing.Size(19, 23)
        Me.lblAbajoL4.TabIndex = 2
        Me.lblAbajoL4.UseVisualStyleBackColor = True
        '
        'lblAbajoL3
        '
        Me.lblAbajoL3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAbajoL3.FlatAppearance.BorderSize = 0
        Me.lblAbajoL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAbajoL3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAbajoL3.ImageKey = "down-arrow-key.png"
        Me.lblAbajoL3.ImageList = Me.ilFlechas
        Me.lblAbajoL3.Location = New System.Drawing.Point(273, 154)
        Me.lblAbajoL3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAbajoL3.Name = "lblAbajoL3"
        Me.lblAbajoL3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblAbajoL3.Size = New System.Drawing.Size(19, 23)
        Me.lblAbajoL3.TabIndex = 2
        Me.lblAbajoL3.UseVisualStyleBackColor = True
        '
        'lblAbajoL2
        '
        Me.lblAbajoL2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAbajoL2.FlatAppearance.BorderSize = 0
        Me.lblAbajoL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAbajoL2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAbajoL2.ImageKey = "down-arrow-key.png"
        Me.lblAbajoL2.ImageList = Me.ilFlechas
        Me.lblAbajoL2.Location = New System.Drawing.Point(273, 87)
        Me.lblAbajoL2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAbajoL2.Name = "lblAbajoL2"
        Me.lblAbajoL2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblAbajoL2.Size = New System.Drawing.Size(19, 23)
        Me.lblAbajoL2.TabIndex = 2
        Me.lblAbajoL2.UseVisualStyleBackColor = True
        '
        'lblArribaL1
        '
        Me.lblArribaL1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArribaL1.FlatAppearance.BorderSize = 0
        Me.lblArribaL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArribaL1.ImageKey = "up-arrow-key.png"
        Me.lblArribaL1.ImageList = Me.ilFlechas
        Me.lblArribaL1.Location = New System.Drawing.Point(323, 20)
        Me.lblArribaL1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblArribaL1.Name = "lblArribaL1"
        Me.lblArribaL1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblArribaL1.Size = New System.Drawing.Size(21, 23)
        Me.lblArribaL1.TabIndex = 2
        Me.lblArribaL1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblProdL1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblPrecioL1, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(22, 11)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(245, 45)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'lblProdL1
        '
        Me.lblProdL1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdL1.AutoSize = True
        Me.lblProdL1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdL1.Location = New System.Drawing.Point(3, 1)
        Me.lblProdL1.Name = "lblProdL1"
        Me.lblProdL1.Size = New System.Drawing.Size(128, 19)
        Me.lblProdL1.TabIndex = 1
        Me.lblProdL1.Text = "Camisa de Algodon"
        '
        'lblPrecioL1
        '
        Me.lblPrecioL1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrecioL1.AutoSize = True
        Me.lblPrecioL1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioL1.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioL1.Location = New System.Drawing.Point(3, 24)
        Me.lblPrecioL1.Name = "lblPrecioL1"
        Me.lblPrecioL1.Size = New System.Drawing.Size(39, 19)
        Me.lblPrecioL1.TabIndex = 1
        Me.lblPrecioL1.Text = "$120"
        '
        'lblVerProdL1
        '
        Me.lblVerProdL1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblVerProdL1.BackColor = System.Drawing.Color.SteelBlue
        Me.lblVerProdL1.FlatAppearance.BorderSize = 0
        Me.lblVerProdL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVerProdL1.Location = New System.Drawing.Point(6, 7)
        Me.lblVerProdL1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblVerProdL1.Name = "lblVerProdL1"
        Me.lblVerProdL1.Size = New System.Drawing.Size(10, 52)
        Me.lblVerProdL1.TabIndex = 4
        Me.lblVerProdL1.UseVisualStyleBackColor = False
        '
        'lblCantL2
        '
        Me.lblCantL2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantL2.AutoSize = True
        Me.lblCantL2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantL2.ForeColor = System.Drawing.Color.Black
        Me.lblCantL2.Location = New System.Drawing.Point(298, 84)
        Me.lblCantL2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.lblCantL2.Name = "lblCantL2"
        Me.lblCantL2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lblCantL2.Size = New System.Drawing.Size(22, 30)
        Me.lblCantL2.TabIndex = 0
        Me.lblCantL2.Text = "0"
        Me.lblCantL2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCantL3
        '
        Me.lblCantL3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantL3.AutoSize = True
        Me.lblCantL3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantL3.ForeColor = System.Drawing.Color.Black
        Me.lblCantL3.Location = New System.Drawing.Point(298, 151)
        Me.lblCantL3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.lblCantL3.Name = "lblCantL3"
        Me.lblCantL3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lblCantL3.Size = New System.Drawing.Size(22, 30)
        Me.lblCantL3.TabIndex = 0
        Me.lblCantL3.Text = "0"
        Me.lblCantL3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCantL4
        '
        Me.lblCantL4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantL4.AutoSize = True
        Me.lblCantL4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantL4.ForeColor = System.Drawing.Color.Black
        Me.lblCantL4.Location = New System.Drawing.Point(298, 218)
        Me.lblCantL4.Margin = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.lblCantL4.Name = "lblCantL4"
        Me.lblCantL4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lblCantL4.Size = New System.Drawing.Size(22, 30)
        Me.lblCantL4.TabIndex = 0
        Me.lblCantL4.Text = "0"
        Me.lblCantL4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnVerProdL2
        '
        Me.btnVerProdL2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVerProdL2.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVerProdL2.FlatAppearance.BorderSize = 0
        Me.btnVerProdL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProdL2.Location = New System.Drawing.Point(6, 74)
        Me.btnVerProdL2.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnVerProdL2.Name = "btnVerProdL2"
        Me.btnVerProdL2.Size = New System.Drawing.Size(10, 52)
        Me.btnVerProdL2.TabIndex = 4
        Me.btnVerProdL2.UseVisualStyleBackColor = False
        '
        'btnVerProdL3
        '
        Me.btnVerProdL3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVerProdL3.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVerProdL3.FlatAppearance.BorderSize = 0
        Me.btnVerProdL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProdL3.Location = New System.Drawing.Point(6, 141)
        Me.btnVerProdL3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnVerProdL3.Name = "btnVerProdL3"
        Me.btnVerProdL3.Size = New System.Drawing.Size(10, 52)
        Me.btnVerProdL3.TabIndex = 4
        Me.btnVerProdL3.UseVisualStyleBackColor = False
        '
        'btnVerProdL4
        '
        Me.btnVerProdL4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVerProdL4.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVerProdL4.FlatAppearance.BorderSize = 0
        Me.btnVerProdL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProdL4.Location = New System.Drawing.Point(6, 208)
        Me.btnVerProdL4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnVerProdL4.Name = "btnVerProdL4"
        Me.btnVerProdL4.Size = New System.Drawing.Size(10, 52)
        Me.btnVerProdL4.TabIndex = 4
        Me.btnVerProdL4.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.lblProdL2, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lblPrecioL2, 0, 1)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(22, 78)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(245, 45)
        Me.TableLayoutPanel10.TabIndex = 3
        '
        'lblProdL2
        '
        Me.lblProdL2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdL2.AutoSize = True
        Me.lblProdL2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdL2.Location = New System.Drawing.Point(3, 1)
        Me.lblProdL2.Name = "lblProdL2"
        Me.lblProdL2.Size = New System.Drawing.Size(147, 19)
        Me.lblProdL2.TabIndex = 1
        Me.lblProdL2.Text = "Blazer Mezcla de Lana "
        '
        'lblPrecioL2
        '
        Me.lblPrecioL2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrecioL2.AutoSize = True
        Me.lblPrecioL2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioL2.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioL2.Location = New System.Drawing.Point(3, 24)
        Me.lblPrecioL2.Name = "lblPrecioL2"
        Me.lblPrecioL2.Size = New System.Drawing.Size(41, 19)
        Me.lblPrecioL2.TabIndex = 1
        Me.lblPrecioL2.Text = "$240"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.lblProdL3, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.lblPrecioL3, 0, 1)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(22, 145)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(245, 45)
        Me.TableLayoutPanel11.TabIndex = 3
        '
        'lblProdL3
        '
        Me.lblProdL3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdL3.AutoSize = True
        Me.lblProdL3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdL3.Location = New System.Drawing.Point(3, 1)
        Me.lblProdL3.Name = "lblProdL3"
        Me.lblProdL3.Size = New System.Drawing.Size(117, 19)
        Me.lblProdL3.TabIndex = 1
        Me.lblProdL3.Text = "Jersey Cuello Pico"
        '
        'lblPrecioL3
        '
        Me.lblPrecioL3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrecioL3.AutoSize = True
        Me.lblPrecioL3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioL3.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioL3.Location = New System.Drawing.Point(3, 24)
        Me.lblPrecioL3.Name = "lblPrecioL3"
        Me.lblPrecioL3.Size = New System.Drawing.Size(39, 19)
        Me.lblPrecioL3.TabIndex = 1
        Me.lblPrecioL3.Text = "$160"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.lblProdL4, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.lblPrecioL4, 0, 1)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(22, 212)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(245, 45)
        Me.TableLayoutPanel12.TabIndex = 3
        '
        'lblProdL4
        '
        Me.lblProdL4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdL4.AutoSize = True
        Me.lblProdL4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdL4.Location = New System.Drawing.Point(3, 1)
        Me.lblProdL4.Name = "lblProdL4"
        Me.lblProdL4.Size = New System.Drawing.Size(137, 19)
        Me.lblProdL4.TabIndex = 1
        Me.lblProdL4.Text = "Polo Cuello Redondo"
        '
        'lblPrecioL4
        '
        Me.lblPrecioL4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrecioL4.AutoSize = True
        Me.lblPrecioL4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioL4.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioL4.Location = New System.Drawing.Point(3, 24)
        Me.lblPrecioL4.Name = "lblPrecioL4"
        Me.lblPrecioL4.Size = New System.Drawing.Size(33, 19)
        Me.lblPrecioL4.TabIndex = 1
        Me.lblPrecioL4.Text = "$70"
        '
        'lblArribaL2
        '
        Me.lblArribaL2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArribaL2.FlatAppearance.BorderSize = 0
        Me.lblArribaL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArribaL2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblArribaL2.ImageKey = "up-arrow-key.png"
        Me.lblArribaL2.ImageList = Me.ilFlechas
        Me.lblArribaL2.Location = New System.Drawing.Point(325, 87)
        Me.lblArribaL2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblArribaL2.Name = "lblArribaL2"
        Me.lblArribaL2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblArribaL2.Size = New System.Drawing.Size(19, 23)
        Me.lblArribaL2.TabIndex = 1
        Me.lblArribaL2.UseVisualStyleBackColor = True
        '
        'lblArribaL3
        '
        Me.lblArribaL3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArribaL3.FlatAppearance.BorderSize = 0
        Me.lblArribaL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArribaL3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblArribaL3.ImageKey = "up-arrow-key.png"
        Me.lblArribaL3.ImageList = Me.ilFlechas
        Me.lblArribaL3.Location = New System.Drawing.Point(325, 154)
        Me.lblArribaL3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblArribaL3.Name = "lblArribaL3"
        Me.lblArribaL3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblArribaL3.Size = New System.Drawing.Size(19, 23)
        Me.lblArribaL3.TabIndex = 1
        Me.lblArribaL3.UseVisualStyleBackColor = True
        '
        'lblArribaL4
        '
        Me.lblArribaL4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblArribaL4.FlatAppearance.BorderSize = 0
        Me.lblArribaL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArribaL4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblArribaL4.ImageKey = "up-arrow-key.png"
        Me.lblArribaL4.ImageList = Me.ilFlechas
        Me.lblArribaL4.Location = New System.Drawing.Point(325, 221)
        Me.lblArribaL4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblArribaL4.Name = "lblArribaL4"
        Me.lblArribaL4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblArribaL4.Size = New System.Drawing.Size(19, 23)
        Me.lblArribaL4.TabIndex = 1
        Me.lblArribaL4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblProdTitulo, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 86)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(351, 159)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lblProdTitulo
        '
        Me.lblProdTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProdTitulo.AutoSize = True
        Me.lblProdTitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdTitulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblProdTitulo.Location = New System.Drawing.Point(99, 6)
        Me.lblProdTitulo.Name = "lblProdTitulo"
        Me.lblProdTitulo.Size = New System.Drawing.Size(153, 19)
        Me.lblProdTitulo.TabIndex = 1
        Me.lblProdTitulo.Text = "CAMISA DE ALGODON"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36795!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63205!))
        Me.TableLayoutPanel5.Controls.Add(Me.pbProdTitulo, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel9, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(345, 122)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'pbProdTitulo
        '
        Me.pbProdTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProdTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pbProdTitulo.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.pbProdTitulo.Name = "pbProdTitulo"
        Me.pbProdTitulo.Size = New System.Drawing.Size(163, 116)
        Me.pbProdTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProdTitulo.TabIndex = 0
        Me.pbProdTitulo.TabStop = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lblPrecioTitulo, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(169, 6)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(174, 110)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaP1, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaP2, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaP3, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaP4, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaP5, 4, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTallaTitulo, 0, 0)
        Me.TableLayoutPanel6.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(20, 61)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(134, 41)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'lblTallaP1
        '
        Me.lblTallaP1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP1.AutoSize = True
        Me.lblTallaP1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP1.ForeColor = System.Drawing.Color.Black
        Me.lblTallaP1.Location = New System.Drawing.Point(3, 24)
        Me.lblTallaP1.Name = "lblTallaP1"
        Me.lblTallaP1.Size = New System.Drawing.Size(20, 13)
        Me.lblTallaP1.TabIndex = 0
        Me.lblTallaP1.Text = "XS"
        Me.lblTallaP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP2
        '
        Me.lblTallaP2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP2.AutoSize = True
        Me.lblTallaP2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP2.ForeColor = System.Drawing.Color.Black
        Me.lblTallaP2.Location = New System.Drawing.Point(29, 24)
        Me.lblTallaP2.Name = "lblTallaP2"
        Me.lblTallaP2.Size = New System.Drawing.Size(20, 13)
        Me.lblTallaP2.TabIndex = 1
        Me.lblTallaP2.Text = "S"
        Me.lblTallaP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP3
        '
        Me.lblTallaP3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP3.AutoSize = True
        Me.lblTallaP3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP3.ForeColor = System.Drawing.Color.Black
        Me.lblTallaP3.Location = New System.Drawing.Point(55, 24)
        Me.lblTallaP3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP3.Name = "lblTallaP3"
        Me.lblTallaP3.Size = New System.Drawing.Size(23, 13)
        Me.lblTallaP3.TabIndex = 2
        Me.lblTallaP3.Text = "M"
        Me.lblTallaP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP4
        '
        Me.lblTallaP4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP4.AutoSize = True
        Me.lblTallaP4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP4.ForeColor = System.Drawing.Color.Black
        Me.lblTallaP4.Location = New System.Drawing.Point(81, 24)
        Me.lblTallaP4.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP4.Name = "lblTallaP4"
        Me.lblTallaP4.Size = New System.Drawing.Size(23, 13)
        Me.lblTallaP4.TabIndex = 3
        Me.lblTallaP4.Text = "L"
        Me.lblTallaP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP5
        '
        Me.lblTallaP5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP5.AutoSize = True
        Me.lblTallaP5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP5.ForeColor = System.Drawing.Color.Black
        Me.lblTallaP5.Location = New System.Drawing.Point(107, 24)
        Me.lblTallaP5.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP5.Name = "lblTallaP5"
        Me.lblTallaP5.Size = New System.Drawing.Size(27, 13)
        Me.lblTallaP5.TabIndex = 4
        Me.lblTallaP5.Text = "XL"
        Me.lblTallaP5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaTitulo
        '
        Me.lblTallaTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaTitulo.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.lblTallaTitulo, 5)
        Me.lblTallaTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTallaTitulo.Location = New System.Drawing.Point(3, 2)
        Me.lblTallaTitulo.Name = "lblTallaTitulo"
        Me.lblTallaTitulo.Size = New System.Drawing.Size(128, 15)
        Me.lblTallaTitulo.TabIndex = 5
        Me.lblTallaTitulo.Text = "Tallas"
        Me.lblTallaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecioTitulo
        '
        Me.lblPrecioTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioTitulo.AutoSize = True
        Me.lblPrecioTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTitulo.Location = New System.Drawing.Point(55, 2)
        Me.lblPrecioTitulo.Name = "lblPrecioTitulo"
        Me.lblPrecioTitulo.Size = New System.Drawing.Size(64, 51)
        Me.lblPrecioTitulo.TabIndex = 0
        Me.lblPrecioTitulo.Text = "$0"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnCerrar, 2, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(12, 14)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(352, 54)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.PictureBox1, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(38, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(275, 45)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(98, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Tienda Virtual"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 3)
        Me.Panel1.TabIndex = 4
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(0, 615)
        Me.btnComprar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(375, 43)
        Me.btnComprar.TabIndex = 5
        Me.btnComprar.Text = "COMPRAR"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.47727!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.52273!))
        Me.TableLayoutPanel13.Controls.Add(Me.Label22, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.lblTotal, 1, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(12, 557)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(352, 49)
        Me.TableLayoutPanel13.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(3, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Label22.Size = New System.Drawing.Size(56, 22)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "TOTAL"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotal.Location = New System.Drawing.Point(299, 2)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(3, 0, 0, 4)
        Me.lblTotal.Size = New System.Drawing.Size(53, 45)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "$0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ilProductosH
        '
        Me.ilProductosH.ImageStream = CType(resources.GetObject("ilProductosH.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosH.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosH.Images.SetKeyName(0, "hombres-01.jpg")
        Me.ilProductosH.Images.SetKeyName(1, "hombres-02.jpg")
        Me.ilProductosH.Images.SetKeyName(2, "hombres-03.jpg")
        Me.ilProductosH.Images.SetKeyName(3, "hombres-04.jpg")
        '
        'ilProductosM
        '
        Me.ilProductosM.ImageStream = CType(resources.GetObject("ilProductosM.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosM.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosM.Images.SetKeyName(0, "mujeres-01.jpg")
        Me.ilProductosM.Images.SetKeyName(1, "mujeres-02.jpg")
        Me.ilProductosM.Images.SetKeyName(2, "mujeres-03.jpg")
        Me.ilProductosM.Images.SetKeyName(3, "mujeres-04.jpg")
        '
        'ilProductosC
        '
        Me.ilProductosC.ImageStream = CType(resources.GetObject("ilProductosC.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosC.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosC.Images.SetKeyName(0, "calzado-01.jpg")
        Me.ilProductosC.Images.SetKeyName(1, "calzado-02.jpg")
        Me.ilProductosC.Images.SetKeyName(2, "calzado-03.jpg")
        Me.ilProductosC.Images.SetKeyName(3, "calzado-04.jpg")
        '
        'ilProductosA
        '
        Me.ilProductosA.ImageStream = CType(resources.GetObject("ilProductosA.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosA.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosA.Images.SetKeyName(0, "accesorios-01.jpg")
        Me.ilProductosA.Images.SetKeyName(1, "accesorios-02.jpg")
        Me.ilProductosA.Images.SetKeyName(2, "accesorios-03.jpg")
        Me.ilProductosA.Images.SetKeyName(3, "accesorios-04.jpg")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(375, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel13)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.pbProdTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnHombres As Button
    Friend WithEvents btnMujeres As Button
    Friend WithEvents btnCalzado As Button
    Friend WithEvents btnAccesorios As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAbajoL1 As Button
    Friend WithEvents lblCantL1 As Label
    Friend WithEvents lblArribaL1 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblProdL1 As Label
    Friend WithEvents lblPrecioL1 As Label
    Friend WithEvents ilFlechas As ImageList
    Friend WithEvents lblVerProdL1 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents pbProdTitulo As PictureBox
    Friend WithEvents lblProdTitulo As Label
    Friend WithEvents lblPrecioTitulo As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblTallaP1 As Label
    Friend WithEvents lblTallaP2 As Label
    Friend WithEvents lblTallaP3 As Label
    Friend WithEvents lblTallaP4 As Label
    Friend WithEvents lblTallaP5 As Label
    Friend WithEvents lblTallaTitulo As Label
    Friend WithEvents lblArribaL2 As Button
    Friend WithEvents lblArribaL3 As Button
    Friend WithEvents lblArribaL4 As Button
    Friend WithEvents lblAbajoL2 As Button
    Friend WithEvents lblAbajoL3 As Button
    Friend WithEvents lblAbajoL4 As Button
    Friend WithEvents lblCantL2 As Label
    Friend WithEvents lblCantL3 As Label
    Friend WithEvents lblCantL4 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents btnVerProdL2 As Button
    Friend WithEvents btnVerProdL3 As Button
    Friend WithEvents btnVerProdL4 As Button
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents lblProdL2 As Label
    Friend WithEvents lblPrecioL2 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents lblProdL3 As Label
    Friend WithEvents lblPrecioL3 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents lblProdL4 As Label
    Friend WithEvents lblPrecioL4 As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents ilProductosH As ImageList
    Friend WithEvents ilProductosM As ImageList
    Friend WithEvents ilProductosC As ImageList
    Friend WithEvents ilProductosA As ImageList
End Class
