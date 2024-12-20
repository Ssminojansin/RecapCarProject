﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandİd(int brandId);
        List<Car> GetCarsByColorId(int ColorId);
        List<Car> GetByDailyPrice(decimal min , decimal max);
    }
}
