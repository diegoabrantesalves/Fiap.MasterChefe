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
    public class ModoDePreparoAppService : IModoDePreparoAppService
    {
        private readonly IMapper _mapper;
        private readonly IModoDePreparoRepositorio _modoDePreparoRepositorio;
        public ModoDePreparoAppService(IMapper mapper, IModoDePreparoRepositorio modoDePreparoRepositorio)
        {
            _mapper = mapper;
            _modoDePreparoRepositorio = modoDePreparoRepositorio;
        }

        public IEnumerable<ModoDePreparoViewModel> GetAll()
        {
            return _mapper.Map<List<ModoDePreparoViewModel>>(_modoDePreparoRepositorio.GetAll());
        }

        public ModoDePreparoViewModel GetById(Guid id)
        {
            return _mapper.Map<ModoDePreparoViewModel>(_modoDePreparoRepositorio.GetById(id));
        }

        public void Add(ModoDePreparoViewModel obj)
        {
            _modoDePreparoRepositorio.Add(_mapper.Map<ModoDePreparo>(_modoDePreparoRepositorio));
            _modoDePreparoRepositorio.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _modoDePreparoRepositorio.Remove(id);
            _modoDePreparoRepositorio.SaveChanges();
        }

        public void Update(ModoDePreparoViewModel obj)
        {
            _modoDePreparoRepositorio.Add(_mapper.Map<ModoDePreparo>(_modoDePreparoRepositorio));
            _modoDePreparoRepositorio.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
