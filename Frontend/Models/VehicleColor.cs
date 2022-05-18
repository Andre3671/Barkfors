using System;
using System.Collections.Generic;
using System.Text;

namespace Frontend.Models
{
   public class VehicleColor
    {
        public int Id { get; set; }
        public VehicleColorOptions SelectedVehicleColor { get; set; }
        
        
        public VehicleColor()
        {

        }
    }
    public enum VehicleColorOptions
    {
        Blue,
        Red,
        White,
        Black
    }
}
