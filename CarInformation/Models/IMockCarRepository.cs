using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInformation.Models
{
    public interface IMockCarRepository
    {
        List<CarModel> GetAllCarsDetails();

        IEnumerable<CarModel> GetCarDetails(string registrationNumber);
    }
}