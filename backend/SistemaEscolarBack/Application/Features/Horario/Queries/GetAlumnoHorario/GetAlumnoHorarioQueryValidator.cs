using FluentValidation;

namespace Application.Features.Horario.Queries.GetAlumnoHorario;

public class GetAlumnoHorarioQueryValidator : AbstractValidator<GetAlumnoHorarioQuery>
{
    public GetAlumnoHorarioQueryValidator()
    {
        RuleFor(p => p.NoBoleta)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
    }
}
