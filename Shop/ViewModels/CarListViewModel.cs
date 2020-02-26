using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string carCategory { get; set; }
    }
}
