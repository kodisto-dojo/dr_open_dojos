using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.Model;

namespace UsesCases
{
    public class DefineSkill
    {
        private readonly ISet<Skill> skills = new HashSet<Skill>();

        public void Define(Skill skill) {
            if (string.IsNullOrEmpty(skill?.Name)) {
                throw new ArgumentException("no, no asi no eh no");
            }
            skills.Add(skill);
        }

        
    }
}
