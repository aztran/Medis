<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnHapus = New System.Windows.Forms.Button()
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
        Me.bt_Simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbPasien.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ImageIndex = 1
        Me.btnHapus.Location = New System.Drawing.Point(309, 261)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 44)
        Me.btnHapus.TabIndex = 34
        Me.btnHapus.Text = "hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapus.UseVisualStyleBackColor = False
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
        Me.gbPasien.Location = New System.Drawing.Point(28, 66)
        Me.gbPasien.Name = "gbPasien"
        Me.gbPasien.Size = New System.Drawing.Size(847, 190)
        Me.gbPasien.TabIndex = 32
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
        'bt_Simpan
        '
        Me.bt_Simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Simpan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.bt_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Simpan.ImageIndex = 1
        Me.bt_Simpan.Location = New System.Drawing.Point(197, 262)
        Me.bt_Simpan.Name = "bt_Simpan"
        Me.bt_Simpan.Size = New System.Drawing.Size(95, 43)
        Me.bt_Simpan.TabIndex = 33
        Me.bt_Simpan.Text = "Simpan"
        Me.bt_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Simpan.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 422)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 150)
        Me.DataGridView1.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageIndex = 1
        Me.Button1.Location = New System.Drawing.Point(436, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 44)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Edit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 597)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.gbPasien)
        Me.Controls.Add(Me.bt_Simpan)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbPasien.ResumeLayout(False)
        Me.gbPasien.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents gbPasien As System.Windows.Forms.GroupBox
    Friend WithEvents txtnoRm As System.Windows.Forms.TextBox
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
    Friend WithEvents bt_Simpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
