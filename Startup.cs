using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace ETicaret
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
            var con = @"Server=.;
              Database=ETicaret;
		      User Id=sa;
		      Password=******;
              Trusted_Connection=True;";

            //Contex daha evvel oluþturduðumuz clasýn adý sizde faklý olabilir.
            services.AddDbContext<ApplicationIdentityDbContext>(x => x.UseSqlServer(con));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationIdentityDbContext>().AddDefaultTokenProviders();
            services.AddDbContext<Context>(x => x.UseSqlServer(con));
            services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddTransient<IProduct, ProductRepository>();
            services.AddTransient<IMagaza, MagazaRepository>();
            services.AddTransient<IIller, IllerRepository>();
            services.AddTransient<IYorumlar, YorumlarRepository>();
            services.AddTransient<Iilce, IlcelerRepository>();
            services.AddTransient<IKategori, KategoriRepository>();
            services.AddTransient<IMenu, MenuRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "Areas",
                  template: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/modules"
            });
            
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
           
        }
    }
}
