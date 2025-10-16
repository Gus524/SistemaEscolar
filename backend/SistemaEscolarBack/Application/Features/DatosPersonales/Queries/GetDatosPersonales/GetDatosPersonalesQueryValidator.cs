using FluentValidation;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonales;

public class GetDatosPersonalesQueryValidator : AbstractValidator<GetDatosPersonalesQuery>
{
    public GetDatosPersonalesQueryValidator()
    {
        RuleFor(a => a.NoBoleta)
            .NotEmpty()
            .WithMessage("El número de boleta es requerido.");
    }
}