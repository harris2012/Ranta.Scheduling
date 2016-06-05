using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    /// <summary>
    /// 取消任务的请求
    /// </summary>
    public class CancelMissionRequest
    {
        /// <summary>
        /// 需要被取消执行的任务编号
        /// </summary>
        public Guid Guid { get; set; }
    }
}
