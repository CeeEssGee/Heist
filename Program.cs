using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            NewTeamMember();

            static void NewTeamMember()
            {
                // starting line
                Console.WriteLine("Plan your Heist");

                System.Console.WriteLine("Time to add your Team Members!");
                Team HeistTeam = new Team();

                // Add a team member
                void NewTeamMember()
                {
                    Console.WriteLine("What is your team member's name?");
                    string TeamMemberName = Console.ReadLine();
                    if (TeamMemberName == "")
                    {
                        return;
                    }
                    Console.WriteLine("What is your team member's skill level on a scale of 1 to 100 (whole numbers only)?");
                    string skillLevelString = Console.ReadLine();
                    int skillLevel = Convert.ToInt32(skillLevelString);
                    Console.WriteLine("What is your team member's courage level on a scale of 0.0 to 2.0?");
                    string courageLevelString = (Console.ReadLine());
                    decimal courageLevel = Convert.ToDecimal(courageLevelString);

                    TeamMember theTeamMember = new TeamMember(TeamMemberName, skillLevel, courageLevel);
                    theTeamMember.GetDescription();

                    HeistTeam.AddToTeam(theTeamMember);
                    addAnother();
                }
                NewTeamMember();




                void addAnother()
                {
                    Console.WriteLine("Add another team member?\n\t1) Yes\n\t2) No");
                    string answer = Console.ReadLine();
                    int numAnswer = int.Parse(answer);

                    switch (numAnswer)
                    {
                        case 1:
                            NewTeamMember();
                            break;
                        case 2:
                            return;
                    }
                }
            }


        }
    }
}
