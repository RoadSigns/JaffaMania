using System;
using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetAllContestantsQueryHandler : IRequestHandler<GetAllContestantsQuery, IList<Contestant>>
    {
        public IList<Contestant> Handle(GetAllContestantsQuery message)
        {
            return new List<Contestant>
            {
                new Contestant{
                    Id = "ab38493a-7186-4ed0-8e65-7ef6e5c69744",  GivenName="Contestant",FamilyName ="One",
                    StageName = "Bulk Hogan", AttemptsMade = 2, BestTime = new TimeSpan(0,2,58)
                },
                new Contestant {
                    Id = "6a39dfa6-8f44-48ed-8f85-fd7b6458725c", GivenName="Contestant", FamilyName="Two",
                    AttemptsMade = 2, BestTime = new TimeSpan(0,4,30)
                }
            };
        }
    }
}