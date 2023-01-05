using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Certify
{
    internal class TestOne
    {
        public class Team
        {
            protected string teamName;
            protected int noOfPlayers;
            protected Team(string teamName, int noOfPlayers)
            {
                this.teamName = teamName;
                this.noOfplayers = noOfPlayers;
            }

            public void AddPlayer(int count)
            {
                noOfPlayers += counter;
            }

            public bool RemovePlayer(int count)
            {
                if (noOfPlayers - count < 0) return false;
                else
                {
                    noOfPlayers -= count;
                    return true;
                }
            }
        }

        public class Subteam : Team
        {
            public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
            {

            }


            public string ChaneTeamName(string name)
            {
                this.teamName = name;
            }
        }
    }
}
