using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ServiceCalcing;

namespace WCFLabb2CalcDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ServiceCalcing");
            using (ServiceHost selfServiceHost = new ServiceHost(typeof(CalcingDays), baseAddress))
            {
                try
                {
                    selfServiceHost.AddServiceEndpoint
                     (typeof(ICalcDaysOld),
                     new WSHttpBinding(),
                     "CalcingDays");

                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;

                    selfServiceHost.Description.Behaviors.Add(smb);

                    selfServiceHost.Open();
                    Console.WriteLine("Let´s calculate how many days you are");
                    Console.WriteLine("Press ENTER to exit");
                    Console.ReadLine();

                }
                catch (CommunicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    selfServiceHost.Close();
                }
            }
        }
    }
}
