using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Dominio.Interfaces;
using Fiap.MasterChefe.Infra.Dados.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Fiap.MasterChefe.Infra.Dados.Repositorio
{
    public class ReceitaRepositorio : Repository<Receita>, IReceitaRepositorio
    {
        private Contexto _context;

        public ReceitaRepositorio(Contexto context) : base(context)
        {
            _context = context;       
        }

        public override IQueryable<Receita> GetAll()
        {
            var receitas = _context.Receita.Include(s => s.CategoriaReceita);
            return receitas;
        }

        public override Receita GetById(Guid id)
        {
            var receita = _context.Receita.Include(s => s.CategoriaReceita).Where(r => r.Id == id).FirstOrDefault();
            return receita;
        }

        public IQueryable<Receita> GetByCategoryId(Guid categoryId)
        {
            var receitas = _context.Receita.Include(s => s.CategoriaReceita).Where(r => r.CategoriaReceitaId == categoryId).AsQueryable();
            return receitas;
        }

    }
}
