@ModelType web417.Book

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Book</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Author.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Author.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Publisher.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Publisher.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
