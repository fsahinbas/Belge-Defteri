using BelgeDefteri.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeDefteri.Service
{
    public class SystemService
    {
        public Repository<Grup> _grupRepo;

        public SystemService()
        {
            _grupRepo = new Repository<Grup>();
        }
        public void Insert(Grup data)
        {
            _grupRepo.Insert(data);
        }
        public IQueryable<Grup> getGroupByParentId(int Id)
        {
            return _grupRepo.GetAll().Where(x => x.ParentId == Id);
        }


       //****************
        public IQueryable<Grup> getGroupAll()
        {
            return _grupRepo.GetAll();
                
        }


        public void update(Grup data)
        {
            _grupRepo.update(data);
            //_grupRepo.SaveChanges();           
        }
        //*******************

    }
}
