using Domain.Enums;

namespace Application.DTOs.Auth;

public record AuthUserDto(string UserName, UserType Tipo);