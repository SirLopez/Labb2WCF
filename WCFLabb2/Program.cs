using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ServiceLabb2;

namespace WCFLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ServiceLabb2");
            using (ServiceHost selfServiceHost = new ServiceHost(typeof(CountingService), baseAddress))
            {
                try
                {
                    selfServiceHost.AddServiceEndpoint
                     (typeof(ICounting),
                     new WSHttpBinding(),
                     "CountingService");

                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;

                    selfServiceHost.Description.Behaviors.Add(smb);

                    selfServiceHost.Open();
                    Console.WriteLine("Let´s calculate your BMI");
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
