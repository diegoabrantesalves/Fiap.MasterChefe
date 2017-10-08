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
    public class CategoriaReceitaAppService : ICategoriaReceitaAppService
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaReceitaRepositorio _categoriaReceitaRepositorio;

        public CategoriaReceitaAppService(IMapper mapper, ICategoriaReceitaRepositorio categoriaReceitaRepositorio)
        {
            _mapper = mapper;
            _categoriaReceitaRepositorio = categoriaReceitaRepositorio;
        }

        public IEnumerable<CategoriaReceitaViewModel> GetAll()
        {
            return _mapper.Map<List<CategoriaReceitaViewModel>>(_categoriaReceitaRepositorio.GetAll());
        }

        public CategoriaReceitaViewModel GetById(Guid id)
        {
            return _mapper.Map<CategoriaReceitaViewModel>(_categoriaReceitaRepositorio.GetById(id));
        }

        public void Add(CategoriaReceitaViewModel obj)
        {
            _categoriaReceitaRepositorio.Add(_mapper.Map<CategoriaReceita>(obj));
            _categoriaReceitaRepositorio.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _categoriaReceitaRepositorio.Remove(id);
            _categoriaReceitaRepositorio.SaveChanges();
        }

        public void Update(CategoriaReceitaViewModel obj)
        {
            _categoriaReceitaRepositorio.Update(_mapper.Map<CategoriaReceita>(obj));
            _categoriaReceitaRepositorio.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
