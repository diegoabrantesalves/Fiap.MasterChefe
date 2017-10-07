using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.Interfaces
{
    public interface IAppService<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Update(TEntity obj);
        void Remove(Guid id);
    }
}
