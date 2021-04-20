using DogsHome.BLL.Interfaces;
using DogsHome.BLL.Services;
using DogsHome.DAL.Context;
using DogsHome.DAL.Interfaces;
using DogsHome.DAL.Repositories;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DogsHome.webAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            string myconnect = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DogsHomeContext>(options => options.UseSqlServer(myconnect));
            services.AddTransient<IDonationService, DonationService>();
            services.AddTransient<IUnitOfWork, DogsHomeUnitOfWork>();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
