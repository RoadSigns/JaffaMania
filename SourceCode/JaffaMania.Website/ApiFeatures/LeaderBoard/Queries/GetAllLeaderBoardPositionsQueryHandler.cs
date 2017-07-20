using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MediatR;
using JaffaMania.Data;
using JaffaMania.Website.ApiFeatures.LeaderBoard.ServiceModel;

namespace JaffaMania.Website.ApiFeatures.LeaderBoard.Queries
{
    public class GetAllLeaderBoardPositionsQueryHandler
               : IRequestHandler<GetAllLeaderBoardPositionsQuery, IList<LeaderboardPosition>>
    {

        public GetAllLeaderBoardPositionsQueryHandler(JafamaniaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //
        //  Methods:  IRequestHandler Implementation

        public IList<LeaderboardPosition> Handle(GetAllLeaderBoardPositionsQuery message)
        {
            var attemptsDtos = _dbContext.Attempts
                    .Include(a => a.Contestant)
                    .OrderBy(o => o.TimeTaken)
                    .ToList();

            var leaderBoardPosition = 1;

            return attemptsDtos.Select(dto => new LeaderboardPosition
            {
                Position = leaderBoardPosition++,
                Contestant = dto.Contestant.FullName,
                ContestantPhotoUri = dto.Contestant.PhotoUri,
                TimeTaken = dto.TimeTaken
            }).ToList();
        }


        //
        //  Fields
        private readonly JafamaniaDbContext _dbContext;
    }
}