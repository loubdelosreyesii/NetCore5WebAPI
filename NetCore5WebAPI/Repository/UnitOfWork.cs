using NetCore5WebAPI.Data;
using NetCore5WebAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Doctor> _doctors;
        private IGenericRepository<Clinic> _clinics;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Doctor> Doctors => _doctors ??= new GenericRepository<Doctor>(_context);

        public IGenericRepository<Clinic> Clinics => _clinics ??= new GenericRepository<Clinic>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
