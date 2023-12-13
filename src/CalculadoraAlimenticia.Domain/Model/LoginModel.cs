using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Model
{
    [Table("usuarios")]
    public class LoginModel 
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
            
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
