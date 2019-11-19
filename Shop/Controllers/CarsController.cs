using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Controllers
{
    public class CarsController: Controller
    {

        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory icarsCategory)
        {
            allCars = iAllCars;
            allCategory = icarsCategory;
        }

        public ViewResult List()
        {
            var cars = allCars.Cars;
            return View(cars);
        }
    }
}
