using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using JaffaMania.Website.Extensions;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantByIdQuery : IRequest<Contestant>
    {
        public GetContestantByIdQuery(string contestantId)
        {
            ContestantId = contestantId;
        }


        //
        //  Properties

        public string ContestantId { get; }


        //
        //  Methods:  Validation

        public bool IsValid()
        {
            return this.ContestantId.IsValidGuid();
        }
    }
}