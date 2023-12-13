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
    public class AlimentosService : IAlimentosService
    {
        private readonly IAlimentosRepository _alimentos;

        public AlimentosService(IAlimentosRepository alimentos)
        {
            _alimentos = alimentos;
        }

        public async Task<bool> CreateAlimento(AlimentosDTO alimento)
        {
            try
            {
                var exist = await _alimentos.FindByNome(alimento.nome);
                if (exist == null)
                {
                    if (alimento != null)
                    {
                        AlimentosModel alimentoModel = new AlimentosModel();
                        
                        alimentoModel.nome = alimento.nome;
                        alimentoModel.proteina = alimento.proteina;
                        alimentoModel.carbo = alimento.carbo;
                        alimentoModel.calorias = alimento.calorias;
                        alimentoModel.gramas_porcao = alimento.gramas_porcao;
                        alimentoModel.gordura = alimento.gordura;
                        alimentoModel.gordura_saturada = alimento.gordura_saturada;
                        alimentoModel.sodio = alimento.sodio;

                        await _alimentos.AddAsync(alimentoModel);
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
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
