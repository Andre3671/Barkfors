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
    public partial class MainWindow : Window
    {
       public MainViewModel Vm { get; set; }

        public MainWindow()
        { 
            InitializeComponent();
            Vm = new MainViewModel();
            MainListView.ItemsSource = Vm.Vehicles;
            //Task.Run(() => Vm.EditVehicle());
        }



        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VehicleModel SelectedVehicle = (VehicleModel)MainListView.SelectedItem;
            TextBlockModel.Text = SelectedVehicle.ModelName;
            TextBlockVin.Text = SelectedVehicle.VIN;
            TextBlockReg.Text = SelectedVehicle.LicensePlateNumber;
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TextBoxSearch.Text.Length >= 1) { 
            List<VehicleModel> TempList = new List<VehicleModel>(); ;
            foreach (VehicleModel v in Vm.Vehicles)
            {
                if (v.VIN.ToLower().Contains(TextBoxSearch.Text.ToLower()))
                {
                        TempList.Add(v);
                }
            }
            MainListView.ItemsSource = TempList;
            }                
        }
    }
}
