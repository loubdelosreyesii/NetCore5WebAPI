using NetCore5WebAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Models
{
    public class CreateDoctorDTO
    {
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Last Name is too long")]
        public string LastName { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "First Name is too long")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Middle Name is too long")]
        public string MiddleName { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int ClinicId { get; set; }
    }
    public class DoctorDTO : CreateDoctorDTO
    {
        public int Id { get; set; }
        public Clinic Clinic { get; set; }
    }
}
