using Application.DTOs.Inicio;
using Application.Features.Inicio.Queries.GetInicioAlumno;
using Application.Features.Inicio.Queries.GetInicioDocente;
using Application.Features.Inicio.Queries.GetInicioGestion;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Enums;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApi.Controllers.v1;

namespace SistemaEscolar.UnitTests.WebApi.Controllers;

public class InicioControllerTests
{
    private readonly Mock<IMediator> _mediatorMock;
    private readonly Mock<ICurrentUserService> _userServiceMock;
    private readonly InicioController _controller;

    public InicioControllerTests()
    {
        _mediatorMock = new Mock<IMediator>();
        _userServiceMock = new Mock<ICurrentUserService>();
        _controller = new InicioController(_mediatorMock.Object, _userServiceMock.Object);
    }

    [Fact]
    public async Task GetInicio_UsuarioEsAlumno_DebeEnviarQueryAlumnoYRetornarOk()
    {
        var UserName = "2020640001";
        _userServiceMock.Setup(x => x.UserName).Returns(UserName);
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns(UserType.Alumno);

        _mediatorMock.Setup(m => m.Send(It.IsAny<GetInicioAlumnoQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(
                Response<InicioAlumnoDto>.Success(new InicioAlumnoDto(1, "Institucion test", 1, "Carrera test",
                    "Nombre alumno")));

        var result = await _controller.GetInicio();

        _mediatorMock.Verify(x => x.Send(
            It.Is<GetInicioAlumnoQuery>(q => q.NoBoleta == UserName), 
            It.IsAny<CancellationToken>()), Times.Once);

        var objectResult = result as ObjectResult;
        objectResult.Should().NotBeNull();
        objectResult!.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task GetInicio_UsuarioEsDocente_DebeEnviarQueryDocenteYRetornarOk()
    {
        var UserName = "RFC123456";
        _userServiceMock.Setup(x => x.UserName).Returns(UserName);
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns(UserType.Docente);

        _mediatorMock.Setup(m => m.Send(It.IsAny<GetInicioDocenteQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(
                Response<InicioDocenteDto>.Success(new InicioDocenteDto(1, "Institucion test", "Academia test",
                    "Nombre docente")));

        var result = await _controller.GetInicio();

        _mediatorMock.Verify(x => x.Send(
            It.Is<GetInicioDocenteQuery>(q => q.Rfc == UserName), 
            It.IsAny<CancellationToken>()), Times.Once);

        var objectResult = result as ObjectResult;
        objectResult!.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task GetInicio_UsuarioEsGestion_DebeEnviarQueryGestionYRetornarOk()
    {
        var UserName = "admin_user";
        _userServiceMock.Setup(x => x.UserName).Returns(UserName);
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns(UserType.Gestion);

        _mediatorMock.Setup(m => m.Send(It.IsAny<GetInicioGestionQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Response<InicioGestionDto>.Success(new InicioGestionDto(1, "Institucion test")));

        var result = await _controller.GetInicio();

        _mediatorMock.Verify(x => x.Send(
            It.Is<GetInicioGestionQuery>(q => q.Usuario == UserName), 
            It.IsAny<CancellationToken>()), Times.Once);

        var objectResult = result as ObjectResult;
        objectResult!.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task GetInicio_UserIdEsNulo_DebeRetornarBadRequest()
    {
        _userServiceMock.Setup(x => x.UserName).Returns((string?)null);
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns(UserType.Alumno);

        var result = await _controller.GetInicio();

        var objectResult = result as ObjectResult;
        objectResult.Should().NotBeNull();
        objectResult!.StatusCode.Should().Be(400); 

        _mediatorMock.Verify(x => x.Send(It.IsAny<object>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task GetInicio_UserTypeEsNulo_DebeRetornarBadRequest()
    {
        _userServiceMock.Setup(x => x.UserName).Returns("123");
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns((UserType?)null);

        var result = await _controller.GetInicio();

        var objectResult = result as ObjectResult;
        objectResult!.StatusCode.Should().Be(400);
        _mediatorMock.Verify(x => x.Send(It.IsAny<object>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task GetInicio_RolNoSoportado_DebeRetornarBadRequest()
    {
        var rolNoManejado = (UserType)999; 
        
        _userServiceMock.Setup(x => x.UserName).Returns("123");
        _userServiceMock.Setup(x => x.GetCurrentUserType()).Returns(rolNoManejado);

        var result = await _controller.GetInicio();

        var objectResult = result as ObjectResult;
        objectResult!.StatusCode.Should().Be(400);
        
        var response = objectResult.Value as Response<string>;
        response!.Message.Should().Contain("Rol de usuario no soportado");
    }
}