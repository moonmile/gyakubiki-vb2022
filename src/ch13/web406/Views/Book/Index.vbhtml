@ModelType Book
@Code
    ViewData("Title") = "Index"
End Code

<h1>フォーム入力</h1>

@Using Html.BeginForm("Post", "Book")
@<div Class="container">
    <div Class="row">
        <div Class="col-2">ID</div>
        <div Class="col-3">@Html.TextBoxFor(Function(x) x.Id)</div>
    </div>
    <div Class="row">
        <div Class="col-2">タイトル</div>
        <div Class="col-3">@Html.TextBoxFor(Function(x) x.Title)</div>
    </div>
    <div Class="row">
        <div Class="col-2">価格</div>
        <div Class="col-3">@Html.TextBoxFor(Function(x) x.Price)</div>
    </div>
    <div>
    <input type = "submit" value="登録" Class="btn-primary" />
    </div>
</div>
End Using 

