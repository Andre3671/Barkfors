using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Frontend.Models
{
    public class VehicleModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public string ModelName { get; set; }
       //Egna klasser
        //public string Brand { get; set; }        
        //public string Color { get; set; }
        //public string VehicleEquipment { get; set; }

        public VehicleModel()
        {
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string Obj)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(Obj));
            }
        }


    }
}
