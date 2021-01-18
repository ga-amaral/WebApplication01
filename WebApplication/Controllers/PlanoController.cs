using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class PlanoController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            return View();
        }

        [Route("editarPlanos/{planoId:regex(\\d{2}):range{1,10}}/{name}")]
        public ActionResult Edit(int planoId,string name)
        {
            return Content("Id = " + planoId + " Name = " + name);
        }
    }
}