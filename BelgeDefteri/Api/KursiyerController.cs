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
    public class KursiyerController : BaseController<Kursiyer>
    {
        
        public bool insert(VMKursiyer model)
        {
            var data = new Kursiyer();
            if (model==null)
            {
                return false;
            }
            else
            {
                data.TcKimlik = model.tcKimlik;
                data.OkulNo = model.okulNo;
                data.Name = model.name;
                data.SurName = model.surName;
                data.SinifId = model.sinifId;
                data.BabaAdi = model.babaAdi;
                data.AnaAdi = model.anaAdi;
                data.DogumYeri = model.dogumYeri;
                data.DogumTarihi = model.dogumTarihi;
                base.Insert(data);
                return true;
            }
        }


        public bool update(VMKursiyer model)
        {
            var data = new Kursiyer();
            if (model==null)
            {
                return false;
            }
            else
            {
                data.Id = model.id;
                data.TcKimlik = model.tcKimlik;
                data.OkulNo = model.okulNo;
                data.Name = model.name;
                data.SurName = model.surName;
                data.SinifId = model.sinifId;
                data.BabaAdi = model.babaAdi;
                data.AnaAdi = model.anaAdi;
                data.DogumYeri = model.dogumYeri;
                data.DogumTarihi = model.dogumTarihi;
                base.Update(data);
                return true;
            }
        }

        public bool del(String Id)
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

      
        public HttpResponseMessage getById(string Id)
        {
            var data = base.GetById(Id);
            var model = new VMKursiyer();
            
            
            if (data!=null)
            {
                model.id = data.Id;
                model.tcKimlik = data.TcKimlik;
                model.okulNo = data.OkulNo;
                model.name = data.Name;
                model.surName = data.SurName;
                model.sinifId = data.SinifId;
                model.babaAdi = data.BabaAdi;
                model.anaAdi = data.AnaAdi;
                model.dogumYeri = data.DogumYeri;
                model.dogumTarihi = data.DogumTarihi;
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