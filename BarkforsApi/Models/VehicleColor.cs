using System;
using System.Collections.Generic;
using System.Text;

namespace BarkforsApi.Models
{
   public class VehicleColor
    {
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
