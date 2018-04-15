using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CBI.Domain.Entities.Infrastructure;

namespace CBI.Domain.Entities.Models
{
    [Table("Semesters", Schema = "dbo")]
    public class Semester : BaseEntity
    {
        [Required]
        public int Number { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
