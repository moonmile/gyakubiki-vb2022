@ModelType List(Of Book)
@Code
    ViewData("Title") = "Index"

End Code

<h1>書籍一覧</h1>
<div Class="container">
@If Model Is Nothing Then
    @<div>書籍がありません</div>
Else
@<div Class="container">
    <table class="table">
        <tr>
            <th>ID</th>
            <th>タイトル</th>
            <th>著者名</th>
            <th>出版社</th>
            <th>価格</th>
        </tr>
        @For Each book In Model 
        @<tr>
            <td>@Book.Id</td>
            <td>@Book.Title</td>
            <td>@Book.Author.Name</td>
            <td>@Book.Publisher.Name</td>
            <td>@Book.Price</td>
        </tr>
        next
    </table>
</div>
End If
</div>



