using System;
using AnimalHousePersistence;
using AnimalHouseEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalHouseUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Jacob
        // testing discount method in POS-system.
        [TestMethod]
        public void TestMethodDiscount1()
        {
            int pris = 100;
             OrderLine Test=new OrderLine(pris); 
            double TestPris= Test.Discount(pris, 20);
            Assert.AreEqual(80, TestPris);
        }
        [TestMethod]
        public void TestMethodDiscount2()
        {
            int pris = 100000;
            OrderLine Test = new OrderLine(pris);
            double TestPris = Test.Discount(pris, 20);
            Assert.AreEqual(80000, TestPris);
        }
        [TestMethod]
        //Testing Moms Methods in POS-system 
        public void TestMethodChangedOfPriceWithMoms()
        {
            int OldPris = 100;
            int NewPris = 120;
            OrderLine Test = new OrderLine(OldPris);
           double testpris= Test.ChangeOfPriceWithMoms(NewPris, 2, OldPris);
            Assert.AreEqual(400, testpris);
        }
        [TestMethod]
        public void TestMethodChangedOfPriceWithoutMoms()
        {
            int OldPris = 100;
            int NewPris = 120;
            OrderLine Test = new OrderLine(OldPris);
            double testpris = Test.ChangeOfPriceWithOutMoms(NewPris, 2, OldPris);
            Assert.AreEqual(340, testpris);
        }
    }
}
