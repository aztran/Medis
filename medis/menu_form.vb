Imports MetroFramework.Forms

Public Class menu_form
    Inherits MetroForm
    Dim minsales, minPurchase As Integer
    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        tampilkan(Form1)
    End Sub


    Private Sub LinkSales_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSales.LinkClicked
        Dim i As Integer
        'LinkSales.Enabled = False
        If minsales = 0 Then
            For i = 0 To 110
                PanelSales.Height = PanelSales.Height + 1
                'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
                minsales = minsales + PanelPurchasing.Height
                Application.DoEvents()
            Next
        Else
            'MsgBox(Min)
            For i = 0 To 110
                PanelSales.Height = PanelSales.Height - 1
                'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 5
                Application.DoEvents()
            Next
            minsales = 0
        End If

    End Sub

    Private Sub LinkPurchasing_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPurchasing.LinkClicked
        Dim i As Integer
        'LinkPurchasing.Enabled = False
        If minPurchase = 0 Then
            For i = 0 To 110
                PanelPurchasing.Height = PanelPurchasing.Height + 1
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
                minPurchase = minPurchase + PanelPurchasing.Height
                Application.DoEvents()
            Next
        Else
            'MsgBox(Min)
            For i = 0 To 110
                PanelPurchasing.Height = PanelPurchasing.Height - 1
                PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 2
                Application.DoEvents()
            Next
            minPurchase = 0
        End If
    End Sub

    Private Sub menu_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Parent = Me.Panel1
        TabControl1.Dock = DockStyle.Fill
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        tampilkan(form_pasien)
    End Sub
End Class