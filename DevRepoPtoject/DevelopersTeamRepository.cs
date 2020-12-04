using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevRepoPtoject
{
    public class DevelopersTeamRepository
    {
        private readonly DevelopersRepository _developerRepo = new DevelopersRepository(); // access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevelopersTeam> _devTeams = new List<DevelopersTeam>();

        //DevTeam Create
        public void AddDevTeamToList(DevelopersTeam devTeam)
        {
            _devTeams.Add(devTeam); 
        }

        //DevTeam Read
        public List<DevelopersTeam> GetDevTeamList()
        {
            return _devTeams;
        }

        //DevTeam Update
        public bool UpdateExistingDevTeams(string originalID, DevelopersTeam newID)
        {
            //Find the content
            DevelopersTeam oldID = GetDevTeamByID(originalID);

            //Update the content
            if (oldID != null)
            {
                oldID.TeamName = newID.TeamName;
                oldID.TeamID = newID.TeamID;
                oldID.DevTeamMembers = newID.DevTeamMembers;

                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Delete
        public bool RemoveDevTeamFromList(string iD)
        {
            DevelopersTeam devTeam = GetDevTeamByID(iD);

            if (devTeam == null)
            {
                return false;
            }

            int initialCount = _devTeams.Count;
            _devTeams.Remove(devTeam);

            if (initialCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID)

        public DevelopersTeam GetDevTeamByID(string iD)
        {
            foreach (DevelopersTeam devTeam in _devTeams)
            {
                if (devTeam.TeamID.ToLower() == iD.ToLower())
                {
                    return devTeam;
                }
            }

            return null;
        }

    }

}
