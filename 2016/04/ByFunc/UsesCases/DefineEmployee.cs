using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.Model;

namespace UsesCases
{
    class DefineEmployee
    {
        private readonly ISet<Job> jobs = new HashSet<Job>();

        public void Define(Job job)
        {
            if (string.IsNullOrEmpty(job?.Title))
            {
                throw new ArgumentException("no, no asi no eh no");
            }
            jobs.Add(job);
        }
    }
}
