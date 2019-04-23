using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.Data
{
    [Table("Animal", Schema = "dbo")]
    public class Animal
    {
        [Key]

        public Guid AnimalId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Age { get; set; }

        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }

        [Required]
        public bool Friendly { get; set; }

        [Required]
        public string Food { get; set; }

        [Required]
        public int Health { get; set; }

    }
}
