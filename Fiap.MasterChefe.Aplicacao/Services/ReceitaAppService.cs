using Fiap.MasterChefe.Aplicacao.Interfaces;
using Fiap.MasterChefe.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.Services
{
   public class ReceitaAppService: IReceitaAppService
    {
        private readonly IReceitaRepositorio _receitaRepositorio;
        public ReceitaAppService(IReceitaRepositorio receitaRepositorio)
        {
                
        }
    }
}
