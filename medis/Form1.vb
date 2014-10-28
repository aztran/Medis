Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        tampilkanPegawai(Dg)
        MyParent(Me)
        id_otomatis("id_pegawai", "P", TextID)
    End Sub




    Private Sub bt_Simpan_Click_1(sender As Object, e As EventArgs) Handles bt_Simpan.Click
        pegawai(TextID.Text, TextNama.Text, Radio(RadioLaki, RadioPerempuan), TextAlamat.Text, TextTelp.Text, "I")
        ClearTextBoxes(GroupBox1)

        id_otomatis("id_pegawai", "P", TextID)
        Dg.Columns.Clear()
        tampilkanPegawai(Dg)

        'Dim xValue As String = ""
        'If RadioLaki.Checked = True Then
        '    xValue = "L"
        'ElseIf RadioPerempuan.Checked = True Then
        '    xValue = "P"
        'End If
        'sql = String.Format("select * from t_pegawai where id_pegawai ='" & TextID.Text & "'")
        'cn.Open()
        'command = New SqlCommand(sql, cn)
        'reader = command.ExecuteReader
        'If reader.HasRows = True Then
        '    reader.Close()
        '    MsgBox("data sudah ada")
        'Else
        '    reader.Close()
        '    command = New SqlCommand("pegawai", cn)
        '    With command
        '        .CommandType = CommandType.StoredProcedure
        '        .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = TextID.Text
        '        .Parameters.Add("@nama_pegawai", SqlDbType.VarChar).Value = TextNama.Text
        '        .Parameters.Add("@jenis_kelamin", SqlDbType.VarChar).Value = xValue
        '        .Parameters.Add("@alamat", SqlDbType.VarChar).Value = TextAlamat.Text
        '        .Parameters.Add("@telepon", SqlDbType.VarChar).Value = TextTelp.Text
        '        .Parameters.Add("@pil", SqlDbType.VarChar).Value = "I"
        '        .ExecuteNonQuery()
        '    End With

        '    MsgBox("DATA BERHASIL")
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Close()
        cn.Open()
        ''menghapus langsung di textboxt
        'del(TextID.Text, TextNama.Text, Radio(RadioLaki, RadioPerempuan), TextAlamat.Text, TextTelp.Text, "D")
        'cn.Close()
        'id_otomatis("id_pegawai", "P", TextID)
        'tampilkanPegawai(Dg)


        'menghapus lewat checkbox di datagrid
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

        id_otomatis("id_pegawai", "P", TextID)
        Dg.Columns.Clear()
        tampilkanPegawai(Dg)
    End Sub

    Sub DeleteRecord(ByVal id As String)
        Try

            command = New SqlCommand("delete from T_pegawai where id_pegawai= '" & id & "'", cn)


            command.ExecuteNonQuery()



        Catch ex As SqlException
            MsgBox("Barang anda tidak bisa dihapus dikarenakan data bunga masih tersimpan di form pemesanan." & vbCrLf & "Mohon hapus data di form pemesanan terlebih dahulu", MsgBoxStyle.Information, "perhatian")

            '  display_table()

        End Try


    End Sub
    

    Private Sub Dg_DoubleClick(sender As Object, e As EventArgs)
        TextID.Text = dg.SelectedCells(1).Value
        TextNama.Text = dg.SelectedCells(2).Value
        If dg.CurrentRow.Cells(3).Value.Equals("Laki-laki") Then
            RadioLaki.Checked = True
        End If

        TextAlamat.Text = dg.CurrentRow.Cells(4).Value
    End Sub
End Class
