using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fiap.MasterChefe.Aplicacao.ViewModels;
using Fiap.MasterChefe.Aplicacao.Interfaces;

namespace Fiap.MasterChefe.Web.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly IReceitaAppService _receitaAppService;
        private readonly ICategoriaReceitaAppService _categoriaAppService;

        public ReceitasController(IReceitaAppService receitaAppService, ICategoriaReceitaAppService categoriaAppService)
        {
            _receitaAppService = receitaAppService;
            _categoriaAppService = categoriaAppService;
        }

        // GET: Receitas
        public ActionResult Index()
        {
            return View(_receitaAppService.GetAll());
        }

        // GET: Receitas/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receitaViewModel = _receitaAppService.GetById(id.Value);
            if (receitaViewModel == null)
            {
                return NotFound();
            }

            return View(receitaViewModel);
        }

        // GET: Receitas/Create
        public IActionResult Create()
        {
            ViewBag.Categorias = _categoriaAppService.GetAll();
            return View();
        }

        // POST: Receitas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReceitaViewModel receitaViewModel)
        {
            if (ModelState.IsValid)
            {
                receitaViewModel.Id = Guid.NewGuid();
                _receitaAppService.Add(receitaViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(receitaViewModel);
        }

        // GET: Receitas/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Categorias = _categoriaAppService.GetAll();
            var receitaViewModel = _receitaAppService.GetById(id.Value);
            if (receitaViewModel == null)
            {
                return NotFound();
            }
            return View(receitaViewModel);
        }

        // POST: Receitas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, ReceitaViewModel receitaViewModel)
        {
            if (id != receitaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _receitaAppService.Update(receitaViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitaViewModelExists(receitaViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(receitaViewModel);
        }

        // GET: Receitas/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receitaViewModel = _receitaAppService.GetById(id.Value);
            if (receitaViewModel == null)
            {
                return NotFound();
            }

            return View(receitaViewModel);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var receitaViewModel = _receitaAppService.GetById(id);
            _receitaAppService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitaViewModelExists(Guid id)
        {
            return _receitaAppService.GetById(id) != null;
        }
    }
}
