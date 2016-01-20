using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CountingClient BMI = new CountingClient();
            
            //Nu ska jag ta in två nummer från användaren, först vikt sen längd.
            //bla bla bla
            Console.WriteLine("Welcome, let´s calculate your BMI \r\nPlease input your weight.");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert your height in cm.");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(BMI.Bmi(weight, height));
            Console.ReadKey();

        }
    }
}
