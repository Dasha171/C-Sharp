using Microsoft.AspNetCore.Builder;
using WebApplication19.Models;
using System.Data.Entity;

namespace WebApplication19
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            static IHostBuilder CreateHostBuilder(string[] args)
            {
                return Host.CreateDefaultBuilder(args)
       .ConfigureWebHostDefaults(webBuilder =>
       {
           // Инициализация базы данных
           using (var scope = webBuilder.Build().Services.CreateScope())
           {
               var services = scope.ServiceProvider;
               try
               {
                   var context = services.GetRequiredService<BookContext>();
                   /* context.Database.EnsureCreated();*/
                   // Другие действия по инициализации базы данных
               }
               catch (Exception ex)
               {
                   var logger = services.GetRequiredService<ILogger<Program>>();
                   logger.LogError(ex, "An error occurred while initializing the database.");
               }
           }

           webBuilder.UseStartup<Startup>();
       });
            }
        }
    }
}
