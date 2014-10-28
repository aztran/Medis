
Public Class form_menu
    Private Sub LoadTree()
        ' TODO: Add code to add items to the treeview

        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode
        Dim tvode As TreeNode

        Dim tvroota As TreeNode
        Dim tvnodea As TreeNode
        Dim tvnodeaa As TreeNode
        Dim yeah As TreeNode
        Dim physical As TreeNode
        tvroota = Me.TreeView.Nodes.Add("Transaction")
        tvnodea = tvroota.Nodes.Add("Checkup")
        tvnodeaa = tvnodea.Nodes.Add("Create Checkup Record")
        tvnodeaa = tvnodea.Nodes.Add("Search Checkup Record")
        tvnodeaa = tvnodea.Nodes.Add("Edit Checkup Record")
        tvnodeaa = tvnodea.Nodes.Add("View Checkup Record")
        tvnodea = tvroota.Nodes.Add("Examination")
        yeah = tvnodea.Nodes.Add("Create Examination Record")
        yeah = tvnodea.Nodes.Add("Search Examination Record")
        yeah = tvnodea.Nodes.Add("Update Examination Record")
        tvode = tvroota.Nodes.Add("Physical Examination Record")
        physical = tvode.Nodes.Add("Create Physical Examination Record")
        physical = tvode.Nodes.Add("Search Physical Examination Record")




        tvRoot = Me.TreeView.Nodes.Add("User Management")
        tvNode = tvRoot.Nodes.Add("Create User Account")
        tvNode = tvRoot.Nodes.Add("Search User Account")

        tvNode = tvRoot.Nodes.Add("Update User Account")

        'load start page in panel
        'Panel1.Controls.Clear()
        'Panel1.Controls.Add(UMcreate)
        'UMcreate.Dock = DockStyle.Fill
    End Sub
    Private Sub ToggleFoldersVisible()
        'First toggle the checked state of the associated menu item
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Change the Folders toolbar button to be in sync
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Collapse the Panel containing the TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked
    End Sub
    Private Sub form_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTree()

    End Sub

    Private Sub FoldersToolStripButton_Click(sender As Object, e As EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub TreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect

        If TreeView.SelectedNode.Text = "Checkup" = True Then
            Dim checkup As New menu

            Panel1.Controls.Clear()
            Panel1.Controls.Add(checkup)
            checkup.Dock = DockStyle.Fill

        End If
    End Sub
End Class