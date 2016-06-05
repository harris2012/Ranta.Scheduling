using System.Threading;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    internal class TaskConsumer
    {
        /// <summary>
        /// 默认消费频率，100毫秒
        /// </summary>
        private const int DefaultWorkFrequency = 100;

        #region Fields
        private bool stopConsume;

        private TaskQuque queue;

        private Task workTask;

        /// <summary>
        /// 消费频率，毫秒为单位
        /// </summary>
        private int workFrequency;
        #endregion

        #region 构造函数
        /// <summary>
        /// 任务消费者
        /// </summary>
        /// <param name="taskQueue">需要从其中取出task执行</param>
        public TaskConsumer(TaskQuque taskQueue)
            : this(taskQueue, DefaultWorkFrequency)
        {
        }

        /// <summary>
        /// 任务消费者
        /// </summary>
        /// <param name="taskQueue">需要从其中取出task执行</param>
        /// <param name="workFrequency">消费频率，毫秒为单位</param>
        public TaskConsumer(TaskQuque taskQueue, int workFrequency)
        {
            this.queue = taskQueue;
            this.workFrequency = workFrequency;
        }
        #endregion


        /// <summary>
        /// 开始消费
        /// </summary>
        public void Start()
        {
            workTask = new Task(() =>
            {
                while (!stopConsume)
                {
                    RantaTaskBase task = queue.Dequeue();

                    if (task != null)
                    {
                        task.Start();
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
            });
            workTask.Start();
        }

        /// <summary>
        /// 停止消费
        /// </summary>
        public void Stop()
        {
            stopConsume = true;

            workTask.Wait();
        }
    }
}
