using GamingFest_fatema.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamingFest_fatema.Controllers
{
    public class AdminController : Controller
    {
        private object st;

        public int Id { get; private set; }

        // public object Admins { get; private set; }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }


           

        public ActionResult Profile_Update()
        {
            return View();
        }
        public ActionResult Profile_Update2()
        {



            return View();
        }



        public ActionResult Volunteers_Info2()
        {
            fatema_gamingfestEntities1 db = new fatema_gamingfestEntities1();
            var data = db.volunteers.ToList();

            return View(data);
        }
        public ActionResult vcreate()
        {

            return View();
        }
        [HttpPost]
        public ActionResult vcreate(volunteer av)
        {
            fatema_gamingfestEntities1 a = new fatema_gamingfestEntities1();
            a.volunteers.Add(av);
            a.SaveChanges();
            return RedirectToAction("Volunteers_Info2");
        }

        public ActionResult vedit(int Id)
        {
            fatema_gamingfestEntities1 a = new fatema_gamingfestEntities1();
            var volunteer = (from vt in a.volunteers
                             where a.Id == Id
                             select st).First();

            return View(volunteer);
        }

        [HttpPost]
        public ActionResult vedit(volunteer av)
        {
            using (fatema_gamingfestEntities1 a = new fatema_gamingfestEntities1())
            {
                var entity = (from vt in a.volunteers
                              where vt.Id == av.Id
                              select vt).FirstOrDefault();

                a.Entry(entity).CurrentValues.SetValues(av);
                a.SaveChanges();
                return RedirectToAction("Volunteers_Info2");

            }
        }

        public ActionResult vdetails(int Id)
        {
            fatema_gamingfestEntities1 a = new fatema_gamingfestEntities1();
            var volunteer = (from vt in a.volunteers
                             where vt.Id == Id
                             select vt).First();
            return View(volunteer);
        }
        public ActionResult vdelete(int Id)
        { 
        using (fatema_gamingfestEntities1 a=new fatema_gamingfestEntities1())
            {
                var v = (from vt in a.volunteers
                               where vt.Id == Id
                               select vt).FirstOrDefault();
            }
        [HttpPost]
        
        
        }


            //  [HttpPost]
            //public ActionResult Volunteers_Info2( Admin v)
            //{
            //  string connString = @"Server=DESKTOP-KC1AJ4P\SQLEXPRESS; Database= gamingdata; Integrated Security=true";
            // SqlConnection conn = new SqlConnection(connString);
            // string query = String.Format("Insert into Students values ('{0}', '{1}', '{2}')", v.Name, v.Dob, v.Gender);
            // SqlCommand cmd = new SqlCommand(query, conn);
            // conn.Open();
            // int r = cmd.ExecuteNonQuery();

            //conn.Close();

            // return View();
            // }





            public ActionResult Users_Info()
        {
            return View();
        }
        public ActionResult Users_Info2()
        {
            return View();
        }
        public ActionResult Overview()
        {
            return View();
        }
        public ActionResult Overview2()
        {
            return View();
        }


        public ActionResult Review()
        {
            return View();
        }
        public ActionResult Review2()
        {
            return View();
        }

        public ActionResult Gameadd2()
        {
            return View();
        }

        public ActionResult Logout2()
        {
            return View();
        }
        //[HttpGet]
        //public ActionResult gamecreate()
        //{

        // return View();
        //}
        //[HttpPost]
        //public ActionResult gamecreate(Admin g)
        //{
        //  fatema_gamingfestEntities1 q = new fatema_gamingfestEntities1();
        //q.games.Add(g);
        //q.SaveChanges();
        //return RedirectToAction("Index2");

        //}

    }
}