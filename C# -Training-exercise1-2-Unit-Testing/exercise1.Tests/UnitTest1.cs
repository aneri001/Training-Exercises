using NUnit.Framework;

namespace exercise1.Tests
{
    [TestFixture]
    public class Tests
    {
        exe1_billgenerator obj;
        [SetUp]
        public void Setup()
        {
            obj = new exe1_billgenerator();
        }

        //For cust_Unit<0
        [Test]
        public void unitCharge_cust_Unit_returncharge1()
        {
            //Arrange
            double expected = 0;
            double cust_Unit = -3;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //For cust_Unit =0
        [Test]
        public void unitCharge_cust_Unit_returncharge2()
        {
            //Arrange
            double expected = 1.20;
            double cust_Unit = 0;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //For cust_Unit<200
        [Test]
        public void unitCharge_cust_Unit_returncharge3()
        {
            //Arrange
            double expected = 1.20;
            double cust_Unit = 170;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //for cust_Unit=200
        [Test]
        public void unitCharge_cust_Unit_returncharge4()
        {
            //Arrange
            double expected = 1.50;
            double cust_Unit = 200;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //For cust_Unit< 400
        [Test]
        public void unitCharge_cust_Unit_returncharge5()
        {
            //Arrange
            double expected = 1.50;
            double cust_Unit = 320;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //For cust_Unit=400
        [Test]
        public void unitCharge_cust_Unit_returncharge6()
        {
            //Arrange
            double expected = 1.80;
            double cust_Unit = 400;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //For cust_Unit<600
        [Test]
        public void unitCharge_cust_Unit_returncharge7()
        {
            //Arrange
            double expected = 1.80;
            double cust_Unit = 570;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        //For cust_Unit<600
        [Test]
        public void unitCharge_cust_Unit_returncharge8()
        {
            //Arrange
            double expected = 2.00;
            double cust_Unit = 600;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //For cust_Unit>600
        [Test]
        public void unitCharge_cust_Unit_returncharge9()
        {
            //Arrange
            double expected = 2.00;
            double cust_Unit = 1000;

            //Act
            var actual = obj.unitCharge(cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //for total unit charges
        [Test]
        public void unitAmount_charge_custUnit_returnUnitTotalAmt()
        {
            //Arrange
            double expected = 2000.00;
            double charge = 2.00;
            double cust_Unit = 1000;

            //Act
            var actual = obj.unitAmount(charge, cust_Unit);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //to alculate surge amount for total unit bill< 400
        [Test]
        public void surCharge_UnitTotalAmt_returnsurcharge1()
        {
            //Arrange
            double expected = 0;
            double gramt = 200;


            //Act
            var actual = obj.surCharge(gramt);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //to alculate surge amount for totalUnitbill =400
        [Test]
        public void surCharge_UnitTotalAmt_returnsurcharge2()
        {
            //Arrange
            double expected = 0;
            double gramt = 400;


            //Act
            var actual = obj.surCharge(gramt);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //to alculate surge amount for totalUnitBill >400
        [Test]
        public void surCharge_UnitTotalAmt_returnsurcharge3()
        {
            //Arrange
            double expected = 150;
            double UnitTotalAmt = 1000;


            //Act
            var actual = obj.surCharge(UnitTotalAmt);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void netAmount_UnitTotalAmt_surcharge_reutrn_netamt1()
        {
            //Arrange
            double expected = 100;
            double UnitTotalAmt = 59;
            double surcharge = 0;


            //Act
            var actual = obj.netAmount(surcharge, UnitTotalAmt);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void netAmount_UnitTotalAmt_surcharge_reutrn_netamt2()
        {
            //Arrange
            double expected = 512;
            double UnitTotalAmt = 500;
            double surcharge = 12;


            //Act
            var actual = obj.netAmount(surcharge, UnitTotalAmt);

            //Assert
            Assert.AreEqual(expected, actual);

        }



    }
}