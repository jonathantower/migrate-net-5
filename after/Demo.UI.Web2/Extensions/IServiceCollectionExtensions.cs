namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static void AddCssAndJsBundles(this IServiceCollection services)
        {
            services.AddWebOptimizer(pipeline =>
            {
                // js 
                pipeline.AddJavaScriptBundle("/bundles/jquery.js", "Scripts/jquery-3.4.1.js");
                pipeline.AddJavaScriptBundle("/bundles/jqueryval.js", "Scripts/jquery.validate*");
                pipeline.AddJavaScriptBundle("/bundles/modernizr.js", "Scripts/modernizr-*");
                pipeline.AddJavaScriptBundle("/bundles/bootstrap.js", "Scripts/bootstrap.js");

                // css
                pipeline.AddCssBundle("/content/css.css", "Content/bootstrap.css");
            });

        }
    }
}
