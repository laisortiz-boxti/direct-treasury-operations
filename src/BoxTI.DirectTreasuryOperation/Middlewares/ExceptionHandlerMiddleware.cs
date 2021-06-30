using Microsoft.AspNetCore.Http;
using System;
using System.Net.Mime;
using System.Net;
using System.Threading.Tasks;
using BoxTI.DirectTreasuryOperation.API.Client.Responses;
using BoxTI.DirectTreasuryOperation.API.Client.Exceptions;

namespace BoxTI.DirectTreasuryOperation.API.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }

            catch(BusinessException exception)
            {
                await HandleExceptionAsync(context, exception);
            }
            
            catch (NotFoundException exceptionObj)
            {
                await HandleExceptionAsync(context, exceptionObj);
            }
            
            catch (Exception exceptionObj)
            {
                await HandleExceptionAsync(context, exceptionObj);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, BusinessException exception)
        {
            context.Response.ContentType = MediaTypeNames.Application.Json;
            string result = new ExceptionResponse() { Message = exception.Message }.ToString();
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return context.Response.WriteAsync(result);
        }

        private static Task HandleExceptionAsync(HttpContext context, NotFoundException exception)
        {
            context.Response.ContentType = MediaTypeNames.Application.Json;
            string result = new ExceptionResponse() { Message = exception.Message }.ToString();
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            return context.Response.WriteAsync(result);
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = MediaTypeNames.Application.Json;
            string result = new ExceptionResponse() { Message = exception.Message }.ToString();
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(result);
        }
    }
}
