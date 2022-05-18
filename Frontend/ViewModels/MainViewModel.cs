using Frontend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<VehicleModel> _vehicles;
        public ObservableCollection<VehicleModel> Vehicles { get { return _vehicles; } set { _vehicles = value; } }

        public MainViewModel()
        {
            Vehicles = Task.Run(() => GetVehicles()).Result;
        }
   

        public static async Task<ObservableCollection<VehicleModel>> GetVehicles()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    ObservableCollection<VehicleModel> vehicles = new ObservableCollection<VehicleModel>();

                    httpClient.Timeout = new TimeSpan(0, 0, 5);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonResult = await httpClient.GetStringAsync("https://localhost:44378/api/Vehicles");

                    vehicles = JsonConvert.DeserializeObject<ObservableCollection<VehicleModel>>(jsonResult);

                    httpClient.Dispose();
                    return vehicles;
                }
            }
            catch (HttpRequestException hr)
            {
                Debug.WriteLine(hr.StackTrace);
                Debug.WriteLine("Server isn´t responding");
                return null;
                
            }

        }

        public  async Task EditVehicle()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    ObservableCollection<VehicleModel> vehicles = new ObservableCollection<VehicleModel>();

                    httpClient.Timeout = new TimeSpan(0, 0, 5);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonResult = await httpClient.GetStringAsync("https://localhost:44378/api/Vehicles");

                    vehicles = JsonConvert.DeserializeObject<ObservableCollection<VehicleModel>>(jsonResult);

                    httpClient.Dispose();
                    
                }
            }
            catch (HttpRequestException hr)
            {
                Debug.WriteLine(hr.StackTrace);
                Debug.WriteLine("Server isn´t responding");
                
            }

        }
        public static async Task<ObservableCollection<VehicleModel>> RemoveVehicle()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    ObservableCollection<VehicleModel> vehicles = new ObservableCollection<VehicleModel>();

                    httpClient.Timeout = new TimeSpan(0, 0, 5);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonResult = await httpClient.GetStringAsync("https://localhost:44378/api/Vehicles");

                    vehicles = JsonConvert.DeserializeObject<ObservableCollection<VehicleModel>>(jsonResult);

                    httpClient.Dispose();
                    return vehicles;
                }
            }
            catch (HttpRequestException hr)
            {
                Debug.WriteLine(hr.StackTrace);
                Debug.WriteLine("Server isn´t responding");
                return null;

            }

        }
    }
}
