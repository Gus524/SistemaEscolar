using FluentValidation;

namespace Application.Features.Horario.Queries.GetHorarioPorGrupo;

public class GetHorarioPorGrupoQueryValidator : AbstractValidator<GetHorarioPorGrupoQuery>
{
    public GetHorarioPorGrupoQueryValidator()
    {
        RuleFor(p => p.Secuencia)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.");
    }
}
