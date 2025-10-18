using FluentValidation;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;

public class GetHistorialAlumnoQueryValidator : AbstractValidator<GetHistorialAlumnoQuery>
{
    public GetHistorialAlumnoQueryValidator()
    {
        RuleFor(p => p.NoBoleta)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
    }
}
