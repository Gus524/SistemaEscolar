using FluentValidation;

namespace Application.Features.Horario.Queries.GetGrupos;

public class GetGruposQueryValidator : AbstractValidator<GetGruposQuery>
{
    public GetGruposQueryValidator()
    {
        RuleFor(s => s.PlanId)
            .NotEmpty()
            .WithMessage("El plan es requerido.")
            .GreaterThan(0)
            .WithMessage("El plan debe ser mayor que 0.");
        
        RuleFor(s => s.Semestre)
            .NotEmpty()
            .WithMessage("El semestre es requerido.")
            .GreaterThan(0)
            .WithMessage("El semestre debe ser mayor que 0.");
    }
}