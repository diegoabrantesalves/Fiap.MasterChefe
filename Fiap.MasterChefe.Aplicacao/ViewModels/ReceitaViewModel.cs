using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class ReceitaViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int TempodePreparo { get; set; }
        public int Rendimento { get; set; }

        public CategoriaReceitaViewModel CategoriaReceita { get; set; }
        public List<IngredienteViewModel> Ingredientes { get; set; }
        public List<ModoDePreparoViewModel> ModosDePreparo { get; set; }
    }
}
