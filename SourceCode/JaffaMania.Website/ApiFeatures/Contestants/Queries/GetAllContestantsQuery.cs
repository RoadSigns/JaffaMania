using System.Collections.Generic;
using JaffaMania.Website.ApiFeatures.Contestants.ServiceModel;
using MediatR;

namespace JaffaMania.Website.ApiFeatures.Contestants.Queries
{
    public class GetAllContestantsQuery : IRequest<IList<Contestant>>
    {
        //
        //  Methods:  Validation

        public bool IsValid()
        {
            return true;
        }

    }
}