﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsMVCSamples.Controllers
{
    public class CompanySalesController : PreviewController
    {
        // GET: CompanySales
        public ActionResult Index()
        {
            return View();
        }
    }
}