using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    //Заполнение
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Category.Any())
                //Из функции получаем все объекты и записываем их как отдельные объекты
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Paint.Any())
            {
                content.AddRange(
                    new Paint
                    {
                        name = "The Starry Night",
                        author = "Vincent Willem van Gogh",
                        shortDesc = "",
                        longDesc = "The Starry Night is an oil on canvas painting by Dutch Post-Impressionist painter Vincent van Gogh. Painted in June 1889, it depicts the view from the east-facing window of his asylum room at Saint-Rémy-de-Provence, just before sunrise, with the addition of an imaginary village.",
                        img = "https://img2.goodfon.ru/original/1920x1408/0/aa/kartina-zvezdnaya-noch-van-goga.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["1"]
                    },
                    new Paint
                    {
                        name = "Composition 8",
                        author = "Vasily Kandinsky",
                        shortDesc = "",
                        longDesc = "This geometrical sort of painting was made in 1923 by Vasily Kandinsky. It was one of the best pieces of postwar by Vasily. Kandinsky also evolved an abstract style that reflected the utopian artistic experiments of the Russian avant-garde.",
                        img = "https://i1.wp.com/bookmypainting.com/wp-content/uploads/2019/06/composition-8-2.jpeg?resize=569%2C394&ssl=1",
                        price = 35000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["1"]
                    },
                    new Paint
                    {
                        name = "Beheading of Saint John the Baptist",
                        author = "Caravaggio",
                        shortDesc = "Italian artist Caravaggio made this Oil painting. This masterpiece is also considered one of the most important works in Western painting. The painting shows also different sides of death and human cruelty and how it’s scale and shadow daunt and possess humans nowadays. This painting was completed in 1608 and was celebrated worldwide by its a clear depiction of the dark world too.",
                        longDesc = "",
                        img = "https://i2.wp.com/bookmypainting.com/wp-content/uploads/2019/06/beheading-of-saint-john-the-baptist-the-famous-pai-2.jpeg?resize=555%2C385&ssl=1",
                        price = 37000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["2"]
                    },
                    new Paint
                    {
                        name = "Luncheon on the Boating Party",
                        author = "Pierre-Auguste Renoir",
                        shortDesc = "",
                        longDesc = "The Luncheon on the boating party is one of the most famous paintings made in 1881 by the French painter Pierre-Auguste Renoir. This Painting was also one of the best painting in the Seventh Impressionist Exhibition in 1882. This painting is a true example of wealthiness, the beautiful impression of strokes and also an amazing art style.",
                        img = "https://i0.wp.com/bookmypainting.com/wp-content/uploads/2019/06/luncheon-on-the-boating-party-1.jpeg?resize=613%2C453&ssl=1",
                        price = 42000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["2"]
                    },
                    new Paint
                    {
                        name = "No. 5, 1948",
                        author = "Jackson Pollock",
                        shortDesc = "",
                        longDesc = "One of the most priced painting by Jackson Pollock, an American painter also not surpassed until April 2011. The painting was made from liquid colors and is one kind of an abstract art sold at a whopping price of $140 million. It was also painted on the fibreboard with different hues of brown, grey, white and yellow paint all mixed up together forming the shape of a bird’s nest.",
                        img = "https://i0.wp.com/bookmypainting.com/wp-content/uploads/2019/06/no-5-1948-2.jpeg?resize=519%2C292&ssl=1",
                        price = 15000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["1"]
                    },
                    new Paint
                    {
                        name = "Water Lilies",
                        author = "Claude Monet",
                        shortDesc = "",
                        longDesc = "",
                        img = "https://i0.wp.com/bookmypainting.com/wp-content/uploads/2019/06/the-lillies-the-famous-painting-2.jpeg?resize=515%2C428&ssl=1",
                        price = 39000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["1"]
                    }
                    );
            }
            
            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {   //Проверяем заполненна ли переменная
                if(category == null)
                {   //Создаем список и помещаем туда котегории
                    var list = new Category[]
                    {
                        new Category{categoryName = "Пейзаж", desc = "Изображение природы"},
                        new Category{categoryName = "Портрет", desc = "Изображение человека"}
                    };
                    //Выделяем память
                    category = new Dictionary<string, Category>();
                    //Добаляем элементы
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
