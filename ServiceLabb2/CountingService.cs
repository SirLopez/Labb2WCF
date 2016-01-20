using System;
using System.ServiceModel;

namespace ServiceLabb2
{
    [ServiceContract(Namespace = "CountingBMIservice")]
    public interface ICounting
    {
        //1. BMI
        [OperationContract]
        double Bmi(double weight, double height);
    }

    public class CountingService : ICounting
    {

        public double Bmi(double weight, double height)
        {
            Console.WriteLine("Received");
            return weight / ((height / 100) * (height / 100));
        }
    }
}
