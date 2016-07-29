using BelgeDefteri.Data.Entity;
using BelgeDefteri.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BelgeDefteri.Api
{
    public class BaseController<T>:ApiController where T:BaseEntity
    {
        BaseService<T> _service = new BaseService<T>();

        protected void Insert(T data)
        {
            _service.Insert(data);
        }
        protected void Update(T data)
        {
            _service.update(data);
        }
        protected void Delete(T data)
        {
            _service.delete(data);
        }
        protected IQueryable<T> GetAll()
        {
            return _service.GetAll();
        }
        protected T GetById(string Id)
        {
            return _service.GetById(Id);
        }
    }
}