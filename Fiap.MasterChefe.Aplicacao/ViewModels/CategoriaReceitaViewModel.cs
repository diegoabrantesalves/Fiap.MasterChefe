using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class CategoriaReceitaViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool ExibirTelaPrincipal { get; set; }

        public List<ReceitaViewModel> Receitas { get; set; }
    }
}
