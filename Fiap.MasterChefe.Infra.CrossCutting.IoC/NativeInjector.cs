using Fiap.MasterChefe.Aplicacao.Interfaces;
using Fiap.MasterChefe.Aplicacao.Services;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Infra.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //Aplicação
            services.AddScoped<IReceitaAppService, ReceitaAppService>();


            //Infra
            services.AddScoped<IReceitaRepositorio, ReceitaRepositorio>();
        }
    }
}
