using CalculadoraAlimenticia.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Interfaces
{
    public interface ILoginService
    {
        Task<bool> CreateLogin(LoginDTO login);

    }
}
