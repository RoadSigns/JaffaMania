using System.Collections.Generic;
using System.Linq;
using JaffaMania.Data;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetAllContestantsQueryHandler : IRequestHandler<GetAllContestantsQuery, IList<Contestant>>
    {
        public GetAllContestantsQueryHandler(JafamaniaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //
        //  Methods:  IRequestHandler Implementation

        public IList<Contestant> Handle(GetAllContestantsQuery message)
        {
            var contestantDtos = _dbContext
                    .Contestants.Include(a=>a.AttemptsMade)
                    .ToList();

            return contestantDtos.Select(dto => new Contestant
            {
                Id = dto.PublicId,
                GivenName = dto.GivenName,
                FamilyName = dto.FamilyName,
                StageName = dto.StageName,
                AttemptsMade = dto.AttemptsMade.Count,
                BestTime = dto.AttemptsMade.OrderBy(o=>o.TimeTaken).First().TimeTaken
            })
            .ToList();
        }


        //
        //  Fields
        private readonly JafamaniaDbContext _dbContext;
    }
}