using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class ModoDePreparoViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public short Ordem { get; set; }

        public ReceitaViewModel Receita { get; set; }
    }
}
