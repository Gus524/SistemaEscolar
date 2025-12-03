using FluentValidation;

namespace Application.Features.Reinscripcion.Commands.ValidarReinscripcion;

public class ValidarReinscripcionCommandValidator : AbstractValidator<ValidarReinscripcionCommand>
{
    public ValidarReinscripcionCommandValidator()
    {
        RuleFor(a => a.Horario)
            .NotEmpty()
            .WithMessage("Se debe inscribir al menos una materia.");
    }
}