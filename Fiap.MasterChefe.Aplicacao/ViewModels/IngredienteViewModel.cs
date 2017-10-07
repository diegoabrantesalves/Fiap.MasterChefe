using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class IngredienteViewModel
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public ReceitaViewModel Receita { get; set; }
    }
}
