using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetContestantAttemptsQuery : IRequest<IList<Attempt>>
    {
    }
}