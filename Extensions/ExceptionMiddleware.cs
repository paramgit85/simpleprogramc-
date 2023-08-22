using FindDistanceApp.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace FindDistanceApp.Extensions
{
    public static class ExceptionMiddleware
    {
        public static void ConfigureExceptionHandelr(this IApplicationBuilder app)
        {

            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        var ex = error.Error;

                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            ErrorMessage = ex.Message
                        }.ToString()); 
                    }
                });
            });


        }
    }
}
