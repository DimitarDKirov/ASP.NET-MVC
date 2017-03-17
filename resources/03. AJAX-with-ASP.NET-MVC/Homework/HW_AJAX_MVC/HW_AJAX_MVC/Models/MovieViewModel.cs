using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW_AJAX_MVC.Models
{
    public class MovieViewModel
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public uint Year { get; set; }

        public string LeadingMaleRole { get; set; }

        public uint LeadingMaleRoleAge { get; set; }

        public string LeadingFemaleRole { get; set; }

        public uint LeadingFemaleRoleAge { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }
    }
}