<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pasien))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.no_RM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbPasien = New System.Windows.Forms.GroupBox()
        Me.txtnoRm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.txtpekerjaan = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.bt_Simpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPasien.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.no_RM, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 122)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(894, 163)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'no_RM
        '
        Me.no_RM.Text = "Nomor RM"
        Me.no_RM.Width = 91
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama Pasien"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Jenis Kelamin"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tanggal Lahir"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Umur"
        Me.ColumnHeader4.Width = 59
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat"
        Me.ColumnHeader5.Width = 235
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Pekerjaan"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Telepon"
        Me.ColumnHeader7.Width = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 77)
        Me.Panel1.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(62, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Menampilkan daftar Pasien Secara Rinci" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(61, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Daftar Pasien"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'gbPasien
        '
        Me.gbPasien.Controls.Add(Me.txtnoRm)
        Me.gbPasien.Controls.Add(Me.Label7)
        Me.gbPasien.Controls.Add(Me.Label6)
        Me.gbPasien.Controls.Add(Me.Label5)
        Me.gbPasien.Controls.Add(Me.Label4)
        Me.gbPasien.Controls.Add(Me.Label3)
        Me.gbPasien.Controls.Add(Me.txttelp)
        Me.gbPasien.Controls.Add(Me.txtpekerjaan)
        Me.gbPasien.Controls.Add(Me.txtalamat)
        Me.gbPasien.Controls.Add(Me.txtumur)
        Me.gbPasien.Controls.Add(Me.DateTimePicker1)
        Me.gbPasien.Controls.Add(Me.ComboBox1)
        Me.gbPasien.Controls.Add(Me.Label10)
        Me.gbPasien.Controls.Add(Me.txtNama)
        Me.gbPasien.Controls.Add(Me.Label2)
        Me.gbPasien.Controls.Add(Me.Label1)
        Me.gbPasien.Location = New System.Drawing.Point(12, 304)
        Me.gbPasien.Name = "gbPasien"
        Me.gbPasien.Size = New System.Drawing.Size(847, 190)
        Me.gbPasien.TabIndex = 22
        Me.gbPasien.TabStop = False
        Me.gbPasien.Text = "Tambah Pasien"
        '
        'txtnoRm
        '
        Me.txtnoRm.Location = New System.Drawing.Point(121, 20)
        Me.txtnoRm.MaxLength = 100
        Me.txtnoRm.Name = "txtnoRm"
        Me.txtnoRm.Size = New System.Drawing.Size(214, 20)
        Me.txtnoRm.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(405, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Pekerjaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Umur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tanggal Lahir"
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(503, 119)
        Me.txttelp.MaxLength = 100
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(214, 20)
        Me.txttelp.TabIndex = 26
        '
        'txtpekerjaan
        '
        Me.txtpekerjaan.Location = New System.Drawing.Point(503, 93)
        Me.txtpekerjaan.MaxLength = 100
        Me.txtpekerjaan.Name = "txtpekerjaan"
        Me.txtpekerjaan.Size = New System.Drawing.Size(214, 20)
        Me.txtpekerjaan.TabIndex = 25
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(503, 20)
        Me.txtalamat.MaxLength = 100
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(214, 72)
        Me.txtalamat.TabIndex = 24
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(121, 128)
        Me.txtumur.MaxLength = 100
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(89, 20)
        Me.txtumur.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 103)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(89, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox1.Location = New System.Drawing.Point(121, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nomor RM"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(121, 46)
        Me.txtNama.MaxLength = 100
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(214, 20)
        Me.txtNama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pasien :"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdadd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Image = CType(resources.GetObject("cmdadd.Image"), System.Drawing.Image)
        Me.cmdadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdadd.Location = New System.Drawing.Point(65, 545)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(95, 43)
        Me.cmdadd.TabIndex = 21
        Me.cmdadd.Text = "Tambah"
        Me.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'bt_Simpan
        '
        Me.bt_Simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Simpan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.bt_Simpan.Enabled = False
        Me.bt_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Simpan.ImageIndex = 1
        Me.bt_Simpan.Location = New System.Drawing.Point(210, 544)
        Me.bt_Simpan.Name = "bt_Simpan"
        Me.bt_Simpan.Size = New System.Drawing.Size(95, 43)
        Me.bt_Simpan.TabIndex = 30
        Me.bt_Simpan.Text = "Simpan"
        Me.bt_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Simpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ImageIndex = 1
        Me.btnHapus.Location = New System.Drawing.Point(328, 544)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 44)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'Dg
        '
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dg.Location = New System.Drawing.Point(12, 122)
        Me.Dg.Name = "Dg"
        Me.Dg.Size = New System.Drawing.Size(894, 150)
        Me.Dg.TabIndex = 32
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(935, 25)
        Me.ToolStrip1.TabIndex = 33
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bt_Keluar
        '
        Me.bt_Keluar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Keluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bt_Keluar.Image = CType(resources.GetObject("bt_Keluar.Image"), System.Drawing.Image)
        Me.bt_Keluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Keluar.Name = "bt_Keluar"
        Me.bt_Keluar.Size = New System.Drawing.Size(23, 22)
        Me.bt_Keluar.Text = "Tutup"
        '
        'form_pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(935, 635)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Dg)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.gbPasien)
        Me.Controls.Add(Me.bt_Simpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "form_pasien"
        Me.Text = "form_pasien"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPasien.ResumeLayout(False)
        Me.gbPasien.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents no_RM As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbPasien As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents txtpekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnoRm As System.Windows.Forms.TextBox
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents bt_Simpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
End Class
