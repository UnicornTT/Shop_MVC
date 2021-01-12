using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllPaints
    {
        IEnumerable<Paint> Paints { get; }
        IEnumerable<Paint> getFavPaints { get; }
        Paint getObjectPaint(int paintId);
    }
}
