using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl.Domain
{
    public class Task : WorkItem
    {
        public int SubTaskCount;

        public Task(string name, string description, int subTaskCount) : base(name, description)
        {
            WorkType = WorkTypes.Task;
            SubTaskCount = subTaskCount;
        }

        public override int EstimateEffort()
        {
            if (SubTaskCount <= 2) return 1;
            if (SubTaskCount <= 5) return 2;
            return 3;
        }
    }
}
