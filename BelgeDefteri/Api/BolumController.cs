using BelgeDefteri.Data.Entity;
using BelgeDefteri.Model;
using BelgeDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace BelgeDefteri.Api
{
    public class BolumController :BaseController<Bolum>
    {
        
       public bool insert(VMBolum model)
        {
            var data = new Bolum();

            if (model==null)
            {
                return false;

            }
            else
            {
                data.Name = model.name;
                base.Insert(data);
                return true;
            }


        }

        public bool update(VMBolum model)
       {
           var data = new Bolum();
           if (model==null)
           {
               return false;
           }
            else
           {
               data.Id = model.id;
               data.Name = model.name;
               base.Update(data);
               return true;
           }

       }

        public bool del(string Id)
        {
            if (Id==null)
            {
                return false;
            }
            else
            {
                var data = base.GetById(Id);
                base.Delete(data);
                return true;
            }
        }

       [HttpPost]
        public HttpResponseMessage getbyId(string Id)
        {
            var data = base.GetById(Id);
            var model = new VMBolum();

            if (data!=null)
            {
                model.id = data.Id;
                model.name = data.Name;
              
            }
              return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        [HttpPost]
        public HttpResponseMessage getAll()
       {
           var data = base.GetAll().ToList();
           return Request.CreateResponse(HttpStatusCode.OK, data);
       }

       
	}
}