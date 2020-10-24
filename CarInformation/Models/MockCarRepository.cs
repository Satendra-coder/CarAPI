using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace CarInformation.Models
{
    public class MockCarRepository : IMockCarRepository
    {
        List<CarModel> carDetails;
        public MockCarRepository()
        {
            carDetails = new List<CarModel>()
            { 
                new CarModel
                {
                    RegistartionNumber = "HC1234567",
                    CompanyName = "Honda",
                    ModelName = "City",
                    InsuranceStatus = "Valid",
                    AccidentDetails = new List<AccidentModel>()
                    {
                        new AccidentModel { AccidentType = "Minor", AccidentDate = DateTime.Now /*using this date to mock up the data*/},
                        new AccidentModel { AccidentType = "Major", AccidentDate = DateTime.Now }
                    },
                    Owners = new List<CarOwnersModel>()
                    {
                        new CarOwnersModel { OwnerName  = "Pankaj Tripathi", OwnershipStartDate = DateTime.Now , OwnershipEndDate = DateTime.Now}
                    }
                },
                 new CarModel
                {
                    RegistartionNumber = "TN37423828",
                    CompanyName = "Tata",
                    ModelName = "Nexon",
                    InsuranceStatus = "Valid",
                    AccidentDetails = new List<AccidentModel>()
                    {
                        new AccidentModel { AccidentType = "Critical", AccidentDate = DateTime.Now /*using this date to mock up the data*/},
                        new AccidentModel { AccidentType = "Major", AccidentDate = DateTime.Now }
                    },
                    Owners = new List<CarOwnersModel>()
                    {
                        new CarOwnersModel { OwnerName  = "Ankit Sharma", OwnershipStartDate = DateTime.Now , OwnershipEndDate = DateTime.Now}
                    }
                },
                  new CarModel
                {
                    RegistartionNumber = "HV09302385",
                    CompanyName = "Hyundai",
                    ModelName = "Verna",
                    InsuranceStatus = "Invalid",
                    AccidentDetails = new List<AccidentModel>()
                    {
                        new AccidentModel { AccidentType = "Minor", AccidentDate = DateTime.Now /*using this date to mock up the data*/},
                        new AccidentModel { AccidentType = "Critical", AccidentDate = DateTime.Now }
                    },
                    Owners = new List<CarOwnersModel>()
                    {
                        new CarOwnersModel { OwnerName  = "Nilesh Singh", OwnershipStartDate = DateTime.Now , OwnershipEndDate = DateTime.Now}
                    }
                }
            };
        }

        public List<CarModel> GetAllCarsDetails()
        {
            List<CarModel> carDetail = new List<CarModel>();

            try
            {
                if (carDetails != null)
                    return carDetails;
                else
                    return null;
            }
            catch (Exception ex)
            {
                //Log Exception
            }

            return carDetail;
        }

        public IEnumerable<CarModel> GetCarDetails(string registrationNumber)
        {
            IEnumerable<CarModel> carDetail = null;
            try
            {
                carDetail = from car in carDetails
                            where car.RegistartionNumber.ToUpper() == registrationNumber.ToUpper()
                            select car;
            }
            catch(Exception ex)
            {
                //Log Exception
            }

            return carDetail;
        }

    }
}
