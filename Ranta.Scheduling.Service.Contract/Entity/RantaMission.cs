using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract.Entity
{
    /// <summary>
    /// 当前正在活动的任务
    /// </summary>
    [DataContract]
    public class RantaMission
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        ///创建时间
        /// </summary>
        [DataMember]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 开始执行的时间
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [DataMember]
        public MissionStatus TaskStatus { get; set; }
    }
}
