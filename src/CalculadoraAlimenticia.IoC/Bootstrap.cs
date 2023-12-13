using CalculadoraAlimenticia.Data.DBContext;
using CalculadoraAlimenticia.Data.Repositories;
using CalculadoraAlimenticia.Domain.Interfaces;
using CalculadoraAlimenticia.Domain.Model;
using CalculadoraAlimenticia.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.IoC
{
    public static class Bootstrap
    {
        public static void AddConfigDatabaseCalculadoraAlimenticia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer("Server=DESKTOP-AJV45NP;Database=database01;Trusted_Connection=True;TrustServerCertificate=True"));
            
        }

        public static void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IAlimentosService, AlimentosService>();
            services.AddScoped<ICaloriasInseridasService, CaloriasInseridasService>();
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IAlimentosRepository, AlimentosRepository>();
            services.AddScoped<ICaloriasInseridasRepository, CaloriasInseridasRepository>();
        }
    }
}
