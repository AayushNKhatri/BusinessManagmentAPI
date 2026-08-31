using BusinessManagment.DomainLayer.HelperModel;
using System.Net;
using System.Text.Json;

namespace BusinessManagment.PresentaionLayer.Middleware
{
    public class GlobalExeption
    {
        private readonly RequestDelegate _next;

        public GlobalExeption(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        private static async Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            var status = e switch
            {
                ArgumentException => HttpStatusCode.BadRequest,
                UnauthorizedAccessException => HttpStatusCode.Unauthorized,
                KeyNotFoundException => HttpStatusCode.NotFound,
                InvalidOperationException => HttpStatusCode.Conflict,
                _ => HttpStatusCode.InternalServerError,
            };

            var response = new APIResponse
            {
                Error = e.InnerException?.Message ?? e.Message,
                Messege = e.Message,
                Success = false,
                TraceID = context.TraceIdentifier
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

    }
}
