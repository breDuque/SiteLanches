using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteLanches.Repositories.RepositoriesInterfaces;
using SiteLanches.ViewModels;

namespace SiteLanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILogger<HomeController> logger, ILancheRepository lancheRepository)
        {
            _logger = logger;
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel {LanchesPreferidos = _lancheRepository.LanchesPreferidos};
            return View(homeViewModel);
        }

    }
}