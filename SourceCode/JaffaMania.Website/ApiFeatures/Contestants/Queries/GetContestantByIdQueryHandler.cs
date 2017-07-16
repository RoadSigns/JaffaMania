using System.Linq;
using JaffaMania.Data;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantByIdQueryHandler : IRequestHandler<GetContestantByIdQuery, Contestant>
    {
        public GetContestantByIdQueryHandler(JafamaniaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //
        //  Methods:  IRequestHandler Implementation

        public Contestant Handle(GetContestantByIdQuery message)
        {
            var contestantDto = _dbContext
                .Contestants.Include(a => a.AttemptsMade)
                .FirstOrDefault(i => i.PublicId == message.ContestantId);

            return new Contestant  {
                Id = contestantDto.PublicId,
                GivenName = contestantDto.GivenName,
                FamilyName = contestantDto.FamilyName,
                StageName = contestantDto.StageName,
                AttemptsMade = contestantDto.AttemptsMade.Count,
                BestTime = contestantDto.AttemptsMade.OrderBy(o => o.TimeTaken).First().TimeTaken
            };
        }


        //
        //  Fields
        private readonly JafamaniaDbContext _dbContext;

    }
}