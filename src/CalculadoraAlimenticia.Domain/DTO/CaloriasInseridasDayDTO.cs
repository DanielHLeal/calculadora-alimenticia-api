using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.DTO
{
    public class CaloriasInseridasDayDTO
    {
        public decimal quantidadeCalorias { get; set; }
        public decimal quantidadeCarbo{ get; set; }
        public decimal quantidadeProteina { get; set; }
        public decimal quantidadeGordura { get; set; }
        public decimal quantidadeGorduraSaturada { get; set; }
        public decimal quantidadeGorduraSodio { get; set; }
    }
}
