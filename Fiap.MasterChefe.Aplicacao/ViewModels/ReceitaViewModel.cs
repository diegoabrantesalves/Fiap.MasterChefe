﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class ReceitaViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Categoria")]
        public Guid CategoriaReceitaId { get; set; }

        [Display(Name = "Nome")]
        public string Descricao { get; set; }

        [Display(Name = "Tempo de Preparo")]
        public int TempodePreparo { get; set; }

        [Display(Name = "Rendimento")]
        public int Rendimento { get; set; }

        [Display(Name = "Ingredientes")]
        public string Ingrediente { get; set; }

        [Display(Name = "Modo de Preparo")]
        public string ModoDePreparo { get; set; }

        public CategoriaReceitaViewModel CategoriaReceita { get; set; }

        //public List<IngredienteViewModel> Ingredientes { get; set; }
        //public List<ModoDePreparoViewModel> ModosDePreparo { get; set; }
    }
}
