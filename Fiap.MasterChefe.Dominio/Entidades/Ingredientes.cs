using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Dominio.Entidades
{
    public class Ingredientes
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public Receita Receita { get; set; }
    }
}
