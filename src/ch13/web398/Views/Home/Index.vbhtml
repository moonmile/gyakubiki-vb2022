@Code
    ViewData("Title") = "Home Page"
End Code

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
    @Html.ActionLink("About ページへ", "About", "Home")
</div>
