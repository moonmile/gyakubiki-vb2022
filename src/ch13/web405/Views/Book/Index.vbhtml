@ModelType Book
@Code
    ViewData("Title") = "Index"

End Code

<h1>モデルを参照する</h1>
@If Model Is Nothing Then
    @<div Class="container">
        <div> 指定したIDの書籍が見つかりませんでした</div>
    </div>
Else
    @<div Class="container">
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
End If
                                                                        



