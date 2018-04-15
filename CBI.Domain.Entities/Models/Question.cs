using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CBI.Domain.Entities.Infrastructure;

namespace CBI.Domain.Entities.Models
{
    [Table("Questions", Schema = "dbo")]
    public class Question : BaseEntity
    {
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
