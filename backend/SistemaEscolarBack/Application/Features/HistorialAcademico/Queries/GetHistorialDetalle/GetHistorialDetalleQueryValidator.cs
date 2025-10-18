using FluentValidation;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;

public class GetHistorialDetalleQueryValidator : AbstractValidator<GetHistorialDetalleQuery>
{
    public GetHistorialDetalleQueryValidator()
    {
        RuleFor(p => p.NoBoleta)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
    }
}
