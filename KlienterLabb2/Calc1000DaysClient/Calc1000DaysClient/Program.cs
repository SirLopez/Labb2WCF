using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1000DaysClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ThousandDaysClient tdc = new ThousandDaysClient();

            Console.WriteLine("Welcome, want to know when ur next 1000th day anniversary is? \r\nPlease input the date you where born dd.MM.yyyy");
            DateTime bornday = DateTime.ParseExact(Console.ReadLine(),
                                            "dd.MM.yyyy",
                                            CultureInfo.InvariantCulture);
            Console.WriteLine("Your next 1000th day celebration will be on the " + tdc.nextThousandDay(bornday).ToShortDateString());
            Console.ReadKey();
        }
    }
}
