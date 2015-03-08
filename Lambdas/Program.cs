using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Lambda + Func<T, TResult>
            Func<Double, Double> cpointer = r => 3.1415 * r * r;  // define
            Double Area = cpointer(20);  // Call

            // Action delegate with no return result
            Action<string> MyAction = y => Console.WriteLine(y);  // define
            MyAction("Hello World!");  // Call


            // Predicate is an extension to Func
            // Can take any input type, will always return boolean
            // This is used to validate data
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;  // define
            bool t = CheckGreaterThan5("Shot");  // Call


            List<string> oString = new List<string>();
            oString.Add("Shiv");
            oString.Add("Shiv123");
            oString.Add("HelP");
            oString.Add("MyText");
            oString.Add("Another Text");

            // Predicate<string> passes values of items and passes it to the lambda
            string str1 = oString.Find(CheckGreaterThan5);
            // Console.WriteLine(str1); // Only shows first results




            // Expression Trees

            
            
            Console.Read();
        }




        static double CalculateArea(int r)
        {
            return 3.1415 * r * r;
        }



    }
}
