﻿using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace simpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css")
                );

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-1.10.2.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/areas/admin/scripts/forms.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-1.10.2.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));
            
        }
    }
}