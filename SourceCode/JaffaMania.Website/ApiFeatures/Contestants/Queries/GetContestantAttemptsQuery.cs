using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using JaffaMania.Website.Extensions;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantAttemptsQuery : IRequest<IList<Attempt>>
    {
        public GetContestantAttemptsQuery(string contestantId)
        {
            ContestantId = contestantId;
        }


        //
        //  Properties

        public string ContestantId { get;}


        //
        //  Methods:  Validation

        public bool IsValid()
        {
            return this.ContestantId.IsValidGuid();
        }

    }
}