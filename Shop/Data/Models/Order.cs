using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string address { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина телефона не менее 10 знаков")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина email не менее 15 знаков")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
