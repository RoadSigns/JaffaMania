using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JaffaMania.Data.DataModel
{
    [Table("Contestant")]
    public class ContestantDto
    {
        public int Id { get; set; }

        public string PublicId { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string StageName { get; set; }

        public IList<AttemptDto> AttemptsMade { get; set; }
    }
}