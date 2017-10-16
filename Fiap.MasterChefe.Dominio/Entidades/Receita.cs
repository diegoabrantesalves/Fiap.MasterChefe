using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Dominio.Entidades
{
    public class Receita
    {
        public Guid Id { get; set; }
        public Guid CategoriaReceitaId { get; set; }
        public string Descricao { get; set; }
        public int TempodePreparo { get; set; }
        public int Rendimento { get; set; }
        public string Ingrediente { get; set; }
        public string ModoDePreparo { get; set; }

        public CategoriaReceita CategoriaReceita { get; set; }
        public ICollection<Ingrediente> Ingredientes { get; set; }
        public ICollection<ModoDePreparo> ModosDePreparo { get; set; }
    }
}
