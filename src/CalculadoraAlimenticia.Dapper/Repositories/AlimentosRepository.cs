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
    public class AlimentosRepository: IAlimentosRepository
    {
        private readonly Context _context;
        
        public AlimentosRepository (Context context) 
        {
            _context = context;
        }


        public async Task AddAsync(AlimentosModel entity)
        {
            try
            {
                _context.alimentos.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<AlimentosModel> FindByNome(string nome)
        {
            try
            {
                AlimentosModel getbyNome = _context.alimentos.Include(x => x.nome).FirstOrDefault(x => x.nome == nome);

                return getbyNome;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<AlimentosModel> FindById(int id)
        {
            try
            {
                AlimentosModel getbyid = _context.alimentos.Include(x => x.id).FirstOrDefault(x => x.id == id);

                return getbyid;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
