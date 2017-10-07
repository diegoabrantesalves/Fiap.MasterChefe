using Fiap.MasterChefe.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.Interfaces
{
   public interface IReceitaAppService:IDisposable
    {
        void Add(ReceitaViewModel receitaViewModel);
        IEnumerable<ReceitaViewModel> GetAll();
        ReceitaViewModel GetById(Guid id);
        void Update(ReceitaViewModel receitaViewModel);
        void Remove(Guid id);

    }
}
