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
    public class BelgeController :BaseController<Belge>
    {
        

        public bool insert(VMBelge model)
        {
            var data = new Belge();

            if (model==null)
            {
                return false;
            }
            else
            {
                data.BelgeNo = model.belgeNo;
                data.BelgeAdi = model.belgeAdi;
                data.BelgeAciklama = model.belgeAciklama;
                data.BelgeTarih = model.belgeTarih;
                data.Egitmen = model.egitmen;
                data.Idareci = model.idareci;
                data.BasimTarihi = model.basimTarihi;
                data.KursiyerId = model.kursiyerId;
                data.KursId = model.kursId;
                data.BasildiMi = model.basildiMi;
                base.Insert(data);
                return true;
            }

        }

        public bool update(VMBelge model)
        {
            var data = new Belge();
            if (model==null)
	        {
               return false;		 
	        }
            else
            {
                data.Id=model.id;
                data.BelgeNo = model.belgeNo;
                data.BelgeAdi = model.belgeAdi;
                data.BelgeAciklama = model.belgeAciklama;
                data.BelgeTarih = model.belgeTarih;
                data.Egitmen = model.egitmen;
                data.Idareci = model.idareci;
                data.BasimTarihi = model.basimTarihi;
                data.KursiyerId = model.kursiyerId;
                data.KursId = model.kursId;
                data.BasildiMi = model.basildiMi;
                base.Update(data);
                return true;

            }
        }

        public bool del(string Id)
        {
            var data = base.GetById(Id);
            if (data==null)
            {
                return false;
            }
            else
            {
                base.Delete(data);
                return true;
            }
        }

        public HttpResponseMessage getById(string Id)
        {
            var data = base.GetById(Id);
            var model = new VMBelge();
           if (data!=null)
            {
                model.id=data.Id;
                model.belgeNo= data.BelgeNo ;
                model.belgeAdi=data.BelgeAdi;
                model.belgeAciklama=data.BelgeAciklama;
                model.belgeTarih=data.BelgeTarih;
                model.egitmen=data.Egitmen;
                model.idareci=data.Idareci;
                model.basimTarihi=data.BasimTarihi;
                model.kursiyerId=data.KursiyerId;
                model.kursId=data.KursId;
                model.basildiMi=data.BasildiMi; 
            }
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        public HttpResponseMessage getAll()
        {
            var data = base.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
	}
}