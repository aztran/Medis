<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_form
    ' Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_form))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusWaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusPegawai = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApotekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelSales = New System.Windows.Forms.Panel()
        Me.cmdSalesReceipt = New System.Windows.Forms.Button()
        Me.cmdCashier = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkSales = New System.Windows.Forms.LinkLabel()
        Me.cmdCustomerOrder = New System.Windows.Forms.Button()
        Me.PanelMaintain = New System.Windows.Forms.Panel()
        Me.cmdBusInfo = New System.Windows.Forms.Button()
        Me.cmdUsers = New System.Windows.Forms.Button()
        Me.cmdManageClient = New System.Windows.Forms.Button()
        Me.cmdProductListing = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkMaintain = New System.Windows.Forms.LinkLabel()
        Me.PanelPurchasing = New System.Windows.Forms.Panel()
        Me.cmdDefective = New System.Windows.Forms.Button()
        Me.cmdCriticalProduct = New System.Windows.Forms.Button()
        Me.cmdStockMonitoring = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkPurchasing = New System.Windows.Forms.LinkLabel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelSales.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelMaintain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelPurchasing.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(102, 20)
        Me.ToolStripStatusLabel2.Text = "SITEK V.1.0.0.0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(577, 20)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'StatusWaktu
        '
        Me.StatusWaktu.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusWaktu.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.StatusWaktu.Image = CType(resources.GetObject("StatusWaktu.Image"), System.Drawing.Image)
        Me.StatusWaktu.Name = "StatusWaktu"
        Me.StatusWaktu.Size = New System.Drawing.Size(32, 20)
        Me.StatusWaktu.Text = "-"
        '
        'StatusTanggal
        '
        Me.StatusTanggal.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusTanggal.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.StatusTanggal.Image = CType(resources.GetObject("StatusTanggal.Image"), System.Drawing.Image)
        Me.StatusTanggal.Name = "StatusTanggal"
        Me.StatusTanggal.Size = New System.Drawing.Size(32, 20)
        Me.StatusTanggal.Text = "-"
        '
        'StatusPegawai
        '
        Me.StatusPegawai.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusPegawai.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.StatusPegawai.Name = "StatusPegawai"
        Me.StatusPegawai.Size = New System.Drawing.Size(16, 20)
        Me.StatusPegawai.Text = "-"
        '
        'StatusID
        '
        Me.StatusID.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusID.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.StatusID.Image = CType(resources.GetObject("StatusID.Image"), System.Drawing.Image)
        Me.StatusID.Name = "StatusID"
        Me.StatusID.Size = New System.Drawing.Size(32, 20)
        Me.StatusID.Text = "-"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripStatusLabel.Text = "Status :"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.StatusID, Me.StatusPegawai, Me.StatusTanggal, Me.StatusWaktu, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip.Location = New System.Drawing.Point(20, 666)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(851, 25)
        Me.StatusStrip.TabIndex = 16
        Me.StatusStrip.Text = "StatusStrip"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SupplierToolStripMenuItem.Text = "&Pasien"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 6)
        '
        'SatuanToolStripMenuItem
        '
        Me.SatuanToolStripMenuItem.Name = "SatuanToolStripMenuItem"
        Me.SatuanToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SatuanToolStripMenuItem.Text = "&Satuan"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.KategoriToolStripMenuItem.Text = "&Kategori"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(115, 6)
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ObatToolStripMenuItem.Text = "&Obat"
        '
        'ApotekToolStripMenuItem
        '
        Me.ApotekToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObatToolStripMenuItem, Me.ToolStripMenuItem1, Me.KategoriToolStripMenuItem, Me.SatuanToolStripMenuItem})
        Me.ApotekToolStripMenuItem.Name = "ApotekToolStripMenuItem"
        Me.ApotekToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ApotekToolStripMenuItem.Text = "&Apotek"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PegawaiToolStripMenuItem.Text = "&Pegawai"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegawaiToolStripMenuItem, Me.ApotekToolStripMenuItem, Me.ToolStripMenuItem3, Me.SupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "&Master"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(851, 24)
        Me.MenuStrip.TabIndex = 15
        Me.MenuStrip.Text = "MenuStrip"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PanelSales)
        Me.GroupBox1.Controls.Add(Me.PanelMaintain)
        Me.GroupBox1.Controls.Add(Me.PanelPurchasing)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 586)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'PanelSales
        '
        Me.PanelSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSales.Controls.Add(Me.cmdSalesReceipt)
        Me.PanelSales.Controls.Add(Me.cmdCashier)
        Me.PanelSales.Controls.Add(Me.Panel5)
        Me.PanelSales.Controls.Add(Me.cmdCustomerOrder)
        Me.PanelSales.Location = New System.Drawing.Point(3, 60)
        Me.PanelSales.Name = "PanelSales"
        Me.PanelSales.Size = New System.Drawing.Size(175, 23)
        Me.PanelSales.TabIndex = 29
        '
        'cmdSalesReceipt
        '
        Me.cmdSalesReceipt.BackColor = System.Drawing.Color.Transparent
        Me.cmdSalesReceipt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalesReceipt.Image = CType(resources.GetObject("cmdSalesReceipt.Image"), System.Drawing.Image)
        Me.cmdSalesReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalesReceipt.Location = New System.Drawing.Point(3, 88)
        Me.cmdSalesReceipt.Name = "cmdSalesReceipt"
        Me.cmdSalesReceipt.Size = New System.Drawing.Size(168, 34)
        Me.cmdSalesReceipt.TabIndex = 31
        Me.cmdSalesReceipt.Text = "Daftar Belanja"
        Me.cmdSalesReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalesReceipt.UseVisualStyleBackColor = False
        '
        'cmdCashier
        '
        Me.cmdCashier.BackColor = System.Drawing.Color.Transparent
        Me.cmdCashier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCashier.Image = CType(resources.GetObject("cmdCashier.Image"), System.Drawing.Image)
        Me.cmdCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCashier.Location = New System.Drawing.Point(3, 55)
        Me.cmdCashier.Name = "cmdCashier"
        Me.cmdCashier.Size = New System.Drawing.Size(168, 34)
        Me.cmdCashier.TabIndex = 30
        Me.cmdCashier.Text = "Bayar dan Antar"
        Me.cmdCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCashier.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.LinkSales)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(163, 21)
        Me.Panel5.TabIndex = 29
        '
        'LinkSales
        '
        Me.LinkSales.AutoSize = True
        Me.LinkSales.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSales.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkSales.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkSales.Location = New System.Drawing.Point(23, 2)
        Me.LinkSales.Name = "LinkSales"
        Me.LinkSales.Size = New System.Drawing.Size(117, 17)
        Me.LinkSales.TabIndex = 1
        Me.LinkSales.TabStop = True
        Me.LinkSales.Text = "Pesan dan Bayar"
        '
        'cmdCustomerOrder
        '
        Me.cmdCustomerOrder.BackColor = System.Drawing.Color.Transparent
        Me.cmdCustomerOrder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomerOrder.Image = CType(resources.GetObject("cmdCustomerOrder.Image"), System.Drawing.Image)
        Me.cmdCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCustomerOrder.Location = New System.Drawing.Point(3, 22)
        Me.cmdCustomerOrder.Name = "cmdCustomerOrder"
        Me.cmdCustomerOrder.Size = New System.Drawing.Size(168, 34)
        Me.cmdCustomerOrder.TabIndex = 29
        Me.cmdCustomerOrder.Text = "Pemesanan"
        Me.cmdCustomerOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCustomerOrder.UseVisualStyleBackColor = False
        '
        'PanelMaintain
        '
        Me.PanelMaintain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelMaintain.Controls.Add(Me.cmdBusInfo)
        Me.PanelMaintain.Controls.Add(Me.cmdUsers)
        Me.PanelMaintain.Controls.Add(Me.cmdManageClient)
        Me.PanelMaintain.Controls.Add(Me.cmdProductListing)
        Me.PanelMaintain.Controls.Add(Me.Panel2)
        Me.PanelMaintain.Location = New System.Drawing.Point(3, 12)
        Me.PanelMaintain.Name = "PanelMaintain"
        Me.PanelMaintain.Size = New System.Drawing.Size(175, 22)
        Me.PanelMaintain.TabIndex = 0
        '
        'cmdBusInfo
        '
        Me.cmdBusInfo.BackColor = System.Drawing.Color.Transparent
        Me.cmdBusInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBusInfo.Image = CType(resources.GetObject("cmdBusInfo.Image"), System.Drawing.Image)
        Me.cmdBusInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBusInfo.Location = New System.Drawing.Point(3, 22)
        Me.cmdBusInfo.Name = "cmdBusInfo"
        Me.cmdBusInfo.Size = New System.Drawing.Size(167, 34)
        Me.cmdBusInfo.TabIndex = 6
        Me.cmdBusInfo.Text = "Informasi Perusahaan"
        Me.cmdBusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBusInfo.UseVisualStyleBackColor = False
        '
        'cmdUsers
        '
        Me.cmdUsers.BackColor = System.Drawing.Color.Transparent
        Me.cmdUsers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsers.Image = CType(resources.GetObject("cmdUsers.Image"), System.Drawing.Image)
        Me.cmdUsers.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdUsers.Location = New System.Drawing.Point(3, 121)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(167, 34)
        Me.cmdUsers.TabIndex = 5
        Me.cmdUsers.Text = "Data Pengguna"
        Me.cmdUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUsers.UseVisualStyleBackColor = False
        '
        'cmdManageClient
        '
        Me.cmdManageClient.BackColor = System.Drawing.Color.Transparent
        Me.cmdManageClient.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManageClient.Image = CType(resources.GetObject("cmdManageClient.Image"), System.Drawing.Image)
        Me.cmdManageClient.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdManageClient.Location = New System.Drawing.Point(3, 88)
        Me.cmdManageClient.Name = "cmdManageClient"
        Me.cmdManageClient.Size = New System.Drawing.Size(167, 34)
        Me.cmdManageClient.TabIndex = 3
        Me.cmdManageClient.Text = "Data Client"
        Me.cmdManageClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManageClient.UseVisualStyleBackColor = False
        '
        'cmdProductListing
        '
        Me.cmdProductListing.BackColor = System.Drawing.Color.Transparent
        Me.cmdProductListing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProductListing.Image = CType(resources.GetObject("cmdProductListing.Image"), System.Drawing.Image)
        Me.cmdProductListing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdProductListing.Location = New System.Drawing.Point(3, 55)
        Me.cmdProductListing.Name = "cmdProductListing"
        Me.cmdProductListing.Size = New System.Drawing.Size(167, 34)
        Me.cmdProductListing.TabIndex = 2
        Me.cmdProductListing.Text = "Daftar Produk"
        Me.cmdProductListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProductListing.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.LinkMaintain)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 106)
        Me.Panel2.TabIndex = 1
        '
        'LinkMaintain
        '
        Me.LinkMaintain.AutoSize = True
        Me.LinkMaintain.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkMaintain.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkMaintain.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkMaintain.Location = New System.Drawing.Point(44, 3)
        Me.LinkMaintain.Name = "LinkMaintain"
        Me.LinkMaintain.Size = New System.Drawing.Size(78, 17)
        Me.LinkMaintain.TabIndex = 1
        Me.LinkMaintain.TabStop = True
        Me.LinkMaintain.Text = "Perawatan"
        '
        'PanelPurchasing
        '
        Me.PanelPurchasing.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPurchasing.Controls.Add(Me.cmdDefective)
        Me.PanelPurchasing.Controls.Add(Me.cmdCriticalProduct)
        Me.PanelPurchasing.Controls.Add(Me.cmdStockMonitoring)
        Me.PanelPurchasing.Controls.Add(Me.Panel3)
        Me.PanelPurchasing.Location = New System.Drawing.Point(3, 36)
        Me.PanelPurchasing.Name = "PanelPurchasing"
        Me.PanelPurchasing.Size = New System.Drawing.Size(175, 23)
        Me.PanelPurchasing.TabIndex = 1
        '
        'cmdDefective
        '
        Me.cmdDefective.BackColor = System.Drawing.Color.Transparent
        Me.cmdDefective.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDefective.Image = CType(resources.GetObject("cmdDefective.Image"), System.Drawing.Image)
        Me.cmdDefective.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDefective.Location = New System.Drawing.Point(3, 88)
        Me.cmdDefective.Name = "cmdDefective"
        Me.cmdDefective.Size = New System.Drawing.Size(168, 34)
        Me.cmdDefective.TabIndex = 32
        Me.cmdDefective.Text = "Produk Rusak"
        Me.cmdDefective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDefective.UseVisualStyleBackColor = False
        '
        'cmdCriticalProduct
        '
        Me.cmdCriticalProduct.BackColor = System.Drawing.Color.Transparent
        Me.cmdCriticalProduct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCriticalProduct.Image = CType(resources.GetObject("cmdCriticalProduct.Image"), System.Drawing.Image)
        Me.cmdCriticalProduct.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdCriticalProduct.Location = New System.Drawing.Point(3, 55)
        Me.cmdCriticalProduct.Name = "cmdCriticalProduct"
        Me.cmdCriticalProduct.Size = New System.Drawing.Size(168, 34)
        Me.cmdCriticalProduct.TabIndex = 31
        Me.cmdCriticalProduct.Text = "Stok Kritis"
        Me.cmdCriticalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCriticalProduct.UseVisualStyleBackColor = False
        '
        'cmdStockMonitoring
        '
        Me.cmdStockMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.cmdStockMonitoring.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStockMonitoring.Image = CType(resources.GetObject("cmdStockMonitoring.Image"), System.Drawing.Image)
        Me.cmdStockMonitoring.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdStockMonitoring.Location = New System.Drawing.Point(3, 22)
        Me.cmdStockMonitoring.Name = "cmdStockMonitoring"
        Me.cmdStockMonitoring.Size = New System.Drawing.Size(168, 34)
        Me.cmdStockMonitoring.TabIndex = 30
        Me.cmdStockMonitoring.Text = "Stok Monitoring"
        Me.cmdStockMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStockMonitoring.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.LinkPurchasing)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(163, 21)
        Me.Panel3.TabIndex = 29
        '
        'LinkPurchasing
        '
        Me.LinkPurchasing.AutoSize = True
        Me.LinkPurchasing.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkPurchasing.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkPurchasing.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkPurchasing.Location = New System.Drawing.Point(42, 1)
        Me.LinkPurchasing.Name = "LinkPurchasing"
        Me.LinkPurchasing.Size = New System.Drawing.Size(81, 17)
        Me.LinkPurchasing.TabIndex = 1
        Me.LinkPurchasing.TabStop = True
        Me.LinkPurchasing.Text = "Persediaan"
        Me.LinkPurchasing.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainPanel.Location = New System.Drawing.Point(20, 84)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(182, 582)
        Me.MainPanel.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(202, 84)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(669, 25)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(202, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 557)
        Me.Panel1.TabIndex = 38
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 618)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 18
        '
        'menu_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "menu_form"
        Me.Text = "p"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelSales.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelMaintain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelPurchasing.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusWaktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusPegawai As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SatuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApotekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelSales As System.Windows.Forms.Panel
    Friend WithEvents cmdSalesReceipt As System.Windows.Forms.Button
    Friend WithEvents cmdCashier As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LinkSales As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdCustomerOrder As System.Windows.Forms.Button
    Friend WithEvents PanelMaintain As System.Windows.Forms.Panel
    Friend WithEvents cmdBusInfo As System.Windows.Forms.Button
    Friend WithEvents cmdUsers As System.Windows.Forms.Button
    Friend WithEvents cmdManageClient As System.Windows.Forms.Button
    Friend WithEvents cmdProductListing As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkMaintain As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelPurchasing As System.Windows.Forms.Panel
    Friend WithEvents cmdDefective As System.Windows.Forms.Button
    Friend WithEvents cmdCriticalProduct As System.Windows.Forms.Button
    Friend WithEvents cmdStockMonitoring As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkPurchasing As System.Windows.Forms.LinkLabel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
