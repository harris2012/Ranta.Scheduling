using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Ranta.Scheduling.Service.Core
{
    /// <summary>
    /// 线程安全的任务队列
    /// </summary>
    public class TaskQuque
    {
        private List<RantaTaskBase> taskList;

        private object lockObject;

        /// <summary>
        /// 构造函数
        /// </summary>
        public TaskQuque()
        {
            taskList = new List<RantaTaskBase>();
            lockObject = new object();
        }

        /// <summary>
        /// 将指定task入队
        /// </summary>
        /// <param name="task"></param>
        public void Enqueue(RantaTaskBase task)
        {
            lock (lockObject)
            {
                taskList.Add(task);
            }
        }

        /// <summary>
        /// 出队一个指定的task
        /// </summary>
        /// <returns></returns>
        public RantaTaskBase Dequeue()
        {
            lock (lockObject)
            {
                RantaTaskBase task = null;

                if (taskList.Count > 0)
                {
                    task = taskList.First();

                    taskList.RemoveAt(0);
                }

                return task;
            }
        }

        /// <summary>
        /// 获取池中task的个数
        /// </summary>
        public int TaskCount
        {
            get
            {
                lock (lockObject)
                {
                    return taskList.Count;
                }
            }
        }
    }
}
