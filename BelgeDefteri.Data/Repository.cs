using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeDefteri.Data.Entity
{
    public class Repository<T> : IDisposable where T : BaseEntity
    {
        public ApplicationDbContext _context;
        public DbSet<T> _repo;

        public Repository()
        {
            _context = new ApplicationDbContext();
            _repo = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _repo;
        }

        public T GetById(string Id)
        {
            return _repo.Find(Id);
        }


        public void delete(T data)
        {
            if (data == null)
                throw (new Exception("No Data"));
            _repo.Remove(data);
            _context.SaveChanges();
        }
        public void update(T data)
        {
            if (data == null)
                throw (new Exception("No Data"));
            data.UpdateDate = DateTime.Now;
            _repo.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
      
        public void Insert(T data)
        {
            if (data == null)
                throw (new Exception("No Data"));
            data.Id = Guid.NewGuid().ToString();
            data.UpdateDate = DateTime.Now;
            data.CreatDate = DateTime.Now;
            _repo.Add(data);
            _context.SaveChanges();
        }


        public void Dispose()
        {
            if (_context == null)
            {
                return;
            }
            _context = null;
            GC.SuppressFinalize(this);
        }
    }
}
