using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Aplicacao.Services;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using System.Net;
using System.Net.Http;
using Fiap.MasterChefe.Aplicacao.Interfaces;

namespace Fiap.MasterChefe.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReceitasController : Controller
    {
        private readonly IReceitaAppService _receitaService;

        public ReceitasController(IReceitaAppService receitaService)
        {
            _receitaService = receitaService;
        }
        [HttpGet]
        public IEnumerable<ReceitaViewModel> GetAll()
        {
            return _receitaService.GetAll();
        }

        [HttpGet]
        public ReceitaViewModel GetProduto(Guid id)
        {
            ReceitaViewModel item = _receitaService.GetById(id);
            if (item == null)
            {
                return null;
            }
            return item;
        }
        [HttpGet]
        public IEnumerable<ReceitaViewModel> GetReceitasPorDescricao(string categoria)
        {
            return _receitaService.GetAll().Where(
                p => string.Equals(p.Descricao, categoria, StringComparison.OrdinalIgnoreCase));
        }
        [HttpPost]
        public HttpResponseMessage PostProduto(ReceitaViewModel item)
        {
            _receitaService.Add(item);
            var response = item;
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        [HttpPut]
        public void PutProduto(Guid id, ReceitaViewModel produto)
        {
            produto.Id = id;
        }
        [HttpDelete]
        public void DeleteProduto(Guid id)
        {
            ReceitaViewModel item = _receitaService.GetById(id);
            if (item == null)
            {
                return;
            }
            _receitaService.Remove(id);
        }
    }
}

