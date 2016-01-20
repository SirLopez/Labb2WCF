using System;
using System.ServiceModel;

namespace ServiceCalcing
{
    [ServiceContract(Namespace = "Calculate days")]
    public interface ICalcDaysOld
    {
        [OperationContract]
        int daysOld(DateTime bornDate, DateTime today);
    }
    public class CalcingDays : ICalcDaysOld
    {
        public int daysOld(DateTime bornDate, DateTime today)
        {
            Console.WriteLine("Recieved");
            return today.Day - bornDate.Day;
        }
    }
}
