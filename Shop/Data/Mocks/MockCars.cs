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
                        img = "/img/tesla.jpg", 
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Telsa", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car
                    {
                        name = "Lada Vesta",
                        shortDesc = "Тихий спокойный",
                        img = "/img/vesta.jpg",
                        longDesc = "Удобный автомобиль для городской жизни",
                        price = 10000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Lada Granta",
                        shortDesc = "Городской, простой автомобиль",
                        img = "/img/granta.jpg",
                        longDesc = "Удобный автомобиль легко ремонтировать",
                        price = 25000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Городской автомобиль",
                        img = "/img/leaf.jpg",
                        longDesc = "Городской элекромобиль, очень удобный",
                        price = 20000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }

                };
            }
                
        }
        public IEnumerable<Car> getFavsCars => Cars.Where(p => p.isFavourite);

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
