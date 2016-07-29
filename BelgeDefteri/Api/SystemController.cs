using BelgeDefteri.Data.Entity;
using BelgeDefteri.Service;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BelgeDefteri.Api
{
    public class SystemsController : ApiController
    {
        SystemService _service = new SystemService();

        [HttpPost]
        public HttpResponseMessage getItem(int Id)
        {
            var data = _service.getGroupByParentId(Id).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //********************************
        [HttpPost]
        public HttpResponseMessage getAll()
        {
            var data = _service.getGroupAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        public bool update(Grup model)
        {
            //var d = _service
            //        .getGroupAll()
            //        .Where(x => x.Id == model.Id)
            //        .FirstOrDefault();
            //d.Adi = model.Adi;
            _service.update(model);
            return true;
        }
        //************************************
        [HttpPost]
        public bool insert(Grup model)
        {
            _service.Insert(model);
            return true;
        }


    }
}