using Ranta.Scheduling.Service.Contract;
using Ranta.Scheduling.Service.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Scheduling.Service.Core.Service
{
    public class MissionService : IMissionService
    {
        private TaskQuque queue;

        public MissionService(TaskQuque queue)
        {
            this.queue = queue;
        }

        public StartMissionResponse StartMission(StartMissionRequest request)
        {
            throw new NotImplementedException();
        }

        public CancelMissionResponse CancelMission(CancelMissionRequest request)
        {
            throw new NotImplementedException();
        }

        public StopMissionResponse StopMission(StopMissionRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMissionListResponse GetMissionList(GetMissionListRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
