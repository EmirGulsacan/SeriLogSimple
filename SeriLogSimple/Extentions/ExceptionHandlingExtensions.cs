using SeriLogSimple.Helpers;

namespace SeriLogSimple.Extentions
{
    public static class ExceptionHandlingExtensions
    {
        public static IApplicationBuilder UseExceptionHandlerWithLogging(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    var exceptionHandlerPathFeature =
                        context.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature>();

                    if (exceptionHandlerPathFeature?.Error != null)
                    {
                        var logHelper = context.RequestServices.GetService(typeof(ILogHelper)) as ILogHelper;
                        if (logHelper != null)
                        {
                            logHelper.LogError($"Exception occurred: {exceptionHandlerPathFeature.Error}");
                        }
                    }

                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await context.Response.WriteAsync("An unexpected fault occurred. Please try again later.");
                });
            });

            return app;
        }
    }
}
