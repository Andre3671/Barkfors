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
    public partial class EditVehicle : Window
    {
       public MainViewModel Vm { get; set; }
        List<VehicleModel> TempList = new List<VehicleModel>();
        VehicleModel Vehicle { get; set; }
        public EditVehicle(VehicleModel vehicle)
        { 
            InitializeComponent();
            Vm = new MainViewModel();
            Vehicle = vehicle;

            BrandTextBox.ItemsSource = Enum.GetValues(typeof(Brands)); 
            BrandTextBox.Text = vehicle.Brand.ToString();
            ColorTextBox.ItemsSource = Enum.GetValues(typeof(VehicleColorOptions));
            ColorTextBox.Text = vehicle.Color.ToString();
            FuelTextBox.ItemsSource = Enum.GetValues(typeof(TypesOfFuel));
            FuelTextBox.Text = vehicle.FuelType.ToString();



            VinTextBox.Text = vehicle.VIN;
            RegTextBox.Text = vehicle.LicensePlateNumber;
            ModelTextBox.Text = vehicle.ModelName;


            
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
           // Vehicle.Brand =
            Vehicle.VIN = VinTextBox.Text;
            Vm.EditVehicle(Vehicle);
            this.Close();
        }

        private void ColorTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Vehicle.Color = (VehicleColorOptions)ColorTextBox.SelectedItem;
        }

        private void BrandTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehicle.Brand = (Brands)BrandTextBox.SelectedItem;
        }

        private void FuelTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Vehicle.FuelType = (TypesOfFuel)FuelTextBox.SelectedItem;
        }
    }
}
