using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCare.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointments>();
        }

        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [Column("specialty")]
        [StringLength(100)]
        public string Specialty { get; set; }

        [InverseProperty("Employee")]
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
