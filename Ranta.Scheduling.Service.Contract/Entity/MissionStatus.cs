using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    /// <summary>
    /// 任务状态
    /// </summary>
    [Flags]
    public enum MissionStatus
    {
        /// <summary>
        /// 任务已经创建，即将执行
        /// </summary>
        Created = 1,

        /// <summary>
        /// 任务正在被正在执行
        /// </summary>
        Running = 2,

        /// <summary>
        /// 任务已经执行完毕
        /// </summary>
        Finished = 4,

        /// <summary>
        /// 任务已经被中断
        /// </summary>
        Abort = 8,

        /// <summary>
        /// 所有状态
        /// </summary>
        All = 15
    }
}
