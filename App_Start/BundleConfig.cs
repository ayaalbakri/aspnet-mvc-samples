using System.Web;
using System.Web.Optimization;

namespace ReportsMVCSamples
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                      "~/Scripts/dependent/prism.js",
                      "~/Scripts/dependent/prism-csharp.min.js",
                      "~/Scripts/dependent/jquery.min.js",
                      "~/Scripts/dependent/jsrender.min.js",
                      "~/Scripts/dependent/popper.min.js",
                      "~/Scripts/dependent/bootstrap.min.js",
                      "~/Scripts/ej/common/ej.reporting.common.min.js",
                      "~/Scripts/ej/common/ej.reporting.widgets.min.js",
                      "~/Scripts/ej/ej.report-viewer.min.js",
                      "~/Scripts/ej/data-visualization/ej.bulletgraph.min.js",
                      "~/Scripts/ej/data-visualization/ej.chart.min.js",
                      "~/Scripts/ej/data-visualization/ej.circulargauge.min.js",
                      "~/Scripts/ej/data-visualization/ej.lineargauge.min.js",
                      "~/Scripts/ej/data-visualization/ej.map.min.js"));

            bundles.Add(new StyleBundle("~/Content/main").Include(
                       "~/Content/css/dependent/bootstrap.min.css",
                       "~/Content/css/dependent/prism.css",
                       "~/Content/css/ej/material/ej.reports.all.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/preview").Include(
                      "~/Scripts/dependent/jquery.min.js",
                      "~/Scripts/dependent/jsrender.min.js",
                      "~/Scripts/ej/common/ej.reporting.common.min.js",
                      "~/Scripts/ej/common/ej.reporting.widgets.min.js",
                      "~/Scripts/ej/ej.report-viewer.min.js",
                      "~/Scripts/ej/common/ej.report-designer-widgets.min.js",
                      "~/Scripts/ej/ej.report-designer.min.js",
                      "~/Scripts/ej/data-visualization/ej.bulletgraph.min.js",
                      "~/Scripts/ej/data-visualization/ej.chart.min.js",
                      "~/Scripts/ej/data-visualization/ej.circulargauge.min.js",
                      "~/Scripts/ej/data-visualization/ej.lineargauge.min.js",
                      "~/Scripts/ej/data-visualization/ej.map.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/codemirror").Include(
                      "~/Scripts/dependent/codemirror.js",
                      "~/Scripts/dependent/show-hint.js",
                      "~/Scripts/dependent/sql-hint.js",
                      "~/Scripts/dependent/sql.js",
                      "~/Scripts/dependent/vb.js"));

            bundles.Add(new StyleBundle("~/Content/codemirror").Include(
                       "~/Content/css/dependent/codemirror.css",
                       "~/Content/css/dependent/show-hint.css"));

            bundles.Add(new StyleBundle("~/Content/preview").Include(
                       "~/Content/css/ej/material/ej.reports.all.min.css",
                       "~/Content/css/ej/material/ej.reportdesigner.min.css"));
        }

    }
}
