Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()
        ' CORS��ǉ�
        builder.Services.AddCors()

        Dim app = builder.Build()
        If app.Environment.IsDevelopment() Then
            app.UseSwagger()
            app.UseSwaggerUI()
        End If

        ' CORS�̐ݒ�
        app.UseCors(Function(options)
                        Return options.AllowAnyOrigin().
                            AllowAnyMethod().
                            AllowAnyHeader()
                    End Function)

        app.UseHttpsRedirection()
        app.UseAuthorization()
        app.MapControllers()
        app.Run()
    End Sub
End Module
