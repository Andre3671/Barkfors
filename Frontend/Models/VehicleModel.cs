using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Frontend.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public string ModelName { get; set; }
        public Brands Brand { get; set; }
        public VehicleColorOptions Color { get; set; }
        public TypesOfFuel FuelType { get; set; }
        public VehicleEquipment SelectedVehicleEquipment { get; set; }

        public VehicleModel()
        {
            
        }





    }
}
