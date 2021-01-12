using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ShopCartController: Controller
    {
        private IAllPaints _paiRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllPaints paiRep, ShopCart shopCart)
        {
            _paiRep = paiRep;
            _shopCart = shopCart;
        }

        public ViewResult Cart()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            //Выбирает нужный товар по его id
            var item = _paiRep.Paints.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Cart");
        }
    }
}
