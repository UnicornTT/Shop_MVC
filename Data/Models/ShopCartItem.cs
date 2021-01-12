﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Paint paint { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
