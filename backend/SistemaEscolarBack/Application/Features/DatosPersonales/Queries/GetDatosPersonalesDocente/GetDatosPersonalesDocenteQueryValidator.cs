using FluentValidation;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;

public class GetDatosPersonalesDocenteQueryValidator : AbstractValidator<GetDatosPersonalesDocenteQuery>
{
    public GetDatosPersonalesDocenteQueryValidator()
    {
        RuleFor(p => p.Rfc)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
            .MaximumLength(13).WithMessage("{PropertyName} no debe exceder {MaximumLength} caracteres.");
    }
}
