using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;


namespace Tavisca.Applause.Web.Middleware
{
    public class ErrorHandler
    {
       private readonly RequestDelegate _next;
        public ErrorHandler(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            
            catch (Exception exception)
            {

                await HandleException(context, exception);
            }
        }

        private Task HandleException(HttpContext context, Exception exception)
        {
            ErrorInfo error;
            if (exception is BaseApplicationException baseApplicationException)
            {
                error = ToErrorInfo(baseApplicationException);
                context.Response.StatusCode = (int)baseApplicationException.HttpStatusCode;
            }
            else
            {
                error = new ErrorInfo("Internal Server Error", HttpStatusCode.InternalServerError);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                
            }
            
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(JsonConvert.SerializeObject(error));
        }

        private ErrorInfo ToErrorInfo(BaseApplicationException baseApplicationException)
        {
            var errorInfo = new ErrorInfo(baseApplicationException.ErrorMessage, baseApplicationException.HttpStatusCode);
            if (baseApplicationException.Info != null && baseApplicationException.Info.Count > 0)
                errorInfo.Info.AddRange(baseApplicationException.Info);
            return errorInfo;
        }


    }

       
    }
