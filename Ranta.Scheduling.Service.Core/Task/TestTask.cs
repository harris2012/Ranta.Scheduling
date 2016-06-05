using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    public class TestTask : RantaTaskBase
    {
        public TestTask(Action action)
            : base(action)
        {

        }
    }
}
