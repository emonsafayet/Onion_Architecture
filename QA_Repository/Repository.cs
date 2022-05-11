using Microsoft.EntityFrameworkCore;
using QA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entity = _context.Set<T>(); 
        }
        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }

        public T GetById(int Id)
        {
            return entity.FirstOrDefault(x=>x.Id == Id );
        }
    }
}
