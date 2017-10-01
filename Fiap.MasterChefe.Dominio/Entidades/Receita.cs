using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Dominio.Entidades
{
    public class Receita
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int TempodePreparo { get; set; }
        public int Rendimento { get; set; }
        public string MododePreparo { get; set; }
        public List<Ingredientes> Ingredientes { get; set; }
    }
}
