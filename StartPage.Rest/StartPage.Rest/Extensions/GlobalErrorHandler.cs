using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    public static class GlobalErrorHandler
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app, ILogger logger, bool showException = false)
        {
            app.UseExceptionHandler(a => 
                a.Run(async context =>
                {
                    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var exception = exceptionHandlerPathFeature.Error;

                    logger.LogError($"Unhandled Exception: {exception.ToString()}");

                    var result = showException
                        ? JsonConvert.SerializeObject(new { error = exception.ToString() })
                        : JsonConvert.SerializeObject(new { error = "Unhandled Error" });
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync(result);
                }));

        }
    }
}
