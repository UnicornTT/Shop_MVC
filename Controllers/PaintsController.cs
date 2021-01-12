using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class PaintsController: Controller
    {
        private readonly IAllPaints _allPaints;
        private readonly IPaintsCategory _allCategories;

        public PaintsController(IAllPaints iAllPaints, IPaintsCategory iPaintsCat)
        {
            _allPaints = iAllPaints;
            _allCategories = iPaintsCat;
        }

        public ViewResult Index()
        {
            PaintsListViewModel obj = new PaintsListViewModel();
            obj.AllPaints = _allPaints.Paints;
            obj.currCategory = "Картины";
            return View(obj);
        }
        [Route("Paints/Products")]
        [Route("Paints/Products/{category}")]
        public ViewResult Products(string category)
        {
            string _category = category;
            IEnumerable<Paint> paints = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                paints = _allPaints.Paints.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("1", category, StringComparison.OrdinalIgnoreCase))
                {
                    paints = _allPaints.Paints.Where(i => i.Category.categoryName.Equals("Пейзаж")).OrderBy(i => i.id);
                }
                else if (string.Equals("2", category, StringComparison.OrdinalIgnoreCase))
                {
                    paints = _allPaints.Paints.Where(i => i.Category.categoryName.Equals("Портрет")).OrderBy(i => i.id);
                }

                currCategory = _category;

            }

            var paintObj = new PaintsListViewModel
            {
                AllPaints = paints,
                currCategory = currCategory
            };

            PaintsListViewModel obj = new PaintsListViewModel();
            obj.AllPaints = _allPaints.Paints;
            obj.currCategory = "Картины";
            return View(paintObj);
        }
        public ViewResult Blog()
        {
            PaintsListViewModel obj = new PaintsListViewModel();
            obj.AllPaints = _allPaints.Paints;
            obj.currCategory = "Картины";
            return View(obj);
        }
        public ViewResult Contacts()
        {
            PaintsListViewModel obj = new PaintsListViewModel();
            obj.AllPaints = _allPaints.Paints;
            obj.currCategory = "Картины";
            return View(obj);
        }
        public ViewResult List()
        {
            PaintsListViewModel obj = new PaintsListViewModel();
            obj.AllPaints = _allPaints.Paints;
            obj.currCategory = "Картины";
            return View(obj);
        }
        
    }
}
