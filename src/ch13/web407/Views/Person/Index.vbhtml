@ModelType Person
@Code
    ViewData("Title") = "登録"
End Code

<h1>フォーム入力</h1>
<div style="color:red">@ViewBag.ErrorMessage</div>
@Using Html.BeginForm("Post", "Person")
    @<div Class="container">
        <div Class="row">
            <div Class="col-2">名前</div>
            <div Class="col-3">@Html.TextBoxFor(Function(x) x.Name)</div>
        </div>
        <div Class="row">
            <div Class="col-2">年齢</div>
            <div Class="col-3">@Html.TextBoxFor(Function(x) x.Age)</div>
        </div>
        <div Class="row">
            <div Class="col-2">電話</div>
            <div Class="col-3">@Html.TextBoxFor(Function(x) x.Telephone)</div>
        </div>
        <div>
            <input type = "submit" value="登録" Class="btn-primary" />
        </div>
    </div>
End using 
