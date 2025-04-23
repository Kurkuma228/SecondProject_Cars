using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject_Auto
{
    public class AutoContext : DbContext
    {
        public AutoContext()
            : base("DBConnection")
        { }

        public DbSet<Auto> Autos { get; set; }
    }
    public class Auto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutoType { get; set; }
        public decimal Price { get; set; }
        public string FuelType { get; set; }
        public string Engine { get; set; }
        public uint HorsePower { get; set; }
        public uint Torque { get; set; }
        public byte SeatingCapacity { get; set; }
        public string Mfr { get; set; }
        public string PhotoFilePath { get; set; }
    }
}
