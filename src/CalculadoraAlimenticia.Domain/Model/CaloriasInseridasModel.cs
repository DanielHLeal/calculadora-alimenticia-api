using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Model
{
    [Table("calorias_inserida")]
    public class CaloriasInseridasModel
    {
        [Key]
        public int id { get; set; }
        public DateTime data { get; set; }
        public decimal quantidade { get; set; }
        public int id_user { get; set; }
        public int id_alimento { get; set; }
    }
}
