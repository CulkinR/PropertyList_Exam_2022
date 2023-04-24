using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyList_Exam_2022;
using System.Data.Entity;
using PropertyList_Exam_2022;
using static System.Console;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalPropertyData db = new RentalPropertyData();

            using (db)
            {
                WriteLine("Creating DB Objects");

                RentalProperty p1 = new RentalProperty()
                {
                    price = 400,
                    RentalType = RentalType.Flat,
                    description = "A modern 1 bedroom apartment located close to the campus." +
                    "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
                    "a small kitchen and a lounge/dining room",
                    location = "Town Centre"
                };

                RentalProperty p2 = new RentalProperty()
                {
                    price = 400,
                    RentalType = RentalType.House,
                    description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There locations also a dining room and a large sitting room",
                    location = "Ballinode"
                };

                RentalProperty p3 = new RentalProperty()
                {
                    price = 400,
                    RentalType = RentalType.Share,
                    description = "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    location = "Strandhill"
                };

                WriteLine("Createad Objects");

                db.RentalProperties.Add(p1);
                db.RentalProperties.Add(p2);
                db.RentalProperties.Add(p3);

                WriteLine("Added Objects to DB");

                db.SaveChanges();

                WriteLine("Saved changes to db");
                WriteLine("Press enter to continue");
                ReadLine();
            }
        }
    }
}
