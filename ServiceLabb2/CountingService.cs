using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLabb2
{
    [ServiceContract(Namespace = "Countingservice")]
    public interface ICounting
    {
        [OperationContract]
        double Bmi(double number);

        [OperationContract]
        DateTime DaysOld(DateTime days);

        [OperationContract]
        DateTime HoursOld(DateTime hours);
        
    }

    public class CountingService : ICounting
    {
        public double Bmi(double number)
        {
            throw new NotImplementedException();
        }

        public DateTime DaysOld(DateTime days)
        {
            throw new NotImplementedException();
        }

        public DateTime HoursOld(DateTime hours)
        {
            throw new NotImplementedException();
        }
    }
}
