using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    /// <summary>
    /// 一个活动的Job
    /// </summary>
    public abstract class RantaTaskBase
    {
        public RantaTaskBase(Action action)
        {
            this.action = action;
        }

        private Action action;

        Thread thread;

        /// <summary>
        /// 开始执行任务
        /// </summary>
        public void Start()
        {
            try
            {
                thread = new Thread(new ParameterizedThreadStart(StartAction));

                thread.Start(action);
            }
            catch (ThreadAbortException)
            {
                OnAbort();
            }
        }

        /// <summary>
        /// 终止执行任务
        /// </summary>
        public void Stop()
        {
            thread.Abort();

            thread.Join();
        }

        ///// <summary>
        ///// 开始执行任务
        ///// </summary>
        //protected abstract void OnStart();

        private void StartAction(object action)
        {
            var act = action as Action;

            act();
        }

        /// <summary>
        /// 任务被外部终止的时候执行
        /// </summary>
        protected virtual void OnAbort()
        {

        }
    }
}
