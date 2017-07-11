using System;

namespace JaffaMania.Website.ApiFeatures.Contestants.ServiceModel
{
    public sealed class Contestant
    {
        public string Id { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string StageName { get; set; }

        public string FullName => string.IsNullOrEmpty(StageName) 
            ? $"{GivenName} {FamilyName}" 
            : $"{GivenName} '{StageName}' {FamilyName}";

        public int AttemptsMade { get; set; }

        public TimeSpan BestTime { get; set; }
    }
}