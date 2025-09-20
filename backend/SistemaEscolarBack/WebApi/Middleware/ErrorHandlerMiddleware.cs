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

            Response<string> responseModel;

            switch (error)
            {
                case Application.Exceptions.ApiException e:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    responseModel = Response<string>.Fail(error.Message);
                    break;

                case Application.Exceptions.ValidationException e:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    responseModel = Response<string>.Fail(e.Errors); 
                    break;

                case KeyNotFoundException e:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    responseModel = Response<string>.Fail("El recurso solicitado no fue encontrado.");
                    break;

                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    responseModel = Response<string>.Fail("Ocurrió un error interno en el servidor.");
                    break;
            }

            var result = JsonSerializer.Serialize(responseModel);

            await response.WriteAsync(result);
        }
    }
}