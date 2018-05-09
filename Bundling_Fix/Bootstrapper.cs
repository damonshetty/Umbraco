using System.Web.Optimization;
using Umbraco.Core;

namespace Project.Bundling_Fix
{
    public class Bootstrapper : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        { }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //CSS
            BundleTable.Bundles.Add(new StyleBundle("~/bundles/css").Include(
            "~/css/bootstrap.css",
            "~/css/site.css",
            "~/css/sitemediaqueries.css",
            "~/slick/slick.css",
            "~/slick/slick-theme.css",
            "~/css/Tabs.css",
            "~/css/Smart-Menu/sm-core-css.css",
            "~/css/Smart-Menu/rLdJAK.css",
            "~/css/Smart-Menu/SmartMenu.css",
            "~/css/carousel.css"));

            //            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //                        "~/Scripts/jquery.validate*"));

            //            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            //            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //                        "~/Scripts/modernizr-*"));

            //SCRIPTS
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                "~/Scripts/jquery-2.2.0.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/Smart-Menu/jquery.smartmenus.js",
                "~/slick/slick.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/GoogleAnalytics").Include(
                "~/Scripts/GoogleAnalytics.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/CookiesAndSearchBar").Include(
                "~/Scripts/CookiesAndSearchBar.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/SliderHome").Include(
                "~/Scripts/SliderHome.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            #if DEBUG
                        BundleTable.EnableOptimizations = false;
#else
                            BundleTable.EnableOptimizations = true;
#endif

            ////Scripts
            //BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //   "~/Scripts/jquery-{version}.js",
            //   "~/Scripts/jquery-ui.js"));

            //BundleTable.Bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //   "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //BundleTable.Bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //BundleTable.Bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            ////CSS
            //BundleTable.Bundles.Add(new StyleBundle("~/bundles/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css",
            //           "~/Content/jquery-ui.css",
            //           "~/jquery-ui.structure.css",
            //           "~/jquery-ui.theme.css"
            //          ));
        }


        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //BundleTable.EnableOptimizations = true;

            //Bootstrapper.RegisterBundles(BundleTable.Bundles);

            //BundleConfig.RegisterBundles(BundleTable.Bundles);


        }

        private static void RegisterBundles(BundleCollection bundles)
        {
            //Add all style files. These will be bundled and minified.
            //After everything has been bundled (which only happens when debug=false in the web.config) check if there are no errors in the bundled file. Not all files can be bundled.
            //Bundle styles = new Bundle("~/Content/css");
            //styles.Include("~/Content/bootstrap.css");
            //styles.Include("~/Content/site.css");
            //styles.Include("~/Content/sitemediaqueries.css");
            //styles.Transforms.Add(new CssMinify());
            //bundles.Add(styles);
        }

    }
}