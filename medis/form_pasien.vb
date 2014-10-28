Imports System.Data.SqlClient
Public Class form_pasien

    Private Sub form_pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkanPasien(Dg)
        disableTextBoxes(gbPasien)
        'disableComboBoxes(gbPasien)
        'disableDateTime(gbPasien)
        MyParent(Me)
        cn.Close()
        cn.Open()

        ambilPasen()


    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        'gbPasien.Visible = True
        enableAll(gbPasien)
        bt_Simpan.Enabled = True : btnHapus.Enabled = True
    End Sub

    

    Private Sub bt_Simpan_Click(sender As Object, e As EventArgs) Handles bt_Simpan.Click
        Dim t As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            t = "L"
        Else
            t = "P"
        End If
        cn.Close()
        addPasien(txtnoRm.Text, txtNama.Text, t, Format(DateTimePicker1.Value, "yyyy/MM/dd"), txtumur.Text, txtalamat.Text, txtpekerjaan.Text, txttelp.Text, "i")
        'ListView1.Items.Clear()
        Dg.Columns.Clear()
        tampilkanPasien(Dg)
        ambilPasen()
        ClearTextBoxes(gbPasien)
        cn.Close()
        cn.Open()
    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Dim t As String
        If ComboBox1.SelectedIndex = 0 Then
            t = "L"
        Else
            t = "P"
        End If
        gbPasien.Visible = False
        cn.Close()
        cn.Open()
        command = New SqlCommand("select * from t_pasien where no_rm ='" & ListView1.SelectedItems(0).Text & "'", cn)
        reader = command.ExecuteReader

        While reader.Read
            txtnoRm.Text = reader!no_rm
            txtNama.Text = reader!nama_pasien
            ComboBox1.Text = reader!jk
            DateTimePicker1.Value = reader!tgl_lahir
            txtumur.Text = reader!umur
            txtalamat.Text = reader!alamat
            txtpekerjaan.Text = reader!pekerjaan
            txttelp.Text = reader!nama_pasien
        End While
    End Sub
    Public Sub delPasien()
        Dim itmx As ListViewItem
        Dim id As String = ""
        If ListView1.Items.Count = 0 Then Exit Sub
        If ListView1.CheckedItems.Count > 1 Then
            With ListView1
                For Each itmx In .Items
                    If itmx.Checked = True Then
                        id = .CheckedItems(0).Text
                    End If
                    
                Next

            End With
            If MessageBox.Show("Apakah anda ingin menghapus data ini?", "Hapus Data Pelanggan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                deletePasien(id)
            End If
        ElseIf ListView1.FocusedItem.Selected Then
            If MessageBox.Show("Apakah anda ingin menghapus data ini?", "Hapus Data Pelanggan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                deletePasien(ListView1.FocusedItem.Text)
            End If
        End If


    End Sub
    Sub DeleteRecord(ByVal id As String)
        Try

            command = New SqlCommand("delete from t_pasien where no_rm= '" & id & "'", cn)


            command.ExecuteNonQuery()



        Catch ex As SqlException
            MsgBox("Barang anda tidak bisa dihapus dikarenakan data bunga masih tersimpan di form pemesanan." & vbCrLf & "Mohon hapus data di form pemesanan terlebih dahulu", MsgBoxStyle.Information, "perhatian")

            '  display_table()

        End Try

       
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        cn.Close()
        cn.Open()
        'delPasien()
        ' ListView1.Items.Clear()
        Dim rowstodelete As New List(Of DataGridViewRow)
        For Each row As DataGridViewRow In Dg.Rows
            If row.Cells(0).Value = True Then
                DeleteRecord(row.Cells(1).Value)
                rowstodelete.Add(row)

            End If


        Next
        MsgBox("DATA BERHASIL DIHAPUS")
        For Each rowtodelete In rowstodelete
            Dg.Rows.Remove(rowtodelete)
            cn.Close()
        Next
        Dg.Columns.Clear()
        tampilkanPasien(Dg)
        ambilPasen()
    End Sub

    Private Sub bt_Keluar_Click(sender As Object, e As EventArgs) Handles bt_Keluar.Click
        tutup(Me)
    End Sub

    Private Sub Dg_MouseClick(sender As Object, e As MouseEventArgs) Handles Dg.MouseClick
        txtnoRm.Text = Dg.SelectedCells(1).Value
        txtNama.Text = Dg.SelectedCells(2).Value
        


    End Sub
End Class
