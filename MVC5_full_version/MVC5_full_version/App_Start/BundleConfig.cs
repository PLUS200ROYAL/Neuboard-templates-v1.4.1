using System.Web;
using System.Web.Optimization;

namespace MVC5_full_version
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/ie").Include(
                      "~/Scripts/html5shiv.min.js",
                      "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/simple-line-icons.css",
                      "~/Content/clndr.css",
                      "~/Content/dropzone.css",
                      "~/Scripts/plugins/switchery/switchery.min.css",
                      "~/Content/morris.css",
                      "~/Content/animate.css",
                      "~/Content/main.css"));


            bundles.Add(new StyleBundle("~/plugins/dataTablesCSS").Include(
                    "~/Scripts/plugins/dataTables/css/dataTables.css"));

            bundles.Add(new StyleBundle("~/Content/icheckCSS").Include(
                  "~/Content/icheck/grey.css"));

            bundles.Add(new StyleBundle("~/plugins/c3ChartCSS").Include(
                    "~/Scripts/plugins/c3Chart/css/c3.css"));

            bundles.Add(new StyleBundle("~/plugins/daterangepickerCSS").Include(
                "~/Scripts/plugins/daterangepicker/daterangepicker-bs3.css"));

            bundles.Add(new StyleBundle("~/plugins/slidersCSS").Include(
               "~/Scripts/plugins/bootstrap-slider/css/slider.css"));

            bundles.Add(new StyleBundle("~/plugins/jvectormapsCSS").Include(
              "~/Scripts/plugins/jvectormap/css/jquery-jvectormap-1.2.2.css"));

            bundles.Add(new StyleBundle("~/plugins/wysihtml5CSS").Include(
              "~/Scripts/plugins/bootstrap-wysihtml5/css/bootstrap-wysihtml5.css"));

            bundles.Add(new StyleBundle("~/plugins/messengerCSS").Include(
                    "~/Scripts/plugins/messenger/css/messenger.css",
                     "~/Scripts/plugins/messenger/css/messenger-theme-flat.css",
                     "~/Scripts/plugins/messenger/css/location-sel.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
               "~/Scripts/jquery-1.11.1.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/validate").Include(
            "~/Scripts/plugins/validation/js/jquery.validate.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
             "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/pace").Include(
             "~/Scripts/plugins/fullscreen/jquery.fullscreen-min.js"));

            bundles.Add(new ScriptBundle("~/plugins/fullscreen").Include(
           "~/Scripts/plugins/pace/pace.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/navgoco").Include(
            "~/Scripts/plugins/navgoco/jquery.navgoco.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/countTo").Include(
            "~/Scripts/plugins/countTo/jquery.countTo.js"));

            bundles.Add(new ScriptBundle("~/plugins/skycons").Include(
          "~/Scripts/plugins/weather/js/skycons.js"));

            bundles.Add(new ScriptBundle("~/plugins/wizard").Include(
             "~/Scripts/plugins/wizard/js/loader.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/moment").Include(
            "~/Scripts/plugins/daterangepicker/moment.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/raphael").Include(
            "~/Scripts/plugins/morris/js/raphael.2.1.0.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/daterangepicker").Include(
             "~/Scripts/plugins/daterangepicker/daterangepicker.js"));

            bundles.Add(new ScriptBundle("~/plugins/chartjs-demo").Include(
            "~/Scripts/plugins/chartjs/chartjs-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/chartjs").Include(
            "~/Scripts/plugins/chartjs/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/c3ChartD3").Include(
           "~/Scripts/plugins/c3Chart/js/d3.v3.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/c3Chart").Include(
           "~/Scripts/plugins/c3Chart/js/c3.js"));

            bundles.Add(new ScriptBundle("~/plugins/c3ChartDemo").Include(
           "~/Scripts/plugins/c3Chart/js/c3-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/morris").Include(
           "~/Scripts/plugins/morris/js/morris.min.js"));


            bundles.Add(new ScriptBundle("~/plugins/morrisExample").Include(
            "~/Scripts/plugins/morris/js/morris-example.js"));

            bundles.Add(new ScriptBundle("~/plugins/sparkline").Include(
           "~/Scripts/plugins/sparkline/jquery.sparkline.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/sparkline-demo").Include(
            "~/Scripts/plugins/sparkline/sparkline-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/jvectormap").Include(
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/jvectormap-world").Include(
             "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new ScriptBundle("~/plugins/gauge").Include(
            "~/Scripts/plugins/gauge/gauge.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/gauge-demo").Include(
            "~/Scripts/plugins/gauge/gauge-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/calendar").Include(
            "~/Scripts/plugins/calendar/clndr.js"));

            bundles.Add(new ScriptBundle("~/plugins/calendar-demo").Include(
            "~/Scripts/plugins/calendar/clndr-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/underscore").Include(
            "~/Scripts/plugins/calendar/underscore-min.js"));

            bundles.Add(new ScriptBundle("~/plugins/switchery").Include(
           "~/Scripts/plugins/switchery/switchery.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/sliders").Include(
              "~/Scripts/plugins/bootstrap-slider/js/bootstrap-slider.js"));

            bundles.Add(new ScriptBundle("~/plugins/nestableJS").Include(
             "~/Scripts/plugins/sortNestable/js/jquery.nestable.js"));

            bundles.Add(new ScriptBundle("~/plugins/maskedinput").Include(
            "~/Scripts/plugins/mask/js/jquery.maskedinput.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/dropzone").Include(
           "~/Scripts/plugins/dropzone/dropzone.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/wysihtml5").Include(
             "~/Scripts/plugins/bootstrap-wysihtml5/js/wysihtml5-0.3.0.js"));

            bundles.Add(new ScriptBundle("~/plugins/bootstrap3-wysihtml5").Include(
             "~/Scripts/plugins/bootstrap-wysihtml5/js/bootstrap3-wysihtml5.js"));

            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
             "~/Scripts/plugins/dataTables/js/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle("~/plugins/dataTables-bootstrap").Include(
          "~/Scripts/plugins/dataTables/js/dataTables.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/plugins/icheck").Include(
            "~/Scripts/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/gmaps").Include(
           "~/Scripts/plugins/gmaps/gmaps.js",
            "~/Scripts/plugins/gmaps/gmaps-demo.js"));

            bundles.Add(new ScriptBundle("~/plugins/messenger").Include(
             "~/Scripts/plugins/messenger/js/messenger.min.js",
              "~/Scripts/plugins/messenger/js/messenger-theme-future.js",
              "~/Scripts/plugins/messenger/js/demo/location-sel.js",
              "~/Scripts/plugins/messenger/js/demo/theme-sel.js",
              "~/Scripts/plugins/messenger/js/demo/demo.js",
              "~/Scripts/plugins/messenger/js/demo/demo-messages.js"));

            bundles.Add(new ScriptBundle("~/plugins/jvectormaps").Include(
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-europe-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-ca-lcc-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-it-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-us-aea-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-us-il-chicago-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-us-ny-newyork-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-uk-mill-en.js",
            "~/Scripts/plugins/jvectormap/js/jquery-jvectormap-demo.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
           "~/Scripts/src/app.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}

