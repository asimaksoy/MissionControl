using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl.Domain
{
    public class Bug : WorkItem
    {
        public enum Severities
        {
            Minor,
            Major,
            Critical
        }

        public Severities Severity;

        public Bug(string name, string description,Severities severity) : base(name, description)
        {
            WorkType = WorkTypes.Bug;
            Severity = severity;
        }

        public override int EstimateEffort()
        {
            if (Severity == Severities.Minor) return 1;
            if (Severity == Severities.Major) return 3;
            return 5;
        }
    }
}
