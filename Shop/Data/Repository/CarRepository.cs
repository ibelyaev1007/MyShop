using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDbContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavsCars => appDbContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carID) => appDbContent.Car.FirstOrDefault(p => p.id == carID);
    }
}
