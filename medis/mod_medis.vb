Imports System.Data.SqlClient
Imports VB = Microsoft.VisualBasic
Module mod_medis
    Public ConnString As String = "Data Source=.\SQLEXPRESS; initial catalog=medis; integrated security=true"
    Public cn As New SqlConnection(ConnString)
    Public sql As String
    Public command As SqlCommand
    Public reader As SqlDataReader
    Public IDKode As String
    Public nomor As String
    Public ds As New DataSet
    Public da As SqlDataAdapter

#Region "Fungsi"
    Public Function tampilkan(ByVal xform As Form)
        For i As Integer = 0 To menu_form.TabControl1.TabPages.Count - 1
            If menu_form.TabControl1.TabPages(i).Name = xform.Name Then
                menu_form.TabControl1.SelectedTab = menu_form.TabControl1.TabPages(xform.Name)
                Return xform
            End If
        Next i
        menu_form.TabControl1.TabPages.Add(xform.Name, xform.Text)
        menu_form.TabControl1.SelectedTab = menu_form.TabControl1.TabPages(xform.Name)
        xform.TopLevel = False
        xform.Parent = menu_form.TabControl1.TabPages(xform.Name)
        xform.Show()
        Return xform
    End Function

    Public Function MyParent(ByVal xform As Form)
        With xform
            .FormBorderStyle = Windows.Forms.BorderStyle.None
            .ControlBox = False
            .Parent = menu_form.TabControl1.TabPages(xform.Name)
            .Height = menu_form.TabControl1.TabPages(xform.Name).Height
            .Width = menu_form.TabControl1.TabPages(xform.Name).Width
        End With
        Return xform
    End Function

    Public Function tutup(ByVal xForm As Form)
        xForm.Dispose()
        menu_form.TabControl1.TabPages(xForm.Name).Dispose()
        Return xForm
    End Function
    Public Function Radio(ByVal xRB1 As RadioButton, ByVal xRB2 As RadioButton)
        Dim xValue As String = ""
        If xRB1.Checked = True Then
            xValue = "L"
        ElseIf xRB2.Checked = True Then
            xValue = "P"
        End If
        Return xValue
    End Function

    Public Sub ClearTextBoxes(frm As GroupBox)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub

    Public Sub disableTextBoxes(frm As GroupBox)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.enabled = False
            ElseIf TypeOf Control Is ComboBox Then
                Control.enabled = False
            Else
                Control.enabled = False
            End If

        Next Control

    End Sub

    Public Sub enableAll(frm As GroupBox)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.enabled = True
            ElseIf TypeOf Control Is ComboBox Then
                Control.enabled = True
            Else
                Control.enabled = True
            End If

        Next Control

    End Sub

    Public Sub ambilPasen()
        cn.Close()
        cn.Open()
        command = New SqlCommand("Select * from t_pasien", cn)
        reader = command.ExecuteReader
        ' If reader.HasRows Then
        Do While reader.Read
            Dim lv As New ListViewItem
            Dim btn As New Button

            lv = form_pasien.ListView1.Items.Add(reader!no_rm)

            lv.SubItems.Add(reader!nama_pasien)
            lv.SubItems.Add(reader!jk)
            lv.SubItems.Add(reader!tgl_lahir)
            lv.SubItems.Add(reader!umur)
            lv.SubItems.Add(reader!alamat)
            lv.SubItems.Add(reader!pekerjaan)
            lv.SubItems.Add(reader!telp)

            lv.Selected = True
            lv.EnsureVisible()
            ' lv = Nothing
        Loop
        '  End If
        ' reader.Close()

    End Sub
#End Region
   
