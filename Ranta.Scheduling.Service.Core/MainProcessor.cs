using Ranta.Scheduling.Service.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    public class MainProcessor
    {
        private TaskProducer producer;
        private TaskConsumer consumer;

        private ServiceHost host;

        public void Start()
        {
            TaskQuque queue = new TaskQuque();

            producer = new TaskProducer(queue);

            consumer = new TaskConsumer(queue);

            host = new ServiceHost(new MissionService(queue));

            producer.Start();

            consumer.Start();

            host.Open();
        }

        public void Stop()
        {
            producer.Stop();

            consumer.Stop();

            host.Close();
        }
    }
}
