using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeevan.Models;
using Jeevan.Database;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Jeevan.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private JeevanDBContext db = new JeevanDBContext();

        //
        // GET: /CordBlood/

        public ViewResult Index(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            ViewBag.Count = db.CordBloodUnits.Count();
            ViewBag.Start = start;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.OrderBy = orderBy;
            ViewBag.Desc = desc;
            
            return View();
        }

        //
        // GET: /CordBlood/GridData/?start=0&itemsPerPage=20&orderBy=ID&desc=true

        public ActionResult GridData(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            Response.AppendHeader("X-Total-Row-Count", db.CordBloodUnits.Count().ToString());
            ObjectQuery<CordBloodUnit> cordbloodunits = (db as IObjectContextAdapter).ObjectContext.CreateObjectSet<CordBloodUnit>();
            cordbloodunits = cordbloodunits.OrderBy("it." + orderBy + (desc ? " desc" : ""));

            return PartialView(cordbloodunits.Skip(start).Take(itemsPerPage));
        }
        
        //
        //GET : /CordBlood/Search/?
        public ActionResult Search(int? HLA_A1, int? HLA_A2, int? HLA_B1, int? HLA_B2, int DRB_1, int DRB_2)
        {
            var searchResults = db.CordBloodUnits.Select(c => c)
                                                    .Where(unit => unit.DRB_1 == DRB_1
                                                           && unit.DRB_2 == DRB_2);
            return PartialView("GridData", searchResults);
        }

        //
        // GET: /Default5/RowData/5

        public ActionResult RowData(int id)
        {
            CordBloodUnit cordbloodunit = db.CordBloodUnits.Find(id);
            return PartialView("GridData", new CordBloodUnit[] { cordbloodunit });
        }

        //
        // GET: /CordBlood/Create

        public ActionResult Create()
        {
            return PartialView("Edit");
        }

        //
        // POST: /CordBlood/Create

        [HttpPost]
        public ActionResult Create(CordBloodUnit cordbloodunit)
        {
            if (ModelState.IsValid)
            {
                db.CordBloodUnits.Add(cordbloodunit);
                db.SaveChanges();
                return PartialView("GridData", new CordBloodUnit[] { cordbloodunit });
            }

            return PartialView("Edit", cordbloodunit);
        }

        //
        // GET: /CordBlood/Edit/5

        public ActionResult Edit(int id)
        {
            CordBloodUnit cordbloodunit = db.CordBloodUnits.Find(id);
            return PartialView(cordbloodunit);
        }

        //
        // POST: /CordBlood/Edit/5

        [HttpPost]
        public ActionResult Edit(CordBloodUnit cordbloodunit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cordbloodunit).State = EntityState.Modified;
                db.SaveChanges();
                return PartialView("GridData", new CordBloodUnit[] { cordbloodunit });
            }

            return PartialView(cordbloodunit);
        }

        //
        // POST: /CordBlood/Delete/5

        [HttpPost]
        public void Delete(int id)
        {
            CordBloodUnit cordbloodunit = db.CordBloodUnits.Find(id);
            db.CordBloodUnits.Remove(cordbloodunit);
            db.SaveChanges();
        }

   

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
