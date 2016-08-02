using BelgeDefteri.Data.Entity;
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
    public class SinifController :BaseController<Sinif>
    {
       public bool insert(VMSinif model)
        {
            var data = new Sinif();

            if (model==null)
            {
                return false;
            }
            else
            {
                data.SinifNo = model.sinifNo;
                data.OkulTuru = model.okulTuru;
                data.Sube = model.sube;
                data.BolumId = model.bolumId;
                base.Insert(data);
                return true;

            }
        }


        public bool update(VMSinif model)
       {
           var data = new Sinif();
           if (model==null)
           {
               return false;
           }
           else
           {
               data.Id = model.id;
               data.SinifNo = model.sinifNo;
               data.OkulTuru = model.okulTuru;
               data.Sube = model.sube;
               data.BolumId = model.bolumId;
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
        public HttpResponseMessage getById(string Id)
        {
            var data = base.GetById(Id);
            var model=new VMSinif();
            if (data!=null)
            {
                model.id=data.Id;
                model.sinifNo=data.SinifNo;
                model.okulTuru=data.OkulTuru;
                model.sube=data.Sube;
                model.bolumId=data.BolumId;
                
            }
               return Request.CreateResponse(HttpStatusCode.OK,model);
        }

        [HttpPost]
        public HttpResponseMessage getAll()
        {
            var data = base.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

	}
}