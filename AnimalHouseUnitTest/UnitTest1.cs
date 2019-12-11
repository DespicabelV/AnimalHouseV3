using System;
using AnimalHouseTemp;
using AnimalHousePersistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalHouseUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        // testing discount method in POS-system.
        [TestMethod]
        public void TestMethodDiscount1()
        {
            int pris = 100;
            EntityLejeOrdre Test = new EntityLejeOrdre(pris); 
            double TestPris= Test.Discount(pris, 20);
            Assert.AreEqual(80, TestPris);
        }
        [TestMethod]
        public void TestMethodDiscount2()
        {
            int pris = 100000;
            EntityLejeOrdre Test = new EntityLejeOrdre(pris);
            double TestPris = Test.Discount(pris, 20);
            Assert.AreEqual(80000, TestPris);
        }
        [TestMethod]
        public void TestMethodChangedOfPriceWithMoms()
        {
            int OldPris = 100;
            int NewPris = 120;
            EntityLejeOrdre Test = new EntityLejeOrdre(OldPris);
           double testpris= Test.ChangeOfPriceWithMoms(NewPris, 2, OldPris);
            Assert.AreEqual(400, testpris);
        }
        [TestMethod]
        public void TestMethodChangedOfPriceWithoutMoms()
        {
            int OldPris = 100;
            int NewPris = 120;
            EntityLejeOrdre Test = new EntityLejeOrdre(OldPris);
            double testpris = Test.ChangeOfPriceWithOutMoms(NewPris, 2, OldPris);
            Assert.AreEqual(340, testpris);
        }


    }
         
}
