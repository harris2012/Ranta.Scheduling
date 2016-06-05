using Ranta.Scheduling.Service.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Dal
{
    public class JobDal
    {
        /// <summary>
        /// 获取需要运行的Job
        /// </summary>
        /// <returns></returns>
        public List<JobEntity> GetJobEntityList()
        {
            List<JobEntity> list = new List<JobEntity>();


            return list;
        }

        /// <summary>
        /// 获取Job实例
        /// </summary>
        /// <returns></returns>
        public List<JobInstance> GetJobInstance()
        {
            List<JobInstance> list = new List<JobInstance>();


            return list;
        }
    }
}
