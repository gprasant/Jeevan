using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeevan.Database;
using Jeevan.Models;
using Jeevan.Models.ViewModels;
using Mvc.Mailer;

namespace Jeevan.Controllers
{
    public class RequestInfoController : Controller
    {
        //
        // GET: /Default1/
        private JeevanDBContext db = new JeevanDBContext();

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // GET: /RequestInfo/HLAMatches

        public ActionResult HLAMatches(RequestInfo info, CordBloodUnit cordBloodUnit)
        {
            try
            {
                var searchResults = db.CordBloodUnits.Select(c => c)
                                                   .Where(unit =>
                                                             unit.DRB_1 == cordBloodUnit.DRB_1
                                                          && unit.DRB_2 == cordBloodUnit.DRB_2
                                                          &&( 
                                                              (cordBloodUnit.HLA_A1.HasValue ? unit.HLA_A1 == cordBloodUnit.HLA_A1 : true)
                                                              || (cordBloodUnit.HLA_A2.HasValue ? unit.HLA_A2 == cordBloodUnit.HLA_A2 : true)
                                                              || (cordBloodUnit.HLA_B1.HasValue ? unit.HLA_B1 == cordBloodUnit.HLA_B1 : true)
                                                              || (cordBloodUnit.HLA_B2.HasValue ? unit.HLA_B2 == cordBloodUnit.HLA_B2 : true)
                                                            )
                                                          ).ToList();

                var model = new HLASearchResultsViewModel() { _5Matches = searchResults.Where(x => x.GetMatchCount(cordBloodUnit) == 5), _6Matches = searchResults.Where(x => x.GetMatchCount(cordBloodUnit) == 6) };

                return PartialView("_SearchResults", model);
            }
            catch
            {
                return View();
            }
        }

        

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private UserMailer _mailer = new UserMailer();

        public UserMailer Mailer
        {
            get { return _mailer; }
            set { _mailer = value; }
        }

        
        public ActionResult SendMail(RequestInfo requestInfo, CordBloodUnit cordBloodUnit)
        {
            Mailer.Welcome().Send();
            return new EmptyResult();
        }
    }
}
