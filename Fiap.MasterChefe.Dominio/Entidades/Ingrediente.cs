using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Dominio.Entidades
{
    public class Ingrediente
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public Receita Receita { get; set; }
    }
}
