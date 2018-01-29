using Builder.CaseOne;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Case One

            var experiencedWebDev = new AspNetDeveloperBuilder()
                .AddSkill(new ProgrammersSkill
                {
                    Name = "ASP.NET Core",
                    Level = SkillLevel.ProjectContibutor
                })
                .AddSkill(new ProgrammersSkill
                {
                    Name = "C#",
                    Level = SkillLevel.ProjectContibutor
                })
                .Build();


            var beginnerWebDev = new AspNetDeveloperBuilder()
                .AddSkill(new ProgrammersSkill
                {
                    Name = "ASP.NET Core",
                    Level = SkillLevel.KnowsThatExists
                })
                .AddSkill(new ProgrammersSkill
                {
                    Name = "C#",
                    Level = SkillLevel.Basic
                })
                .Build();

            #endregion
        }
    }
}