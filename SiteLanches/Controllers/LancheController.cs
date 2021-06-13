using Microsoft.AspNetCore.Mvc;
using SiteLanches.Repositories;
using SiteLanches.Repositories.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List()
        {
            ViewBag.Lanche = "Laches";
            ViewData["Categoria"] = "Categoria";

            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
