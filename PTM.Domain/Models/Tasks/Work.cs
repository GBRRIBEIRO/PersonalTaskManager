using PTM.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.Tasks
{
    public class Work : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime FinishedDateTime { get; private set; }
        public int Status { get; private set; } 

        public Work
            (
            string title,
            string description,
            DateTime startDateTime,
            DateTime finishedDateTime,
            int status
            )
        {
            SetId(new Guid());
            Title = title;
            Description = description;
            StartDateTime = startDateTime;
            FinishedDateTime = finishedDateTime;
            Status = 1;
        }
    }
}
