using Ranta.Scheduling.Service.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service
{
    public partial class RantaSchedulingService : ServiceBase
    {
        public RantaSchedulingService()
        {
            InitializeComponent();
        }

        MainProcessor processor;

        protected override void OnStart(string[] args)
        {
            processor = new MainProcessor();

            processor.Start();
        }

        protected override void OnStop()
        {
            if (processor != null)
            {
                processor.Stop();
            }
        }
    }
}
