using AutoMapper;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using Fiap.MasterChefe.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CategoriaReceita, CategoriaReceitaViewModel>();
            CreateMap<Receita, ReceitaViewModel>();
            CreateMap<Ingrediente, IngredienteViewModel>();
            CreateMap<ModoDePreparo, ModoDePreparoViewModel>();
        }
    }
}
