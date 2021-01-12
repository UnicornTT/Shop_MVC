using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(4)]
        [Required(ErrorMessage ="Имя должно быть не короче 4 символов")]

        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(4)]
        [Required(ErrorMessage = "Фамилия должна быть не короче 4 символов")]

        public string surname { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(8)]
        [Required(ErrorMessage = "Адрес должен быть не короче 8 символов")]

        public string adress { get; set; }
        [Display(Name = "Введите телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(8)]
        [Required(ErrorMessage = "Телефон должен быть не короче 8 символов")]

        public string phone { get; set; }
        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(8)]
        [Required(ErrorMessage = "Email должен быть не короче 8 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
