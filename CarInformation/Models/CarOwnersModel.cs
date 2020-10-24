using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInformation.Models
{
    public class CarOwnersModel
    {
        public string OwnerName { get; set; }
        public DateTime OwnershipStartDate { get; set; }
        public DateTime OwnershipEndDate { get; set; }
    }
}