﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsMVCSamples.Controllers
{
    public class PreviewController : Controller
    {
        // GET: Preview
        public ActionResult Preview()
        {
            string foderName = this.ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.action = "Preview";
            return View("~/Views/" + foderName + "/Index.cshtml");

        }
    }
}