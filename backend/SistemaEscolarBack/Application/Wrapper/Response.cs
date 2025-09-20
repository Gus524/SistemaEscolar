namespace Application.Wrapper;

public class Response<T>
{
    public bool Succeeded { get; init; }
    public string? Message { get; init; }
    public List<string> Errors { get; init; }
    public T? Data { get; init; }
    private Response(bool succeeded, T? data, string? message, List<string>? errors)
    {
        Succeeded = succeeded;
        Data = data;
        Message = message;
        Errors = errors ?? []; 
    }
    
    public static Response<T> Success(T data, string? message = null)
    {
        return new Response<T>(true, data, message, null);
    }

    public static Response<T> Fail(string errorMessage)
    {
        return new Response<T>(false, default, errorMessage, [errorMessage]); 
    }
    public static Response<T> Fail(List<string> errors)
    {
        var message = string.Join(Environment.NewLine, errors);
        return new Response<T>(false, default, message, errors);
    }
}