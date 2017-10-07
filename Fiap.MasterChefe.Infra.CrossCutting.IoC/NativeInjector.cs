using AutoMapper;
using Fiap.MasterChefe.Aplicacao.Interfaces;
using Fiap.MasterChefe.Aplicacao.Services;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Context;
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
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IReceitaAppService, ReceitaAppService>();

            
            
            //Infra
            services.AddScoped<IReceitaRepositorio, ReceitaRepositorio>();
            services.AddScoped<Contexto>();
        }
    }
}
