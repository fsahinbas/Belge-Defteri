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
    public class DevamsizlikController :BaseController<Devamsizlik>
    {
        public bool insert(VMDevamsizlik model)
        {
            var data = new Devamsizlik();

            if (model==null)
            {
                return false;
            }
            else
            {
                data.KursId = model.kursId;
                data.KursiyerId = model.kursiyerId;
                data.DevamsizlikMiktari = model.devamsizlikMiktari;
                data.Tarih = model.tarih;
                base.Insert(data);
                return true;   
            }
           

        }

        [HttpPost]
        public HttpResponseMessage getByDevamsizlik(string Id)
        {
            var data = base.GetAll().Where(x => x.KursiyerId == Id).Sum(y => y.DevamsizlikMiktari).ToString();
           
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        
        //Test edilecek
        public bool getByKisiKurs(string KursiyerId, string KursId)
        {
            var data = base.GetAll().Where(x => x.KursiyerId == KursiyerId && x.KursId == KursId).Sum(y => y.DevamsizlikMiktari).ToString();
            return  true;
        }
        //***************************
        public HttpResponseMessage getByKursiyerId(string Id)
        {
            var data = base.GetAll().Where(x => x.KursiyerId == Id).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        public HttpResponseMessage getByKursId(string Id)
        {
            var data = base.GetAll().Where(x => x.KursId == Id).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
  
	}
}