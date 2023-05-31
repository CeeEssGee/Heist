using System.Collections.Generic;

namespace Heist
{
    public class Team
    {

        // dictionary
        public Dictionary<string, TeamMember> HeistTeam = new Dictionary<string, TeamMember>() { };

        public void AddToTeam(TeamMember person)
        {
            HeistTeam.Add(person.Name, person);
        }

    }



}