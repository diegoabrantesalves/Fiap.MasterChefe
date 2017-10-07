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
    public class IngredienteAppService : IIngredienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IIngredienteRepositorio _ingredienteRepositorio;
        public IngredienteAppService(IMapper mapper, IIngredienteRepositorio ingredienteRepositorio)
        {
            _mapper = mapper;
            _ingredienteRepositorio = ingredienteRepositorio;
        }

        public IEnumerable<IngredienteViewModel> GetAll()
        {
            return _mapper.Map<List<IngredienteViewModel>>(_ingredienteRepositorio.GetAll());
        }

        public IngredienteViewModel GetById(Guid id)
        {
            return _mapper.Map<IngredienteViewModel>(_ingredienteRepositorio.GetById(id));
        }

        public void Add(IngredienteViewModel obj)
        {
            _ingredienteRepositorio.Add(_mapper.Map<Ingrediente>(_ingredienteRepositorio));
            _ingredienteRepositorio.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _ingredienteRepositorio.Remove(id);
            _ingredienteRepositorio.SaveChanges();
        }

        public void Update(IngredienteViewModel obj)
        {
            _ingredienteRepositorio.Add(_mapper.Map<Ingrediente>(_ingredienteRepositorio));
            _ingredienteRepositorio.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
