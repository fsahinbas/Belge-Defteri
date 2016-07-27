using BelgeDefteri.Data.Entity;
using BelgeDefteri.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BelgeDefteri.Controllers
{
    public class BolumController : Controller
    {
        public BolumService _bolumSrv;
        public BolumController()
        {
            _bolumSrv = new BolumService();
        }
        // GET: Bolum
        public ActionResult List()
        {
            return View(_bolumSrv.GetAll().ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Bolum model)
        {
            _bolumSrv.Insert(model);
            return RedirectToAction("List");
        }


        public ActionResult Edit(string Id)
        {
            return View(_bolumSrv.GetById(Id));
        }

        [HttpPost]
        public ActionResult Edit(Bolum model)
        {
            _bolumSrv.update(model);
            return RedirectToAction("List");
        }

        public ActionResult Details(string Id)
        {
            return View(_bolumSrv.GetById(Id));
        }

        public ActionResult Delete(string Id)
        {
            return View(_bolumSrv.GetById(Id));
        }

      
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(string Id)
        {
            var data = _bolumSrv.GetById(Id);
            _bolumSrv.delete(data);
            return RedirectToAction("List");
        }
    }
}