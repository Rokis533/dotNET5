using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PotatoApi.Controllers;
using PotatoApi.Entities;
using PotatoApi.Repositories;

namespace PotatoApi.Test
{
    public class PotatoControllerTests
    {
        [Fact]
        public async Task GetPotato_GetPotatoById_NotFound()
        {
            //Arrange
            var potatoRepositoryMock = new Mock<IPotatoRepository>();
            var loggerMock = new Mock<ILogger<PotatoesController>>();

            // sut - subject under test
            var sut = new PotatoesController(potatoRepositoryMock.Object, loggerMock.Object);

            //Act
            var result = await sut.GetPotato(1);


            //Assert
            Assert.IsType<NotFoundResult>(result.Result);

        }
        [Theory, PotatoData]
        public async Task GetPotato_GetPotatoById_Success(Potato potato)
        {

            //Arrange

            var potatoRepositoryMock = new Mock<IPotatoRepository>();
            var loggerMock = new Mock<ILogger<PotatoesController>>();

            // sut - subject under test
            var sut = new PotatoesController(potatoRepositoryMock.Object, loggerMock.Object);
            potatoRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(potato);


            //Act
            var result = await sut.GetPotato(It.IsAny<int>());


            //Assert
            Assert.Equal(potato, result.Value);


        }
        [Fact]
        public async Task GetPotato_GetPotatoById_Exception()
        {

            //Arrange

            var potatoRepositoryMock = new Mock<IPotatoRepository>();
            var loggerMock = new Mock<ILogger<PotatoesController>>();

            // sut - subject under test
            var sut = new PotatoesController(potatoRepositoryMock.Object, loggerMock.Object);
            potatoRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Throws<Exception>();


            //Act
            var result = await sut.GetPotato(It.IsAny<int>());


            //Assert
            var objectResult = Assert.IsType<ObjectResult>(result.Result);
            Assert.Equal(500, objectResult.StatusCode);

        }
    }
}