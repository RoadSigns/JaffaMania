using System.Threading.Tasks;
using JaffaMania.Website.ApiFeatures.Contestants;
using JaffaMania.Website.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace JaffaMania.Website.Tests.ApiFeatures.Contestants
{
    public class ContestantsController_GetContestantById_Should
    {
        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp200OkResultWhenContestantsAreFound()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithResults();
            var systemUnderTest = new ContestantsController(mediator.Object);

            //  Act
            var result = await systemUnderTest.GetContestantById("ab38493a-7186-4ed0-8e65-7ef6e5c69744");

            //  Assert
            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp404NotFoundResultWhenNoContestantsAreFound()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithNoResults();
            var systemUnderTest = new ContestantsController(mediator.Object);

            //  Act
            var result = await systemUnderTest.GetContestantById("ab38493a-7186-4ed0-8e65-7ef6e5c69744");

            //  Assert
            Assert.IsType<NotFoundResult>(result);
        }


        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp400BadRequestResultWhenContestantIdIsNotValidGuid()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithNoResults();
            var systemUnderTest = new ContestantsController(mediator.Object);

            //  Act
            var result = await systemUnderTest.GetContestantById("");

            //  Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

    }
}