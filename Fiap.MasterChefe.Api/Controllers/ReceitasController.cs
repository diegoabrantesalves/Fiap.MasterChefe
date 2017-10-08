using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Web.Http;
using Fiap.MasterChefe.Dominio.Entidades;
using Fiap.MasterChefe.Aplicacao.Services;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using System.Net;
using System.Net.Http;

namespace Fiap.MasterChefe.Api.Controllers
{
    [Produces("application/json")]
    [Microsoft.AspNetCore.Mvc.Route("api/Receitas")]
    public class ReceitasController : ApiController
    {
        private ReceitaAppService receitaService;

        private ReceitasController(ReceitaAppService receitaService) {

        }

        public IEnumerable<ReceitaViewModel> GetAllProdutos()
        {
            return receitaService.GetAll();
        }

        public ReceitaViewModel GetProduto(Guid id)
        {
            ReceitaViewModel item = receitaService.GetById(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<ReceitaViewModel> GetReceitasPorDescricao(string categoria)
        {
            return receitaService.GetAll().Where(
                p => string.Equals(p.Descricao, categoria, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage PostProduto(ReceitaViewModel item)
        {
            receitaService.Add(item);
            var response = Request.CreateResponse<ReceitaViewModel>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutProduto(Guid id, ReceitaViewModel produto)
        {
            produto.Id = id;
        }

        public void DeleteProduto(Guid id)
        {
            ReceitaViewModel item = receitaService.GetById(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            receitaService.Remove(id);
        }
    }
}

