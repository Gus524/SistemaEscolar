using System.Text.Json.Serialization;
using MediatR;

namespace Application.Wrapper;

public class Response<T>
{
    public bool Succeeded { get; set; }
    public string? Message { get; set; }
    public List<string> Errors { get; set; }
    public T? Data { get; set; }
    [JsonIgnore]
    public SuccessType SuccessType { get; set; }
    [JsonIgnore]
    public ErrorType ErrorType { get; set; }
    public Response() { }

    private Response(bool succeeded, T? data, string? message, List<string>? errors, SuccessType successType, ErrorType errorType)
    {
        Succeeded = succeeded;
        Data = data;
        Message = message;
        Errors = errors ?? [];
        SuccessType = successType;
        ErrorType = errorType;
    }

    public static Response<T> Success(T data, string? message = null)
    {
        return new Response<T>(true, data, message, null, SuccessType.Ok, default);
    }

    public static Response<Unit> NoContent(string? message = null)
    {
        return new Response<Unit>(true, Unit.Value, message, null, SuccessType.NoContent, default);
    }

    public static Response<T> Created(T data, string? message = null)
    {
        return new Response<T>(true, data, message, null, SuccessType.Created, default);
    }

    public static Response<T> Fail(string errorMessage)
    {
        return new Response<T>(false, default, errorMessage, [errorMessage], default, ErrorType.Validation);
    }
    
    public static Response<T> NotFound(string message = "Recurso no encontrado.")
    {
        return new Response<T>(false, default, message, [message], default, ErrorType.NotFound);
    }

    public static Response<T> Unauthorized(string message = "Usted no está autorizado para consumir este recurso.")
    {
        return new Response<T>(false, default, message, [message], default, ErrorType.Unauthorized);
    }

    public static Response<T> Forbbiden(
        string message = "No tiene los permisos suficientes para consumir este recurso.")
    {
        return new Response<T>(false, default, message, [message], default, ErrorType.Forbidden);
    }
}