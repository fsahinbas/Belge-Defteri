using BelgeDefteri.Data.Entity;
using BelgeDefteri.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace BelgeDefteri.Api
{
    public class KursController : BaseController<Kurs>
    {
        public bool insert(VMKurs model)
        {
            var data = new Kurs();
         
            if (model == null)
            {
                return false;
            }
            else
            {
                data.KursAdi = model.kursAdi;
                data.BelgeAdi = model.belgeAdi;
                data.BaslamaTarihi = model.baslamaTarihi;
                data.BitisTarihi = model.bitisTarihi;
                data.MakDevamsizlikSayisi = model.makDevamsizlikSayisi;
                data.DersSaati = model.dersSaati;
                base.Insert(data);
                return true;
            }

        }

        public bool update(VMKurs model)
        {
            var data = new Kurs();

            if (model==null)
            {
                return false;    
            }
            else
            { 
            data.Id = model.id;
            data.KursAdi = model.kursAdi;
            data.BelgeAdi = model.belgeAdi;
            data.BaslamaTarihi = model.baslamaTarihi;
            data.BitisTarihi = model.bitisTarihi;
            data.MakDevamsizlikSayisi = model.makDevamsizlikSayisi;
            data.DersSaati = model.dersSaati;
            base.Update(data);
            return true;
            }

        }

      
        [HttpPost]
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
        public HttpResponseMessage getAll()
        {
            var data = base.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpPost]
        public HttpResponseMessage getById(string Id)
        {
            var data = base.GetById(Id);
            var model = new VMKurs();
            if (data!=null)
            {
                model.id=data.Id;
                model.kursAdi = data.KursAdi;
                model.belgeAdi = data.BelgeAdi;
                model.baslamaTarihi = data.BaslamaTarihi;
                model.bitisTarihi = data.BitisTarihi;
                model.makDevamsizlikSayisi = data.MakDevamsizlikSayisi;
                model.dersSaati = data.DersSaati;
            }       
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }
    }
}