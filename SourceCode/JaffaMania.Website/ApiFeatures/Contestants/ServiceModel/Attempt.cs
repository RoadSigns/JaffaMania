using System;

namespace JaffaMania.Website.ApiFeatures.Contestants.ServiceModel
{
    public sealed class Attempt
    {
        public string Id { get; set; }

        public DateTime HappenedOn { get; set; }

        public TimeSpan TimeTaken { get; set; }
    }
}