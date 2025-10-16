using FluentValidation;

namespace Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;

public class GetEstadoGeneralAlumnoQueryValidator : AbstractValidator<GetEstadoGeneralAlumnoQuery>
{
    public GetEstadoGeneralAlumnoQueryValidator()
    {
        RuleFor(p => p.NoBoleta)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
        
        RuleFor(p => p.IdPlan)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
    }
}
