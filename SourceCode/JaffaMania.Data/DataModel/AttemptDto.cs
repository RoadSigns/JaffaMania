using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JaffaMania.Data.DataModel
{
    [Table("Attempt")]
    public sealed class AttemptDto
    {
        public int Id { get; set; }

        public string PublicId { get; set; }

        public DateTime HappenedOn { get; set; }

        public TimeSpan TimeTaken { get; set; }
    }
}