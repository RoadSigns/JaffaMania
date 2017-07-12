using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
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
    }
}