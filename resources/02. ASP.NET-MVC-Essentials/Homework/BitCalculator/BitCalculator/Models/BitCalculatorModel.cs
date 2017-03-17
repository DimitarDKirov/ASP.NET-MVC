using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitCalculator.Models
{
    public class BitCalculatorModel
    {
        public float Quantity { get; set; }

        public int SelectedUnit { get; set; }

        public IEnumerable<SelectListItem>  Units { get; set; }

        public int SelectedKilo { get; set; }

        public IEnumerable<SelectListItem> Kilos { get; set; }
    }
}