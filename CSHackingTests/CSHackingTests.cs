using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSHacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHacking.Tests
{
    [TestClass()]
    public class CSHackingTests
    {
        [TestMethod()]
        public void CheckIfProcOpenTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();
            Console.WriteLine(isProcessOpen);          
            Assert.IsTrue(isProcessOpen);
        }

        #region Read Value Tests

        [TestMethod()]
        public void ReadHPValueTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();
            double hpValue = hackClass.ReadHPValue();
            Console.WriteLine(hpValue);
            //Assert.AreEqual(0, hpValue);
        }

        [TestMethod()]
        public void ReadXPOSTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();
            double xPOS = hackClass.ReadXPOS();
            Console.WriteLine(xPOS);
        }

        [TestMethod()]
        public void ReadYPOSTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();
            double yPOS = hackClass.ReadYPOS();
            Console.WriteLine(yPOS);
        }

        #endregion

        #region Write Value Tests

        [TestMethod()]
        public void WriteMoneyTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();

            // Input Value you want to test here
            hackClass.WriteMoney("9999");

            double moneyValue = hackClass.ReadMoneyValue();
            Console.WriteLine(moneyValue);
        }

        [TestMethod()]
        public void WriteXPOSTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();

            double xPOS = hackClass.ReadXPOS();
            Console.WriteLine(xPOS);

            // Input Value you want to test here
            hackClass.WriteXPOS("723");

            xPOS = hackClass.ReadXPOS();
            Console.WriteLine(xPOS);
        }

        [TestMethod()]
        public void WriteYPOSTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();

            double yPOS = hackClass.ReadYPOS();
            Console.WriteLine(yPOS);

            // Input Value you want to test here
            hackClass.WriteYPOS("160");

            yPOS = hackClass.ReadYPOS();
            Console.WriteLine(yPOS);
        }

        [TestMethod()]
        public void GiveSPDispenserTest()
        {
            CSHackingClass hackClass = new CSHackingClass();
            bool isProcessOpen = hackClass.CheckIfProcOpen();

            hackClass.GiveSPDispenser();
        }

        #endregion
    }
}