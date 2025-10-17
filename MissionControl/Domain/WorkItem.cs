using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl.Domain
{
    public abstract class WorkItem
    {
        public enum Statuses
        {
            ToDo,
            InProgress,
            Done,
            Archived
        }

        public enum WorkTypes
        {
            Task,
            Bug,
            Feature
        }


        public static int WorkItemCount;
        public int Id;
        public string Name;
        public string Description;
        public DateTime CreatedDate;
        public DateTime UpdatedDate;
        public string CreatedBy;
        public string UpdatedBy;
        public Statuses Status;
        public WorkTypes WorkType;

        protected WorkItem(string name, string description)
        {
            Name = name;
            Description = description;
            Status = Statuses.ToDo;
            CreatedBy = "Asım";
            CreatedDate = DateTime.Now;
            Id = ++WorkItemCount;
        }

        public abstract int EstimateEffort();
       

    }
}
