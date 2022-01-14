using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Rental_System.Models;

namespace Car_Rental_System.Controllers
{
    public class returncarController : Controller
    {
        Car_Rental_System_DBEntities db = new Car_Rental_System_DBEntities();
        // GET: returncar
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(returncar recar)
        {
            if (ModelState.IsValid)
            {
                db.returncars.Add(recar);
                var car = db.carregs.SingleOrDefault(e => e.carno == recar.carno);
                if (car==null)
                    return HttpNotFound("car Number Not found");
                    car.available = "yes";
                    db.Entry(car).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
            }
            return View(recar);
        }


        public ActionResult Getid(string carno)
        {

            var carn = (from s in db.rentails
                        where s.carid == carno
                        select new
                        {
                            StartDate = s.sdatre,
                            EndDate = s.edate,
                            Custid = s.custid,
                            CarNo = s.carid,
                            fee = s.fee,
                            ElapsedDays = SqlFunctions.DateDiff("day", s.edate, DateTime.Now)
                        }).ToArray();
            return Json(carn,JsonRequestBehavior.AllowGet);
        }
    }
}