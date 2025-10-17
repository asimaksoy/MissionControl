using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl.Domain
{
    public class Feature : WorkItem
    {
        public int StoryPoint;

        public Feature(string name, string description,int storyPoint) : base(name, description)
        {
            WorkType = WorkTypes.Feature;
            StoryPoint = storyPoint<1 ? 1 : storyPoint;
        }

        public override int EstimateEffort()
        {
            return StoryPoint;
        }
    }
}
