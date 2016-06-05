using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.JobLibrary
{
    public class WriteJob : JobBase
    {
        public override void Start()
        {
            Console.WriteLine("This is a test.");
        }
    }
}
