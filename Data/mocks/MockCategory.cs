using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IPaintsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Пейзаж", desc = "Изображение природы"},
                    new Category{categoryName = "Портрет", desc = "Изображение человека"}
                };
            }
        }
    }
}
