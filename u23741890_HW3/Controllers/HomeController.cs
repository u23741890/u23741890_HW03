﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace u23741890_HW3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Maintain.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Report.";

            return View();
        }
    }





}