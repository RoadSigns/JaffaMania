using System;
using System.Collections.Generic;
using System.Linq;
using JaffaMania.Data.DataModel;

namespace JaffaMania.Data
{
    public static class JafamaniaDbContextExtensions
    {
        public static void EnsureSeedData(this JafamaniaDbContext context)
        {
            if (!context.Contestants.Any())
            {
                context.Contestants.Add(new ContestantDto
                {
                    PublicId = "ab38493a-7186-4ed0-8e65-7ef6e5c69744",
                    GivenName = "ContestantDto",
                    FamilyName = "One",
                    StageName = "Bulk Hogan",
                    AttemptsMade = new List<AttemptDto>  {
                        new AttemptDto  {
                            PublicId = "d1b4d397-a43a-4ce2-aa01-bc6081cf68ab",
                            HappenedOn = new DateTime(2017, 07, 11),
                            TimeTaken = new TimeSpan(0, 0, 2, 56, 00)
                        },
                        new AttemptDto  {
                            PublicId = "45778f45-29d4-456a-bcff-7ee8dae526a1",
                            HappenedOn = new DateTime(2017, 07, 05),
                            TimeTaken = new TimeSpan(0, 0, 3, 30, 00)
                        }
                    }
                });
                context.Contestants.Add(new ContestantDto
                {
                    PublicId = "6a39dfa6-8f44-48ed-8f85-fd7b6458725c",
                    GivenName = "ContestantDto",
                    FamilyName = "Two",
                    AttemptsMade = new List<AttemptDto>  {
                        new AttemptDto  {
                            PublicId = "3a4b1359-7f64-43cd-bf5c-6e467a5cf2b5",
                            HappenedOn = new DateTime(2017, 07, 11),
                            TimeTaken = new TimeSpan(0, 0, 2, 56, 00)
                        }
                    }
                });
            }

            context.SaveChanges();
        }
    }
}