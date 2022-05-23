using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BarkforsApi.Models;

namespace BarkforsApi.Data
{
    public class BarkforsApiContext : DbContext
    {
        public BarkforsApiContext (DbContextOptions<BarkforsApiContext> options)
            : base(options)
        {
        }

        public DbSet<BarkforsApi.Models.VehicleModel> VehicleModel { get; set; }
        public DbSet<BarkforsApi.Models.VehicleEquipment> VehicleEquipment { get; set; }
    }
}
