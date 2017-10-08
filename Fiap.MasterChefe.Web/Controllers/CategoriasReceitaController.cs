using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiap.MasterChefe.Aplicacao.Interfaces;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Fiap.MasterChefe.Web.Controllers
{
    public class CategoriasReceitaController : Controller
    {
        private ICategoriaReceitaAppService _categoriaReceitaAppService;

        public CategoriasReceitaController(ICategoriaReceitaAppService categoriaReceitaAppService)
        {
            _categoriaReceitaAppService = categoriaReceitaAppService;
        }

        public ActionResult Index()
        {
            return View(_categoriaReceitaAppService.GetAll());
        }

        public ActionResult Details(Guid? id)
        {
            if (id == null)
                return NotFound();

            var model = _categoriaReceitaAppService.GetById(id.Value);
            if (model == null)
                return NotFound();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Descricao,TempodePreparo,Rendimento,MododePreparo")] CategoriaReceitaViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _categoriaReceitaAppService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public ActionResult Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var model = _categoriaReceitaAppService.GetById(id.Value);
            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, [Bind("Id,Descricao,TempodePreparo,Rendimento,MododePreparo")] CategoriaReceitaViewModel model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _categoriaReceitaAppService.Update(model);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaReceitaViewModelExists(model.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var model = _categoriaReceitaAppService.GetById(id.Value);
            if (model == null)
                return NotFound();

            return View(model);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var model = _categoriaReceitaAppService.GetById(id);
            _categoriaReceitaAppService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaReceitaViewModelExists(Guid id)
        {
            return _categoriaReceitaAppService.GetById(id) != null;
        }
    }
}