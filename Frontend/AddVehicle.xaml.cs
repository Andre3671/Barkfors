using Frontend.Models;
using Frontend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddVehicle : Window
    {
       public MainViewModel Vm { get; set; }
        List<VehicleModel> TempList = new List<VehicleModel>();
        VehicleModel Vehicle { get; set; }
        public AddVehicle()
        { 
            InitializeComponent();
            Vm = new MainViewModel();
           Vehicle = new VehicleModel();
            BrandTextBox.ItemsSource = Enum.GetValues(typeof(Brands)); 
            ColorTextBox.ItemsSource = Enum.GetValues(typeof(VehicleColorOptions));
            FuelTextBox.ItemsSource = Enum.GetValues(typeof(TypesOfFuel));
           


            
        }
        //avbryt
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //uppdate
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vehicle.LicensePlateNumber = RegTextBox.Text;
            Vehicle.ModelName = ModelTextBox.Text;
            Vehicle.VIN = VinTextBox.Text;
            Vehicle.SelectedVehicleEquipment = new VehicleEquipment();
            Vehicle.SelectedVehicleEquipment.VehicleEquipmentList = new List<VehicleEquipments>();
            if(SunroofCheck.IsChecked == true)
            {
                Vehicle.SelectedVehicleEquipment.VehicleEquipmentList.Add(VehicleEquipments.Sunroof);
            }
            if (SportseatsCheck.IsChecked == true)
            {
                Vehicle.SelectedVehicleEquipment.VehicleEquipmentList.Add(VehicleEquipments.Sportseats);
            }
            if (KeylessCheck.IsChecked == true)
            {
                Vehicle.SelectedVehicleEquipment.VehicleEquipmentList.Add(VehicleEquipments.Keyless);
            }
            if (AutoPilotCheck.IsChecked == true)
            {
                Vehicle.SelectedVehicleEquipment.VehicleEquipmentList.Add(VehicleEquipments.AutoPilot);
            }
            if (AndroidAutoCheck.IsChecked == true)
            {
                Vehicle.SelectedVehicleEquipment.VehicleEquipmentList.Add(VehicleEquipments.AndroidAuto);
            }

            Vm.AddVehicle(Vehicle);
            this.Close();
        }

        private void ColorTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


          
            
                foreach (int i in Enum.GetValues(typeof(VehicleColorOptions)))
                {
                    if(ColorTextBox.SelectedItem.ToString() == Enum.GetName(typeof(VehicleColorOptions), i))
                    {
                    Vehicle.Color = (VehicleColorOptions)Enum.Parse(typeof(VehicleColorOptions), ColorTextBox.SelectedItem.ToString());
                       
                    }
                    
                }
            

        }

        private void BrandTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

            foreach (int i in Enum.GetValues(typeof(Brands)))
            {
                if (BrandTextBox.SelectedItem.ToString() == Enum.GetName(typeof(Brands), i))
                {
                    Vehicle.Brand = (Brands)Enum.Parse(typeof(Brands), BrandTextBox.SelectedItem.ToString());

                }

            }
        }

        private void FuelTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Vehicle.FuelType = (TypesOfFuel)FuelTextBox.SelectedItem;

            foreach (int i in Enum.GetValues(typeof(TypesOfFuel)))
            {
                if (FuelTextBox.SelectedItem.ToString() == Enum.GetName(typeof(TypesOfFuel), i))
                {
                    Vehicle.FuelType = (TypesOfFuel)Enum.Parse(typeof(TypesOfFuel), FuelTextBox.SelectedItem.ToString());

                }

            }
        }
    }
}
