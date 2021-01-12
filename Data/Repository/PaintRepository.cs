using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class PaintRepository : IAllPaints
    {
        private readonly AppDBContent appDBContent;

        public PaintRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        //Получаем все данные, которые релевантны определенной категории
        public IEnumerable<Paint> Paints => appDBContent.Paint.Include(c => c.Category);

        //Получаем все данные, у которых Favorite = true
        public IEnumerable<Paint> getFavPaints => appDBContent.Paint.Where(p => p.isFavorite).Include(c => c.Category);

        //Получаем один объект, у которого id равен id, которое передали
        public Paint getObjectPaint(int paintId) => appDBContent.Paint.FirstOrDefault(p => p.id == paintId);
    }
}
