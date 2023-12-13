using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Interfaces
{
    public interface ICaloriasInseridasRepository
    {
        Task AddAsync(CaloriasInseridasModel entity);
        Task<List<CaloriasInseridasModel>> FindByData(DateTime data, int idUser);
    }
}
