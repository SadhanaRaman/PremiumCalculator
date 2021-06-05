using Microsoft.AspNetCore.Mvc;
using Moq;
using PremiumCalculator.Controllers;
using PremiumCalculator.Repository;
using PremiumCalculator.Services;
using PremiumCalculator.Services.Interfaces;
using System;
using Xunit;

namespace PremiumCalculator.Test
{
    public class PremiumControllerTests
    {
        private readonly Mock<IPremiumService> _serviceMock = new Mock<IPremiumService>();
        [Fact]
        public void PremiumController_WhenNoError_ReturnsOKResult()
        {
            //Arrange

            double cover = 20000;
            string occupation = "Doctor";
            DateTime birthdate = DateTime.Now.AddYears(-40);
            double premium = 66.67;

            _serviceMock.Setup(x => x.CalculatePremium(cover, occupation, birthdate)).Returns(premium);
            PremiumController premiumCalculator = new PremiumController(_serviceMock.Object);

            //Act

            var result = premiumCalculator.FetchPremium(cover, occupation, birthdate);
            var actionResult = result.Result as OkObjectResult;

            //Assert 

            Assert.NotNull(actionResult);
            Assert.Equal(actionResult.Value, 66.67);
        }

        [Fact]
        public void PremiumController_WhenErrorOccurs_ReturnsNotFound()
        {
            //Arrange

            double cover = 20000;
            string occupation = "Doctor";
            DateTime birthdate = DateTime.Now.AddYears(-40);

            _serviceMock.Setup(x => x.CalculatePremium(cover, occupation, birthdate)).Throws(new ArgumentException());
            PremiumController premiumCalculator = new PremiumController(_serviceMock.Object);

            //Act

            var result = premiumCalculator.FetchPremium(cover, occupation, birthdate);
            var actionResult = result.Result as NotFoundResult;

            //Assert 

            Assert.NotNull(actionResult);
        }

        [Fact]
        public void PremiumController_WhenPremiumIsNegetive_ReturnsBadRequest()
        {
            //Arrange

            double cover = 20000;
            string occupation = "Doctor";
            DateTime birthdate = DateTime.Now.AddYears(10);
            double premium = -1;

            _serviceMock.Setup(x => x.CalculatePremium(cover, occupation, birthdate)).Returns(premium);
            PremiumController premiumCalculator = new PremiumController(_serviceMock.Object);

            //Act

            var result = premiumCalculator.FetchPremium(cover, occupation, birthdate);
            var actionResult = result.Result as BadRequestResult;

            //Assert 

            Assert.NotNull(actionResult);
        }
    }
}
