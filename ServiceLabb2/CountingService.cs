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
        //1. BMI
        [OperationContract]
        double Bmi(double weight, double height);
        //2. Years/Days/Hours
        [OperationContract]
        DateTime WhatIsMyAgeIn(DateTime days);
        
        [OperationContract]
        DateTime ThousandDaysEven(DateTime thousandDays);

    }

    public class CountingService : ICounting
    {

        public double Bmi(double weight, double height)
        {
            //Calculate (weight / 2*(height))
            //Return result
            throw new NotImplementedException();
        }

        public DateTime WhatIsMyAgeIn(DateTime days)
        {
            //Calculate years and days and hours using datetime
            //Return result depending on what the user choose
            throw new NotImplementedException();
        }

        public DateTime ThousandDaysEven(DateTime thousandDays)
        {
            //When is my next age an even thousand days?
            throw new NotImplementedException();
        }
    }
}
