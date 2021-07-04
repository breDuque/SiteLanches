using Microsoft.AspNetCore.Mvc;
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

        public IActionResult List()
        {
            ViewBag.Lanche = "Laches";
            ViewData["Categoria"] = "Categoria";

            var lanchesListiewModel = new LancheListViewModel();
            lanchesListiewModel.Lanches = _lancheRepository.Lanches;
            lanchesListiewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListiewModel);
        }
    }
}