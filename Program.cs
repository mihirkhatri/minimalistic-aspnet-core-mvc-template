using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace SimpleMvcTemplate
{
    public class Program
    {
        //This is the main method and the entry point of this 
        //web application
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder() //constructing web builder
                .UseKestrel()  //using Kestrel the lightweight web server provided with ASP.NET
                .UseContentRoot(Directory.GetCurrentDirectory()) //pointing to the content root for the content
                .UseStartup<Startup>() //telling the application to look for startup logic in Startup class
                .Build(); // to build the host to run our web application
                
            host.Run(); //running the host
        }
    }
}
