using CalculadoraAlimenticia.Data.Repositories;
using CalculadoraAlimenticia.Domain.DTO;
using CalculadoraAlimenticia.Domain.Interfaces;
using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(LoginRepository loginRepository) { 
            _loginRepository= loginRepository;
        }   

        public async Task<bool> CreateLogin(LoginDTO login)
        {
            try
            {
                var exist = await _loginRepository.FindEmail(login.email);
                if (exist == null)
                {
                    if (login.usuario != null && login.senha != null && login.email != null && login.telefone != null)
                    {
                        int letraMaiscula = Regex.Matches(login.senha, @"[a-zA-Z]").Count;
                        int letraMinuscula = Regex.Matches(login.senha, @"[a-zA-Z]").Count;
                        int isNumber = Regex.Matches(login.senha, @"[0-9]").Count;

                        if(letraMaiscula > 0 && letraMinuscula > 0 && isNumber > 0)
                        {
                            LoginModel loginModel = new LoginModel();
                            loginModel.usuario = login.usuario;
                            loginModel.senha = login.senha;
                            loginModel.email = login.email;
                            loginModel.telefone = login.telefone;
                            await _loginRepository.AddAsync(loginModel);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
