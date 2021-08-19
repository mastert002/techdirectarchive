using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessBankPortal.Repository
{
    public class MainRepository : IMainRepository
    {
        private readonly ApplicationDBContext _context;
        public MainRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
