using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsMVCSamples.Controllers
{
    public class WebsiteVisitorAnalysisController : PreviewController
    {
        // GET: WebsiteVisitorAnalysis
        public ActionResult Index()
        {
            return View();
        }
    }
}