using System;
using System.Collections.Generic;
using System.Text;
using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Context;

namespace Fiap.MasterChefe.Infra.Dados.Repositorio
{
    public class IngredienteRepositorio : Repository<Ingrediente>, IIngredienteRepositorio
    {
        public IngredienteRepositorio(Contexto context) : base(context)
        {
        }
    }
}
