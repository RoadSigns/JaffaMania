using System;

namespace JaffaMania.Website.ApiFeatures.LeaderBoard.ServiceModel
{
    public sealed class LeaderboardPosition
    {
        public int Position { get; set; }

        public string Contestant { get; set; }

        public string ContestantPhotoUri { get; set; }

        public TimeSpan TimeTaken { get; set; }
    }
}