using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Model
{
    public class Resource
    {
        public string Name { get; }
        public Skill Skill { get; }

        public Resource(string title, Skill skill)
        {
            Name = title;
            Skill = skill;
        }

        public override bool Equals(object obj)
        {
            return Name.Equals((obj as Resource).Name);
        }

        public override int GetHashCode() => Name.GetHashCode();
    }
}
