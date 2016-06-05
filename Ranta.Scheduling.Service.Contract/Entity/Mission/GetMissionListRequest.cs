using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    [DataContract]
    public class GetMissionListRequest
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [DataMember]
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [DataMember]
        public int PageSize { get; set; }

        /// <summary>
        /// 任务执行状态
        /// </summary>
        [DataMember]
        public MissionStatus TaskStatus { get; set; }
    }
}
