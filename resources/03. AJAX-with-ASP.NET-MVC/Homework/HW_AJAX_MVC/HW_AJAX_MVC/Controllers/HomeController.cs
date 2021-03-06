﻿using HW_AJAX_MVC.Data;
using HW_AJAX_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_AJAX_MVC.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDbContext dbContext;

        public HomeController()
        {
            this.dbContext = new MoviesDbContext();
        }

        public ActionResult Index()
        {
            var movies = this.dbContext
                .Movies
                .Select(m => new MoviesListViewModel
                {
                    Id = m.Id,
                    Title = m.Title
                })
                .ToList();

            return View(movies);
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