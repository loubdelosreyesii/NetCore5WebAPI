using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Data
{
    public class Doctor
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(Clinic))]
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        
    }
}

