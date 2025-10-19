using FluentValidation;

namespace Application.Features.Horario.Queries.GetGrupos;

public class GetGruposQueryValidator : AbstractValidator<GetGruposQuery>
{
    public GetGruposQueryValidator()
    {
        RuleFor(s => s.PlanId)
            .NotEmpty()
            .WithMessage("El plan es requerido.");
        
        RuleFor(s => s.Semestre)
            .NotEmpty()
            .WithMessage("El semestre es requerido.");
    }
}