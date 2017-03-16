using HW_AJAX_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW_AJAX_MVC.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("DefaultConnection")
        { }

        public IDbSet<MovieDbModel> Movies { get; set; }
    }
}