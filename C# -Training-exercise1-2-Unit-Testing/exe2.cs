using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercise1
{
    public class exe2
    {
        public void add_generic<T>(T val1, T val2)
        {
            //declaring dynamic variable to access these undeclared variable types
            dynamic x = val1;
            dynamic y = val2;
            Console.WriteLine(x + y);
            Console.WriteLine("*******************************");
        }

        public void sort_linq()
        {
            //SIZE OF LIST
            Console.WriteLine("enter the length in list");

            double input = double.Parse(Console.ReadLine());

            List<double> val = new List<double>();
            //INPUT FOR LIST
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Enter {0}'s value in list :", i + 1);
                val.Add(double.Parse(Console.ReadLine()));
            }
            //using order by to sort anD IMPLEMENT ON NUM
            var result = from num in val
                         orderby num ascending
                         select num;

            Console.WriteLine("*******************************");
            Console.WriteLine($"Aescending list :");
            foreach (var num in result)
            {

                Console.WriteLine(num);
            }
        }
        int? num = null;

       public void GetValueorDefault(int? defaultvalue)
       {
          num= defaultvalue.GetValueOrDefault(6);
            //setting default value to 6 
           Console.WriteLine(num);
       }

    }
}