using FluentValidation;

namespace Application.Features.Horario.Queries.GetHorarioGeneral;

public class GetHorarioGeneralQueryValidator : AbstractValidator<GetHorarioGeneralQuery>
{
    public GetHorarioGeneralQueryValidator()
    {
        RuleFor(p => p.IdPlan)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
            .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
    }
}
