using CalculadoraAlimenticia.Domain.DTO;
using CalculadoraAlimenticia.Domain.Interfaces;
using CalculadoraAlimenticia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAlimenticia.Application.Services
{
    public class CaloriasInseridasService : ICaloriasInseridasService
    {
        private readonly ICaloriasInseridasRepository _caloriasInseridasRepository;
        private readonly ILoginRepository _loginRepository;
        private readonly IAlimentosRepository _alimentosRepository;

        public CaloriasInseridasService(ICaloriasInseridasRepository caloriasInseridasRepository, IAlimentosRepository alimentosRepository, ILoginRepository loginRepository)
        {
            _caloriasInseridasRepository = caloriasInseridasRepository;
            _loginRepository = loginRepository;
            _alimentosRepository = alimentosRepository;
        }


        public async Task<bool> AddCalorias(CaloriasInseridasDTO calorias)
        {
            try
            {
                var existLogin = await _loginRepository.FindbyId(calorias.id_user);
                var existAlimento = await _alimentosRepository.FindById(calorias.id_alimento);
                if (existLogin != null && existAlimento != null)
                {

                    CaloriasInseridasModel caloriasModel = new CaloriasInseridasModel();

                    caloriasModel.data = calorias.data;
                    caloriasModel.quantidade = calorias.quantidade;
                    caloriasModel.id_user = calorias.id_user;
                    caloriasModel.id_alimento = calorias.id_alimento;

                    await _caloriasInseridasRepository.AddAsync(caloriasModel);
                    return true;

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

        public async Task<CaloriasInseridasDayDTO> getCaloriaperDay(DateTime data,int idUser)
        {
            try
            {
                var existLogin = await _loginRepository.FindbyId(idUser);
                CaloriasInseridasDayDTO caloriasInseridas = new CaloriasInseridasDayDTO();
                if (existLogin != null)
                {
                    var caloriasData = await _caloriasInseridasRepository.FindByData(data, idUser);

                    if (caloriasData.Count > 0)
                    {
                        foreach (var item in caloriasData)
                        {
                            AlimentosModel existAlimento = await _alimentosRepository.FindById(item.id_alimento);

                            var calorias = existAlimento.calorias / existAlimento.gramas_porcao;
                            var carbo = existAlimento.carbo / existAlimento.gramas_porcao;
                            var proteina = existAlimento.proteina / existAlimento.gramas_porcao;
                            var gordura = existAlimento.gordura / existAlimento.gramas_porcao ;
                            var gordurasaturada = existAlimento.gordura_saturada / existAlimento.gramas_porcao ;
                            var sodio = existAlimento.sodio / existAlimento.gramas_porcao;

                            caloriasInseridas.quantidadeCalorias += item.quantidade * calorias;
                            caloriasInseridas.quantidadeCarbo += item.quantidade * carbo;
                            caloriasInseridas.quantidadeProteina += item.quantidade * proteina;
                            caloriasInseridas.quantidadeGordura += item.quantidade * gordura;
                            caloriasInseridas.quantidadeGorduraSaturada += item.quantidade * gordurasaturada;
                            caloriasInseridas.quantidadeGorduraSodio += item.quantidade * sodio;
                        }
                        
                    }
                }
                

                return caloriasInseridas;

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
