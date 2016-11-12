using mvc_ef_mysql_beg02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_ef_mysql_beg02.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext db = new MyDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // add address
            //db.addresses.Add(new address {
            //    Address1 = "BacGiang",
            //    FullAddress = "Ngo Quyen, Bac Giang"
            //});

            //db.personmasters.Add(new personmaster
            //{
            //    FIRSTNAME = "Linh",
            //    LASTNAME = "Vu",
            //    ADDRESS1 = "Hanoi",
            //    ADDRESS2 = "VanKhe HaDong"
            //});

            // add address
            //db.addresses.Add(new address
            //{
            //    Address = "BacNinh",
            //    FullAddress = "Tu Son, Bac Ninh"
            //});

            db.personmasters.Add(new personmaster
            {
                FIRSTNAME = "Ha Anh",
                LASTNAME = "Vu",
                ADDRESS1 = "Hanoi",
                ADDRESS2 = "VanKhe HaDong"
            });

            db.SaveChanges();

            /***
             * //var tours = db.Tours.Include(t => t.Rating)   //this is an eagle loading: load now (opoosite to lazy loading)
             * //               .Where(t => t.Rating.Name == "Difficult")
             * //               .OrderBy(t => t.Name);
             * 
             * var tours = from t in db.Tours
             *              where t.Rating.Name == "Difficult"
             *              orderby t.Name
             *              select t;
             * return View(tours.ToList()); //ToList() is a deffered query (only load in db if you action on result of query)
             * 
             * // Your own Query
             * db.Database.... (BeginTransaction, ExecuteSqlCommand, ExecuteSqlCommandAsync, SqlQuery,.....)
             * // Or you can ADO.NET classes
             * 
             ***/

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}