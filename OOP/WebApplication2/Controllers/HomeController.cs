using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.SessionExtensions;

namespace WebApplication2.Controllers
{

    public class HomeController : Controller
    {
        private FlowersDBEntities db = new FlowersDBEntities();

        public ActionResult Index()
        {
            var flowers = (from flower in db.Tables select flower).ToList();
            return View(flowers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Details(int id)
        {
            var flowerDetail = (from flower in db.Tables where flower.FlowerId == id select flower).First();
            return View(flowerDetail);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /*
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Create(Table table)
                {
                    if (ModelState.IsValid)
                    {
                        db.Tables.Add(table);
                        db.SaveChanges();

                        // Добавьте следующую строку для обновления данных в базе данных
                        db.Entry(table).GetDatabaseValues();

                        return RedirectToAction("Index");
                    }

                    return View(table);
                }*/
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(table);
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Table flowerToEdit = db.Tables.Find(id);

            if (flowerToEdit == null)
            {
                return HttpNotFound();
            }

            return View(flowerToEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Table editedFlower)
        {
            if (ModelState.IsValid)
            {
                db.Entry(editedFlower).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(editedFlower);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Table flowerToDelete = db.Tables.Find(id);

            if (flowerToDelete == null)
            {
                return HttpNotFound();
            }

            return View(flowerToDelete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table flowerToDelete = db.Tables.Find(id);

            if (flowerToDelete != null)
            {
                db.Tables.Remove(flowerToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Cart()
        {
            var cart = Session["Cart"] as List<Table> ?? new List<Table>();
            return View(cart);
        }


        [HttpPost]
        public ActionResult AddToCart(int id)
        {
            var flowerToAdd = db.Tables.Find(id);

            if (flowerToAdd != null)
            {
                var cart = Session["Cart"] as List<Table> ?? new List<Table>();
                cart.Add(flowerToAdd);
                Session["Cart"] = cart;
            }

            var flowers = (from flower in db.Tables select flower).ToList();
            return View("Index", flowers);
        }
        [HttpPost]
        public ActionResult Pay()
        {
            // код для обработки оплаты
            return View("Pay");
        }
        [HttpPost]
        public ActionResult CompleteOrder(OrderViewModel order)
        {
            if (!Regex.IsMatch(order.CardNumber, @"^\d{8}$"))
            {
                ModelState.AddModelError("CardNumber", "Номер карты должен состоять из 8 цифр");
                return View("Pay", order); // Возвращаем на страницу оформления заказа с сообщением об ошибке
            }

            Session["Cart"] = new List<Table>();
            TempData["Message"] = "Заказ успешно оформлен";

            return RedirectToAction("Cart");
        }
        [HttpPost]
        public ActionResult DeleteFromCart(int id)
        {
            var cart = Session["Cart"] as List<Table> ?? new List<Table>();
            var itemToRemove = cart.FirstOrDefault(item => item.FlowerId == id);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Session["Cart"] = cart;
            }

            return RedirectToAction("Cart");
        }

    }
}