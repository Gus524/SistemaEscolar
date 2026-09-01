using System.Net;
using System.Text.Json;
using Application.Wrapper;

namespace WebApi.Middleware;

public class ErrorHandlerMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var responseModel = Response<string>.Fail(error.Message);

            switch (error)
            {
                case Application.Exceptions.ApiException e:
                    //custom application error
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case Application.Exceptions.ValidationException e:
                    //custom application error
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    responseModel.Errors = e.Errors;
                    break;
                default:
                    // unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonSerializer.Serialize(responseModel);

            await response.WriteAsync(result);
        }
    }
}