using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiap.MasterChefe.Aplicacao.ViewModels
{
    public class CategoriaReceitaViewModel
    {
        [Display(Name="Código")]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Descricao { get; set; }

        [Display(Name = "Exibe na Home Page?")]
        public bool ExibirTelaPrincipal { get; set; }

        [Display(Name = "Nome da imagem")]
        public string UrlImagem { get; set; }

        public List<ReceitaViewModel> Receitas { get; set; }
    }
}
