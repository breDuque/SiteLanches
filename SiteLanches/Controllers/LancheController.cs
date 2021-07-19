using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SiteLanches.Models;
using SiteLanches.Repositories.RepositoriesInterfaces;
using SiteLanches.ViewModels;

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

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches.Where(l => string.Equals(l.Categoria.Nome, categoria, StringComparison.OrdinalIgnoreCase)).OrderBy(l => l.Nome);
                categoriaAtual = categoria;
            }

            var lanchesListiewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual.ToUpper()
            };
            return View(lanchesListiewModel);
        }
    }
}