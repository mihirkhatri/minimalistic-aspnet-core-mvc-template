using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleMvcTemplate
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  //adding MVC as service so that ASP.MVC website can be created
        }

        
        public void Configure(IApplicationBuilder app)
        {
            //add static file middleware
            //server the static content from wwwroot folder by default
            //this can be configured, please refer the documentation 
            //for how to configure other folder to server the static 
            //content
            app.UseStaticFiles();  


            //add the default MVC routing pattern as middleware
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });        
        }
    }
}