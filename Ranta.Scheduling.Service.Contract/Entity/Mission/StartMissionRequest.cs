using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    /// <summary>
    /// 触发一次执行任务的请求
    /// </summary>
    [DataContract]
    public class StartMissionRequest
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [DataMember]
        public Guid TaskGuid { get; set; }
    }
}
