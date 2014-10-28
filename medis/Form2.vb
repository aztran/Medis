Imports System.Data.SqlClient

Public Class Form2
    Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS; initial catalog=medis; integrated security=true")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet


    Public Sub tampil()
        ds = New DataSet
        cmd = New SqlCommand("Select * from t_pasien", cn)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.Close()
        cn.Open()
        tampil()
    End Sub

    Private Sub bt_Simpan_Click(sender As Object, e As EventArgs) Handles bt_Simpan.Click
        Dim t As String
        If ComboBox1.SelectedIndex = 0 Then
            t = "L"
        Else
            t = "P"
        End If
        cn.Close()
        cn.Open()
        cmd = New SqlCommand("insert into t_pasien values('" & txtnoRm.Text & "','" & txtNama.Text & "', '" & _
                           t & "','" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "','" & txtumur.Text & "','" & txtalamat.Text & "','" & txtpekerjaan.Text & "','" & txttelp.Text & "') ", cn)
        cmd.ExecuteNonQuery()
        tampil()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        cn.Close()
        cn.Open()
        cmd = New SqlCommand("delete from t_pasien where no_rm='" & txtnoRm.Text & "'", cn)
        cmd.ExecuteNonQuery()
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String
        If ComboBox1.SelectedIndex = 0 Then
            t = "L"
        Else
            t = "P"
        End If
        cn.Close()
        cn.Open()
        cmd = New SqlCommand("update t_pasien set nama_pasien='" & txtNama.Text & "',jk='" & t & "',tgl_lahir='" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "',umur='" & txtumur.Text & "',alamat='" & txtalamat.Text & "',pekerjaan='" & txtpekerjaan.Text & "',telp ='" & txttelp.Text & "' where no_rm = '" & txtnoRm.Text & "'", cn)
        cmd.ExecuteNonQuery()

        tampil()
    End Sub
End Class