#Region "DML SQL"

    Public Sub tampilkanPegawai(ByVal dgv As DataGridView)
        cn.Close()
        cn.Open()
        Dim v_check As New DataGridViewCheckBoxColumn() With {.Name = "select", .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells}
        Dim btnEdit As New DataGridViewButtonColumn() With {.HeaderText = "delete", .Text = "edit"}

        ds = New DataSet
        command = New SqlCommand("Select id_pegawai as 'ID Pegawai',nama_pegawai as' Nama Pegawai', jenis_kelamin as 'Jenis Kelamin', alamat as 'Alamat', telepon as 'Telepon' from t_pegawai", cn)
        da = New SqlDataAdapter(command)
        da.Fill(ds)
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        ' dgv.ReadOnly = True
        dgv.DataSource = ds.Tables(0)

        dgv.Columns.Insert(0, v_check)

        dgv.Refresh()
    End Sub

    Public Sub tampilkanPasien(ByVal dgv As DataGridView)
        cn.Close()
        cn.Open()
        Dim v_check As New DataGridViewCheckBoxColumn() With {.Name = "select", .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells}
        Dim btnEdit As New DataGridViewButtonColumn() With {.HeaderText = "delete", .Text = "edit"}

        ds = New DataSet
        command = New SqlCommand("Select no_rm as 'Nomor RM',nama_pasien as' Nama Pasien', jk as 'Jenis Kelamin', tgl_lahir as 'Tanggal Lahir', umur as 'umur', alamat as 'alamat', pekerjaan as 'pekerjaan', telp as 'telp' from t_pasien", cn)
        da = New SqlDataAdapter(command)
        da.Fill(ds)
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False

        ' dgv.ReadOnly = True
        dgv.DataSource = ds.Tables(0)

        dgv.Columns("alamat").Width = 150

        dgv.Columns.Insert(0, v_check)
        dgv.Columns.GetFirstColumn(DataGridViewElementStates.ReadOnly)


        dgv.Refresh()
    End Sub
    'Private Sub display_table()
    '    ' dg.Columns.Clear()
    '    Dim v_check As New DataGridViewCheckBoxColumn() With {.Name = "select", .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells}
    '    Dim btnEdit As New DataGridViewButtonColumn() With {.HeaderText = "delete", .Text = "edit"}
    '    Dim dt As New DataTable
    '    ds = New DataSet
    '    cmd = New SqlCommand("select * from barang order by kode_bunga asc", tes)
    '    cmd.ExecuteNonQuery()
    '    db = New SqlDataAdapter(cmd)
    '    db.Fill(ds)




    '    dg.DataSource = ds.Tables(0)

    '    dg.Columns.Insert(0, v_check)
    '    ' dg.Columns.Insert(6, btnEdit)
    '    'dg.Columns.Add("", "kode Barang")
    '    'dg.Columns.Add("", "Nama Barang")
    '    'dg.Columns.Add("", "kategori barang")
    '    'dg.Columns.Add("", "stok")
    '    'dg.Columns.Add("", "Harga")



    'End Sub
    Public Function id_otomatis(ByVal xSP As String, ByVal xNo As String, ByVal text As TextBox)

        Try
            Dim maxString As String = ""
            Dim maxInteger As Integer = 0
            Dim tahun As String = Format(Now, "yyyy")
            cn.Close()
            cn.Open()
            command = New SqlCommand(xSP, cn) With {
                .CommandType = CommandType.StoredProcedure}
            reader = command.ExecuteReader
            If reader.Read Then
                If reader.Item("tahun").ToString = tahun Then
                    maxString = reader.Item("maksimum").ToString
                Else
                    maxString = 0
                End If
            End If
            reader.Close()
            maxInteger = VB.Right(maxString, 4)
            maxInteger = maxInteger + 1
            maxString = maxInteger
            If maxString.Length = 1 Then

                nomor = String.Format(xNo & "{0}000{1}", tahun, maxString)
            ElseIf maxString.Length = 2 Then
                nomor = String.Format(xNo & "{0}00{1}", tahun, maxString)
            ElseIf maxString.Length = 3 Then
                nomor = String.Format(xNo & "{0}0{1}", tahun, maxString)
            ElseIf maxString.Length = 4 Then
                nomor = String.Format(xNo & "{0}{1}", tahun, maxString)


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "peringatan")
        Finally
            cn.Close()
        End Try
        text.Text = nomor
        Return text
    End Function

    Public Function pegawai(ByVal xID As String, ByVal xNama As String, ByVal xJK As String, ByVal xAlamat As String, ByVal xTelepon As String,
                            ByVal Pilihan As String)


        sql = String.Format("select * from t_pegawai where id_pegawai ='{0}' ", xID)
        cn.Open()
        command = New SqlCommand(sql, cn)
        reader = command.ExecuteReader
        Try
            If reader.HasRows = True Then
                reader.Close()
                MsgBox("data sudah ada")
            Else
                reader.Close()
                command = New SqlCommand("pegawai", cn)
                With command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@nama_pegawai", SqlDbType.VarChar).Value = xNama
                    .Parameters.Add("@jenis_kelamin", SqlDbType.VarChar).Value = xJK
                    .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                    .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                    .Parameters.Add("@pil", SqlDbType.VarChar).Value = Pilihan
                    .ExecuteNonQuery()
                End With

                MsgBox("DATA BERHASIL")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return xID
    End Function


    Public Function deletePegawai(ByVal xID As String, ByVal xNama As String, ByVal xJK As String, ByVal xAlamat As String, ByVal xTelepon As String,
                            ByVal Pilihan As String)
        cn.Open()
        command = New SqlCommand("select * from t_pegawai where id_pegawai='" & xID & "'", cn)

        reader = command.ExecuteReader
        If reader.HasRows = True Then
            reader.Close()
            sql = "pegawai '" & xID & "','','','','','D'"

            command = New SqlCommand(sql)
            command.ExecuteNonQuery()
        End If
        Return xID
    End Function

    Public Function del(ByVal xID As String, ByVal xNama As String, ByVal xJK As String, ByVal xAlamat As String, ByVal xTelepon As String,
                            ByVal Pilihan As String)


        sql = String.Format("select * from t_pegawai where id_pegawai ='{0}' ", xID)
        cn.Open()
        command = New SqlCommand(sql, cn)
        reader = command.ExecuteReader
        If reader.HasRows = True Then

            reader.Close()
            command = New SqlCommand("pegawai", cn)
            With command
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xID
                .Parameters.Add("@nama_pegawai", SqlDbType.VarChar).Value = xNama
                .Parameters.Add("@jenis_kelamin", SqlDbType.VarChar).Value = xJK
                .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                .Parameters.Add("@pil", SqlDbType.VarChar).Value = Pilihan
                .ExecuteNonQuery()
            End With

            MsgBox("DATA BERHASIL")
        Else
            reader.Close()

            MsgBox("data sudah ada")
        End If

        Return xID
    End Function

    Public Function deletePasien(ByVal xID As String)

        Try
            cn.Close()
            cn.Open()
            command = New SqlCommand("delPasien", cn)
            With command
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@no_rm", SqlDbType.VarChar).Value = xID

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return xID
    End Function

    Public Function addPasien(ByVal no_rem As String, ByVal nm_pasien As String,
                              ByVal jk As String, ByVal tanggal As Date, ByVal umur As String, ByVal alamat As String, ByVal pekerjaan As String, ByVal telp As String, ByVal pil As String)


        sql = String.Format("select * from t_pasien where no_rm  ='{0}' ", no_rem)
        cn.Open()
        command = New SqlCommand(sql, cn)
        reader = command.ExecuteReader
        If reader.HasRows = True Then
            reader.Close()
            MsgBox("data sudah ada")
        Else


            reader.Close()
            command = New SqlCommand("pasien", cn)
            With command
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@no_rm", SqlDbType.VarChar).Value = no_rem
                .Parameters.Add("@nama_pasien", SqlDbType.VarChar).Value = nm_pasien
                .Parameters.Add("@jk", SqlDbType.VarChar).Value = jk
                .Parameters.Add("@tgl_lahir", SqlDbType.Date).Value = tanggal
                .Parameters.Add("@umur", SqlDbType.VarChar).Value = umur
                .Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat
                .Parameters.Add("@pekerjaan", SqlDbType.VarChar).Value = pekerjaan
                .Parameters.Add("@telp", SqlDbType.VarChar).Value = telp
                .Parameters.Add("@pil", SqlDbType.VarChar).Value = pil
                .ExecuteNonQuery()
            End With
            MsgBox("data berhasil disimpan")
        End If
        Return no_rem
    End Function
#End Region
End Module
