using System.Collections.Generic;
using System.Linq;

namespace Builder.CaseOne
{
    /// <summary>
    /// Purpose of this class is to enforce rules introduced by "AspNetDeveloper" context to programmer objects. 
    /// In this case rule is that asp.net developer should have knowledge of below defined skills. 
    /// </summary>
    public class AspNetDeveloperBuilder
    {
        readonly IEnumerable<ProgrammersSkill> _necessarySkillset = new List<ProgrammersSkill>
        {
            new ProgrammersSkill
            {
                Name = "ASP.NET Core",
                Level = SkillLevel.Middle
            },
            new ProgrammersSkill
            {
                Name = "C#",
                Level = SkillLevel.Middle
            }
        };

        readonly Programmer _webDeveloper = new Programmer();

        public AspNetDeveloperBuilder AddSkill(ProgrammersSkill skill)
        {
            _webDeveloper.LearnSkill(skill);
            return this;
        }

        public Programmer Build()
        {
            //Builder enforces rules of "AspNetDeveloper Context" to Programmer object.
            if (_necessarySkillset.Any(it => !_webDeveloper.HasSkill(it.Name, it.Level)))
                throw new InvalidAspNetDeveloperException("Developer have no enough knowledge of essential skillset");
            return _webDeveloper;
        }
    }
}