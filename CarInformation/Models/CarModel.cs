using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInformation.Models
{
    public class CarModel
    {
        public string RegistartionNumber { get; set; }
        public string ModelName { get; set; }
        public string CompanyName { get; set; }
        public string InsuranceStatus { get; set; }
        public List<CarOwnersModel> Owners { get; set; }
        public List<AccidentModel> AccidentDetails { get; set; }
    }
}
