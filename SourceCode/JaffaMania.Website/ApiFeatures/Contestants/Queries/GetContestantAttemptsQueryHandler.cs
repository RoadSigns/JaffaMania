using System;
using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantAttemptsQueryHandler : IRequestHandler<GetContestantAttemptsQuery, IList<Attempt>>
    {
        public IList<Attempt> Handle(GetContestantAttemptsQuery message)
        {
            return new List<Attempt>(new List<Attempt>
            {
                    new Attempt{ Id = "d1b4d397-a43a-4ce2-aa01-bc6081cf68ab", HappenedOn = new DateTime(2017,07,11), TimeTaken = new TimeSpan(0,0,2,56,00) },
                    new Attempt{ Id = "45778f45-29d4-456a-bcff-7ee8dae526a1", HappenedOn = new DateTime(2017,07,05), TimeTaken = new TimeSpan(0,0,3,30,00) }
             });
        }
    }
}