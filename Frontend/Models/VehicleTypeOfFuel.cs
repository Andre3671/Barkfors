using System;
using System.Collections.Generic;
using System.Text;

namespace Frontend.Models
{
    public class VehicleTypeOfFuel
    {
        public int Id { get; set; }
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
