using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using web_menu.Data;
using System.IO;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace web_menu
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MenuContext>(options => options.UseMySql(GetMySQLConnectionString()));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private string GetMySQLConnectionString()
        {
            DbConfig config;
            using (StreamReader r = new StreamReader("Data/dbconfig.json"))
            {
                string json = r.ReadToEnd();
                config = JsonConvert.DeserializeObject<DbConfig>(json);
            }
            return "Server=" + config.server + ";database=" + config.database + ";uid=" + config.uid + ";pwd=" + config.password;
        }
    }
}
