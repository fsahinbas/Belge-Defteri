using BelgeDefteri.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeDefteri.Service
{
    public class BaseService<T> where T : BaseEntity
    {
        public Repository<T> _repo;
        public BaseService()
        {
            _repo = new Repository<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public T GetById(string Id)
        {
            return _repo.GetById(Id);
        }


        public void delete(T data)
        {
            _repo.delete(data);
        }
        public void update(T data)
        {
            _repo.update(data);
        }
        public void Insert(T data)
        {
            _repo.Insert(data);
        }

    }
}
