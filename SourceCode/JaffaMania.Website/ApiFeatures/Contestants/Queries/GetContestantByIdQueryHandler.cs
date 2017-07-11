using System;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantByIdQueryHandler : IRequestHandler<GetContestantByIdQuery, Contestant>
    {
        public Contestant Handle(GetContestantByIdQuery message)
        {
            return new Contestant
            {
                Id = "ab38493a-7186-4ed0-8e65-7ef6e5c69744",
                GivenName = "Player",
                FamilyName = "One",
                StageName = "Bulk Hogan",
                AttemptsMade = 2,
                BestTime = new TimeSpan(0,2,30)
            };
        }
    }
}