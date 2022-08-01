Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = DateTime.Now

        Label3.Text = $"例:
  {dt.ToString("yyyy年MM月dd日")} 
  {dt.ToString("yyyy/MM/dd")} 
  {dt.ToString("yyyy-MM-dd")} 
"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DateTime
        If DateTime.TryParse(TextBox1.Text, dt) = False Then
            Label2.Text = "日付が変換できませんでした"
        Else
            Label2.Text = dt.ToString()
        End If
    End Sub
End Class
