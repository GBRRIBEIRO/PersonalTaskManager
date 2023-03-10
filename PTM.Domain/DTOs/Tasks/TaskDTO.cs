using PTM.Domain.DTOs.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.DTOs.Tasks
{
    public class TaskDTO
    {
        public string Title { get;  set; }
        public string Description { get;  set; }
        public DateTime CreatedOn { get;  set; }
        public DateTime StartDateTime { get;  set; }
        public DateTime FinishedDateTime { get;  set; }
        public int Status { get;  set; }
    }
}
