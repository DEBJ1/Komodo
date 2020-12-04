using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevRepoPtoject
{
    class DevelopersTeam
    {
        public string TeamName { get; set; }
        public string TeamID { get; set; }
        public List<Developers> DevTeamMembers { get; set; } = new List<Developers>();

        public DevelopersTeam() { }
        public DevelopersTeam(string teamName, string teamID)
        {
            TeamName = teamName;
            TeamID = teamID;
        }
    }
}
