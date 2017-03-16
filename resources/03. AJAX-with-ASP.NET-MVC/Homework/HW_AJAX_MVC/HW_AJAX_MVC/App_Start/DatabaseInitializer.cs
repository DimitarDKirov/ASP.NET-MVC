using HW_AJAX_MVC.Data;
using HW_AJAX_MVC.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW_AJAX_MVC.App_Start
{
    public class DatabaseInitializer
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
        }
    }
}