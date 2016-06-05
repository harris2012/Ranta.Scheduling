using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    [DataContract]
    public class GetMissionListResponse
    {
        /// <summary>
        /// 任务总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        public List<RantaMission> TaskList { get; set; }
    }
}
