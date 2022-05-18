using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Frontend.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<VehicleModel> _vehicles;
        public ObservableCollection<VehicleModel> Vehicles { get { return _vehicles; } set { _vehicles = value; } }

        public MainViewModel()
        {
            Vehicles = new ObservableCollection<VehicleModel>();
            Vehicles.Add(new VehicleModel() { ModelName = "Audi", VIN = "AAA333" });
        }  
    }
}
