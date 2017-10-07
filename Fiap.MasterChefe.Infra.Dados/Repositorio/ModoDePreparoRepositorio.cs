using System;
using System.Collections.Generic;
using System.Text;
using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Context;

namespace Fiap.MasterChefe.Infra.Dados.Repositorio
{
    public class ModoDePreparoRepositorio : Repository<ModoDePreparo>, IModoDePreparoRepositorio
    {
        public ModoDePreparoRepositorio(Contexto context) : base(context)
        {
        }
    }
}
