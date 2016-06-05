using Ranta.Scheduling.Service.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Contract
{
    /// <summary>
    /// 活动任务服务
    /// </summary>
    public interface IMissionService
    {
        /// <summary>
        /// 触发一次执行任务的请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        StartMissionResponse StartMission(StartMissionRequest request);

        /// <summary>
        /// 请求取消某个任务
        /// 任务没有开始执行的状态下，可以取消。任务正在执行的时候，只能停止，不能取消.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CancelMissionResponse CancelMission(CancelMissionRequest request);

        /// <summary>
        /// 停止某个任务
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        StopMissionResponse StopMission(StopMissionRequest request);

        /// <summary>
        /// 获取任务列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetMissionListResponse GetMissionList(GetMissionListRequest request);
    }
}
