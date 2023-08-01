using GamingFest_fatema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamingFest_fatema.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Index()
        {
            fatema_gamingfestEntities1 db = new fatema_gamingfestEntities1();
            var data = db.volunteers.ToList();

            return View();
        }
    }
}