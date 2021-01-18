using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            return View();
        }

        [Route("editPlans/{planId:regex(\\d{2})}/{name}")]
        public ActionResult Edit(int planId,string name)
        {
            return Content("Id = " + planId + " Name = " + name);
        }
    }
}