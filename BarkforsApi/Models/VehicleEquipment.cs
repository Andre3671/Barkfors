using System;
using System.Collections.Generic;
using System.Text;

namespace BarkforsApi.Models
{
   public class VehicleEquipment
    {
        public List<VehicleEquipments> VehicleEquipmentList { get; set; }
        public VehicleEquipment()
        {

        }
    }
    public enum VehicleEquipments
    {
        None,
        AutoPilot,
        Sportseats,
        Keyless,
        Sunroof,
        AndroidAuto,
    }
}
