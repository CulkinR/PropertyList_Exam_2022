using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyList_Exam_2022;
using NUnit.Framework;

namespace UnitTests
{
    public class Class1
    {
        [Test]
        public void PrecentageIncrease()
        {
            RentalProperty rental = new RentalProperty();
            decimal increase = rental.IncreaseRent(Convert.ToDecimal(.10), 400);
            Assert.AreEqual(440, increase);
        }
    }
}
