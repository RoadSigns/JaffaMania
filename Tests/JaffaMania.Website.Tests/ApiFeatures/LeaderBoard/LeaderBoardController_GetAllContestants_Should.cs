using System.Threading.Tasks;
using JaffaMania.Website.Tests.ApiFeatures.Contestants;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using JaffaMania.Website.ApiFeatures.LeaderBoard;
using JaffaMania.Website.Tests.Mocks;

namespace JaffaMania.Website.Tests.ApiFeatures.LeaderBoard
{
    public class LeaderBoardController_GetLeaderBoard_Should
    {
        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp200OkResultWhenLeaderboardPositionsAreFound()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithResults();
            var systemUnderTest = new LeaderBoardController(mediator.Object);

            //  Act
            var result = await systemUnderTest.GetLeaderBoard(); 

            //  Assert
            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        [Trait("Unit Test", "WebApi")]
        public async Task ReturnsHttp404NotFoundResultWhenLeaderboardPositionsNotFound()
        {
            //  Arrange
            var mediator = MediatorMock.CreateWithNoResults();
            var systemUnderTest = new LeaderBoardController(mediator.Object);
            
            //  Act
            var result = await systemUnderTest.GetLeaderBoard();

            //  Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}