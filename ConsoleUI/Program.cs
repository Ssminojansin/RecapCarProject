using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName );
            }

            carManager.Add(new Car {BrandId=2,ColorId=4,CarName = "Ds",DailyPrice=4500,Descriptions="Elektrikli",ModelYear=2025 } );

            
        }
    }
}
