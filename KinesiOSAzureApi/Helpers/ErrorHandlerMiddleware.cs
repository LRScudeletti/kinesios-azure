﻿using System.Net;
using System.Text.Json;

namespace KinesiOSAzureApi.Helpers
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                response.StatusCode = error switch
                {
                    // Custom application error
                    AppException => (int)HttpStatusCode.BadRequest,
                    // Not found error
                    KeyNotFoundException => (int)HttpStatusCode.NotFound,
                    // Unhandled error
                    _ => (int)HttpStatusCode.InternalServerError
                };

                var result = JsonSerializer.Serialize(new { message = error.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
