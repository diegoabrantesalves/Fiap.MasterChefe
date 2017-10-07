using AutoMapper;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using Fiap.MasterChefe.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.AutoMapper
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriaReceitaViewModel, CategoriaReceita>();
            CreateMap<ReceitaViewModel, Receita>();
            CreateMap<IngredienteViewModel,Ingrediente>();
            CreateMap<ModoDePreparoViewModel, ModoDePreparo>();
        }
    }
}
