using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PotatoApi.Controllers;
using PotatoApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoApi.Test
{
    public class CalculatorControllerTests
    {

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
