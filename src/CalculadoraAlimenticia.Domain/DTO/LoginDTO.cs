using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.DTO
{
    public class LoginDTO
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public string email { get; set; }
        public string telefone { get; set; }
    }
}
