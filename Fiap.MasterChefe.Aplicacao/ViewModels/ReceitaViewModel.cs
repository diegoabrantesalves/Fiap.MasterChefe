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
        public string MododePreparo { get; set; }
        public List<IngredientesViewModel> Ingredientes { get; set; }
    }
}
