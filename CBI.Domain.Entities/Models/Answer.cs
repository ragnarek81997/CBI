﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CBI.Domain.Entities.Infrastructure;

namespace CBI.Domain.Entities.Models
{
    [Table("Answers", Schema = "dbo")]
    public class Answer : BaseEntity
    {
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public bool IsTrue { get; set; }
    }
}
