using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController: Controller
    {
        private IAllPaints _paiRep;

        public HomeController(IAllPaints paiRep)
        {
            _paiRep = paiRep;
        }

        public ViewResult Index()
        {
            var homePaints = new HomeViewModel
            {
                favPaints = _paiRep.getFavPaints
            };
            return View(homePaints);
        }
    }
}
