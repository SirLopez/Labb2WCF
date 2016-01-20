using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHobby
{
    [ServiceContract]
    public interface ITeam
    {
        [OperationContract]
        List<string> GetTeamNames();
    }
    public class TeamClass : ITeam
    {

        public List<string> GetTeamNames()
        {
            return new List<string>() {"Mercedes", "Ferrari", "Williams", "Red Bull Racing", "Force India", "Lotus", "Torro Rosso", "Sauber", "McLaren", "Manor", "Haas"};
        }
    }
}
