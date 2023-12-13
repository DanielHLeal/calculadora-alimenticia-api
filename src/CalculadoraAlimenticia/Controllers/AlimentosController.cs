using CalculadoraAlimenticia.Domain.DTO;
using CalculadoraAlimenticia.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAlimenticia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlimentosController : Controller
    {
        public IAlimentosService _service;
        public ICaloriasInseridasService _caloriasInseridasService;

        public AlimentosController(IAlimentosService service, ICaloriasInseridasService caloriasInseridasService)
        {
            _service = service;
            _caloriasInseridasService = caloriasInseridasService;
        }

        [HttpGet("CreateAlimento")]
        public void Post([FromQuery] AlimentosDTO alimento)
        {
            try
            {
                _service.CreateAlimento(alimento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("InserirAlimentoConsumido")]
        public void InserirAlimentoConsumido([FromQuery] CaloriasInseridasDTO calorias)
        {
            try
            {
                _caloriasInseridasService.AddCalorias(calorias);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("FindByData")]
        public Task<CaloriasInseridasDayDTO> FindByData([FromQuery] DateTime data, int idUser)
        {
            try
            {
                var retorno = _caloriasInseridasService.getCaloriaperDay(data, idUser);

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
