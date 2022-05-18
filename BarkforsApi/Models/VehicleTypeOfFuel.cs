using System;
using System.Collections.Generic;
using System.Text;

namespace BarkforsApi.Models
{
    public class VehicleTypeOfFuel
    {
        public TypesOfFuel SelectesFuelType { get; set; }
        public VehicleTypeOfFuel()
        {

        }
    }

    public enum TypesOfFuel
    {
        Diesel,
        Electric,
        Gasoline,
        BioDiesel
    }
}
