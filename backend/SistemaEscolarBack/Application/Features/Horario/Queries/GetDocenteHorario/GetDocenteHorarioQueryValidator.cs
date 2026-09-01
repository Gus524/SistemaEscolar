using FluentValidation;

namespace Application.Features.Horario.Queries.GetDocenteHorario;

public class GetDocenteHorarioQueryValidator : AbstractValidator<GetDocenteHorarioQuery>
{
    public GetDocenteHorarioQueryValidator()
    {
        RuleFor(p => p.Rfc)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
            .MaximumLength(13).WithMessage("{PropertyName} no debe exceder {MaximumLength} caracteres.");
    }
}
