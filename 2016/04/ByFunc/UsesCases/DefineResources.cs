using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.Model;

namespace UsesCases
{
    class DefineResources
    {
        private readonly ISet<Resource> resources = new HashSet<Resource>();

        public void Define(Resource resource)
        {
            if (string.IsNullOrEmpty(resource?.Name))
            {
                throw new ArgumentException("no, no asi no eh no");
            }
            resources.Add(resource);
        }
    }
}
