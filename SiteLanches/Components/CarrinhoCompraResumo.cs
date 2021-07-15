using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SiteLanches.Models;
using SiteLanches.ViewModels;

namespace SiteLanches.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            //var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            var itens = new List<CarrinhoCompraItem>() {new CarrinhoCompraItem(), new CarrinhoCompraItem()};
            _carrinhoCompra.CarrinhoCompraItens = itens;
            var carrinhoCompraVm = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            
            return View(carrinhoCompraVm);
        }
    }
}