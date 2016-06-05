using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Core
{
    public class JobFactory
    {
        public JobBase CreateJob(string assemblyFile, string typeName)
        {
            JobBase job = null;

            var type = Assembly.LoadFrom(assemblyFile).GetType(typeName, true, false);

            var instance = Activator.CreateInstance(type);

            if (instance is JobBase)
            {
                job = instance as JobBase;
            }

            return job;
        }
    }
}
