using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        private string mFirstName = "First Name of Customer";
        private string mLastName = "Last Name of Customer";


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = mFirstName;
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = mFirstName;
            Error = ACustomer.Valid(mFirstName);

            string TestData2 = mLastName;
            Error = ACustomer.Valid(mLastName);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void MinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = ACustomer.Valid(TestData);

            string TestData2 = "";
            Error = ACustomer.Valid(TestData2);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = ACustomer.Valid(TestData);

            string TestData2 = "";
            TestData2 = TestData2.PadLeft(51, '*');
            Error = ACustomer.Valid(TestData2);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = mLastName;
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }
    }
}
