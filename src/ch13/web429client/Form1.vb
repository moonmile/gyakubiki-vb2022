Imports System.ComponentModel.DataAnnotations
Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1

    Private _store As Store

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = Integer.Parse(TextBox1.Text)
        Dim Url = $"https://localhost:7282/api/Stores/{id}"
        Dim cl As New HttpClient()
        Dim Json = Await cl.GetStringAsync(Url)
        _store = System.Text.Json.JsonSerializer.Deserialize(Of Store)(
            Json, New System.Text.Json.JsonSerializerOptions With
            {
                .PropertyNameCaseInsensitive = True
            })
        If _store Is Nothing Then
            MessageBox.Show("指定した在庫が見つかりません")
            Return
        End If
        TextBox2.Text = _store.Stock.ToString()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If _store Is Nothing Then Return

        Dim Url = $"https://localhost:7282/api/Stores/{_store.Id}"
        _store.Stock = Integer.Parse(TextBox2.Text)
        Dim cl As New HttpClient()
        Dim Json = System.Text.Json.JsonSerializer.Serialize(_store)
        Dim context = New StringContent(Json, System.Text.Encoding.UTF8, "application/json")
        Dim response = Await cl.PostAsync(Url, context)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("在庫数を変更しました")
        Else
            MessageBox.Show("在庫数の変更に失敗しました")
        End If
    End Sub
End Class


''' <summary>
''' 在庫クラス
''' </summary>
Public Class Store
    <Key>
    Public Id As Integer
    Public BookId As Integer
    Public Stock As Integer
    Public CreatedAt As DateTime
    Public UpdatedAt As DateTime
End Class
