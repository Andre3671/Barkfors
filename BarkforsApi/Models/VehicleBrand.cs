using System;
using System.Collections.Generic;
using System.Text;

namespace BarkforsApi.Models
{
  public class VehicleBrand
    {
        public Brands SelectedBrand { get; set; }
        public VehicleBrand()
        {

        }
    }
    public enum Brands
    {
        Tesla,
        Audi,
        Saab,
        BMW
    }
}
