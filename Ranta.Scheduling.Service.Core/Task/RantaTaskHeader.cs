using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core
{
    /// <summary>
    /// job信息 
    /// </summary>
    public class RantaTaskHeader
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}
