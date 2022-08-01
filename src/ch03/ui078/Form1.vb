Public Class Form1
    ''' <summary>
    ''' ノードの取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TreeView1.SelectedNode.FullPath
    End Sub

    ''' <summary>
    ''' ノードの追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Text = TextBox1.Text
        Dim node = TreeView1.SelectedNode
        If Text <> "" And Not node Is Nothing Then
            node.Nodes.Add(New TreeNode(Text))
        End If
    End Sub

    ''' <summary>
    ''' ノードの削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim node = TreeView1.SelectedNode
        If Not node Is Nothing Then
            node.Remove()
        End If
    End Sub
End Class
