using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Models.ViewModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Client client = new Client()
            {
                Id = 1,
                Name = "Gabriel"
            };

            List<Plan> planList = new List<Plan>();

            planList.Add(new Plan { Id = 1, Name = "#1", Value = 100 });
            planList.Add(new Plan { Id = 2, Name = "#2", Value = 200 });
            planList.Add(new Plan { Id =3, Name = "#3", Value = 150 });

            ClientPlanViewModel model = new ClientPlanViewModel();

            model.Client = client;
            model.Plan = planList;


            //ViewData["nomeUsuario"] = "Chaves";
            //ViewBag.NomeUsuario = "Chapolin";

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}