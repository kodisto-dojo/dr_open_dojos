using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Model
{
    public class Job
    {
        public string Title { get; }
        public ISet<Skill> Skills { get; }

        public Job(string title)
        {
            Title = title;
            Skills = new HashSet<Skill>();
        }

        public void AddSkill(Skill skill)
        {
            Skills.Add(skill);
        }

        public override bool Equals(object obj)
        {
            return Title.Equals((obj as Job).Title);
        }

        public override int GetHashCode() => Title.GetHashCode();

        public override string ToString() => Title + " | Skills: " + string.Join(", ", Skills.Select(s => s.Name));
    }
}
