﻿@ModelType Book
@Code
    ViewData("Title") = "入力結果"
End Code

<h1>入力結果</h1>

<div class="container">
    <div class="row">
        <div class="col-2">ID</div>
        <div class="col-3">@Model.Id</div>
    </div>
    <div class="row">
        <div class="col-2">タイトル</div>
        <div class="col-3">@Model.Title</div>
    </div>
    <div class="row">
        <div class="col-2">価格</div>
        <div class="col-3">@Model.Price 円</div>
    </div>
</div>

