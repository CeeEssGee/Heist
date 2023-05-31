namespace Heist
{

    public class TeamMember
    {
        public string Name { get; }

        public int skillLevel { get; set; }

        public decimal courageLevel;

        public int SkillLevel
        {
            get { return skillLevel; }
            set
            {
                if (value >= 1 ||
                value <= 100)
                {
                    skillLevel = value;
                }
                else
                {
                    skillLevel = 0;
                }
            }
        }

        public decimal CourageLevel
        {
            get { return courageLevel; }
            set
            {
                if (value >= 0 ||
                value <= 2)
                {
                    courageLevel = value;
                }
                else
                {
                    courageLevel = 0;
                }
            }


        }

        // constructor
        public TeamMember(string name, int skillLevel, decimal courageLevel)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageLevel = courageLevel;
        }


        public void GetDescription()
        {
            System.Console.WriteLine($"Team Member, {this.Name}, has a skill level of {this.SkillLevel} and a courage level of {this.CourageLevel}.");
        }


    }



}