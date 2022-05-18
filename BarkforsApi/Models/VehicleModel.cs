using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BarkforsApi.Models
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
        [NotMapped]
        public List<VehicleEquipment> SelectedVehicleEquipment { get; set; }

        public VehicleModel()
        {
            
        }





    }
}
