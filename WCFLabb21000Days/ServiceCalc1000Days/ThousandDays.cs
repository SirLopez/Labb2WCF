using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCalc1000Days
{
    [ServiceContract]
    public interface IThousandDays
    {
        [OperationContract]
        DateTime nextThousandDay(DateTime celebrateDate);
    }
    public class ThousandDays : IThousandDays
    {
        public DateTime nextThousandDay(DateTime celebrateDate)
        {
            //When is the next 1000th day in my life?
            Console.WriteLine("Recieved");
            
            var nextThousand = 1000 - (DateTime.Now - celebrateDate).Days % 1000;

            return DateTime.Now.AddDays(nextThousand);
        }
    }
}
