﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (SqlServerContext context = new SqlServerContext())
            {
               

                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using (SqlServerContext context = new SqlServerContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (SqlServerContext context = new SqlServerContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (SqlServerContext context = new SqlServerContext())
            {
                return filter == null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (SqlServerContext context = new SqlServerContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
