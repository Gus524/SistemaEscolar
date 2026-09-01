using FluentValidation;

namespace Application.Features.MapaCurricular.Queries.GetPlanesEstudio;

public class GetPlanesEstudioQueryValidator : AbstractValidator<GetPlanesEstudioQuery>
{
    public GetPlanesEstudioQueryValidator()
    {
        RuleFor(x => x.Carrera)
            .NotEmpty()
            .WithMessage("La carrera es obligatoria.");
    }
}