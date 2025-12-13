using Application.DTOs.Inicio;
using Application.Features.Inicio.Queries.GetInicioGestion;
using Application.Interfaces;
using FluentAssertions;
using Moq;

namespace SistemaEscolar.UnitTests.Application.Features.Inicio.Queries;

public class GetInicioGestionQueryHandlerTests
{
    private readonly Mock<IGetInicioRepository> _repoMock;
    private readonly GetInicioGestionQueryHandler _handler;

    public GetInicioGestionQueryHandlerTests()
    {
        _repoMock = new Mock<IGetInicioRepository>();
        _handler = new GetInicioGestionQueryHandler(_repoMock.Object);
    }

    [Fact]
    public async Task Handle_GestionExiste_DebeRetornarSuccess()
    {
        var usuario = "admin_sistemas";
        var query = new GetInicioGestionQuery(usuario);
        
        var dtoEsperado = new InicioGestionDto(5, "Dirección General");
        _repoMock.Setup(x => x.GetInicioGestion(usuario))
            .ReturnsAsync(dtoEsperado);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeTrue();
        result.Data.Institucion.Should().Be("Dirección General");
        _repoMock.Verify(x => x.GetInicioGestion(usuario), Times.Once);
    }

    [Fact]
    public async Task Handle_GestionNoExiste_DebeRetornarNotFound()
    {
        var query = new GetInicioGestionQuery("usuario_fantasma");
        _repoMock.Setup(x => x.GetInicioGestion(It.IsAny<string>()))
            .ReturnsAsync((InicioGestionDto?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeFalse();
        result.Message.Should().Contain("Datos de gestión no encontrados");
    }
}