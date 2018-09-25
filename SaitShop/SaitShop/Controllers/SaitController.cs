using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaitShop.Models;

namespace SaitShop.Controllers
{
  
    public class SaitController : Controller
    {
       SaitDbEntities  db = new SaitDbEntities();
          
        public ActionResult Select_Phones()
        {
            var query = db.Sait.OrderBy(s => s.NameFirm);
            return View(query.ToList());
        }
        public ActionResult Main()
        {
            ViewBag.msg = "Главная страница";
            ViewBag.x = "PhoneShop - это магазин мобильных гаджетов, который отличается большим выбором смартфонов и частыми акциями на них. Магазин открыт с 9:00 до 21:00 и в это время наши сотрудники ждус вас и любезно помогут выбрать смартфон, который нужен именно вам. Мы находимся на Ул. Пржевальского д.4."+Environment.NewLine+"Контактные телефоны: +7(4812)548654 +7(950)7018888";
            ViewBag.Image = "SmolGu.jpg";
            return View();
        }
        public ActionResult Create_Order(int id)
        {
            Sait sait = db.Sait.Find(id);
            ViewBag.firm = sait.NameFirm;
            ViewBag.model = sait.NameModel;
            ViewBag.count = sait.Count;
            ViewBag.stock = sait.InStock;
            ViewBag.price = sait.Price;
            ViewBag.xar = sait.Сharacteristic;
            ViewBag.des = sait.Description;
            ViewBag.c = sait.VonderCode;
            ViewBag.date_order = DateTime.Now.ToShortDateString();
            ViewBag.Image = sait.ImageName;
            return View();
        }
        [HttpPost]
        public ActionResult Create_Order(Orders orders, int id)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(orders);
                db.SaveChanges();
                return RedirectToAction("Select_Phones");
            }
            Sait sait = db.Sait.Find(id);
             ViewBag.firm = sait.NameFirm;
            ViewBag.model = sait.NameModel;
            ViewBag.count = sait.Count;
            ViewBag.stock = sait.InStock;
            ViewBag.price = sait.Price;
            ViewBag.c = sait.VonderCode;
            ViewBag.date_order = DateTime.Now.ToShortDateString();
            ViewBag.Image = sait.ImageName;
            return View(orders);
        }

    }
}