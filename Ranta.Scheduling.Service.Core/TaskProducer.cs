using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    internal class TaskProducer
    {
        /// <summary>
        /// 默认消费频率，100毫秒
        /// </summary>
        private const int DefaultWorkFrequency = 100;

        #region Fields
        private bool stopProduce;

        private TaskQuque queue;

        private Task workTask;

        /// <summary>
        /// 消费频率，毫秒为单位
        /// </summary>
        private int workFrequency;
        #endregion

        #region 构造函数
        public TaskProducer(TaskQuque queue)
            : this(queue, DefaultWorkFrequency)
        {
        }

        public TaskProducer(TaskQuque queue, int workFrequency)
        {
            this.queue = queue;
            this.workFrequency = workFrequency;
        }
        #endregion

        public void Start()
        {
            workTask = new Task(() =>
            {
                while (!stopProduce)
                {
                    RantaTaskBase task = new TestTask(() =>
                    {
                        DateTime time = DateTime.Now;

                        Console.WriteLine("test task starting........ {0:HH:mm:ss}", time);

                        Thread.Sleep(2000);

                        Console.WriteLine("test task finished... {0:HH:mm:ss}", time);
                    });

                    queue.Enqueue(task);

                    Thread.Sleep(1000);
                }
            });
            workTask.Start();
        }

        public void Stop()
        {
            stopProduce = true;

            workTask.Wait();
        }
    }
}
