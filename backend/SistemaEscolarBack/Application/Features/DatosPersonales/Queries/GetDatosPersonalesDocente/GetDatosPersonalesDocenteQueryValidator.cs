using FluentValidation;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;

public class GetDatosPersonalesDocenteQueryValidator : AbstractValidator<GetDatosPersonalesDocenteQuery>
{
    public GetDatosPersonalesDocenteQueryValidator()
    {
        RuleFor(p => p.Rfc)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .MaximumLength(13).WithMessage("{PropertyName} no debe exceder {MaxLength} caracteres.");
    }
}
