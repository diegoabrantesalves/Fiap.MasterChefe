using Fiap.MasterChefe.Aplicacao.Interfaces;
using Fiap.MasterChefe.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using AutoMapper;
using Fiap.MasterChefe.Dominio.Entidades;

namespace Fiap.MasterChefe.Aplicacao.Services
{
   public class ReceitaAppService: IReceitaAppService
    {
        private readonly IMapper _mapper;
        private readonly IReceitaRepositorio _receitaRepositorio;
        public ReceitaAppService(IMapper mapper, IReceitaRepositorio receitaRepositorio)
        {
            _mapper = mapper;
            _receitaRepositorio = receitaRepositorio;
        }


        public IEnumerable<ReceitaViewModel> GetAll()
        {
            return _mapper.Map<List<ReceitaViewModel>>(_receitaRepositorio.GetAll()); 
        }

        public ReceitaViewModel GetById(Guid id)
        {
            return _mapper.Map<ReceitaViewModel>(_receitaRepositorio.GetById(id));
        }

        public void Add(ReceitaViewModel receitaViewModel)
        {
            _receitaRepositorio.Add(_mapper.Map<Receita>(receitaViewModel));
            _receitaRepositorio.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _receitaRepositorio.Remove(id);
            _receitaRepositorio.SaveChanges();
        }

        public void Update(ReceitaViewModel receitaViewModel)
        {
            _receitaRepositorio.Add(_mapper.Map<Receita>(receitaViewModel));
            _receitaRepositorio.SaveChanges();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
