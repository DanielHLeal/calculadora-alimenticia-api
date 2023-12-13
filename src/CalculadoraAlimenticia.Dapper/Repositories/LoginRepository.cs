using CalculadoraAlimenticia.Data.DBContext;
using CalculadoraAlimenticia.Domain.Interfaces;
using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Data.Repositories
{
    public class LoginRepository :BaseRepository,ILoginRepository
    {
        private readonly Context _context;

        public LoginRepository(Context context) : base (context) 
        {
            _context = context;
        }

        public async Task AddAsync(LoginModel entity)
        {
            try
            {
                _context.login.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<LoginModel> FindEmail(string email)
        {
            try
            {
                LoginModel getbyEmail = _context.login.Include(x => x.email).FirstOrDefault(x => x.email == email);

                return getbyEmail;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<LoginModel> FindbyId(int id)
        {
            try
            {
                LoginModel getbyid = _context.login.Include(x => x.id).FirstOrDefault(x => x.id == id);

                return getbyid;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
