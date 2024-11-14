using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using PotatoApi.Controllers;
using PotatoApi.Entities;
using PotatoApi.Test.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PotatoApi.Test
{
    public class CalculatorControllerTests
    {


        [Theory, PotatoData]              //Method_Scenario_Outcome
        public async Task CalculateExternalApi_Response200_Successfull(Potato potato)
        {
            //Arange
            var httpMessageHandler = new Mock<HttpMessageHandler>();

            var httpclient = new HttpClient(httpMessageHandler.Object);
            var sut = new CalculationService(httpclient);

            httpMessageHandler
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = (HttpStatusCode)200, //HttpStatusCode.OK
                    Content = new StringContent(JsonSerializer.Serialize(potato))
                });

            //Act

            var result = await sut.CalculateExternalApiAsync();

            //Assert
            Assert.NotNull(result);




        }



























        [Theory, AutoData]
        public void Calculate_NegativeMultiplication(int returnValue, Potato potato)
        {
            var calculationServiceMock = new Mock<ICalculationService>();

            var sut = new CalculationController(calculationServiceMock.Object);

            calculationServiceMock
                .Setup(x => x
                    .Multiplier(It.IsAny<int>(), It.IsAny<int>()) //metodas
                )
                .Returns(-999); //ka jis gražins

            calculationServiceMock
            .Setup(x => x
                .Divide(It.IsAny<int>(), It.IsAny<int>()) //metodas
            )
            .Returns(777); //ka jis gražins


            var result = sut.Calculate(1, 2);

            Assert.IsType<BadRequestObjectResult>(result);

        }
        [Theory, AutoData]
        public void Calculate_NegativeDivision(int returnValue, Potato potato)
        {
            var calculationServiceMock = new Mock<ICalculationService>();

            var sut = new CalculationController(calculationServiceMock.Object);

            calculationServiceMock
                .Setup(x => x
                    .Multiplier(It.IsAny<int>(), It.IsAny<int>()) //metodas
                )
                .Returns(999); //ka jis gražins

            calculationServiceMock
            .Setup(x => x
                .Divide(It.IsAny<int>(), It.IsAny<int>()) //metodas
            )
            .Returns(-777); //ka jis gražins


            var result = sut.Calculate(1, 2);

            Assert.IsType<BadRequestObjectResult>(result);

        }
    }
}
