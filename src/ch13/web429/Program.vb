Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()

        ' appsettings.json Ç©ÇÁê⁄ë±ï∂éöóÒÇéÊìæÇ∑ÇÈ
        builder.Services.AddDbContext(Of ApplicationDbContext)(
            Sub(options)
                options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext"))
            End Sub
        )


        Dim app = builder.Build()
        If app.Environment.IsDevelopment() Then
            app.UseSwagger()
            app.UseSwaggerUI()
        End If
        app.UseHttpsRedirection()
        app.UseAuthorization()
        app.MapControllers()
        app.Run()
    End Sub
End Module
