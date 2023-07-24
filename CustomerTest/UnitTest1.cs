using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace CustomerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WriteTest()
        {
            ConAppCustomer.Program ob;
            int id = 12;
            string name="Rink";
            DateTime dob=new DateTime(day:26,month:12,year:1995);
            Assert.AreEqual((id,name,dob),ob.Write());
        }
        [TestMethod]
        public void ReadTest()
        {
            ConAppCustomer.Program ob;
            int id = 12;
            string name = "Rink";
            DateTime dob = new DateTime(day: 26, month: 12, year: 1995);
            Assert.AreEqual((id, name, dob), ob.Read());
        }
    }
}
