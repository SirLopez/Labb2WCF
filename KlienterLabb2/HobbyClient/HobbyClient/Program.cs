using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HobbyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamClient tc = new TeamClient();

            Console.WriteLine("Want to see a list of teams in F1?");

            var anwser = Console.ReadLine();
            if (anwser != null && anwser.ToUpper() == "Y")
                foreach (var team in tc.GetTeamNames())
                {
                    Console.WriteLine(team);
                }
                //Console.WriteLine(tc.GetTeamNames());
            
            Thread.Sleep(4000);
            Console.ReadKey();
        }
    }
}
