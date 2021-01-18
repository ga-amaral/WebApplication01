using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models.ViewModel
{
    public class ClientPlanViewModel
    {
        public Client Client { get; set; }
        public List<Plan> Plan { get; set; }
    }
}