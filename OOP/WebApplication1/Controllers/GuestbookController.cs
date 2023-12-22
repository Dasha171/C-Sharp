using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication1.Models;



namespace WebApplication1.Controllers
{
    public class GuestbookController : Controller
    {
        // GET: Guestbook
        private GuestbookContext _db = new GuestbookContext();

        public ActionResult Index()
        {
            var mostRecenEntries = (from entry in _db.Entries
                                    orderby entry.DateAdded descending
                                    select entry).Take(20);
            /* ViewBag.Entries = mostRecenEntries.ToList();*/
            var model = mostRecenEntries.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            if (ModelState.IsValid)
                {
                entry.DateAdded = DateTime.Now.ToUniversalTime();
                _db.Entries.Add(entry);
                _db.SaveChanges();
                /*return Content("Новая запись успешно добавлена.");*/
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Show(int id)
        {
            var entry = _db.Entries.Find(id);

            if (entry == null)
            {
                return HttpNotFound();
            }

            bool hasPermission = User.Identity.Name == entry.Name;
            ViewBag.HasPermission = hasPermission;
            return View(entry);
        }
        public ActionResult CommentSummary()
        {
            var entries = from entry in _db.Entries
                          group entry by entry.Name
                          into groupedByName
                          orderby groupedByName.Count() descending
                          select new CommentSummary
                          {
                              NumberOfComments = groupedByName.Count(),
                              UserName = groupedByName.Key
                          };
            return View(entries.ToList());
        }
        public ActionResult Edit(int id) {
             return View();
        }
    }
}