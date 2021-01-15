using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercise1
{
   public class exe1_billgenerator 
    { 
     
        double charge = 0, cust_Unit, sur_amt = 0, unit_ToatalAmt, net_amt;
        string customerName, customerID;
            public void GetCustomerData()
        {
            Console.Write("\n");
            Console.Write("Calculating Electricity Bill-->\n");
            Console.Write("Enter Customer ID: \n");
            customerID =Console.ReadLine();
            Console.Write("Enter the Customer Name: \n");
            customerName = Console.ReadLine();
            Console.Write("Enter the units consumed by this Customer: \n");
            cust_Unit = double.Parse(Console.ReadLine());
            double returnCharge = unitCharge(cust_Unit);
            double returnGramt = unitAmount(returnCharge, cust_Unit);
            double returnSurcharge = surCharge(returnGramt);
            double returnNetamout = netAmount(returnSurcharge, returnGramt);
            displayDetails(customerID, customerName, cust_Unit, returnCharge, returnGramt, returnSurcharge, returnNetamout);
        }

        ///MEthod to decide per unit charge based on units
        public double unitCharge(double customerUnit)
        {
  
           if (customerUnit < 200)
                    charge = 1.20;
                else if (customerUnit < 400)
                    charge = 1.50;
                else if (customerUnit < 600)
                    charge = 1.80;
                else { 
                    charge = 2.00;
                }
            return charge;
        }

        ///Calculate total unit charges 
        public double unitAmount(double charge, double customerUnit)
        {
                unit_ToatalAmt = customerUnit * charge;
                return unit_ToatalAmt;
        }

        ///Catculate surge amount
        public double surCharge(double unit_ToatalAmt)
        {
            if (unit_ToatalAmt > 400)
                sur_amt = unit_ToatalAmt * 15 / 100.0;
            else
                sur_amt = 0;
            return sur_amt;

        }

        ///Calculating total Bill
        public double netAmount(double surcharge, double unit_ToatalAmt)
        {
                net_amt = unit_ToatalAmt + surcharge;
            if (net_amt < 100)
                return net_amt = 100;
            else
                return net_amt;
        }

        ///Displaying the bill
        public void displayDetails(string customerID, string customerName, double customerUnit, double charge, double gramt, double surcharge, double netamount)
        {
                Console.Clear();
                Console.WriteLine("Generated bill");
                Console.WriteLine("*******************************");
                Console.WriteLine("Customer ID: {0}", customerID);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Customer Units consumed: {0}", customerUnit);
            Console.WriteLine("Amout Charges @Rs. {0} per unit : {1}", charge, gramt);
            Console.WriteLine("Surface Amont: {0}", surcharge);
            Console.WriteLine("Net Amount to be paid by Customer : {0}", netamount);
                Console.WriteLine("*******************************");
            }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Electricity Bill Calculation *****");
                    ElectricityBill bill = new ElectricityBill();
                    bill.GetCustomerData();
                



        }
    }
}
//@Aneri adani