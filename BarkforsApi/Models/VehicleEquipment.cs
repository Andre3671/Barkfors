using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BarkforsApi.Models
{
   public class VehicleEquipment
    {
        [Key]
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string VehicleEquipmentString{ get; set; }
        [NotMapped]
        public List<VehicleEquipments> VehicleEquipmentList { get {
                List<VehicleEquipments> equipments = new List<VehicleEquipments>();
                if (VehicleEquipmentString != null) { 
                List<string> EquipmentListString = VehicleEquipmentString.Split(",").ToList();
                
                foreach (string equipment in EquipmentListString)
                {
                    foreach (int i in Enum.GetValues(typeof(VehicleEquipments)))
                    {
                        if (equipment == Enum.GetName(typeof(VehicleEquipments), i))
                        {
                            VehicleEquipments equip = (VehicleEquipments)Enum.Parse(typeof(VehicleEquipments), equipment);
                            equipments.Add(equip);
                        }

                    }
                }
                }
                return equipments;
            } set { VehicleEquipmentList = value; } }

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
