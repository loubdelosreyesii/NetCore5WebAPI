using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Data
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual IList<Doctor> Doctors { get; set; }
    }
}
