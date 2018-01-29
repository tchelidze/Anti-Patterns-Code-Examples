using System.Collections.Generic;
using System.Linq;

namespace Builder.CaseOne
{
    public class ProgrammersSkill
    {
        public string Name { get; set; }

        public SkillLevel Level { get; set; }
    }

    public enum SkillLevel
    {
        KnowsThatExists,
        Basic,
        Middle,
        Senior,
        ProjectContibutor
    }

    public class Programmer
    {
        readonly Dictionary<string, ProgrammersSkill> _skills = new Dictionary<string, ProgrammersSkill>();

        public IEnumerable<ProgrammersSkill> Skills => _skills.Select(it => it.Value);

        public void LearnSkill(ProgrammersSkill skill)
        {
            if (skill.Name == "PHP" || skill.Name == "VB.NET")
                throw new PleaseDontDoThisException($"Please don't force me to learn {skill.Name}");

            if (_skills.ContainsKey(skill.Name))
                _skills[skill.Name] = skill;
            else
                _skills.Add(skill.Name, skill);
        }

        public bool HasSkill(string skillName, SkillLevel minLevel) => _skills.ContainsKey(skillName) && _skills[skillName].Level >= minLevel;
    }
}