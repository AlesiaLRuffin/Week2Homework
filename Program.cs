using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Week2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("  Exercise 1: Fahrenheit to Celsius");
            Console.WriteLine("  What is today's temperature in fahrenheit?");
            Double tempF = Convert.ToDouble(Console.ReadLine());
            int cNumber = 32;
            double difference = tempF - cNumber; 
            double quotient = difference * 5 / 9;
            Double tempC = quotient;
            Console.WriteLine($"  {tempF} degrees fahrenheit is {tempC} degrees celsius.");
            Console.WriteLine("  Press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("  Exercise 1B: Fahrenheit to Celsius and vice versa");
            Console.WriteLine("  Enter today's temperature.");
            int temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  Enter C for celsius or F for fahrenheit");
            DoOver:
            char scale = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"  You entered {temperature} degrees {scale} \n  Press enter to continue");
            Console.ReadLine();

            if (scale == 'F')
            {
                Double cTemp = (temperature - 32) * 5 / 9;
                
                Console.WriteLine($"  {temperature} degrees fahrenheit is {cTemp} degrees celsius.");
            }
            else if (scale == 'C')
            {
                Double fTemp = (temperature * 9 / 5) + 32;
                
                Console.WriteLine($"  {temperature} degrees celsius is {fTemp} degrees fahrenheit.");
            }
            else
            {
                Console.WriteLine("  Please use a capital C or capital F");
                {
                    goto DoOver;
                }
            }
            Console.WriteLine();
            Console.WriteLine("  Press enter to continue to Exercise 2: Sales Tax");
            Console.ReadLine();
            
            Console.WriteLine("  Exercise 2: Sales Tax\n  Enter the price of your product");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  Enter your state's sales tax perentage");
            decimal stateTax = Convert.ToDecimal(Console.ReadLine());
            decimal salesTax = Math.Round((stateTax/ 100) * productPrice,2);
            decimal Total = productPrice + salesTax;
            Console.WriteLine($"  Your item is\n              {productPrice}\n  Tax          {salesTax}\n  Total       {Total}\n");
            Console.ReadLine();
            
            Console.WriteLine("  Press enter to continue to Exercise 3: Tip Calculator");
            Console.ReadLine();
           
            Console.WriteLine("  Exercise 3: Tip Calculator\n  What is the total bill");
            decimal totalBill = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  What percentage would you like to tip?");
            decimal tip = Convert.ToDecimal(Console.ReadLine());
            decimal tipOwed = Math.Round((tip / 100) * totalBill, 2);
            decimal grandTotal = Math.Round(tipOwed + totalBill, 2);
            Console.WriteLine($"  Your tip amount is {tipOwed}");
            Console.WriteLine($"  Your grand total is {grandTotal}");
            Console.WriteLine();
            Console.WriteLine("  Press enter to continue to Exercise 4: Bill Dividends");
            Console.ReadLine();
            
            Console.WriteLine("  Exercise 4: Bill Dividends\n  What is the total bill?");
            decimal totalBill3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  How many people are splitting the bill?");
            int people = Convert.ToInt32(Console.ReadLine());
            decimal split = Math.Round(totalBill3 / people, 2);
            Console.WriteLine($"  Each person owes {split}");
            Console.WriteLine();
            Console.WriteLine("  Press enter to continue to Exercise 5: Challenge: Formatting Money");
            Console.ReadLine();

            Console.WriteLine("  Exercise 5: Challenge: Formatting Money");
            double value = 6231965;
            Console.WriteLine(value.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}
