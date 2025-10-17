using FluentValidation;

namespace Application.Features.PeriodoActual.Queries.GetAlumnosGrupo;

public class GetAlumnosGrupoQueryValidator : AbstractValidator<GetAlumnosGrupoQuery>
{
    public GetAlumnosGrupoQueryValidator()
    {
        RuleFor(g => g.Clave)
            .NotEmpty()
            .WithMessage("La clave es requerida.");
        
        RuleFor(g => g.Grupo)
            .NotEmpty()
            .WithMessage("El grupo es requerido.");
    }
}