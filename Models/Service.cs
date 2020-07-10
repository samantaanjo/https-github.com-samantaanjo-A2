using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCare.Models
{
    public partial class Service
    {
        public Service()
        {
            Appointments = new HashSet<Appointments>();
        }

        [Key]
        [Column("ServiceID")]
        public int ServiceId { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Duration { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [InverseProperty("Service")]
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
