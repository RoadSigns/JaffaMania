using System.Collections.Generic;
using System.Linq;
using JaffaMania.Data;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantAttemptsQueryHandler : IRequestHandler<GetContestantAttemptsQuery, IList<Attempt>>
    {
        public GetContestantAttemptsQueryHandler(JafamaniaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //
        //  Methods:  IRequestHandler Implementation

        public IList<Attempt> Handle(GetContestantAttemptsQuery message)
        {
            var customer = _dbContext.Contestants.Include(i => i.AttemptsMade)
                    .FirstOrDefault(c => c.PublicId == message.ContestantId);

            return customer.AttemptsMade
                .Select(dto => new Attempt  {
                    Id = dto.PublicId,
                    HappenedOn = dto.HappenedOn,
                    TimeTaken = dto.TimeTaken
                })
                .ToList();
        }


        //
        //  Fields
        private readonly JafamaniaDbContext _dbContext;
    }
}