﻿<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
    <title>@ViewBag.Title</title>
    <style>
        body {
            font-size: 30px;
            color: white;
            background-color: black;
            font-family: Impact;
        }
    </style>
</head>
<body>
    <div class="container">
        <main role="main" class="pb-3">
            @RenderBody()
        </main>
    </div>

    <footer class="border-top footer text-muted">
        <div class="container">
            逆引き大全 Visual Basic 2022
        </div>
    </footer>
</body>
</html>
