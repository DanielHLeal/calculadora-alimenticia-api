using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.DTO
{
    public class CaloriasInseridasDTO
    {
        public DateTime data { get; set; }
        public decimal quantidade { get; set; }
        public int id_user { get; set; }
        public int id_alimento { get; set; }
    }
}
