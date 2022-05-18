using System;
using System.Collections.Generic;
using System.Text;

namespace Frontend.Models
{
   public class VehicleEquipment
    {
        public int Id { get; set; }
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
