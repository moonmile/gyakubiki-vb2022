﻿@ModelType web401.Book
@Code
    ViewData("Title") = "Index"
End Code

<h1>モデルを参照する</h1>
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
        <div class="col-2">著者名</div>
        <div class="col-3">@Model.Author.Name</div>
    </div>
    <div class="row">
        <div class="col-2">出版社名</div>
        <div class="col-3">@Model.Publisher.Name</div>
    </div>
    <div class="row">
        <div class="col-2">価格</div>
        <div class="col-3">@Model.Price 円</div>
    </div>
</div>
