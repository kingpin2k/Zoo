using HandlebarsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Zoo.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
#if(DEBUG)
            var debug = true;
#else
            var debug = false;
#endif

            var ember = debug ? "ember.js" : "ember.min.js";
            var emberdata = debug ? "ember-data.js" : "ember-data.min.js";


            bundles.Add(new ScriptBundle("~/bundles/thirdparty")
                        .Include("~/Scripts/ThirdParty/jquery-1.10.2.min.js")
                        .Include("~/Scripts/ThirdParty/handlebars-v1.3.0.js")
                        .Include("~/Scripts/ThirdParty/" + ember)
                        .Include("~/Scripts/ThirdParty/" + emberdata)
                        .Include("~/Scripts/ThirdParty/moment.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                                    .Include("~/Scripts/Zoo/application.js")
                                    .Include("~/Scripts/Zoo/router.js")
                                    .IncludeDirectory("~/Scripts/Zoo/Util", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Mixins", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Adapters", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Controllers", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Components", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Models", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Routes", "*.js", true)
                                    .IncludeDirectory("~/Scripts/Zoo/Views", "*.js", true)
                                    );

            bundles.Add(new Bundle("~/bundles/templates", new HandlebarsTransformer())
                .IncludeDirectory("~/Scripts/Zoo/Templates", "*.hbs", true));

            bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Content/styles/", "*.css", true));

            BundleTable.EnableOptimizations = !debug;
        }
    }
}