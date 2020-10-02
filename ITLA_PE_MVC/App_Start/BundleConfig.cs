using System.Web;
using System.Web.Optimization;

namespace ITLA_PE_MVC
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            

                 bundles.Add(new ScriptBundle("~/bundles/modalscript").Include(
                 "~/Scripts/modalPop.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/bootstrap.js",
                 "~/Scripts/alertify.js", 
                 "~/Scripts/bs-custom-file-input.js",
                 "~/Scripts/inputmask.js",
                  "~/Scripts/active.js",
                 "~/Scripts/fontawesome.js",
                 "~/Scripts/steps.js",
                 "~/Scripts/gijgo.min.js"
                 ));

            

            bundles.Add(new ScriptBundle("~/bundles/dropscript").Include(
                     "~/Scripts/DropScripts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/site.css",
                      "~/Content/components.css",
                      "~/Content/colors.css",
                      "~/Content/alertify.core.css",
                      "~/Content/alertify.default.css",
                      "~/Content/bootstrapgrid.min.css"
                      ));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //        "~/Content/style.css",
            //         "~/Content/components.css",
            //         "~/Content/colors.css",
            //         "~/Content/alertify.core.css",
            //         "~/Content/alertify.default.css",
            //         "~/Content/bootstrapgrid.min.css",
            //         "~/Content/steps.css",
            //         "~/Content/gijgo.min.css"
            //         ));


        }
    }
}


