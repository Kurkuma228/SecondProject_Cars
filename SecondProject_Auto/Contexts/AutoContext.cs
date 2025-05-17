using SecondProject_Auto.Enums;
using System;
using System.Data.Entity;


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
        public DateTime YearCreate { get; set; }
        public string AutoType { get; set; }
        public QualityType QualityType { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public float Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public string Engine { get; set; }
        public int HorsePower { get; set; }
        public byte SeatingCapacity { get; set; }
        public string Mfr { get; set; }
        public string PhotoFilePath { get; set; }
    }
}
