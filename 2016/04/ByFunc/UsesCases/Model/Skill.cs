using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Model
{
    public class Skill
    {
        public string Name { get; }

        public Skill(string name) {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return this.Name.Equals((obj as Skill).Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
