using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStoreExample;

namespace InvoiceTest
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void TestGetInvoiceAmount()
        {

            // Make sure you add the reference to the hardware store project First
            // Test Invoice amount QTY
            // Setup an invoice object and setup values needed for the constructor
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

            //Run test to validate the Q * P is the exected amount
            //Remember the M for the decimal value
            Assert.AreEqual(31.90M, invoice1.GetInvoiceAmount());
        }

        [TestMethod]
        public void TestPartNumberProperty()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);
            Assert.AreEqual("1234", invoice1.PartNumber);
        }

        [TestMethod]
        public void TestPriceProperty()
        {
            // Constructor is passing - price, should get a 0 as we told the SET accessor to not pass anything other than >=0. 
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, -15.95M);
            Assert.AreEqual(0, invoice1.Price);
        }
    }
}
