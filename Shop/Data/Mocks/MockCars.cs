using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get 
            {
                return new List<Car>
                {
                    new Car 
                    { 
                        name = "Tesla Model S", 
                        shortDesc = "Быстрый автомобиль", 
                        img = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Tesla_Model_S_02_2013.jpg", 
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Telsa", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() 
                    }                    
                };
            }
                
        }
        public IEnumerable<Car> getFavsCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
