using CalculadoraAlimenticia.Data.DBContext;
using CalculadoraAlimenticia.Domain.Interfaces;
using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Data.Repositories
{
    public class CaloriasInseridasRepository: ICaloriasInseridasRepository
    {
        private readonly Context _context;

        public CaloriasInseridasRepository(Context context)
        {
            _context = context;
        }

        public async Task AddAsync(CaloriasInseridasModel entity)
        {
            try
            {
                _context.calorias.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<CaloriasInseridasModel>> FindByData(DateTime data, int idUser)
        {
            try
            {
                List<CaloriasInseridasModel> getByData = _context.calorias.Include(x => x.data).Where(x => x.data == data && x.id_user == idUser).ToList();

                return getByData;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
