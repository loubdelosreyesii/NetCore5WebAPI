using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Models
{
    public class CreateClinicDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Clinic Name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Clinic Email Address is too long")]
        [EmailAddress(ErrorMessage = "Clinic Email Address is not a valid")]
        public string EmailAddress { get; set; }
    }
    public class ClinicDTO : CreateClinicDTO
    {
        public int Id { get; set; }
        public  IList<DoctorDTO> Doctors { get; set; }

    }
}
