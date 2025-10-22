using FluentValidation;

namespace Application.Features.MapaCurricular.Queries.GetCarreras;

public class GetCarrerasQueryValidator : AbstractValidator<GetCarrerasQuery>
{
    public GetCarrerasQueryValidator()
    {
        RuleFor(x => x.Institucion)
            .NotEmpty()
            .WithMessage("La institución es obligatoria.")
            .GreaterThan(0)
            .WithMessage("La institución debe ser mayor a 0.");
    }
}