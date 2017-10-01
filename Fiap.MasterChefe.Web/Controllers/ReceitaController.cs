using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fiap.MasterChefe.Aplicacao.Interfaces;

namespace Fiap.MasterChefe.Web.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly IReceitaAppService _receitaAppService;
        public ReceitaController(IReceitaAppService receitaAppService)
        {
            _receitaAppService = receitaAppService;  
        }
        // GET: Receita
        public ActionResult Index()
        {
            return View();
        }

        // GET: Receita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Receita/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receita/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Receita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Receita/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Receita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Receita/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}