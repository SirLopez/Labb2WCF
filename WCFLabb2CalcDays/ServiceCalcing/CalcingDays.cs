using System;
using System.ServiceModel;

namespace ServiceCalcing
{
    [ServiceContract(Namespace = "Calculate days")]
    public interface ICalcDaysOld
    {
        [OperationContract]
        int daysOld(DateTime bornDate);
    }
    public class CalcingDays : ICalcDaysOld
    {
        public int daysOld(DateTime bornDate)
        {
            Console.WriteLine("Recieved");
            var today = DateTime.Now;
            return (int)(today.Date - bornDate.Date).TotalDays;
        }
    }
}
