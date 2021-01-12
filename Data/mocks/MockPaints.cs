using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockPaints : IAllPaints
    {
        private readonly IPaintsCategory _categoryPaints = new MockCategory();
        public IEnumerable<Paint> Paints
        {
            get
            {
                return new List<Paint>
                {
                    new Paint {
                    name = "Звездная ночь",
                    author = "Ван Гог",
                    shortDesc = "",
                    longDesc = "",
                    img = "https://img2.goodfon.ru/original/1920x1408/0/aa/kartina-zvezdnaya-noch-van-goga.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryPaints.AllCategories.First()
                    },
                    new Paint {
                    name = "Звездная ночь",
                    author = "Ван Гог",
                    shortDesc = "",
                    longDesc = "",
                    img = "https://img2.goodfon.ru/original/1920x1408/0/aa/kartina-zvezdnaya-noch-van-goga.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryPaints.AllCategories.First()
                    },
                    new Paint {
                    name = "Звездная ночь",
                    author = "Ван Гог",
                    shortDesc = "",
                    longDesc = "",
                    img = "https://img2.goodfon.ru/original/1920x1408/0/aa/kartina-zvezdnaya-noch-van-goga.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryPaints.AllCategories.First()
                    },
                    new Paint {
                    name = "Звездная ночь",
                    author = "Ван Гог",
                    shortDesc = "",
                    longDesc = "",
                    img = "https://img2.goodfon.ru/original/1920x1408/0/aa/kartina-zvezdnaya-noch-van-goga.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryPaints.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Paint> getFavPaints { get; set; }

        public Paint getObjectPaint(int paintId)
        {
            throw new NotImplementedException();
        }
    }
}
