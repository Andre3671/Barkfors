using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarkforsApi.Data;
using BarkforsApi.Models;

namespace BarkforsApi.Controllers
{
    public class VehicleModelsController : Controller
    {
        private readonly BarkforsApiContext _context;

        public VehicleModelsController(BarkforsApiContext context)
        {
            _context = context;
        }

        // GET: VehicleModels
        [HttpGet]
        [Route("~/api/Vehicles/")]
        public async Task<IActionResult> GetAll()
        {
            List<VehicleModel> list = await _context.VehicleModel.ToListAsync();
            foreach (VehicleModel veh in list)
            {
                veh.SelectedVehicleEquipment = new VehicleEquipment();
                VehicleEquipment test = (_context.VehicleEquipment.Where(e => e.VehicleId == veh.Id).FirstOrDefault());
                if(test != null)
                veh.SelectedVehicleEquipment.VehicleEquipmentString = test.VehicleEquipmentString;
            }
            return Ok(list);
        }

        [HttpPost]
        [Route("~/api/Vehicles/Remove/{id}")]
        public async Task<IActionResult> RemoveVehicle(int id)
        {
           _context.VehicleModel.Remove(_context.VehicleModel.Where(v => v.Id == id).First());
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("~/api/Vehicles/Add/{vin}/{plate}/{model}/{brand}/{color}/{fueltype}/{Equipment}")]
        public async Task<IActionResult> AddVehicle(string vin,string plate, string model,Brands brand, VehicleColorOptions color, TypesOfFuel fueltype,string Equipment )
        {
            VehicleModel vehicle = new VehicleModel
            {
                Brand =   brand,
                Color = color,
                VIN = vin,
                LicensePlateNumber = plate,
                ModelName = model,
                FuelType = fueltype,
            };

            List<string> EquipmentListString = Equipment.Split(",").ToList();
            List<VehicleEquipments> equipments = new List<VehicleEquipments>();
            foreach(string equipment in EquipmentListString)
            {
                foreach (int i in Enum.GetValues(typeof(VehicleEquipments)))
                {
                    if( equipment == Enum.GetName(typeof(VehicleEquipments), i))
                    {
                        VehicleEquipments equip = (VehicleEquipments)Enum.Parse(typeof(VehicleEquipments), equipment);
                        equipments.Add(equip);
                    }
                    
                }
            }
            VehicleEquipment vehicleEquipment = new VehicleEquipment();
            vehicleEquipment.VehicleEquipmentList = equipments;
            vehicle.SelectedVehicleEquipment = vehicleEquipment;
            _context.VehicleModel.Add(vehicle);
            _context.SaveChanges();
            return Ok();
        }



    }
}
