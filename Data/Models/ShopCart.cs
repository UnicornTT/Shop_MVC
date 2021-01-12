using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        //Узнать с какой корзиной работаем, или создать новую
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            //Если не существует карт id, мы создаем новый
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CardId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        //Добавить товар в корзину
        public void AddToCart(Paint paint)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                paint = paint,
                price = paint.price

            });

            appDBContent.SaveChanges();
        }

        //Отобразить товары в корзине
        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => ShopCartId == ShopCartId).Include(s => s.paint).ToList();
        }
    }
}
