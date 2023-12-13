using CalculadoraAlimenticia.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Data.DBContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<LoginModel> login { get; set; }
        public DbSet<AlimentosModel> alimentos { get; set; }
        public DbSet<CaloriasInseridasModel> calorias { get; set; }
    }
}
