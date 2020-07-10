using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCare.Models
{
    public partial class Appointments
    {
        [Key]
        [Column("ApointID")]
        public int ApointId { get; set; }
        [Column("ServiceID")]
        public int ServiceId { get; set; }
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Time { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        [StringLength(100)]
        public string PetName { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Appointments")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("Appointments")]
        public virtual Service Service { get; set; }
    }
}
