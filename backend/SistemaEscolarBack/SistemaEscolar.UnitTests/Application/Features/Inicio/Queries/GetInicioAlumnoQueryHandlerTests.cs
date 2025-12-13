using Application.DTOs.Inicio;
using Application.Features.Inicio.Queries.GetInicioAlumno;
using Application.Interfaces;
using Application.Wrapper;
using FluentAssertions;
using Moq;

namespace SistemaEscolar.UnitTests.Application.Features.Inicio.Queries;

public class GetInicioAlumnoQueryHandlerTests
{
    private readonly Mock<IGetInicioRepository> _repoMock;
    private readonly GetInicioAlumnoQueryHandler _handler;

    public GetInicioAlumnoQueryHandlerTests()
    {
        _repoMock = new Mock<IGetInicioRepository>();
        _handler = new GetInicioAlumnoQueryHandler(_repoMock.Object);
    }

    [Fact]
    public async Task Handle_DatosExisten_DebeRetornarSuccessConDatos()
    {
        var boletaString = "2023640001";
        var boletaLong = 2023640001L;
        var query = new GetInicioAlumnoQuery(boletaString);
        
        var dtoEsperado = new InicioAlumnoDto(1, "ESCOM", 2009, "Sistemas");
        _repoMock.Setup(x => x.GetInicioAlumno(boletaLong))
            .ReturnsAsync(dtoEsperado);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeTrue();
        result.Data.Should().NotBeNull();
        result.Data.Institucion.Should().Be("ESCOM");
        result.Data.Carrera.Should().Be("Sistemas");
        
        _repoMock.Verify(x => x.GetInicioAlumno(boletaLong), Times.Once);
    }

    [Fact]
    public async Task Handle_AlumnoNoExiste_DebeRetornarNotFound()
    {
        var query = new GetInicioAlumnoQuery("2023640001");
        
        _repoMock.Setup(x => x.GetInicioAlumno(It.IsAny<long>()))
            .ReturnsAsync((InicioAlumnoDto?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Succeeded.Should().BeFalse();
        result.Message.Should().Contain("no econtrados");
        result.ErrorType.Should().Be(ErrorType.NotFound);
    }

    [Fact]
    public async Task Handle_BoletaFormatoInvalido_DebeLanzarExcepcion()
    {
        var query = new GetInicioAlumnoQuery("BOLETA_INVALIDA"); 

        Func<Task> act = async () => await _handler.Handle(query, CancellationToken.None);

        await act.Should().ThrowAsync<FormatException>();
    }
}