using CalculadoraAlimenticia.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Interfaces
{
    public interface ICaloriasInseridasService
    {
        Task<bool> AddCalorias(CaloriasInseridasDTO calorias);
        Task<CaloriasInseridasDayDTO> getCaloriaperDay(DateTime data, int idUser);
    }
}
