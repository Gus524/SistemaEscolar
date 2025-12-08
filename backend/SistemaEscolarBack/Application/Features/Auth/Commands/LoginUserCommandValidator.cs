using FluentValidation;

namespace Application.Features.Auth.Commands;

public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty()
            .WithMessage("El usuario es requerido.");
        
        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("La contraseña es requerida.");
    }
}