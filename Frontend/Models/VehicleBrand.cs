using System;
using System.Collections.Generic;
using System.Text;

namespace Frontend.Models
{
  public class VehicleBrand
    {
        public int Id { get; set; }
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
