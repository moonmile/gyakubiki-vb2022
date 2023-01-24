@Imports web402.Models
@ModelType Book
@Code
    ViewData("Title") = "Index"

    ' 新しい Book オブジェクトを作る
    Dim Book As New Book With
    {
        .Id = 1,
        .Title = "新しい逆引き大全",
        .AuthorId = 1,
        .PublisherId = 1,
        .Price = 99,
        .Author = New Author With
        {
            .Id = 1,
            .Name = "未定"
        },
            .Publisher = New Publisher With
        {
            .Id = 1,
                .Name = "秀和システム"
        }
    }
End Code

<h1>モデルを参照する</h1>
<div class="container">
    <div class="row">
        <div class="col-2">ID</div>
        <div class="col-3">@Book.Id</div>
    </div>
    <div class="row">
        <div class="col-2">タイトル</div>
        <div class="col-3">@Book.Title</div>
    </div>
    <div class="row">
        <div class="col-2">著者名</div>
        <div class="col-3">@Book.Author.Name</div>
    </div>
    <div class="row">
        <div class="col-2">出版社名</div>
        <div class="col-3">@Book.Publisher.Name</div>
    </div>
    <div class="row">
        <div class="col-2">価格</div>
        <div class="col-3">@Book.Price 円</div>
    </div>
</div>
