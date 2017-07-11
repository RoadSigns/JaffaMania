using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.LeaderBoard.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.LeaderBoard.Queries
{
    public class GetAllLeaderBoardPositionsQuery : IRequest<IList<LeaderboardPosition>>
    {
    }
}