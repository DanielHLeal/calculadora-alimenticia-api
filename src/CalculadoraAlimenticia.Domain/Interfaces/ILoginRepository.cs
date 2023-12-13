using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Domain.Interfaces
{
    public interface ILoginRepository
    {
        Task AddAsync(LoginModel entity);
        Task<LoginModel> FindEmail(string email);
        Task<LoginModel> FindbyId(int id);
    }
}
