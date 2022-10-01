using System.Net;

namespace StockPlatformWebAPI.ErrorHandling
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {            
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            ErrorDetails errorDetails = new ErrorDetails();

            if(exception is NullReferenceException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;

                errorDetails = new ErrorDetails()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Message = exception.Message
                };
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                errorDetails = new ErrorDetails()
                {
                    StatusCode = context.Response.StatusCode,
                    Message = "Internal Server Error from the custom middleware."
                };
            }
  
            await context.Response.WriteAsync(errorDetails.ToString());
        }
    }
}
