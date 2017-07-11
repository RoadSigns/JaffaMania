using System;
using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.LeaderBoard.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.LeaderBoard.Queries
{
    public class GetAllLeaderBoardPositionsQueryHandler 
               : IRequestHandler<GetAllLeaderBoardPositionsQuery, IList<LeaderboardPosition>>
    {

        public IList<LeaderboardPosition> Handle(GetAllLeaderBoardPositionsQuery message)
        {
            return new List<LeaderboardPosition>
            {
                new LeaderboardPosition{Position = 1, Contestant = "Player One", ContestantPhotoUri = "", TimeTaken = new TimeSpan(0,2,56)},
                new LeaderboardPosition{Position = 2, Contestant = "Player One", ContestantPhotoUri = "", TimeTaken = new TimeSpan(0,3,30)},
                new LeaderboardPosition{Position = 3, Contestant = "Player Two", ContestantPhotoUri = "", TimeTaken = new TimeSpan(0,4,38)}
            };
        }
    }
}