using CalculadoraAlimenticia.Domain.DTO;
using CalculadoraAlimenticia.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAlimenticia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        public ILoginService _service;
        public LoginController(ILoginService service) 
        { 
            _service = service;
        }

        [HttpGet("CreateLogin")]
        public void Post([FromQuery]LoginDTO login)
        {
            try
            {
                _service.CreateLogin(login);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
