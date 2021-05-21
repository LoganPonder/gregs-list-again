using System;
using System.Collections.Generic;
using gregs_list_again.DB;
using gregs_list_again.Models;

namespace gregs_list_again.Services
{
    public class CarsService
    {
        // REVIEW what does the next line mean?;
        internal IEnumerable<Car> GetAll()
        {
            return FakeDB.Cars;
        }

        internal Car GetCarById(string id)
        {
            Car found = FakeDB.Cars.Find(c => c.Id == id);
            if(found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Car CreateCar(Car newCar)
        {
            FakeDB.Cars.Add(newCar);
            return newCar;
        }

        internal Car EditCar(Car editCar)
        {
            Car oldCar = GetCarById(editCar.Id);
            oldCar.ImgUrl = editCar.ImgUrl;
            oldCar.Title = editCar.Title;
            oldCar.Year = editCar.Year;
            oldCar.Price = editCar.Price;

            return oldCar;
        }
        // REVIEW why is this one 
        internal void DeleteCar(string id)
        {
            Car found = GetCarById(id);
            FakeDB.Cars.Remove(found);
        }
    }
}