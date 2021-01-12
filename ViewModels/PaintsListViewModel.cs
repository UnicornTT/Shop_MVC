using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    //Создается объект, включающий несколько картин для передачи на view
    public class PaintsListViewModel
    {
        public IEnumerable<Paint> AllPaints { get; set; }

        public string currCategory { get; set; }
    }
}
