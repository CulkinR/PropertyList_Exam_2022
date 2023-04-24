using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PropertyList_Exam_2022
{
    public enum RentalType { 
        House, 
        Flat, 
        Share
    }
    public class RentalProperty
    {
        public int id { get; set; }
        public string location { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public RentalType RentalType { get; set; }
        public string PropertyImage => $"\\Images\\{RentalType.ToString().ToLower()}.png";

        public decimal IncreaseRent(decimal amount, decimal price)
        {
            price *= 1 + amount;
            return price;
        }
    }

    public class RentalPropertyData: DbContext
    {
        public RentalPropertyData() : base ("RentalPropertyDB") { }
        public DbSet<RentalProperty> RentalProperties { get; set; }
    }
}
