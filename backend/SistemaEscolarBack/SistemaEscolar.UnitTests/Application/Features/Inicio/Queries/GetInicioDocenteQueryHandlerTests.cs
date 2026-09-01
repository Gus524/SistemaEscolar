using Application.DTOs.Inicio;
using Application.Features.Inicio.Queries.GetInicioDocente;
using Application.Interfaces;
using FluentAssertions;
using Moq;

namespace SistemaEscolar.UnitTests.Application.Features.Inicio.Queries;

public class GetInicioDocenteQueryHandlerTests
{
    private readonly Mock<IGetInicioRepository> _repoMock;
    private readonly GetInicioDocenteQueryHandler _handler;

    public GetInicioDocenteQueryHandlerTests()
    {
        _repoMock = new Mock<IGetInicioRepository>();
        _handler = new GetInicioDocenteQueryHandler(_repoMock.Object);
    }

    [Fact]
    public async Task Handle_DocenteExiste_DebeRetornarSuccess()
    {
        var rfc = "ABCD900101XYZ";
        var query = new GetInicioDocenteQuery(rfc);
        
        var dtoEsperado = new InicioDocenteDto(1, "UPIITA", "Ingeniería", "Nombre");
        _repoMock.Setup(x => x.GetInicioDocente(rfc))
            .ReturnsAsync(dtoEsperado);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeTrue();
        result.Data.Institucion.Should().Be("UPIITA");
        result.Data.Nombre.Should().Be("Nombre");
        _repoMock.Verify(x => x.GetInicioDocente(rfc), Times.Once);
    }

    [Fact]
    public async Task Handle_DocenteNoExiste_DebeRetornarNotFound()
    {
        var query = new GetInicioDocenteQuery("RFC_INEXISTENTE");
        _repoMock.Setup(x => x.GetInicioDocente(It.IsAny<string>()))
            .ReturnsAsync((InicioDocenteDto?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeFalse();
        result.Message.Should().Contain("No se encontraron datos");
    }
}