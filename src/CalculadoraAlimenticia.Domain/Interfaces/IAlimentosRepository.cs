using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Interfaces
{
    public interface IAlimentosRepository
    {
        Task AddAsync(AlimentosModel entity);
        Task<AlimentosModel> FindByNome(string nome);
        Task<AlimentosModel> FindById(int id);
    }
}
