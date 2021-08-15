using NetCore5WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Doctor> Doctors { get; }
        IGenericRepository<Clinic> Clinics { get; }
        Task Save();

    }
}
