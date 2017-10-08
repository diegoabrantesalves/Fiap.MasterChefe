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
            services.AddScoped<ICategoriaReceitaAppService, CategoriaReceitaAppService>();
            services.AddScoped<IReceitaAppService, ReceitaAppService>();
            services.AddScoped<IIngredienteAppService, IngredienteAppService>();
            services.AddScoped<IModoDePreparoAppService, ModoDePreparoAppService>();

            //Infra
            services.AddScoped<ICategoriaReceitaRepositorio, CategoriaReceitaRepositorio>();
            services.AddScoped<IReceitaRepositorio, ReceitaRepositorio>();
            services.AddScoped<IIngredienteRepositorio, IngredienteRepositorio>();
            services.AddScoped<IModoDePreparoRepositorio, ModoDePreparoRepositorio>();
            services.AddScoped<Contexto>();
        }
    }
}
