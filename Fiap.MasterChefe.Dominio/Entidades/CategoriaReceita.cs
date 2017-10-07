using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Dominio.Entidades
{
    public class CategoriaReceita
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool ExibirTelaPrincipal { get; set; }

        public ICollection<Receita> Receitas { get; set; }
    }
}
