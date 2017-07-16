using System.Collections.Generic;
using System.Threading;
using JaffaMania.Website.ApiFeatures.Contestants.Queries;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using JaffaMania.Website.ApiFeatures.LeaderBoard.Queries;
using JaffaMania.Website.ApiFeatures.LeaderBoard.ServiceModel;
using MediatR;
using Moq;

namespace JaffaMania.Website.Tests.Mocks
{
    public static class MediatorMock
    {
        public static Mock<IMediator> CreateWithResults()
        {
            var mediatorMock = new Mock<IMediator>();

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetAllContestantsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Contestant>{new Contestant()});

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetContestantByIdQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Contestant{GivenName = "Test", FamilyName = "Test"});

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetContestantAttemptsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Attempt> { new Attempt() });

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetAllLeaderBoardPositionsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<LeaderboardPosition> { new LeaderboardPosition() });



            return mediatorMock;
        }


        public static Mock<IMediator> CreateWithNoResults()
        {
            var mediatorMock = new Mock<IMediator>();

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetAllContestantsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Contestant>());

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetContestantByIdQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((Contestant)null);

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetContestantAttemptsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Attempt>());

            mediatorMock
                .Setup(m => m.Send(It.IsAny<GetAllLeaderBoardPositionsQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<LeaderboardPosition>());

            return mediatorMock;
        }

    }
}