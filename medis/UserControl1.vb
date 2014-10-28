Public Class menu

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim checkup As New form_check

        form_menu.Panel1.Controls.Clear()
        form_menu.Panel1.Controls.Add(checkup)
        checkup.Dock = DockStyle.Fill
    End Sub
End Class
