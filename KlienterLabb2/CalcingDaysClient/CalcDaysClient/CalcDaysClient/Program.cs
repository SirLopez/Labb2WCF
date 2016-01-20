using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDaysClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcDaysOldClient cdoc = new CalcDaysOldClient();

            Console.WriteLine("Welcome, want to know how many days old you are? \r\nPlease input the date you where born dd.MM.yyyy");

            DateTime bornday = DateTime.ParseExact(Console.ReadLine(),
                                            "dd.MM.yyyy",
                                            CultureInfo.InvariantCulture);

            Console.WriteLine(cdoc.daysOld(bornday));
            Console.ReadKey();
        }
    }
}
