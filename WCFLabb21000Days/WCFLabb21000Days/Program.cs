using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ServiceCalc1000Days;

namespace WCFLabb21000Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ServiceCalc1000Days");
            using (ServiceHost selfServiceHost = new ServiceHost(typeof(ThousandDays), baseAddress))
            {
                try
                {
                    selfServiceHost.AddServiceEndpoint
                     (typeof(IThousandDays),
                     new WSHttpBinding(),
                     "ThousandDays");

                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;

                    selfServiceHost.Description.Behaviors.Add(smb);

                    selfServiceHost.Open();
                    Console.WriteLine("Let´s calculate when ur next 1000th day is");
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
