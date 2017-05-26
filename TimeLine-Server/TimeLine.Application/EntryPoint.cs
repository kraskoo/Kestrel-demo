namespace TimeLine.Application
{
    using System.IO;
    using Microsoft.AspNetCore.Hosting;

    public class EntryPoint
    {
        public static void Main() =>
            new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseIISIntegration()
                .Build()
                .Run();
        //{
            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseContentRoot(Directory.GetCurrentDirectory())
            //    .UseIISIntegration()
            //    .UseStartup<Startup>()
            //    .UseApplicationInsights()
            //    .Build();

            
        //}
    }
}
