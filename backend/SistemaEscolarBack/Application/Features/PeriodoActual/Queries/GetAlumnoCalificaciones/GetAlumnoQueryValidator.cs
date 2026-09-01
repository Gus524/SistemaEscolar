using FluentValidation;

namespace Application.Features.PeriodoActual.Queries.GetAlumnoCalificaciones;

public class GetAlumnoQueryValidator : AbstractValidator<GetAlumnoCalificacionesQuery>
{
    public GetAlumnoQueryValidator()
    {
        RuleFor(a => a.NoBoleta)
            .NotEmpty()
            .WithMessage("La boleta es requerida")
            .GreaterThan(0)
            .WithMessage("La boleta debe ser mayor a 0");
        
        RuleFor(a => a.Plan)
            .NotEmpty()
            .WithMessage("El plan es requerido.")
            .GreaterThan(0)
            .WithMessage("El plan debe ser mayor a 0");
    }
}