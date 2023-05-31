using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {

            NewTeamMember();

            static void NewTeamMember()
            {
                Console.WriteLine("Plan your Heist");

                Console.WriteLine("What is your name?");
                string TeamMember = Console.ReadLine();
                Console.WriteLine("What is your skill level on a scale of 1 to 10? (whole numbers only)");
                string skillLevelString = Console.ReadLine();
                int skillLevel = Convert.ToInt32(skillLevelString);
                Console.WriteLine("What is your courage level on a scale of 0 to 2? (can use a decimal point)");
                string courageLevelString = (Console.ReadLine());
                decimal courageLevel = Convert.ToDecimal(courageLevelString);

                TeamMember theTeamMember = new TeamMember(TeamMember, skillLevel, courageLevel);
                theTeamMember.GetDescription();
            }


        }
    }
}
