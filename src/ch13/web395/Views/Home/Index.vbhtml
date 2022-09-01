﻿@ModelType SampleModel
@Code
    ViewData("Title") = "Home Page"
End Code

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>

    <div>
        <div>@Model.Name</div>
        <div>@Model.Address</div>
    </div>
</div>
