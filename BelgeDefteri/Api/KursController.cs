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
    public class KursController:BaseController<Kurs>
    {
        public ActionResult Insert(VMKurs model)
        {
            var data = new Kurs();
            /*
             modelden dataya aktarım
             */
            data.KursAdi = model.kursAdi;
            data.BelgeAdi = model.belgeAdi;
            data.BaslamaTarihi = model.baslamaTarihi;
            data.BitisTarihi = model.bitisTarihi;
            data.MakDevamsizlikSayisi = model.makDevamsizlikSayisi;
            data.DersSaati = model.dersSaati;
            base.Insert(data);
            return null;
        }


        [HttpPost]
        public HttpResponseMessage getAll()
        {
            var data = base.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

       


    }
}