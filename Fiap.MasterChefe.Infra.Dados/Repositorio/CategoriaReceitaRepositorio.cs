using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Infra.Dados.Repositorio
{
    public class CategoriaReceitaRepositorio : Repository<CategoriaReceita>, ICategoriaReceitaRepositorio
    {
        public CategoriaReceitaRepositorio(Contexto context) : base(context)
        {
        }
    }
}
