using Moq;
using PremiumCalculator.Repository;
using PremiumCalculator.Services;
using System;
using Xunit;

namespace PremiumCalculator.Test
{
    public class PremiumServiceTests
    {
       private readonly PremiumService _sut;
        private readonly Mock<IPremiumRepository> _repoMock = new Mock<IPremiumRepository>();

        public PremiumServiceTests()
        {
            _sut = new PremiumService(_repoMock.Object);
        }
        [Fact]
       public void CalculatePremium_ShouldReturnPremium_WhenPassedParameters()
        {
            //Arrange

            double cover = 20000;
            string occupation = "Doctor";
            DateTime birthdate = DateTime.Now.AddYears(-40);
            float factor = 1;

            _repoMock.Setup(x => x.GetRatingForOccupation(occupation)).Returns(factor);

            //Act

            var premium = _sut.CalculatePremium(cover, occupation, birthdate);

            //Assert

            Assert.Equal(premium, 66.67);
        }

        [Fact]
        public void CalculatePremium_ShouldReturnZero_WhenAParameterIsNotPassed()
        {
            //Arrange

            double cover = 20000;
            string occupation = "";
            DateTime birthdate = DateTime.Now.AddYears(-40);
            float factor = 0;

            _repoMock.Setup(x => x.GetRatingForOccupation(occupation)).Returns(factor);

            //Act

            var premium = _sut.CalculatePremium(cover, occupation, birthdate);

            //Assert

            Assert.Equal(premium, 0);
        }
    }
}
