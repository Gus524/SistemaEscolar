using Application.Features.MapaCurricular.Queries.GetCarreras;
using FluentValidation;

namespace Application.Features.MapaCurricular.Queries.GetMapaCurricular;

public class GetMapaCurricularQueryValidator : AbstractValidator<GetMapaCurricularQuery>
{
    public GetMapaCurricularQueryValidator()
    {
        RuleFor(m => m.Plan)
            .NotEmpty()
            .WithMessage("El plan es obligatorio.")
            .GreaterThan(0)
            .WithMessage("El plan no puede ser menor que 0.");

        RuleFor(m => m.Carrera)
            .NotEmpty()
            .WithMessage("La carrera es obligatoria.");
    }
}