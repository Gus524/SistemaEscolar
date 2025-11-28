using System.Net;
using Application.Wrapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    protected IActionResult HandleResult<T>(Response<T> response)
    {
        if (response.Succeeded)
        {
            return response.SuccessType switch
            {
                SuccessType.NoContent => NoContent(),
                SuccessType.Created => CreatedAtAction(null, response.Data),
                _ => Ok(response)
            };
        }

        var statusCode = response.ErrorType switch
        {
            ErrorType.NotFound => HttpStatusCode.NotFound,
            ErrorType.Validation => HttpStatusCode.BadRequest,
            ErrorType.Unauthorized => HttpStatusCode.Unauthorized,
            ErrorType.Forbidden => HttpStatusCode.Forbidden,
            _ => HttpStatusCode.InternalServerError
        };

        return StatusCode((int)statusCode, response);
    }
}