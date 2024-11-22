using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal  _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car) 
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                 _carDal.Add(car);
                
            }
            else
            {
                Console.WriteLine("Sisteme Eklenemedi.");
            }
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll(); 
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandİd(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId == colorId);
        }
    }
}
