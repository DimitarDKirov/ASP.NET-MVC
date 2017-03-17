using BitCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly int[] KiloTypes = new int[] { 1000, 1024 };
        private readonly string[] UnitTypes = new string[]
            {
"Bit"      ,
"Byte"     ,
"Kilobit"  ,
"Kilobyte" ,
"Megabit"  ,
"Megabyte" ,
"Gigabit"  ,
"Gigabyte" ,
"Terabit"  ,
"Terabyte" ,
"Petabit"  ,
"Petabyte" ,
"Exabit"   ,
"Exabyte"  ,
"Zettabit" ,
"Zettabyte",
"Yottabit" ,
"Yottabyte"
            };

        private readonly IList<SelectListItem> Kilos;

        private readonly IList<SelectListItem> Units;

        public HomeController()
        {
            this.Units = new List<SelectListItem>();
            for (int i = 0; i < UnitTypes.Length; i++)
            {
                this.Units.Add(new SelectListItem() { Value = i.ToString(), Text = UnitTypes[i] });
            }

            this.Kilos = new List<SelectListItem>();
            for (int i = 0; i < KiloTypes.Length; i++)
            {
                this.Kilos.Add(new SelectListItem { Value = i.ToString(), Text = KiloTypes[i].ToString() });
            };
        }


        public ActionResult Index()
        {
            var model = new BitCalculatorModel()
            {
                Units = this.Units,
                SelectedUnit=0,
                Kilos=this.Kilos,
                SelectedKilo=0
            };

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