using System.Threading.Tasks;
using JaffaMania.Website.ApiFeatures.Contestants;
using JaffaMania.Website.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace JaffaMania.Website.Tests.ApiFeatures.Contestants
{
    public class LeaderBoardController_GetAllContestants_Should
    {
        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp200OkResultWhenContestantsAreFound()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithResults();
            var systemUnderTest = new ContestantsController(mediator.Object);

            //  Act
            var result = await systemUnderTest.GetAllContestants(); 

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
            var result = await systemUnderTest.GetAllContestants();

            //  Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}