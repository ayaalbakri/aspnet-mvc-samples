using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportsMVCSamples.Controllers
{
    public class ReportDesignerController : Controller
    {
        // GET: Designer
        public ActionResult Index()
        {
            ViewBag.toolbarSettings = new Syncfusion.Reporting.Models.ReportDesigner.ToolbarSettings();
            ViewBag.toolbarSettings.Items = Syncfusion.Reporting.ReportDesignerEnums.ToolbarItems.All
                                               & ~Syncfusion.Reporting.ReportDesignerEnums.ToolbarItems.Save;
            ViewBag.action = "Preview";
            return View();
        }
    }
}