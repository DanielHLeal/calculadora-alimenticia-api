using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.DTO
{
    public class AlimentosDTO
    {
        public string nome { get; set; }
        public decimal calorias { get; set; }
        public decimal gramas_porcao { get; set; }
        public decimal carbo { get; set; }
        public decimal proteina { get; set; }
        public decimal gordura { get; set; }
        public decimal gordura_saturada { get; set; }
        public decimal sodio { get; set; }
    }
}
