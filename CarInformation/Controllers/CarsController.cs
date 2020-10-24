using CarInformation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;

namespace CarInformation.Controllers
{
    public class CarsController : ApiController
    {
        private readonly IMockCarRepository mockCarRepository;

        public IEnumerable<CarModel> carData { get; set; }

        List<CarModel> carsData = new List<CarModel>();

        public CarsController()
        {
            this.mockCarRepository = new MockCarRepository();
        }

       
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetAllCarData()
        {
            try
            {
                carsData = mockCarRepository.GetAllCarsDetails();

            }
            catch
            {
                //Log Exception
            }

            return Json(carsData);
        }


        [System.Web.Http.HttpGet]
        public IHttpActionResult GetCarData(string registrationNumber)
        {
            try
            {
                carData = mockCarRepository.GetCarDetails(registrationNumber);
            }
            catch
            {
                //Log Exception
            }

            return Json(carData);
        }


    }
}
